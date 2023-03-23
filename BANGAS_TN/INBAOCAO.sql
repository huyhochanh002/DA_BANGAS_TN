SELECT HoaDon.Mahd,HoaDon.Makh, KhachHang.Tenkh, KhachHang.Diachi, KhachHang.Dienthoai, KhachHang.Ghichu, CTHD.Tratien, CTHD.Notien, CTHD.Travo, CTHD.Novo, CTHD.Tongtien
from HoaDon, KhachHang, CTHD
where HoaDon.Makh=KhachHang.Makh and HoaDon.Mahd=CTHD.Mahd