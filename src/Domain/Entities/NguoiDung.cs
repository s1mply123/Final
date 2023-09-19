using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Domain.Entities;
public class NguoiDung : BaseAuditableEntity
{
    public string? HoTen { get; set; }
    public int Tuoi { get; set; }
    public int GioiTinh { get; set; }
    public string? Email { get; set; }
    public int SoDienThoai { get ; set; }  
}
