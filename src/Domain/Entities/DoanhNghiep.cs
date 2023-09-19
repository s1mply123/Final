using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Domain.Entities;
public class DoanhNghiep : BaseAuditableEntity
{
    public string? TenDoanhNghiep { get; set; }
    public string? TenChuDoanhNghiep { get; set; }
    public string? DiaChi { get; set; }
    public int SoDienThoai { get; set; }
    public int NamThanhLap { get; set; }
    public int NamThamGia { get; set; }
}
