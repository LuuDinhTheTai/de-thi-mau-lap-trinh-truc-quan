using de_thi_thu_lap_trinh_truc_quan.entity;
using de_thi_thu_lap_trinh_truc_quan.service;

namespace de_thi_thu_lap_trinh_truc_quan;

public partial class MainForm : Form
{
    private readonly KhachHangService _khachHangService = new KhachHangService();

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        List<KhachHang> danhSachKhachHang = _khachHangService.List();
        LoaddgvKhachHang(danhSachKhachHang);
    }

    private void LoaddgvKhachHang(List<KhachHang> dataSource)
    {
        dgvKhachHang.DataSource = null;
        dgvKhachHang.DataSource = dataSource;
    }

    private void tbMaKhachHang_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void btnThemMoi_Click(object sender, EventArgs e)
    {
        tbMaKhachHang.Clear();
        tbHoTen.Clear();
        tbDiaChi.Clear();
        tbSoTienGui.Clear();
        cbbThoiGianGui.SelectedIndex = -1;
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox
            .Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void btnThemVaoDS_Click(object sender, EventArgs e)
    {
        string maKhachHang = tbMaKhachHang.Text;
        string hoTen = tbHoTen.Text;
        string diaChi = tbDiaChi.Text;
        DateTime ngayGui = dtpNgayGui.Value;

        ValidateMaKhachHang(maKhachHang);
        ValidateHoTen(hoTen);
        ValidateDiaChi(diaChi);
        ValidateNgayGui(ngayGui);

        int thoiGianGui = int.Parse(cbbThoiGianGui.SelectedItem.ToString() ?? "0");
        double soTienGui = double.Parse(tbSoTienGui.Text);
        double laiSuatGui = thoiGianGui switch
        {
            1 => 0.03,
            3 => 0.45,
            6 => 0.6,
            12 => 0.7,
            _ => 0.0
        };
        double soTienLai = soTienGui * laiSuatGui;

        KhachHang khachHang = new KhachHang
        {
            MaKhachHang = int.Parse(maKhachHang),
            HoTen = hoTen,
            DiaChi = diaChi,
            ThoiGianGui = thoiGianGui,
            SoTienGui = soTienGui,
            LaiSuatGui = laiSuatGui,
            SoTienLai = soTienLai,
            NgayGui = ngayGui
        };

        _khachHangService.Create(khachHang);

        List<KhachHang> danhSachKhachHang = _khachHangService.List();
        LoaddgvKhachHang(danhSachKhachHang);
    }

    private void ValidateMaKhachHang(string maKhachHang)
    {
        foreach (char c in maKhachHang.ToCharArray())
        {
            if (!char.IsDigit(c) || c == ' ')
            {
                MessageBox.Show("Mã khách hàng chỉ được chứa chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

    private void ValidateHoTen(string hoTen)
    {
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Họ tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void ValidateDiaChi(string diaChi)
    {
        if (string.IsNullOrWhiteSpace(diaChi))
        {
            MessageBox.Show("Địa chỉ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void ValidateNgayGui(DateTime ngayGui)
    {

    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
        string maKhachHang = tbTimTheoMaKhachHang.Text;
        List<KhachHang> danhSachKhachHang = _khachHangService.FindByMaKhachHang(int.Parse(maKhachHang));

        LoaddgvKhachHang(danhSachKhachHang);
    }
}