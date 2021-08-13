using Abp.Application.Services.Dto;

namespace AliFitnessAE_SP.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

