using System;
using System.ComponentModel.DataAnnotations;

namespace DugunApp.Models
{
	public class OrderViewModel
	{
		[Required(ErrorMessage = "Düğün adı zorunludur")]
		[StringLength(100, ErrorMessage = "Düğün adı en fazla 100 karakter olabilir")]
		public string WeddingName { get; set; } = string.Empty;

		[Required(ErrorMessage = "Düğün tarihi zorunludur")]
		[DataType(DataType.Date)]
		public DateTime? WeddingDate { get; set; }

		[Required(ErrorMessage = "Düğün yeri zorunludur")]
		[StringLength(200, ErrorMessage = "Düğün yeri en fazla 200 karakter olabilir")]
		public string WeddingLocation { get; set; } = string.Empty;

		[Required(ErrorMessage = "Paket seçimi zorunludur")]
		[RegularExpression("^(basic|standard|pro)$", ErrorMessage = "Geçerli bir paket seçiniz")] 
		public string Package { get; set; } = string.Empty;

		[Required(ErrorMessage = "E-posta adresi zorunludur")]
		[EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Telefon numarası zorunludur")]
		[Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz")]
		public string Phone { get; set; } = string.Empty;

		[StringLength(1000, ErrorMessage = "En fazla 1000 karakter girebilirsiniz")]
		public string? Notes { get; set; }

		[Range(typeof(bool), "true", "true", ErrorMessage = "Gizlilik Politikası ve Kullanım Şartlarını kabul etmelisiniz")]
		public bool Terms { get; set; }
	}
}

