using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace PhanQuyen
{
    public partial class Role : Form
    {
        public static string role;
        public Role(string r)
        {
            InitializeComponent();
            role = r;
            label1.Text = "Danh Sách Quyền Của Role " + r;
            loadform();
        }
        public class privs
        {
            public string col { get; set; }
            public string priv { get; set; }
            public string tab { get; set; }
        }
        public class tabprivs
        {
            public string tab { get; set; }
            public string priv { get; set; }
        }
        public void loadform()
        {
            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                DataTable data = new DataTable();
                string query = "SELECT table_name FROM all_tables where owner='QLTHUVIEN'";
                connection.Open();
                OracleCommand cmd = new OracleCommand(query, connection);
                data.Load(cmd.ExecuteReader());
                connection.Close();
                dataGridView1.DataSource = data;
            }
            table.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "table_name"));
        }
        public List<privs> loadlistpcol()
        {

            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                var privslist = new List<privs>();
                DataTable data = new DataTable();
                string query = "SELECT * FROM  ROLE_TAB_PRIVS  where Role = '" + role + "'";
                connection.Open();
                OracleCommand cmd = new OracleCommand(query, connection);
                data.Load(cmd.ExecuteReader());
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if ((data.Rows[i]["PRIVILEGE"].ToString() == "SELECT") || (data.Rows[i]["PRIVILEGE"].ToString() == "UPDATE"))
                    {
                        if (data.Rows[i]["COLUMN_NAME"].ToString() == "")
                        {
                            DataTable dataview = new DataTable();
                            string queryview = "SELECT * FROM " + data.Rows[i]["TABLE_NAME"] + " where  1 = 2";
                            OracleCommand cmdview = new OracleCommand(queryview, connection);
                            dataview.Load(cmdview.ExecuteReader());
                            foreach (DataColumn column in dataview.Columns)
                            {
                                privs temp = new privs();
                                temp.col = column.ColumnName.ToString();
                                temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                                temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                                privslist.Add(temp);
                            }
                        }
                        else
                        {
                            privs temp = new privs();
                            temp.col = data.Rows[i]["COLUMN_NAME"].ToString();
                            temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                            temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                            privslist.Add(temp);
                        }
                    }

                }
                return privslist;
            }
        }
        public List<tabprivs> loadlistptb()
        {
            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                var privslist = new List<tabprivs>();
                DataTable data = new DataTable();
                string query = "SELECT * FROM  ROLE_TAB_PRIVS  where Role = '" + role + "'";
                connection.Open();
                OracleCommand cmd = new OracleCommand(query, connection);
                data.Load(cmd.ExecuteReader());
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if ((data.Rows[i]["PRIVILEGE"].ToString() == "INSERT") || (data.Rows[i]["PRIVILEGE"].ToString() == "DELETE"))
                    {
                        tabprivs temp = new tabprivs();
                        temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                        temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                        privslist.Add(temp);
                    }
                }
                connection.Close();
                return privslist;
            }
        }

        private void dongy_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                connection.Open();
                string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                OracleCommand command1 = new OracleCommand(query1, connection);
                command1.ExecuteNonQuery();
                string query2 = "begin Drop_Role('" + role + "'); end;";
                OracleCommand command2 = new OracleCommand(query2, connection);
                int result = command2.ExecuteNonQuery();
                connection.Close();

            }

            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                    OracleCommand command1 = new OracleCommand(query1, connection);
                    command1.ExecuteNonQuery();
                    string query2 = "begin grant_NewRole('" + role + "','123'); end;";
                    OracleCommand command2 = new OracleCommand(query2, connection);
                    int result = command2.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception ee)
                {
                    MessageBox.Show("không Thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (insert.Checked == true)
                using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    connection.Open();
                    string query2 = "grant insert on "+table.Text+" to " + role;
                    OracleCommand command2 = new OracleCommand(query2, connection);
                    int result = command2.ExecuteNonQuery();
                    connection.Close();
                }
            if (delete.Checked == true)
                using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    connection.Open();
                    string query2 = "grant delete on " + table.Text + " to " + role;
                    OracleCommand command2 = new OracleCommand(query2, connection);
                    int result = command2.ExecuteNonQuery();
                    connection.Close();
                }
            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                string select = "";
                string update = "";
                int i = 0;
                connection.Open();
                foreach (DataGridViewRow dr in dataGridView2.Rows)
                {
                    try
                    {
                        if (Convert.ToBoolean(dr.Cells[1].Value))
                        {
                            if (i != 0)
                                select = select + "," + dr.Cells[0].Value.ToString();
                            if (i == 0)
                            {
                                select = select + dr.Cells[0].Value.ToString();
                                i = i + 1;
                            }
                        }
                    }
                    catch (Exception ee) { }
                }
                i = 0;
                foreach (DataGridViewRow dr in dataGridView2.Rows)
                {
                    try
                    {
                        if (Convert.ToBoolean(dr.Cells[2].Value))
                        {
                            if (i != 0)
                                update = update + "," + dr.Cells[0].Value.ToString();
                            if (i == 0)
                            {
                                update = update + dr.Cells[0].Value.ToString();
                                i = i + 1;
                            }
                        }
                    }
                    catch (Exception ee) { }
                }
                if (select != "")
                {
                    string query2 = "Create or replace view VIEW_" + table.Text + "_" + role + " as SELECT " + select + " from " + table.Text;
                    OracleCommand command2 = new OracleCommand(query2, connection);
                    int result = command2.ExecuteNonQuery();
                    query2 = "grant SELECT ON VIEW_" + table.Text + "_" + role + " TO " + role;
                    command2 = new OracleCommand(query2, connection);
                    result = command2.ExecuteNonQuery();
                }
                if (update != "")
                {
                    string query2 = "grant update(" + update + ") on VIEW_" + table.Text + "_" + role + " to " + role;
                    OracleCommand command2 = new OracleCommand(query2, connection);
                    int result = command2.ExecuteNonQuery();
                }
                MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
                connection.Close();
            }
        }

        private void table_TextChanged(object sender, EventArgs e)
        {
            insert.Checked = false;
            delete.Checked = false;
            var privslisttab = new List<tabprivs>();
            privslisttab = loadlistptb();
            foreach (tabprivs num in privslisttab)
            {
                if (num.tab == table.Text)
                    if (num.priv == "INSERT")
                        insert.Checked = true;
                    else
                        delete.Checked = true;
            }
            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                var privslist = new List<privs>();
                privslist = loadlistpcol();
                DataTable data = new DataTable();
                string query = " SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = '" + table.Text + "'";
                connection.Open();
                OracleCommand cmd = new OracleCommand(query, connection);
                data.Load(cmd.ExecuteReader());
                connection.Close();
                data.Columns.Add(new DataColumn("SELECT", typeof(bool)));
                data.Columns.Add(new DataColumn("UPDATE", typeof(bool)));
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    foreach (privs num in privslist)
                    {
                        if (num.tab.Contains(table.Text))
                            if (num.col == data.Rows[i]["column_name"].ToString())
                                data.Rows[i][num.priv] = true;
                    }
                }
                dataGridView2.DataSource = data;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main = new TrangChu();
            main.ShowDialog();
            this.Close();
        }

        private void btn_revoke_role_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "begin Revoke_all('" + role + "'); end;";
                    OracleCommand command1 = new OracleCommand(query1, connection);
                    command1.ExecuteReader();



                    MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
                    connection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Tồn tại quyền không thể revoke!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
