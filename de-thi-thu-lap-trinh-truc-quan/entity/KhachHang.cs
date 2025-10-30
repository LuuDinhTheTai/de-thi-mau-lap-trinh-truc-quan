namespace de_thi_thu_lap_trinh_truc_quan.entity;

public class KhachHang
{
    public int MaKhachHang { get; set; }
    
    public String HoTen { get; set; }
    
    public String DiaChi { get; set; }
    
    public int ThoiGianGui { get; set; } // 1 - 3 - 6 - 12
    
    public double SoTienGui { get; set; }
    
    public double LaiSuatGui { get; set; }

    public double SoTienLai { get; set; }

    public DateTime NgayGui { get; set; }
}