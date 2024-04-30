using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels
{
	public class RegisterVM
	{
		[Required]
		public string? Name { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string? Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string? Password { get; set; }

		[Compare("Password", ErrorMessage = "Passwords don't match.")]
		public string? ConfirmPassword { get; set; }


		//çok satırlı metin olacagını belırtmek ıcın
		[DataType(DataType.MultilineText)]
		public string? Adress {  get; set; }

	}
}
