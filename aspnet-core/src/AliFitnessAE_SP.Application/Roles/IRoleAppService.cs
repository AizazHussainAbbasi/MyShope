using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AliFitnessAE_SP.Roles.Dto;

namespace AliFitnessAE_SP.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedRoleResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();

        Task<GetRoleForEditOutput> GetRoleForEdit(EntityDto input);

        Task<ListResultDto<RoleListDto>> GetRolesAsync(GetRolesInput input);
    }
}
