namespace wenaniPos
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.brnCancel = new System.Windows.Forms.Button();
            this.btnSettle = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblVatable = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.brnCancel);
            this.panel1.Controls.Add(this.btnSettle);
            this.panel1.Controls.Add(this.btnDiscount);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 673);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.lblDate1);
            this.panel7.Controls.Add(this.lblTime);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 578);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 95);
            this.panel7.TabIndex = 6;
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate1.Location = new System.Drawing.Point(0, 47);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(90, 22);
            this.lblDate1.TabIndex = 1;
            this.lblDate1.Text = "00:00:00";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(196, 47);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(0, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(281, 39);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "  [ F10 ] Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 432);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(281, 38);
            this.btnChangePassword.TabIndex = 12;
            this.btnChangePassword.Text = "  [ F7 ] Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 394);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(281, 38);
            this.btnSales.TabIndex = 11;
            this.btnSales.Text = "  [ F6 ] Daily Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.button5_Click);
            // 
            // brnCancel
            // 
            this.brnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.brnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnCancel.FlatAppearance.BorderSize = 0;
            this.brnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.brnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCancel.ForeColor = System.Drawing.Color.White;
            this.brnCancel.Image = ((System.Drawing.Image)(resources.GetObject("brnCancel.Image")));
            this.brnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnCancel.Location = new System.Drawing.Point(0, 356);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(281, 38);
            this.brnCancel.TabIndex = 10;
            this.brnCancel.Text = "  [ F5 ] Cancel Sales";
            this.brnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnCancel.UseVisualStyleBackColor = false;
            this.brnCancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSettle
            // 
            this.btnSettle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSettle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettle.Enabled = false;
            this.btnSettle.FlatAppearance.BorderSize = 0;
            this.btnSettle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettle.ForeColor = System.Drawing.Color.White;
            this.btnSettle.Image = ((System.Drawing.Image)(resources.GetObject("btnSettle.Image")));
            this.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettle.Location = new System.Drawing.Point(0, 318);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(281, 38);
            this.btnSettle.TabIndex = 9;
            this.btnSettle.Text = "  [ F4 ] Settle Payement";
            this.btnSettle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettle.UseVisualStyleBackColor = false;
            this.btnSettle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscount.Enabled = false;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(0, 280);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(281, 38);
            this.btnDiscount.TabIndex = 8;
            this.btnDiscount.Text = "  [ F3 ] Add Discount";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(281, 38);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "  [ F2 ] Search Product";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(0, 204);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(281, 38);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "  [ F1 ] New Transaction";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 204);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cashier Name Here";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(29, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wenani POS Software";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(949, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 673);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 248);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.lblVatable);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.lblVat);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.lblDiscount);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lblTotalSales);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 246);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // lblVatable
            // 
            this.lblVatable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatable.Location = new System.Drawing.Point(150, 142);
            this.lblVatable.Name = "lblVatable";
            this.lblVatable.Size = new System.Drawing.Size(125, 21);
            this.lblVatable.TabIndex = 7;
            this.lblVatable.Text = "0.00";
            this.lblVatable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVatable.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 21);
            this.label15.TabIndex = 6;
            this.label15.Text = "Vatable";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lblVat
            // 
            this.lblVat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(150, 115);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(125, 21);
            this.lblVat.TabIndex = 5;
            this.lblVat.Text = "0.00";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVat.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "VAT";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(150, 88);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(125, 21);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscount.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Discount";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(150, 61);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(125, 21);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "0.00";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalSales.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sales Total";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.lblDisplayTotal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 95);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotal.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTotal.Location = new System.Drawing.Point(0, 0);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(299, 95);
            this.lblDisplayTotal.TabIndex = 0;
            this.lblDisplayTotal.Text = "0.00";
            this.lblDisplayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplayTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblTransactionNo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(281, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 95);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 9;
            this.label16.Tag = "";
            this.label16.Text = "Barcode";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(120, 60);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Scan Barcode Here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(303, 26);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Scan Barcode Here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(117, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Tag = "";
            this.lblDate.Text = "000000000000";
            this.lblDate.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 2;
            this.label6.Tag = "";
            this.label6.Text = "Date";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.ForeColor = System.Drawing.Color.Red;
            this.lblTransactionNo.Location = new System.Drawing.Point(117, 13);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(92, 17);
            this.lblTransactionNo.TabIndex = 1;
            this.lblTransactionNo.Tag = "";
            this.lblTransactionNo.Text = "000000000000";
            this.lblTransactionNo.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Tag = "";
            this.label3.Text = "Transaction No";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Delete});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(281, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(668, 575);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "proCode";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 59;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.Width = 51;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.HeaderText = "Discount";
            this.Column7.Name = "Column7";
            this.Column7.Width = 81;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.Width = 59;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 673);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Button btnSales;
        public System.Windows.Forms.Button brnCancel;
        public System.Windows.Forms.Button btnSettle;
        public System.Windows.Forms.Button btnDiscount;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnChangePassword;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        public MetroFramework.Controls.MetroTextBox txtSearch;
        public System.Windows.Forms.Label lblTransactionNo;
        public System.Windows.Forms.Label lblTotalSales;
        public System.Windows.Forms.Label lblVatable;
        public System.Windows.Forms.Label lblVat;
        public System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}