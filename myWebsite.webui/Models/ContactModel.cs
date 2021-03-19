using System.ComponentModel.DataAnnotations;

namespace myWebsite.webui.Models
{
    public class ContactModel
    {
        
        public int Id { get; set; }
        [Display(Name="Ad",Prompt = "Adınızı giriniz")]
        [Required(ErrorMessage = "Lütfen adınızı yazınız")]
        public string Name { get; set; }
        [Display(Name="Soyad",Prompt = "Soyadınızı giriniz")]
        [Required(ErrorMessage = "Lütfen soyadınızı yazınız")] 
        public string Surname { get; set; }
        [Display(Name="E-Mail",Prompt = "xyz@mail.com")]
        [Required(ErrorMessage = "Lütfen mail adresinizi yazınız")]
        [DataType(DataType.EmailAddress,ErrorMessage = "E-Mail türü uyuşmuyor")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen iletişime geçmek istediğiniz konuyu yazınız")]
        public string Subject { get; set; }
    }
}