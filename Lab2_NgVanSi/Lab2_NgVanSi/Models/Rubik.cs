using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab2_NgVanSi.Models
{
    public class Rubik
    {
        public int Id { get; set; }
        [Display(Name = "Tên: ")]
        [Required(ErrorMessage = "Nhập tên của Rubik")]
        public string Ten { get; set; }

        [Display(Name = "Loại: ")]
        [Required(ErrorMessage = "Nhập loại của Rubik")]
        public string Loai { get; set; }
        [Display(Name = "Mô tả: ")]
        [Required(ErrorMessage = "Nhập mô tả của Rubik")]
        public string MoTa { get; set; }

        [Display(Name = "Hãng: ")]
        [Required(ErrorMessage = "Nhập hãng của Rubik")]
        public string Hang { get; set; }
        [Display(Name = "Giá: ")]
        [Required(ErrorMessage = "Nhập giá của Rubik")]
        public int Gia { get; set; }

        [Display(Name = "Hình: ")]
        [Required(ErrorMessage = "Bạn phải dẫn hình của Rubik")]
        public string Hinh { get; set; }

        [Display(Name = "Còn lại: ")]
        [Required(ErrorMessage = "Nhập số lượng của Rubik")]
        public int SoLgTon { get; set; }
    }
}