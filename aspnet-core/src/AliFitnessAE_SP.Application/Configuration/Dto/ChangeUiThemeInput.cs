using System.ComponentModel.DataAnnotations;

namespace AliFitnessAE_SP.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
