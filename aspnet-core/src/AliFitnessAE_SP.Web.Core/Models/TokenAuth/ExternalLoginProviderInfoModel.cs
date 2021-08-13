using Abp.AutoMapper;
using AliFitnessAE_SP.Authentication.External;

namespace AliFitnessAE_SP.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
