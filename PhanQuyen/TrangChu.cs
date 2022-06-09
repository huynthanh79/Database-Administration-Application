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
    public partial class TrangChu : Form
    {
        public BindingSource dsnguoidung = new BindingSource();
        public BindingSource dsvaitro = new BindingSource();
        public TrangChu()
        {
            InitializeComponent();
            loadform();
        }
        public void loadform()
        {
            dsuser.DataSource = dsnguoidung;
            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
             {
                 DataTable data = new DataTable();
                 string query = "select username,user_id from all_users";
                 connection.Open();
                 OracleCommand cmd = new OracleCommand(query, connection);
                 data.Load(cmd.ExecuteReader());
                 connection.Close();
                 dsnguoidung.DataSource = data;
             }
            dsrole.DataSource = dsvaitro;
            using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                DataTable data = new DataTable();
                string query = "SELECT ROLE FROM DBA_ROLES";
                connection.Open();
                OracleCommand cmd = new OracleCommand(query, connection);
                data.Load(cmd.ExecuteReader());
                connection.Close();
                dsvaitro.DataSource = data;
            }
            role.DataBindings.Add(new Binding("text", dsrole.DataSource, "ROLE"));
            NguoiDung.DataBindings.Add(new Binding("text", dsuser.DataSource, "username"));
            
        }

        private void taorole_Click_1(object sender, EventArgs e)
        {
            if (rolename.Text != null && passrole.Text != null)
                using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                        OracleCommand command1 = new OracleCommand(query1, connection);
                        command1.ExecuteNonQuery();
                        string query2 = "begin grant_NewRole('" + rolename.Text + "','" + passrole.Text + "'); end;";
                        OracleCommand command2 = new OracleCommand(query2, connection);
                        int result = command2.ExecuteNonQuery();

                        rolename.Text = "";
                        passrole.Text = "";
                        DataTable data = new DataTable();
                        MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
                        

                        string query = "SELECT ROLE FROM DBA_ROLES";
                        OracleCommand cmd = new OracleCommand(query, connection);
                        data.Load(cmd.ExecuteReader());
                        dsrole.DataSource = data;

                        connection.Close();
                    }
                    catch(Exception ee)
                    {
                        rolename.Text = "";
                        passrole.Text = "";
                        MessageBox.Show("Không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }

        private void taouser_Click_1(object sender, EventArgs e)
        {
            if (username.Text != null && passuser.Text != null)
                using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string query2 = "begin Grant_NewUser('" + username.Text + "','" + passuser.Text + "'); end;";
                        OracleCommand command2 = new OracleCommand(query2, connection);
                        int result = command2.ExecuteNonQuery();

                        username.Text = "";
                        passuser.Text = "";
                        DataTable data = new DataTable();
                        MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);

                        string query = "select username,user_id from all_users";
                        OracleCommand cmd = new OracleCommand(query, connection);
                        data.Load(cmd.ExecuteReader());
                        dsnguoidung.DataSource = data;

                        connection.Close();
                    }
                    catch (Exception ee)
                    {
                        username.Text = "";
                        passuser.Text = "";
                        MessageBox.Show("Không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
        }

        private void xoauser_Click_1(object sender, EventArgs e)
        {
            if (NguoiDung.Text != null)
                using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    try
                    {
                        connection.Open();
                        string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                        OracleCommand command1 = new OracleCommand(query1, connection);
                        command1.ExecuteNonQuery();
                        string query2 = "begin Drop_User('" + NguoiDung.Text + "'); end;";
                        OracleCommand command2 = new OracleCommand(query2, connection);
                        int result = command2.ExecuteNonQuery();

                        DataTable data = new DataTable();
                        MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
                        string query = "select username,user_id from all_users";
                        OracleCommand cmd = new OracleCommand(query, connection);
                        data.Load(cmd.ExecuteReader());
                        dsnguoidung.DataSource = data;

                        connection.Close();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
        }

        private void suaquyenuser_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form us = new User(NguoiDung.Text);
            us.ShowDialog();
            this.Close();
        }

        private void xoarole_Click_1(object sender, EventArgs e)
        {
            if (role.Text != null)
                using (OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                        OracleCommand command1 = new OracleCommand(query1, connection);
                        command1.ExecuteNonQuery();
                        string query2 = "begin Drop_Role('" + role.Text + "'); end;";
                        OracleCommand command2 = new OracleCommand(query2, connection);
                        int result = command2.ExecuteNonQuery();


                        DataTable data = new DataTable();
                        MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
                        string query = "SELECT ROLE FROM DBA_ROLES";
                        OracleCommand cmd = new OracleCommand(query, connection);
                        data.Load(cmd.ExecuteReader());
                        dsvaitro.DataSource = data;

                        connection.Close();
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show("Không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }

        private void suaquyenrole_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form rl = new Role(role.Text);
            rl.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
