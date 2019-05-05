﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    class DonHangViewModel
    {
    }

    public partial class ChiTietHangHoa
    {
        public string TenHang
        {
            get { return ChiTietDonHang.TenHangHoa; }
        }

        public DateTime NgayLap
        {
            get { return ChiTietDonHang.DonHang.NgayLap; }
        }

        public long DonGia
        {
            get { return ChiTietDonHang.DonGia; }
        }

        public long ThanhTien
        {
            get
            {
                var thue = DonGia * ChiTietDonHang.DonHang.Thue / 100f;
                var chietKhau = DonGia * ChiTietDonHang.DonHang.ChietKhau / 100f;
                return (long)(DonGia + thue - chietKhau);
            }
        }

        public string LoaiPhieu
        {
            get
            {
                if (ChiTietDonHang.DonHang.LoaiDonHang == Define.LoaiDonHangEnum.NhapKho.ToString())
                {
                    return "Phiếu Nhập Kho";
                }
                return "Phiếu Xuất Kho";
            }
        }

        public string TenKhach
        {
            get { return ChiTietDonHang.DonHang.TenKhachHang; }
        }

        public string DiaChi
        {
            get { return ChiTietDonHang.DonHang.DiaChi; }
        }

        public string DienThoai
        {
            get { return ChiTietDonHang.DonHang.Dienthoai; }
        }

        public string LoaiDonHang
        {
            get { return ChiTietDonHang.DonHang.LoaiDonHang; }
        }

        public long DonHangId
        {
            get { return ChiTietDonHang.DonHangId; }
        }
    }

    public partial class ChiTietDonHang
    {
        public long ThanhTien
        {
            get
            {
                var soLuong = 0L;
                if (SoLuong != null)
                {
                    soLuong = (long)SoLuong;
                }
                var donGia = 0L;
                if (DonGia != null)
                {
                    donGia = (long)DonGia;
                }
                return soLuong * donGia;
            }
        }

        public long NgaySort { get; set; }

        public long DoanhThuNhap { get; set; }

        public long DoanhThuXuat { get; set; }
        public long LoiNhuan
        {
            get { return DoanhThuXuat - DoanhThuNhap; }
        }

        public long SoLuongNhap { get; set; }

        public long SoLuongXuat { get; set; }

        public string TenHangHoa
        {
            get { return KhoHang.TenHang; }
        }

        public DateTime Ngay
        {
            get { return DonHang.NgayLap; }
        }

        public string Thang
        {
            get { return DonHang.NgayLap.Month.ToString(); }
        }

        public string Nam
        {
            get { return DonHang.NgayLap.Year.ToString(); }
        }

        public string Quy
        {
            get { return TimeHelper.TimeStampToQuarter(DonHang.NgayLap); }
        }

        public long SoLuongTon
        {
            get { return KhoHang.SoLuong; }
        }
        public List<ChiTietHangHoa> ListChiTietHangHoa { get; set; }
    }

    public partial class DonHang
    {
        public string TenKhachHang
        {
            get
            {
                if (KhachHang != null)
                {
                    if (KhachHang.LoaiKhachHang == Define.LoaiKhachHangEnum.KhachLe.ToString())
                    {
                        return Ten;
                    }
                    else
                    {
                        return KhachHang.Ten;
                    }
                }
                return string.Empty;
            }
        }

        public string NgayLapReport
        {
            get { return string.Format("Ngày {0} Tháng {1} Năm {2}  {3}", NgayLap.Day, NgayLap.Month, NgayLap.Year, NgayLap.TimeOfDay); }
        }
    }
}
