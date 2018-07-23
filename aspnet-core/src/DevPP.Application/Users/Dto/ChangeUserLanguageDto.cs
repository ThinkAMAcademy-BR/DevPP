using System.ComponentModel.DataAnnotations;

namespace DevPP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}