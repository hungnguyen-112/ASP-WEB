using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra02.Models
{
    public class LopHoc
    {
        [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Không được để trống tên lớp học!")]
    [Display(Name = "Tên lớp học")]
    public string TenLopHoc { get; set; }

    [Required(ErrorMessage = "Năm nhập học không được để trống!")]
    [Display(Name = "Năm nhập học")]
    [Range(1900, 2100, ErrorMessage = "Năm nhập học không hợp lệ!")]
    public int NamNhapHoc { get; set; }

    [Required(ErrorMessage = "Năm ra trường không được để trống!")]
    [Display(Name = "Năm ra trường")]
    [Range(1900, 2100, ErrorMessage = "Năm ra trường không hợp lệ!")]
    public int NamRaTruong { get; set; }

    [Required(ErrorMessage = "Số lượng sinh viên không được để trống!")]
    [Display(Name = "Số lượng sinh viên")]
    [Range(1, 1000, ErrorMessage = "Số lượng sinh viên không hợp lệ!")]
    public int SoLuongSinhVien { get; set; }
    }

}
