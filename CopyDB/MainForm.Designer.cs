namespace CopyDB
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbx_output = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbbx_import_server_type = new System.Windows.Forms.ComboBox();
            this.btn_import_browse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_import_source_folder = new System.Windows.Forms.TextBox();
            this.btn_import_connect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_import_server_name = new System.Windows.Forms.TextBox();
            this.txtbx_import_username = new System.Windows.Forms.TextBox();
            this.txtbx_import_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_export_connect = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chckbx_show_system_databases = new System.Windows.Forms.CheckBox();
            this.chckbx_select_all_non_system = new System.Windows.Forms.CheckBox();
            this.checkedListBox_databases = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_export_server_name = new System.Windows.Forms.TextBox();
            this.txtbx_export_username = new System.Windows.Forms.TextBox();
            this.txtbx_export_output_folder = new System.Windows.Forms.TextBox();
            this.txtbx_export_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcntrl_tabs = new System.Windows.Forms.TabControl();
            this.picBx_loadingicon = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbcntrl_tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_loadingicon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(397, 547);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 25);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbx_output);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 163);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // txtbx_output
            // 
            this.txtbx_output.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_output.Location = new System.Drawing.Point(8, 31);
            this.txtbx_output.Multiline = true;
            this.txtbx_output.Name = "txtbx_output";
            this.txtbx_output.ReadOnly = true;
            this.txtbx_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_output.Size = new System.Drawing.Size(448, 126);
            this.txtbx_output.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cmbbx_import_server_type);
            this.tabPage2.Controls.Add(this.btn_import_browse);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtbx_import_source_folder);
            this.tabPage2.Controls.Add(this.btn_import_connect);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtbx_import_server_name);
            this.tabPage2.Controls.Add(this.txtbx_import_username);
            this.tabPage2.Controls.Add(this.txtbx_import_password);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Import";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Server Type:";
            // 
            // cmbbx_import_server_type
            // 
            this.cmbbx_import_server_type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbx_import_server_type.FormattingEnabled = true;
            this.cmbbx_import_server_type.Location = new System.Drawing.Point(103, 14);
            this.cmbbx_import_server_type.Name = "cmbbx_import_server_type";
            this.cmbbx_import_server_type.Size = new System.Drawing.Size(336, 25);
            this.cmbbx_import_server_type.Sorted = true;
            this.cmbbx_import_server_type.TabIndex = 20;
            this.cmbbx_import_server_type.SelectedIndexChanged += new System.EventHandler(this.cmbbx_import_server_type_SelectedIndexChanged);
            // 
            // btn_import_browse
            // 
            this.btn_import_browse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import_browse.Location = new System.Drawing.Point(364, 137);
            this.btn_import_browse.Name = "btn_import_browse";
            this.btn_import_browse.Size = new System.Drawing.Size(75, 25);
            this.btn_import_browse.TabIndex = 18;
            this.btn_import_browse.Text = "Browse";
            this.btn_import_browse.UseVisualStyleBackColor = true;
            this.btn_import_browse.Click += new System.EventHandler(this.btn_import_browse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Source Folder:";
            // 
            // txtbx_import_source_folder
            // 
            this.txtbx_import_source_folder.Enabled = false;
            this.txtbx_import_source_folder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_import_source_folder.Location = new System.Drawing.Point(103, 138);
            this.txtbx_import_source_folder.Name = "txtbx_import_source_folder";
            this.txtbx_import_source_folder.Size = new System.Drawing.Size(255, 25);
            this.txtbx_import_source_folder.TabIndex = 17;
            // 
            // btn_import_connect
            // 
            this.btn_import_connect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import_connect.Location = new System.Drawing.Point(364, 106);
            this.btn_import_connect.Name = "btn_import_connect";
            this.btn_import_connect.Size = new System.Drawing.Size(75, 25);
            this.btn_import_connect.TabIndex = 12;
            this.btn_import_connect.Text = "Test Connection";
            this.btn_import_connect.UseVisualStyleBackColor = true;
            this.btn_import_connect.Click += new System.EventHandler(this.btn_import_connect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Server Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Password:";
            // 
            // txtbx_import_server_name
            // 
            this.txtbx_import_server_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_import_server_name.Location = new System.Drawing.Point(103, 45);
            this.txtbx_import_server_name.Name = "txtbx_import_server_name";
            this.txtbx_import_server_name.Size = new System.Drawing.Size(336, 25);
            this.txtbx_import_server_name.TabIndex = 9;
            // 
            // txtbx_import_username
            // 
            this.txtbx_import_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_import_username.Location = new System.Drawing.Point(103, 76);
            this.txtbx_import_username.Name = "txtbx_import_username";
            this.txtbx_import_username.Size = new System.Drawing.Size(336, 25);
            this.txtbx_import_username.TabIndex = 10;
            // 
            // txtbx_import_password
            // 
            this.txtbx_import_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_import_password.Location = new System.Drawing.Point(103, 107);
            this.txtbx_import_password.Name = "txtbx_import_password";
            this.txtbx_import_password.PasswordChar = '*';
            this.txtbx_import_password.Size = new System.Drawing.Size(255, 25);
            this.txtbx_import_password.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Username:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_export_connect);
            this.tabPage1.Controls.Add(this.btn_browse);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtbx_export_server_name);
            this.tabPage1.Controls.Add(this.txtbx_export_username);
            this.tabPage1.Controls.Add(this.txtbx_export_output_folder);
            this.tabPage1.Controls.Add(this.txtbx_export_password);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Export";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_export_connect
            // 
            this.btn_export_connect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_connect.Location = new System.Drawing.Point(371, 78);
            this.btn_export_connect.Name = "btn_export_connect";
            this.btn_export_connect.Size = new System.Drawing.Size(75, 25);
            this.btn_export_connect.TabIndex = 4;
            this.btn_export_connect.Text = "Connect";
            this.btn_export_connect.UseVisualStyleBackColor = true;
            this.btn_export_connect.Click += new System.EventHandler(this.btn_export_connect_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(371, 109);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 25);
            this.btn_browse.TabIndex = 6;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_export_browse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chckbx_show_system_databases);
            this.groupBox2.Controls.Add(this.chckbx_select_all_non_system);
            this.groupBox2.Controls.Add(this.checkedListBox_databases);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 174);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Databases";
            // 
            // chckbx_show_system_databases
            // 
            this.chckbx_show_system_databases.AutoSize = true;
            this.chckbx_show_system_databases.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbx_show_system_databases.Location = new System.Drawing.Point(6, 55);
            this.chckbx_show_system_databases.Name = "chckbx_show_system_databases";
            this.chckbx_show_system_databases.Size = new System.Drawing.Size(166, 21);
            this.chckbx_show_system_databases.TabIndex = 9;
            this.chckbx_show_system_databases.Text = "Show system databases";
            this.chckbx_show_system_databases.UseVisualStyleBackColor = true;
            this.chckbx_show_system_databases.CheckedChanged += new System.EventHandler(this.chckbx_show_system_databases_CheckedChanged);
            // 
            // chckbx_select_all_non_system
            // 
            this.chckbx_select_all_non_system.AutoSize = true;
            this.chckbx_select_all_non_system.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbx_select_all_non_system.Location = new System.Drawing.Point(6, 28);
            this.chckbx_select_all_non_system.Name = "chckbx_select_all_non_system";
            this.chckbx_select_all_non_system.Size = new System.Drawing.Size(213, 21);
            this.chckbx_select_all_non_system.TabIndex = 8;
            this.chckbx_select_all_non_system.Text = "Select all non-system databases";
            this.chckbx_select_all_non_system.UseVisualStyleBackColor = true;
            this.chckbx_select_all_non_system.CheckedChanged += new System.EventHandler(this.chckbx_select_all_non_system_CheckedChanged);
            // 
            // checkedListBox_databases
            // 
            this.checkedListBox_databases.CheckOnClick = true;
            this.checkedListBox_databases.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_databases.FormattingEnabled = true;
            this.checkedListBox_databases.Location = new System.Drawing.Point(6, 82);
            this.checkedListBox_databases.Name = "checkedListBox_databases";
            this.checkedListBox_databases.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox_databases.ScrollAlwaysVisible = true;
            this.checkedListBox_databases.Size = new System.Drawing.Size(425, 84);
            this.checkedListBox_databases.TabIndex = 7;
            this.checkedListBox_databases.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_databases_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Output Folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // txtbx_export_server_name
            // 
            this.txtbx_export_server_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_export_server_name.Location = new System.Drawing.Point(103, 17);
            this.txtbx_export_server_name.Name = "txtbx_export_server_name";
            this.txtbx_export_server_name.Size = new System.Drawing.Size(343, 25);
            this.txtbx_export_server_name.TabIndex = 1;
            this.txtbx_export_server_name.TextChanged += new System.EventHandler(this.txtbx_export_server_name_TextChanged);
            // 
            // txtbx_export_username
            // 
            this.txtbx_export_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_export_username.Location = new System.Drawing.Point(103, 48);
            this.txtbx_export_username.Name = "txtbx_export_username";
            this.txtbx_export_username.Size = new System.Drawing.Size(343, 25);
            this.txtbx_export_username.TabIndex = 2;
            // 
            // txtbx_export_output_folder
            // 
            this.txtbx_export_output_folder.Enabled = false;
            this.txtbx_export_output_folder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_export_output_folder.Location = new System.Drawing.Point(103, 110);
            this.txtbx_export_output_folder.Name = "txtbx_export_output_folder";
            this.txtbx_export_output_folder.Size = new System.Drawing.Size(262, 25);
            this.txtbx_export_output_folder.TabIndex = 5;
            // 
            // txtbx_export_password
            // 
            this.txtbx_export_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_export_password.Location = new System.Drawing.Point(103, 79);
            this.txtbx_export_password.Name = "txtbx_export_password";
            this.txtbx_export_password.PasswordChar = '*';
            this.txtbx_export_password.Size = new System.Drawing.Size(262, 25);
            this.txtbx_export_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // tbcntrl_tabs
            // 
            this.tbcntrl_tabs.Controls.Add(this.tabPage1);
            this.tbcntrl_tabs.Controls.Add(this.tabPage2);
            this.tbcntrl_tabs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcntrl_tabs.Location = new System.Drawing.Point(12, 12);
            this.tbcntrl_tabs.Name = "tbcntrl_tabs";
            this.tbcntrl_tabs.SelectedIndex = 0;
            this.tbcntrl_tabs.Size = new System.Drawing.Size(460, 360);
            this.tbcntrl_tabs.TabIndex = 8;
            // 
            // picBx_loadingicon
            // 
            this.picBx_loadingicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBx_loadingicon.Image = ((System.Drawing.Image)(resources.GetObject("picBx_loadingicon.Image")));
            this.picBx_loadingicon.Location = new System.Drawing.Point(335, 547);
            this.picBx_loadingicon.Name = "picBx_loadingicon";
            this.picBx_loadingicon.Size = new System.Drawing.Size(25, 25);
            this.picBx_loadingicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx_loadingicon.TabIndex = 13;
            this.picBx_loadingicon.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.Location = new System.Drawing.Point(366, 547);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(25, 25);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 581);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.picBx_loadingicon);
            this.Controls.Add(this.tbcntrl_tabs);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(500, 620);
            this.MinimumSize = new System.Drawing.Size(500, 620);
            this.Name = "MainForm";
            this.Text = "CopyDB";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbcntrl_tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBx_loadingicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btn_start;
        internal System.Windows.Forms.TextBox txtbx_output;
        internal System.Windows.Forms.Button btn_export_connect;
        internal System.Windows.Forms.Button btn_browse;
        internal System.Windows.Forms.CheckedListBox checkedListBox_databases;
        internal System.Windows.Forms.TextBox txtbx_export_server_name;
        internal System.Windows.Forms.TextBox txtbx_export_username;
        internal System.Windows.Forms.TextBox txtbx_export_password;
        internal System.Windows.Forms.TextBox txtbx_export_output_folder;
        internal System.Windows.Forms.CheckBox chckbx_show_system_databases;
        internal System.Windows.Forms.CheckBox chckbx_select_all_non_system;
        internal System.Windows.Forms.PictureBox picBx_loadingicon;
        internal System.Windows.Forms.Button btn_import_connect;
        internal System.Windows.Forms.TextBox txtbx_import_server_name;
        internal System.Windows.Forms.TextBox txtbx_import_username;
        internal System.Windows.Forms.TextBox txtbx_import_password;
        internal System.Windows.Forms.Button btn_import_browse;
        internal System.Windows.Forms.TextBox txtbx_import_source_folder;
        internal System.Windows.Forms.ComboBox cmbbx_import_server_type;
        internal System.Windows.Forms.TabControl tbcntrl_tabs;
        internal System.Windows.Forms.Button btn_cancel;
    }
}

