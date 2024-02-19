using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Soyad alanını boş bıraktınız.")]
        public string? Name { get; set; } // string, null

        [Required(ErrorMessage = "Telefon alanını boş bıraktınız.")]
        [Phone(ErrorMessage = "Telefon numarasını hatalı girdiniz.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "E-posta alanını boş bıraktınız.")]
        [EmailAddress(ErrorMessage = "E-posta formatını yanlış girdiniz.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım Durumu için seçim yapmadınız.")]
        public bool? WillAttend { get; set; } // true, false, null
    }
}