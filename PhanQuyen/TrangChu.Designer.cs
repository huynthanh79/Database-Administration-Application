
namespace PhanQuyen
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.dsuser = new System.Windows.Forms.DataGridView();
            this.NguoiDung = new System.Windows.Forms.TextBox();
            this.xoauser = new System.Windows.Forms.Button();
            this.suaquyenuser = new System.Windows.Forms.Button();
            this.taouser = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.taorole = new System.Windows.Forms.Button();
            this.dsrole = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xoarole = new System.Windows.Forms.Button();
            this.passrole = new System.Windows.Forms.TextBox();
            this.suaquyenrole = new System.Windows.Forms.Button();
            this.rolename = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsuser)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsrole)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 504);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Người dùng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 39);
            this.label6.TabIndex = 24;
            this.label6.Text = "QUẢN TRỊ VIÊN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.dsuser);
            this.panel1.Controls.Add(this.NguoiDung);
            this.panel1.Controls.Add(this.xoauser);
            this.panel1.Controls.Add(this.suaquyenuser);
            this.panel1.Controls.Add(this.taouser);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.passuser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 419);
            this.panel1.TabIndex = 22;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(43, 15);
            this.lb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(261, 26);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Danh Sách Người Dùng";
            // 
            // dsuser
            // 
            this.dsuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsuser.Location = new System.Drawing.Point(48, 116);
            this.dsuser.Margin = new System.Windows.Forms.Padding(2);
            this.dsuser.Name = "dsuser";
            this.dsuser.RowHeadersWidth = 51;
            this.dsuser.RowTemplate.Height = 24;
            this.dsuser.Size = new System.Drawing.Size(356, 206);
            this.dsuser.TabIndex = 0;
            // 
            // NguoiDung
            // 
            this.NguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NguoiDung.Location = new System.Drawing.Point(271, 62);
            this.NguoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.NguoiDung.Name = "NguoiDung";
            this.NguoiDung.Size = new System.Drawing.Size(257, 23);
            this.NguoiDung.TabIndex = 4;
            // 
            // xoauser
            // 
            this.xoauser.AutoSize = true;
            this.xoauser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoauser.Location = new System.Drawing.Point(48, 357);
            this.xoauser.Margin = new System.Windows.Forms.Padding(2);
            this.xoauser.Name = "xoauser";
            this.xoauser.Size = new System.Drawing.Size(78, 28);
            this.xoauser.TabIndex = 6;
            this.xoauser.Text = "Xóa User";
            this.xoauser.UseVisualStyleBackColor = true;
            this.xoauser.Click += new System.EventHandler(this.xoauser_Click_1);
            // 
            // suaquyenuser
            // 
            this.suaquyenuser.AutoSize = true;
            this.suaquyenuser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.suaquyenuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaquyenuser.Location = new System.Drawing.Point(211, 358);
            this.suaquyenuser.Margin = new System.Windows.Forms.Padding(2);
            this.suaquyenuser.Name = "suaquyenuser";
            this.suaquyenuser.Size = new System.Drawing.Size(123, 27);
            this.suaquyenuser.TabIndex = 7;
            this.suaquyenuser.Text = "Sửa Quyền User";
            this.suaquyenuser.UseVisualStyleBackColor = true;
            this.suaquyenuser.Click += new System.EventHandler(this.suaquyenuser_Click_1);
            // 
            // taouser
            // 
            this.taouser.AutoSize = true;
            this.taouser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taouser.Location = new System.Drawing.Point(516, 271);
            this.taouser.Margin = new System.Windows.Forms.Padding(2);
            this.taouser.Name = "taouser";
            this.taouser.Size = new System.Drawing.Size(78, 28);
            this.taouser.TabIndex = 15;
            this.taouser.Text = "Tạo User";
            this.taouser.UseVisualStyleBackColor = true;
            this.taouser.Click += new System.EventHandler(this.taouser_Click_1);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(517, 146);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(184, 23);
            this.username.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // passuser
            // 
            this.passuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passuser.Location = new System.Drawing.Point(517, 223);
            this.passuser.Margin = new System.Windows.Forms.Padding(2);
            this.passuser.Name = "passuser";
            this.passuser.PasswordChar = '*';
            this.passuser.Size = new System.Drawing.Size(184, 23);
            this.passuser.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 39);
            this.label7.TabIndex = 25;
            this.label7.Text = "QUẢN TRỊ VIÊN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.taorole);
            this.panel2.Controls.Add(this.dsrole);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.role);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.xoarole);
            this.panel2.Controls.Add(this.passrole);
            this.panel2.Controls.Add(this.suaquyenrole);
            this.panel2.Controls.Add(this.rolename);
            this.panel2.Location = new System.Drawing.Point(1, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 412);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Role";
            // 
            // taorole
            // 
            this.taorole.AutoSize = true;
            this.taorole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taorole.Location = new System.Drawing.Point(527, 293);
            this.taorole.Margin = new System.Windows.Forms.Padding(2);
            this.taorole.Name = "taorole";
            this.taorole.Size = new System.Drawing.Size(78, 28);
            this.taorole.TabIndex = 20;
            this.taorole.Text = "Tạo Role";
            this.taorole.UseVisualStyleBackColor = true;
            this.taorole.Click += new System.EventHandler(this.taorole_Click_1);
            // 
            // dsrole
            // 
            this.dsrole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsrole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsrole.Location = new System.Drawing.Point(37, 106);
            this.dsrole.Margin = new System.Windows.Forms.Padding(2);
            this.dsrole.Name = "dsrole";
            this.dsrole.RowHeadersWidth = 51;
            this.dsrole.RowTemplate.Height = 24;
            this.dsrole.Size = new System.Drawing.Size(367, 229);
            this.dsrole.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password:";
            // 
            // role
            // 
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.Location = new System.Drawing.Point(251, 51);
            this.role.Margin = new System.Windows.Forms.Padding(2);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(270, 23);
            this.role.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Rolename:";
            // 
            // xoarole
            // 
            this.xoarole.AutoSize = true;
            this.xoarole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoarole.Location = new System.Drawing.Point(37, 365);
            this.xoarole.Margin = new System.Windows.Forms.Padding(2);
            this.xoarole.Name = "xoarole";
            this.xoarole.Size = new System.Drawing.Size(76, 28);
            this.xoarole.TabIndex = 9;
            this.xoarole.Text = "Xóa Role";
            this.xoarole.UseVisualStyleBackColor = true;
            this.xoarole.Click += new System.EventHandler(this.xoarole_Click_1);
            // 
            // passrole
            // 
            this.passrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passrole.Location = new System.Drawing.Point(527, 229);
            this.passrole.Margin = new System.Windows.Forms.Padding(2);
            this.passrole.Name = "passrole";
            this.passrole.PasswordChar = '*';
            this.passrole.Size = new System.Drawing.Size(178, 23);
            this.passrole.TabIndex = 17;
            // 
            // suaquyenrole
            // 
            this.suaquyenrole.AutoSize = true;
            this.suaquyenrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaquyenrole.Location = new System.Drawing.Point(207, 365);
            this.suaquyenrole.Margin = new System.Windows.Forms.Padding(2);
            this.suaquyenrole.Name = "suaquyenrole";
            this.suaquyenrole.Size = new System.Drawing.Size(124, 28);
            this.suaquyenrole.TabIndex = 10;
            this.suaquyenrole.Text = "Sửa Quyền Role";
            this.suaquyenrole.UseVisualStyleBackColor = true;
            this.suaquyenrole.Click += new System.EventHandler(this.suaquyenrole_Click_1);
            // 
            // rolename
            // 
            this.rolename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolename.Location = new System.Drawing.Point(527, 136);
            this.rolename.Margin = new System.Windows.Forms.Padding(2);
            this.rolename.Name = "rolename";
            this.rolename.Size = new System.Drawing.Size(178, 23);
            this.rolename.TabIndex = 16;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 504);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsuser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsrole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dsuser;
        private System.Windows.Forms.TextBox NguoiDung;
        private System.Windows.Forms.Button xoauser;
        private System.Windows.Forms.Button suaquyenuser;
        private System.Windows.Forms.Button taouser;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button taorole;
        private System.Windows.Forms.DataGridView dsrole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button xoarole;
        private System.Windows.Forms.TextBox passrole;
        private System.Windows.Forms.Button suaquyenrole;
        private System.Windows.Forms.TextBox rolename;
        private System.Windows.Forms.Label label7;
    }
}