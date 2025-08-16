using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace DugunApp.Models
{
	public class UploadViewModel
	{
		[Required(ErrorMessage = "Adınız zorunludur")]
		[StringLength(100, ErrorMessage = "Ad en fazla 100 karakter olabilir")]
		public string GuestName { get; set; } = string.Empty;

		[StringLength(500, ErrorMessage = "Mesaj en fazla 500 karakter olabilir")]
		public string? GuestMessage { get; set; }

		[Required(ErrorMessage = "En az bir dosya seçiniz")]
		public IFormFileCollection? Files { get; set; }

		[Range(typeof(bool), "true", "true", ErrorMessage = "İzin vermelisiniz")]
		public bool Consent { get; set; }
	}
}

