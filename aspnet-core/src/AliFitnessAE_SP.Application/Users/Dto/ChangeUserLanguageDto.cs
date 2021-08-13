using System.ComponentModel.DataAnnotations;

namespace AliFitnessAE_SP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}