using System.ComponentModel;

namespace de_thi_thu_lap_trinh_truc_quan;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        splitContainer1 = new SplitContainer();
        dtpNgayGui = new DateTimePicker();
        label8 = new Label();
        btnTimKiem = new Button();
        tbTimTheoMaKhachHang = new TextBox();
        label6 = new Label();
        btnThemVaoDS = new Button();
        btnThoat = new Button();
        btnThemMoi = new Button();
        cbbThoiGianGui = new ComboBox();
        label5 = new Label();
        tbSoTienGui = new TextBox();
        label4 = new Label();
        tbDiaChi = new TextBox();
        label3 = new Label();
        tbHoTen = new TextBox();
        label2 = new Label();
        tbMaKhachHang = new TextBox();
        label1 = new Label();
        dgvKhachHang = new DataGridView();
        ((ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((ISupportInitialize)dgvKhachHang).BeginInit();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(dtpNgayGui);
        splitContainer1.Panel1.Controls.Add(label8);
        splitContainer1.Panel1.Controls.Add(btnTimKiem);
        splitContainer1.Panel1.Controls.Add(tbTimTheoMaKhachHang);
        splitContainer1.Panel1.Controls.Add(label6);
        splitContainer1.Panel1.Controls.Add(btnThemVaoDS);
        splitContainer1.Panel1.Controls.Add(btnThoat);
        splitContainer1.Panel1.Controls.Add(btnThemMoi);
        splitContainer1.Panel1.Controls.Add(cbbThoiGianGui);
        splitContainer1.Panel1.Controls.Add(label5);
        splitContainer1.Panel1.Controls.Add(tbSoTienGui);
        splitContainer1.Panel1.Controls.Add(label4);
        splitContainer1.Panel1.Controls.Add(tbDiaChi);
        splitContainer1.Panel1.Controls.Add(label3);
        splitContainer1.Panel1.Controls.Add(tbHoTen);
        splitContainer1.Panel1.Controls.Add(label2);
        splitContainer1.Panel1.Controls.Add(tbMaKhachHang);
        splitContainer1.Panel1.Controls.Add(label1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(dgvKhachHang);
        splitContainer1.Size = new Size(800, 450);
        splitContainer1.SplitterDistance = 266;
        splitContainer1.TabIndex = 0;
        // 
        // dtpNgayGui
        // 
        dtpNgayGui.Dock = DockStyle.Top;
        dtpNgayGui.Location = new Point(0, 312);
        dtpNgayGui.Name = "dtpNgayGui";
        dtpNgayGui.Size = new Size(266, 23);
        dtpNgayGui.TabIndex = 17;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Dock = DockStyle.Top;
        label8.Location = new Point(0, 297);
        label8.Name = "label8";
        label8.Size = new Size(53, 15);
        label8.TabIndex = 16;
        label8.Text = "NgayGui";
        // 
        // btnTimKiem
        // 
        btnTimKiem.Dock = DockStyle.Top;
        btnTimKiem.Location = new Point(0, 274);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new Size(266, 23);
        btnTimKiem.TabIndex = 15;
        btnTimKiem.Text = "Tìm Kiếm";
        btnTimKiem.UseVisualStyleBackColor = true;
        btnTimKiem.Click += btnTimKiem_Click;
        // 
        // tbTimTheoMaKhachHang
        // 
        tbTimTheoMaKhachHang.Dock = DockStyle.Top;
        tbTimTheoMaKhachHang.Location = new Point(0, 251);
        tbTimTheoMaKhachHang.Name = "tbTimTheoMaKhachHang";
        tbTimTheoMaKhachHang.Size = new Size(266, 23);
        tbTimTheoMaKhachHang.TabIndex = 14;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Dock = DockStyle.Top;
        label6.Location = new Point(0, 236);
        label6.Name = "label6";
        label6.Size = new Size(137, 15);
        label6.TabIndex = 13;
        label6.Text = "Tìm theo MaKhachHang";
        // 
        // btnThemVaoDS
        // 
        btnThemVaoDS.Dock = DockStyle.Top;
        btnThemVaoDS.Location = new Point(0, 213);
        btnThemVaoDS.Name = "btnThemVaoDS";
        btnThemVaoDS.Size = new Size(266, 23);
        btnThemVaoDS.TabIndex = 12;
        btnThemVaoDS.Text = "&Thêm vào DS";
        btnThemVaoDS.UseVisualStyleBackColor = true;
        btnThemVaoDS.Click += btnThemVaoDS_Click;
        // 
        // btnThoat
        // 
        btnThoat.Dock = DockStyle.Bottom;
        btnThoat.Location = new Point(0, 427);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(266, 23);
        btnThoat.TabIndex = 11;
        btnThoat.Text = "T&hoát";
        btnThoat.UseVisualStyleBackColor = true;
        btnThoat.Click += btnThoat_Click;
        // 
        // btnThemMoi
        // 
        btnThemMoi.Dock = DockStyle.Top;
        btnThemMoi.Location = new Point(0, 190);
        btnThemMoi.Name = "btnThemMoi";
        btnThemMoi.Size = new Size(266, 23);
        btnThemMoi.TabIndex = 10;
        btnThemMoi.Text = "Thêm &Mới";
        btnThemMoi.UseVisualStyleBackColor = true;
        btnThemMoi.Click += btnThemMoi_Click;
        // 
        // cbbThoiGianGui
        // 
        cbbThoiGianGui.Dock = DockStyle.Top;
        cbbThoiGianGui.FormattingEnabled = true;
        cbbThoiGianGui.Items.AddRange(new object[] { "1", "3", "6", "12" });
        cbbThoiGianGui.Location = new Point(0, 167);
        cbbThoiGianGui.Name = "cbbThoiGianGui";
        cbbThoiGianGui.Size = new Size(266, 23);
        cbbThoiGianGui.TabIndex = 9;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Dock = DockStyle.Top;
        label5.Location = new Point(0, 152);
        label5.Name = "label5";
        label5.Size = new Size(73, 15);
        label5.TabIndex = 8;
        label5.Text = "ThoiGianGui";
        // 
        // tbSoTienGui
        // 
        tbSoTienGui.Dock = DockStyle.Top;
        tbSoTienGui.Location = new Point(0, 129);
        tbSoTienGui.Name = "tbSoTienGui";
        tbSoTienGui.Size = new Size(266, 23);
        tbSoTienGui.TabIndex = 7;
        tbSoTienGui.KeyPress += textBox1_KeyPress;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Dock = DockStyle.Top;
        label4.Location = new Point(0, 114);
        label4.Name = "label4";
        label4.Size = new Size(61, 15);
        label4.TabIndex = 6;
        label4.Text = "SoTienGui";
        // 
        // tbDiaChi
        // 
        tbDiaChi.Dock = DockStyle.Top;
        tbDiaChi.Location = new Point(0, 91);
        tbDiaChi.Name = "tbDiaChi";
        tbDiaChi.Size = new Size(266, 23);
        tbDiaChi.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Dock = DockStyle.Top;
        label3.Location = new Point(0, 76);
        label3.Name = "label3";
        label3.Size = new Size(42, 15);
        label3.TabIndex = 4;
        label3.Text = "DiaChi";
        // 
        // tbHoTen
        // 
        tbHoTen.Dock = DockStyle.Top;
        tbHoTen.Location = new Point(0, 53);
        tbHoTen.Name = "tbHoTen";
        tbHoTen.Size = new Size(266, 23);
        tbHoTen.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Top;
        label2.Location = new Point(0, 38);
        label2.Name = "label2";
        label2.Size = new Size(42, 15);
        label2.TabIndex = 2;
        label2.Text = "HoTen";
        // 
        // tbMaKhachHang
        // 
        tbMaKhachHang.Dock = DockStyle.Top;
        tbMaKhachHang.Location = new Point(0, 15);
        tbMaKhachHang.Name = "tbMaKhachHang";
        tbMaKhachHang.Size = new Size(266, 23);
        tbMaKhachHang.TabIndex = 1;
        tbMaKhachHang.KeyPress += tbMaKhachHang_KeyPress;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(86, 15);
        label1.TabIndex = 0;
        label1.Text = "MaKhachHang";
        // 
        // dgvKhachHang
        // 
        dgvKhachHang.BackgroundColor = SystemColors.Control;
        dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvKhachHang.Dock = DockStyle.Fill;
        dgvKhachHang.Location = new Point(0, 0);
        dgvKhachHang.Name = "dgvKhachHang";
        dgvKhachHang.Size = new Size(530, 450);
        dgvKhachHang.TabIndex = 0;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(splitContainer1);
        Name = "MainForm";
        Text = "MainForm";
        Load += MainForm_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        ((ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((ISupportInitialize)dgvKhachHang).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private DataGridView dgvKhachHang;
    private ComboBox cbbThoiGianGui;
    private Label label5;
    private TextBox tbSoTienGui;
    private Label label4;
    private TextBox tbDiaChi;
    private Label label3;
    private TextBox tbHoTen;
    private Label label2;
    private TextBox tbMaKhachHang;
    private Label label1;
    private Button btnTimKiem;
    private TextBox tbTimTheoMaKhachHang;
    private Label label6;
    private Button btnThemVaoDS;
    private Button btnThoat;
    private Button btnThemMoi;
    private DateTimePicker dtpNgayGui;
    private Label label8;
}