using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestWeb_LeVanThanhDat.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]

        [Required(ErrorMessage = "Chưa nhập tên sách")]
        public string Title { get; set; }
      
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Tên tác giả từ 5 đến 10 ký tự")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Gía bìa không hợp lệ")]
        public decimal Price { get; set; }
        [Required (ErrorMessage ="Số lương không hợp lệ")]
        public int Quantity { get; set; }
    }
}
