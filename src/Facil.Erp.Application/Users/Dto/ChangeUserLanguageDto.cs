using System.ComponentModel.DataAnnotations;

namespace Facil.Erp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}