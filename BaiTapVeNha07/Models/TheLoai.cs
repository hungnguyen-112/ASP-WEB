using System.ComponentModel.DataAnnotations;

namespace BaiTap07.Models
{
    public class TheLoai
    {
    [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Không được để trống tên thể loại!")]
        [Display(Name="Thể Loại")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Không định dạng đúng ngày!")]
        [Display(Name = "Ngày Tạo")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
