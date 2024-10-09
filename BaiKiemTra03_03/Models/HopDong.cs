using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_03.Models
{
    public class HopDong
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "ContractId is required.")]
        public int ContractId { get; set; }
        [Required(ErrorMessage = "Không được để trống tên hợp đồng!")]
        [Display(Name = "Tên hợp đồng")]
        public string? ContractName { get; set; }

        [Required(ErrorMessage = "Không đúng định dạng ngày!")]
        [Display(Name = "Ngày ký kết")]
        public DateTime SigningDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Không được để trống khách hàng!")]
        [Display(Name = "Khách hàng")]
        public string? Customer { get; set; }

        [Required(ErrorMessage = "Giá trị hợp đồng không hợp lệ!")]
        [Display(Name = "Giá trị hợp đồng")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá trị hợp đồng phải lớn hơn hoặc bằng 0!")]
        public decimal ContractValue { get; set; }

    }
}
