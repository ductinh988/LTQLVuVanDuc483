using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050483.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [Display(Name = "ID mã sản phẩm")]
        [StringLength(20)]
        public string MaSanPham { get; set; }
        [Display(Name = "Tên Nhà Cung Cấp")]

        [StringLength(50)]

        public string TenSanPham { get; set; }
        [Display(Name = "Mã Nhà cung cấp")]
        public int Manhacungcap { get; set; }
        [ForeignKey("Manhacungcap")]
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}