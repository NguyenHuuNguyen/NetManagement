
namespace PBL3_NetManagement
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Computers = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonEditComputer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatusComputer = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPriceComputer = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameComputer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDComputer = new System.Windows.Forms.TextBox();
            this.buttonAddComputer = new System.Windows.Forms.Button();
            this.buttonDeleteComputer = new System.Windows.Forms.Button();
            this.flowLayoutComputer = new System.Windows.Forms.FlowLayoutPanel();
            this.Accouts = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddBill = new System.Windows.Forms.Button();
            this.buttonDep_Account = new System.Windows.Forms.Button();
            this.textBoxSearch_Account = new System.Windows.Forms.TextBox();
            this.dataGridView_Account = new System.Windows.Forms.DataGridView();
            this.buttonDel_Account = new System.Windows.Forms.Button();
            this.buttonAdd_Account = new System.Windows.Forms.Button();
            this.buttonEdit_Account = new System.Windows.Forms.Button();
            this.Goods = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Goods = new System.Windows.Forms.DataGridView();
            this.textBoxSearch_Goods = new System.Windows.Forms.TextBox();
            this.buttonDel_Goods = new System.Windows.Forms.Button();
            this.buttonEdit_Goods = new System.Windows.Forms.Button();
            this.buttonAdd_Goods = new System.Windows.Forms.Button();
            this.SystemLog = new System.Windows.Forms.TabPage();
            this.textBoxSystemLog_All = new System.Windows.Forms.TextBox();
            this.buttonRefreshSystemLog = new System.Windows.Forms.Button();
            this.buttonSearch_SystemLog = new System.Windows.Forms.Button();
            this.textBox_SystemLogSearch = new System.Windows.Forms.TextBox();
            this.Bills = new System.Windows.Forms.TabPage();
            this.textBoxBill = new System.Windows.Forms.TextBox();
            this.buttonRefresh_Bills = new System.Windows.Forms.Button();
            this.buttonSearch_Bills = new System.Windows.Forms.Button();
            this.texboxSearch_Bills = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.Computers.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Accouts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Account)).BeginInit();
            this.Goods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Goods)).BeginInit();
            this.SystemLog.SuspendLayout();
            this.Bills.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Computers);
            this.tabControl1.Controls.Add(this.Accouts);
            this.tabControl1.Controls.Add(this.Goods);
            this.tabControl1.Controls.Add(this.SystemLog);
            this.tabControl1.Controls.Add(this.Bills);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 659);
            this.tabControl1.TabIndex = 0;
            // 
            // Computers
            // 
            this.Computers.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.Computers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Computers.Controls.Add(this.panel5);
            this.Computers.Controls.Add(this.buttonEditComputer);
            this.Computers.Controls.Add(this.panel4);
            this.Computers.Controls.Add(this.panel3);
            this.Computers.Controls.Add(this.panel2);
            this.Computers.Controls.Add(this.panel1);
            this.Computers.Controls.Add(this.buttonAddComputer);
            this.Computers.Controls.Add(this.buttonDeleteComputer);
            this.Computers.Controls.Add(this.flowLayoutComputer);
            this.Computers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Computers.Location = new System.Drawing.Point(4, 25);
            this.Computers.Name = "Computers";
            this.Computers.Padding = new System.Windows.Forms.Padding(3);
            this.Computers.Size = new System.Drawing.Size(973, 630);
            this.Computers.TabIndex = 0;
            this.Computers.Text = "Computers";
            this.Computers.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textBoxUser);
            this.panel5.Location = new System.Drawing.Point(594, 238);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 46);
            this.panel5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "User";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Enabled = false;
            this.textBoxUser.Location = new System.Drawing.Point(93, 8);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(227, 30);
            this.textBoxUser.TabIndex = 3;
            // 
            // buttonEditComputer
            // 
            this.buttonEditComputer.AutoSize = true;
            this.buttonEditComputer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditComputer.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonEditComputer.Location = new System.Drawing.Point(716, 330);
            this.buttonEditComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditComputer.Name = "buttonEditComputer";
            this.buttonEditComputer.Size = new System.Drawing.Size(97, 39);
            this.buttonEditComputer.TabIndex = 15;
            this.buttonEditComputer.Text = "EDIT";
            this.buttonEditComputer.UseVisualStyleBackColor = false;
            this.buttonEditComputer.Click += new System.EventHandler(this.buttonEditComputer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelStatus);
            this.panel4.Controls.Add(this.textBoxStatusComputer);
            this.panel4.Location = new System.Drawing.Point(594, 188);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 46);
            this.panel4.TabIndex = 12;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 10);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 25);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // textBoxStatusComputer
            // 
            this.textBoxStatusComputer.Enabled = false;
            this.textBoxStatusComputer.Location = new System.Drawing.Point(93, 8);
            this.textBoxStatusComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStatusComputer.Name = "textBoxStatusComputer";
            this.textBoxStatusComputer.Size = new System.Drawing.Size(227, 30);
            this.textBoxStatusComputer.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxPriceComputer);
            this.panel3.Location = new System.Drawing.Point(594, 137);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 46);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 4;
            // 
            // textBoxPriceComputer
            // 
            this.textBoxPriceComputer.Enabled = false;
            this.textBoxPriceComputer.Location = new System.Drawing.Point(93, 8);
            this.textBoxPriceComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPriceComputer.Name = "textBoxPriceComputer";
            this.textBoxPriceComputer.Size = new System.Drawing.Size(227, 30);
            this.textBoxPriceComputer.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxNameComputer);
            this.panel2.Location = new System.Drawing.Point(594, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 46);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // textBoxNameComputer
            // 
            this.textBoxNameComputer.Enabled = false;
            this.textBoxNameComputer.Location = new System.Drawing.Point(93, 8);
            this.textBoxNameComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameComputer.Name = "textBoxNameComputer";
            this.textBoxNameComputer.Size = new System.Drawing.Size(227, 30);
            this.textBoxNameComputer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxIDComputer);
            this.panel1.Location = new System.Drawing.Point(594, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 46);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // textBoxIDComputer
            // 
            this.textBoxIDComputer.Enabled = false;
            this.textBoxIDComputer.Location = new System.Drawing.Point(93, 8);
            this.textBoxIDComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIDComputer.Name = "textBoxIDComputer";
            this.textBoxIDComputer.Size = new System.Drawing.Size(227, 30);
            this.textBoxIDComputer.TabIndex = 3;
            // 
            // buttonAddComputer
            // 
            this.buttonAddComputer.AutoSize = true;
            this.buttonAddComputer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddComputer.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAddComputer.Location = new System.Drawing.Point(594, 330);
            this.buttonAddComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddComputer.Name = "buttonAddComputer";
            this.buttonAddComputer.Size = new System.Drawing.Size(97, 39);
            this.buttonAddComputer.TabIndex = 10;
            this.buttonAddComputer.Text = "ADD";
            this.buttonAddComputer.UseVisualStyleBackColor = false;
            this.buttonAddComputer.Click += new System.EventHandler(this.buttonAddComputer_Click);
            // 
            // buttonDeleteComputer
            // 
            this.buttonDeleteComputer.AutoSize = true;
            this.buttonDeleteComputer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteComputer.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonDeleteComputer.Location = new System.Drawing.Point(836, 330);
            this.buttonDeleteComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteComputer.Name = "buttonDeleteComputer";
            this.buttonDeleteComputer.Size = new System.Drawing.Size(97, 39);
            this.buttonDeleteComputer.TabIndex = 10;
            this.buttonDeleteComputer.Text = "DEL";
            this.buttonDeleteComputer.UseVisualStyleBackColor = false;
            this.buttonDeleteComputer.Click += new System.EventHandler(this.buttonDeleteComputer_Click);
            // 
            // flowLayoutComputer
            // 
            this.flowLayoutComputer.BackColor = System.Drawing.Color.White;
            this.flowLayoutComputer.Location = new System.Drawing.Point(39, 34);
            this.flowLayoutComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutComputer.Name = "flowLayoutComputer";
            this.flowLayoutComputer.Size = new System.Drawing.Size(515, 562);
            this.flowLayoutComputer.TabIndex = 8;
            // 
            // Accouts
            // 
            this.Accouts.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.Accouts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Accouts.Controls.Add(this.label6);
            this.Accouts.Controls.Add(this.buttonAddBill);
            this.Accouts.Controls.Add(this.buttonDep_Account);
            this.Accouts.Controls.Add(this.textBoxSearch_Account);
            this.Accouts.Controls.Add(this.dataGridView_Account);
            this.Accouts.Controls.Add(this.buttonDel_Account);
            this.Accouts.Controls.Add(this.buttonAdd_Account);
            this.Accouts.Controls.Add(this.buttonEdit_Account);
            this.Accouts.Location = new System.Drawing.Point(4, 25);
            this.Accouts.Name = "Accouts";
            this.Accouts.Padding = new System.Windows.Forms.Padding(3);
            this.Accouts.Size = new System.Drawing.Size(973, 630);
            this.Accouts.TabIndex = 1;
            this.Accouts.Text = "Account";
            this.Accouts.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(692, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Search";
            // 
            // buttonAddBill
            // 
            this.buttonAddBill.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddBill.Location = new System.Drawing.Point(557, 33);
            this.buttonAddBill.Name = "buttonAddBill";
            this.buttonAddBill.Size = new System.Drawing.Size(100, 44);
            this.buttonAddBill.TabIndex = 8;
            this.buttonAddBill.Text = "Add Bill";
            this.buttonAddBill.UseVisualStyleBackColor = false;
            this.buttonAddBill.Click += new System.EventHandler(this.buttonAddBill_Click);
            // 
            // buttonDep_Account
            // 
            this.buttonDep_Account.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDep_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDep_Account.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDep_Account.Location = new System.Drawing.Point(427, 33);
            this.buttonDep_Account.Name = "buttonDep_Account";
            this.buttonDep_Account.Size = new System.Drawing.Size(100, 44);
            this.buttonDep_Account.TabIndex = 7;
            this.buttonDep_Account.Text = "Dep";
            this.buttonDep_Account.UseVisualStyleBackColor = false;
            this.buttonDep_Account.Click += new System.EventHandler(this.buttonDep_Account_Click);
            // 
            // textBoxSearch_Account
            // 
            this.textBoxSearch_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch_Account.Location = new System.Drawing.Point(692, 43);
            this.textBoxSearch_Account.Name = "textBoxSearch_Account";
            this.textBoxSearch_Account.Size = new System.Drawing.Size(241, 30);
            this.textBoxSearch_Account.TabIndex = 5;
            this.textBoxSearch_Account.TextChanged += new System.EventHandler(this.textBoxSearch_Account_TextChanged);
            // 
            // dataGridView_Account
            // 
            this.dataGridView_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Account.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Account.Location = new System.Drawing.Point(45, 121);
            this.dataGridView_Account.MultiSelect = false;
            this.dataGridView_Account.Name = "dataGridView_Account";
            this.dataGridView_Account.ReadOnly = true;
            this.dataGridView_Account.RowHeadersWidth = 51;
            this.dataGridView_Account.RowTemplate.Height = 24;
            this.dataGridView_Account.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Account.Size = new System.Drawing.Size(888, 471);
            this.dataGridView_Account.TabIndex = 4;
            // 
            // buttonDel_Account
            // 
            this.buttonDel_Account.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel_Account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel_Account.Location = new System.Drawing.Point(300, 33);
            this.buttonDel_Account.Name = "buttonDel_Account";
            this.buttonDel_Account.Size = new System.Drawing.Size(100, 44);
            this.buttonDel_Account.TabIndex = 3;
            this.buttonDel_Account.Text = "Delete";
            this.buttonDel_Account.UseVisualStyleBackColor = false;
            this.buttonDel_Account.Click += new System.EventHandler(this.buttonDel_Account_Click);
            // 
            // buttonAdd_Account
            // 
            this.buttonAdd_Account.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd_Account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd_Account.Location = new System.Drawing.Point(45, 33);
            this.buttonAdd_Account.Name = "buttonAdd_Account";
            this.buttonAdd_Account.Size = new System.Drawing.Size(100, 44);
            this.buttonAdd_Account.TabIndex = 2;
            this.buttonAdd_Account.Text = "Add";
            this.buttonAdd_Account.UseVisualStyleBackColor = false;
            this.buttonAdd_Account.Click += new System.EventHandler(this.buttonAdd_Account_Click);
            // 
            // buttonEdit_Account
            // 
            this.buttonEdit_Account.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit_Account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit_Account.Location = new System.Drawing.Point(172, 33);
            this.buttonEdit_Account.Name = "buttonEdit_Account";
            this.buttonEdit_Account.Size = new System.Drawing.Size(100, 44);
            this.buttonEdit_Account.TabIndex = 2;
            this.buttonEdit_Account.Text = "Edit";
            this.buttonEdit_Account.UseVisualStyleBackColor = false;
            this.buttonEdit_Account.Click += new System.EventHandler(this.buttonEdit_Account_Click);
            // 
            // Goods
            // 
            this.Goods.BackColor = System.Drawing.Color.Transparent;
            this.Goods.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.Goods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Goods.Controls.Add(this.button1);
            this.Goods.Controls.Add(this.dataGridView_Goods);
            this.Goods.Controls.Add(this.textBoxSearch_Goods);
            this.Goods.Controls.Add(this.buttonDel_Goods);
            this.Goods.Controls.Add(this.buttonEdit_Goods);
            this.Goods.Controls.Add(this.buttonAdd_Goods);
            this.Goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goods.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Goods.Location = new System.Drawing.Point(4, 25);
            this.Goods.Name = "Goods";
            this.Goods.Size = new System.Drawing.Size(973, 630);
            this.Goods.TabIndex = 3;
            this.Goods.Text = "Goods";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(445, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Goods
            // 
            this.dataGridView_Goods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Goods.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_Goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Goods.Location = new System.Drawing.Point(41, 118);
            this.dataGridView_Goods.MultiSelect = false;
            this.dataGridView_Goods.Name = "dataGridView_Goods";
            this.dataGridView_Goods.ReadOnly = true;
            this.dataGridView_Goods.RowHeadersWidth = 51;
            this.dataGridView_Goods.RowTemplate.Height = 24;
            this.dataGridView_Goods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Goods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Goods.Size = new System.Drawing.Size(888, 471);
            this.dataGridView_Goods.TabIndex = 6;
            // 
            // textBoxSearch_Goods
            // 
            this.textBoxSearch_Goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch_Goods.Location = new System.Drawing.Point(574, 44);
            this.textBoxSearch_Goods.Name = "textBoxSearch_Goods";
            this.textBoxSearch_Goods.Size = new System.Drawing.Size(353, 30);
            this.textBoxSearch_Goods.TabIndex = 4;
            this.textBoxSearch_Goods.TextChanged += new System.EventHandler(this.textBoxSearch_Goods_TextChanged);
            // 
            // buttonDel_Goods
            // 
            this.buttonDel_Goods.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel_Goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel_Goods.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel_Goods.Location = new System.Drawing.Point(318, 35);
            this.buttonDel_Goods.Name = "buttonDel_Goods";
            this.buttonDel_Goods.Size = new System.Drawing.Size(100, 44);
            this.buttonDel_Goods.TabIndex = 3;
            this.buttonDel_Goods.Text = "Delete";
            this.buttonDel_Goods.UseVisualStyleBackColor = false;
            this.buttonDel_Goods.Click += new System.EventHandler(this.buttonDel_Goods_Click);
            // 
            // buttonEdit_Goods
            // 
            this.buttonEdit_Goods.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit_Goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit_Goods.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit_Goods.Location = new System.Drawing.Point(177, 35);
            this.buttonEdit_Goods.Name = "buttonEdit_Goods";
            this.buttonEdit_Goods.Size = new System.Drawing.Size(100, 44);
            this.buttonEdit_Goods.TabIndex = 2;
            this.buttonEdit_Goods.Text = "Edit";
            this.buttonEdit_Goods.UseVisualStyleBackColor = false;
            this.buttonEdit_Goods.Click += new System.EventHandler(this.buttonEdit_Goods_Click);
            // 
            // buttonAdd_Goods
            // 
            this.buttonAdd_Goods.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd_Goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd_Goods.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd_Goods.Location = new System.Drawing.Point(41, 35);
            this.buttonAdd_Goods.Name = "buttonAdd_Goods";
            this.buttonAdd_Goods.Size = new System.Drawing.Size(100, 44);
            this.buttonAdd_Goods.TabIndex = 1;
            this.buttonAdd_Goods.Text = "Add";
            this.buttonAdd_Goods.UseVisualStyleBackColor = false;
            this.buttonAdd_Goods.Click += new System.EventHandler(this.buttonAdd_Goods_Click);
            // 
            // SystemLog
            // 
            this.SystemLog.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.SystemLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SystemLog.Controls.Add(this.textBoxSystemLog_All);
            this.SystemLog.Controls.Add(this.buttonRefreshSystemLog);
            this.SystemLog.Controls.Add(this.buttonSearch_SystemLog);
            this.SystemLog.Controls.Add(this.textBox_SystemLogSearch);
            this.SystemLog.Location = new System.Drawing.Point(4, 25);
            this.SystemLog.Name = "SystemLog";
            this.SystemLog.Size = new System.Drawing.Size(973, 630);
            this.SystemLog.TabIndex = 2;
            this.SystemLog.Text = "System Log";
            this.SystemLog.UseVisualStyleBackColor = true;
            // 
            // textBoxSystemLog_All
            // 
            this.textBoxSystemLog_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSystemLog_All.Location = new System.Drawing.Point(54, 96);
            this.textBoxSystemLog_All.Multiline = true;
            this.textBoxSystemLog_All.Name = "textBoxSystemLog_All";
            this.textBoxSystemLog_All.ReadOnly = true;
            this.textBoxSystemLog_All.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSystemLog_All.Size = new System.Drawing.Size(866, 508);
            this.textBoxSystemLog_All.TabIndex = 3;
            this.textBoxSystemLog_All.WordWrap = false;
            // 
            // buttonRefreshSystemLog
            // 
            this.buttonRefreshSystemLog.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRefreshSystemLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshSystemLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRefreshSystemLog.Location = new System.Drawing.Point(568, 29);
            this.buttonRefreshSystemLog.Name = "buttonRefreshSystemLog";
            this.buttonRefreshSystemLog.Size = new System.Drawing.Size(100, 44);
            this.buttonRefreshSystemLog.TabIndex = 2;
            this.buttonRefreshSystemLog.Text = "Refresh";
            this.buttonRefreshSystemLog.UseVisualStyleBackColor = false;
            this.buttonRefreshSystemLog.Click += new System.EventHandler(this.buttonRefreshSystemLog_Click);
            // 
            // buttonSearch_SystemLog
            // 
            this.buttonSearch_SystemLog.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearch_SystemLog.Enabled = false;
            this.buttonSearch_SystemLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch_SystemLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch_SystemLog.Location = new System.Drawing.Point(445, 29);
            this.buttonSearch_SystemLog.Name = "buttonSearch_SystemLog";
            this.buttonSearch_SystemLog.Size = new System.Drawing.Size(100, 44);
            this.buttonSearch_SystemLog.TabIndex = 2;
            this.buttonSearch_SystemLog.Text = "Search";
            this.buttonSearch_SystemLog.UseVisualStyleBackColor = false;
            // 
            // textBox_SystemLogSearch
            // 
            this.textBox_SystemLogSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SystemLogSearch.Location = new System.Drawing.Point(54, 35);
            this.textBox_SystemLogSearch.Name = "textBox_SystemLogSearch";
            this.textBox_SystemLogSearch.Size = new System.Drawing.Size(347, 30);
            this.textBox_SystemLogSearch.TabIndex = 1;
            this.textBox_SystemLogSearch.TextChanged += new System.EventHandler(this.textBox_SystemLogSearch_TextChanged);
            // 
            // Bills
            // 
            this.Bills.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.Bills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bills.Controls.Add(this.textBoxBill);
            this.Bills.Controls.Add(this.buttonRefresh_Bills);
            this.Bills.Controls.Add(this.buttonSearch_Bills);
            this.Bills.Controls.Add(this.texboxSearch_Bills);
            this.Bills.Location = new System.Drawing.Point(4, 25);
            this.Bills.Name = "Bills";
            this.Bills.Size = new System.Drawing.Size(973, 630);
            this.Bills.TabIndex = 4;
            this.Bills.Text = "Bills";
            this.Bills.UseVisualStyleBackColor = true;
            // 
            // textBoxBill
            // 
            this.textBoxBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBill.Location = new System.Drawing.Point(53, 92);
            this.textBoxBill.Multiline = true;
            this.textBoxBill.Name = "textBoxBill";
            this.textBoxBill.ReadOnly = true;
            this.textBoxBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBill.Size = new System.Drawing.Size(866, 508);
            this.textBoxBill.TabIndex = 4;
            this.textBoxBill.WordWrap = false;
            // 
            // buttonRefresh_Bills
            // 
            this.buttonRefresh_Bills.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRefresh_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh_Bills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh_Bills.Location = new System.Drawing.Point(559, 32);
            this.buttonRefresh_Bills.Name = "buttonRefresh_Bills";
            this.buttonRefresh_Bills.Size = new System.Drawing.Size(100, 44);
            this.buttonRefresh_Bills.TabIndex = 2;
            this.buttonRefresh_Bills.Text = "Refresh";
            this.buttonRefresh_Bills.UseVisualStyleBackColor = false;
            this.buttonRefresh_Bills.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSearch_Bills
            // 
            this.buttonSearch_Bills.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSearch_Bills.Enabled = false;
            this.buttonSearch_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch_Bills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch_Bills.Location = new System.Drawing.Point(431, 32);
            this.buttonSearch_Bills.Name = "buttonSearch_Bills";
            this.buttonSearch_Bills.Size = new System.Drawing.Size(100, 44);
            this.buttonSearch_Bills.TabIndex = 2;
            this.buttonSearch_Bills.Text = "Search";
            this.buttonSearch_Bills.UseVisualStyleBackColor = false;
            // 
            // texboxSearch_Bills
            // 
            this.texboxSearch_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texboxSearch_Bills.Location = new System.Drawing.Point(53, 38);
            this.texboxSearch_Bills.Name = "texboxSearch_Bills";
            this.texboxSearch_Bills.Size = new System.Drawing.Size(347, 30);
            this.texboxSearch_Bills.TabIndex = 1;
            this.texboxSearch_Bills.TextChanged += new System.EventHandler(this.textboxBill_Textchanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.Text = "NetManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Shown += new System.EventHandler(this.FormAdmin_Shown);
            this.tabControl1.ResumeLayout(false);
            this.Computers.ResumeLayout(false);
            this.Computers.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Accouts.ResumeLayout(false);
            this.Accouts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Account)).EndInit();
            this.Goods.ResumeLayout(false);
            this.Goods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Goods)).EndInit();
            this.SystemLog.ResumeLayout(false);
            this.SystemLog.PerformLayout();
            this.Bills.ResumeLayout(false);
            this.Bills.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Computers;
        private System.Windows.Forms.TabPage Accouts;
        private System.Windows.Forms.TabPage Goods;
        private System.Windows.Forms.TabPage SystemLog;
        private System.Windows.Forms.TextBox textBoxSearch_Account;
        private System.Windows.Forms.DataGridView dataGridView_Account;
        private System.Windows.Forms.Button buttonDel_Account;
        private System.Windows.Forms.Button buttonEdit_Account;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonDel_Goods;
        private System.Windows.Forms.Button buttonEdit_Goods;
        private System.Windows.Forms.Button buttonAdd_Goods;
        private System.Windows.Forms.TextBox textBoxSearch_Goods;
        private System.Windows.Forms.Button buttonSearch_SystemLog;
        private System.Windows.Forms.TextBox textBox_SystemLogSearch;
        private System.Windows.Forms.Button buttonDep_Account;
        private System.Windows.Forms.TabPage Bills;
        private System.Windows.Forms.Button buttonSearch_Bills;
        private System.Windows.Forms.TextBox texboxSearch_Bills;
        private System.Windows.Forms.Button buttonEditComputer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatusComputer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPriceComputer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameComputer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDComputer;
        private System.Windows.Forms.Button buttonAddComputer;
        private System.Windows.Forms.Button buttonDeleteComputer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutComputer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonRefreshSystemLog;
        private System.Windows.Forms.TextBox textBoxSystemLog_All;
        private System.Windows.Forms.Button buttonAdd_Account;
        private System.Windows.Forms.TextBox textBoxBill;
        private System.Windows.Forms.Button buttonRefresh_Bills;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Goods;
    }
}