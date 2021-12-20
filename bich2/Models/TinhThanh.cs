using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bich2.Models
{
    [Table("TinhThanh")]
    public class TinhThanh
    {
        [Key]
        [Display(Name ="Mã Tỉnh Thành")]
        public int MaTinhThanh { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên Tỉnh Thành")]
        public string TenTinhThanh { get; set; }
        public ICollection<NhanVien> NhanViens { get; set; }

    }
}