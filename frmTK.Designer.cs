
namespace Quan_Ly_Hieu_Thuoc
{
    partial class frmTK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbxtTK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdenngay = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttungay = new System.Windows.Forms.MaskedTextBox();
            this.gridViewPN = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTongtiennhap = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbtongtienban = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbdoanhthu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnhanvientop1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.gridViewPX = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtthuocbantop1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPX)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.guna2Panel1.Controls.Add(this.cbxtTK);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtdenngay);
            this.guna2Panel1.Controls.Add(this.label13);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txttungay);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1002, 77);
            this.guna2Panel1.TabIndex = 0;
            // 
            // cbxtTK
            // 
            this.cbxtTK.FormattingEnabled = true;
            this.cbxtTK.Items.AddRange(new object[] {
            "Tổng tiền nhập thuốc",
            "Tổng tiền bán thuốc",
            "Doanh thu",
            "Nhân viên bán nhiều nhất",
            "Thuốc bán nhiều nhất"});
            this.cbxtTK.Location = new System.Drawing.Point(141, 29);
            this.cbxtTK.Name = "cbxtTK";
            this.cbxtTK.Size = new System.Drawing.Size(220, 21);
            this.cbxtTK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(583, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // txtdenngay
            // 
            this.txtdenngay.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtdenngay.Location = new System.Drawing.Point(647, 28);
            this.txtdenngay.Mask = "0000/00/00";
            this.txtdenngay.Name = "txtdenngay";
            this.txtdenngay.Size = new System.Drawing.Size(106, 22);
            this.txtdenngay.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(24, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Thống kê theo mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(387, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // txttungay
            // 
            this.txttungay.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txttungay.Location = new System.Drawing.Point(451, 28);
            this.txttungay.Mask = "0000/00/00";
            this.txttungay.Name = "txttungay";
            this.txttungay.Size = new System.Drawing.Size(106, 22);
            this.txttungay.TabIndex = 0;
            this.txttungay.ValidatingType = typeof(System.DateTime);
            // 
            // gridViewPN
            // 
            this.gridViewPN.AllowUserToAddRows = false;
            this.gridViewPN.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridViewPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.gridViewPN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.gridViewPN.ColumnHeadersHeight = 40;
            this.gridViewPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewPN.DefaultCellStyle = dataGridViewCellStyle23;
            this.gridViewPN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewPN.Location = new System.Drawing.Point(5, 222);
            this.gridViewPN.Name = "gridViewPN";
            this.gridViewPN.ReadOnly = true;
            this.gridViewPN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.gridViewPN.RowHeadersVisible = false;
            this.gridViewPN.RowTemplate.Height = 25;
            this.gridViewPN.Size = new System.Drawing.Size(978, 210);
            this.gridViewPN.TabIndex = 1;
            this.gridViewPN.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewPN.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewPN.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewPN.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewPN.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewPN.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewPN.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewPN.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridViewPN.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewPN.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPN.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridViewPN.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridViewPN.ThemeStyle.HeaderStyle.Height = 40;
            this.gridViewPN.ThemeStyle.ReadOnly = true;
            this.gridViewPN.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewPN.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewPN.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPN.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridViewPN.ThemeStyle.RowsStyle.Height = 25;
            this.gridViewPN.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewPN.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng tiền nhập thuốc : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng tiền bán thuốc :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doanh thu:";
            // 
            // lbTongtiennhap
            // 
            this.lbTongtiennhap.AutoSize = true;
            this.lbTongtiennhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtiennhap.ForeColor = System.Drawing.Color.Red;
            this.lbTongtiennhap.Location = new System.Drawing.Point(138, 95);
            this.lbTongtiennhap.Name = "lbTongtiennhap";
            this.lbTongtiennhap.Size = new System.Drawing.Size(15, 17);
            this.lbTongtiennhap.TabIndex = 3;
            this.lbTongtiennhap.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(201, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "VND";
            // 
            // lbtongtienban
            // 
            this.lbtongtienban.AutoSize = true;
            this.lbtongtienban.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtongtienban.ForeColor = System.Drawing.Color.Red;
            this.lbtongtienban.Location = new System.Drawing.Point(138, 134);
            this.lbtongtienban.Name = "lbtongtienban";
            this.lbtongtienban.Size = new System.Drawing.Size(15, 17);
            this.lbtongtienban.TabIndex = 3;
            this.lbtongtienban.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(201, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "VND";
            // 
            // lbdoanhthu
            // 
            this.lbdoanhthu.AutoSize = true;
            this.lbdoanhthu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdoanhthu.ForeColor = System.Drawing.Color.Red;
            this.lbdoanhthu.Location = new System.Drawing.Point(138, 171);
            this.lbdoanhthu.Name = "lbdoanhthu";
            this.lbdoanhthu.Size = new System.Drawing.Size(15, 17);
            this.lbdoanhthu.TabIndex = 3;
            this.lbdoanhthu.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(201, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "VND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nhân viên có doanh thu cao nhất :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Thuốc bán nhiều nhất: ";
            // 
            // txtnhanvientop1
            // 
            this.txtnhanvientop1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnhanvientop1.DefaultText = "";
            this.txtnhanvientop1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnhanvientop1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnhanvientop1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnhanvientop1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnhanvientop1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnhanvientop1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnhanvientop1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnhanvientop1.Location = new System.Drawing.Point(499, 91);
            this.txtnhanvientop1.Name = "txtnhanvientop1";
            this.txtnhanvientop1.PasswordChar = '\0';
            this.txtnhanvientop1.PlaceholderText = "";
            this.txtnhanvientop1.SelectedText = "";
            this.txtnhanvientop1.Size = new System.Drawing.Size(146, 25);
            this.txtnhanvientop1.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(700, 91);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(124, 36);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "THỐNG KÊ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(848, 91);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(124, 36);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "XUẤT FILE";
            // 
            // gridViewPX
            // 
            this.gridViewPX.AllowUserToAddRows = false;
            this.gridViewPX.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridViewPX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.gridViewPX.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gridViewPX.ColumnHeadersHeight = 40;
            this.gridViewPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewPX.DefaultCellStyle = dataGridViewCellStyle19;
            this.gridViewPX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewPX.Location = new System.Drawing.Point(5, 462);
            this.gridViewPX.Name = "gridViewPX";
            this.gridViewPX.ReadOnly = true;
            this.gridViewPX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewPX.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.gridViewPX.RowHeadersVisible = false;
            this.gridViewPX.RowTemplate.Height = 25;
            this.gridViewPX.Size = new System.Drawing.Size(978, 216);
            this.gridViewPX.TabIndex = 1;
            this.gridViewPX.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewPX.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewPX.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewPX.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewPX.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewPX.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewPX.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewPX.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridViewPX.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewPX.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPX.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridViewPX.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridViewPX.ThemeStyle.HeaderStyle.Height = 40;
            this.gridViewPX.ThemeStyle.ReadOnly = true;
            this.gridViewPX.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewPX.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewPX.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewPX.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridViewPX.ThemeStyle.RowsStyle.Height = 25;
            this.gridViewPX.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewPX.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "PHIẾU NHẬP :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 446);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "PHIẾU XUẤT :";
            // 
            // txtthuocbantop1
            // 
            this.txtthuocbantop1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtthuocbantop1.DefaultText = "";
            this.txtthuocbantop1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtthuocbantop1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtthuocbantop1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtthuocbantop1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtthuocbantop1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtthuocbantop1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtthuocbantop1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtthuocbantop1.Location = new System.Drawing.Point(499, 130);
            this.txtthuocbantop1.Name = "txtthuocbantop1";
            this.txtthuocbantop1.PasswordChar = '\0';
            this.txtthuocbantop1.PlaceholderText = "";
            this.txtthuocbantop1.SelectedText = "";
            this.txtthuocbantop1.Size = new System.Drawing.Size(146, 25);
            this.txtthuocbantop1.TabIndex = 4;
            // 
            // frmTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 706);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtthuocbantop1);
            this.Controls.Add(this.txtnhanvientop1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbdoanhthu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbtongtienban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTongtiennhap);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridViewPX);
            this.Controls.Add(this.gridViewPN);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTK";
            this.Load += new System.EventHandler(this.frmTK_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtdenngay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txttungay;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtnhanvientop1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbdoanhthu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbtongtienban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTongtiennhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewPN;
        private System.Windows.Forms.ComboBox cbxtTK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewPX;
        private Guna.UI2.WinForms.Guna2TextBox txtthuocbantop1;
    }
}