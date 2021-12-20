using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bich2.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        [Display(Name = "Mã Nhân viên")]
        public int MaNhanVien { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên Nhân viên")]
        public string TenNhanVien { get; set; }
        [Display(Name = "Mã Tỉnh Thành")]
        public int MaTinhThanh { get; set; }
        [ForeignKey("MaTinhThanh")]
        public virtual TinhThanh TinhThanh { get; set; }
    }
}