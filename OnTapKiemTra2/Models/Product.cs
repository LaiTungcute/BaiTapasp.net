namespace OnTapKiemTra2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [DisplayName("Mã hàng")]
        public int Pid { get; set; }

        [Required(ErrorMessage = "Mã nhóm không được để trống")]
        [DisplayName("Mã nhóm")]
        public int Categoryid { get; set; }

        [Required(ErrorMessage ="Tên hàng không được bỏ trống")]
        [StringLength(250)]
        [DisplayName("Tên hàng")]
        public string ProdName { get; set; }

        [StringLength(50)]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Không thể thiếu ảnh")]
        [StringLength(550)]
        [DisplayName("Ảnh")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Giá tiền không được để trống")]
        [DisplayName("Giá tiền")]
        public decimal Price { get; set; }
    }
}
