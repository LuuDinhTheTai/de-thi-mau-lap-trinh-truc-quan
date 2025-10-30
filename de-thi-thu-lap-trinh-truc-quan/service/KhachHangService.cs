using de_thi_thu_lap_trinh_truc_quan.entity;
using Microsoft.Data.SqlClient;

namespace de_thi_thu_lap_trinh_truc_quan.service;

public class KhachHangService
{
    private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLKhachHang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

    public List<KhachHang> List()
    {
        var list = new List<KhachHang>();
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = new SqlCommand("SELECT * FROM KhachHang", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new KhachHang
                    {
                        MaKhachHang = (int)reader["MaKhachHang"],
                        HoTen = (string)reader["HoTen"],
                        DiaChi = (string)reader["DiaChi"],
                        ThoiGianGui = (int)reader["ThoiGianGui"],
                        SoTienGui = (double)reader["SoTienGui"],
                        LaiSuatGui = (double)reader["LaiSuatGui"],
                        SoTienLai = (double)reader["SoTienLai"],
                        NgayGui = (DateTime)reader["NgayGui"]
                    });
                }
            }
        }

        return list;
    }

    public void Create(KhachHang khachHang)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var sql = @"INSERT INTO KhachHang
                        (MaKhachHang, HoTen, DiaChi, ThoiGianGui, SoTienGui, LaiSuatGui, SoTienLai, NgayGui)
                        VALUES (@MaKhachHang, @HoTen, @DiaChi, @ThoiGianGui, @SoTienGui, @LaiSuatGui, @SoTienLai, @NgayGui)";
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaKhachHang", khachHang.MaKhachHang);
                command.Parameters.AddWithValue("@HoTen", khachHang.HoTen ?? string.Empty);
                command.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi ?? string.Empty);
                command.Parameters.AddWithValue("@ThoiGianGui", khachHang.ThoiGianGui);
                command.Parameters.AddWithValue("@SoTienGui", khachHang.SoTienGui);
                command.Parameters.AddWithValue("@LaiSuatGui", khachHang.LaiSuatGui);
                command.Parameters.AddWithValue("@SoTienLai", khachHang.SoTienLai);
                command.Parameters.AddWithValue("@NgayGui", khachHang.NgayGui);

                command.ExecuteNonQuery();
            }
        }
    }

    public List<KhachHang> FindByMaKhachHang(int maKhachHang)
    {
        List<KhachHang> list = new List<KhachHang>();

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var sql = "select * from KhachHang where MaKhachHang = @MaKhachHang";
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHang
                        {
                            MaKhachHang = (int)reader["MaKhachHang"],
                            HoTen = (string)reader["HoTen"],
                            DiaChi = (string)reader["DiaChi"],
                            ThoiGianGui = (int)reader["ThoiGianGui"],
                            SoTienGui = (double)reader["SoTienGui"],
                            LaiSuatGui = (double)reader["LaiSuatGui"],
                            SoTienLai = (double)reader["SoTienLai"],
                            NgayGui = (DateTime)reader["NgayGui"]
                        });
                    }
                }
            }
        }
        return list;
    }
}