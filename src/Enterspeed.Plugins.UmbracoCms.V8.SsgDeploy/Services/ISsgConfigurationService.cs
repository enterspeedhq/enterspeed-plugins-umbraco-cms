using Enterspeed.Umbraco.Demo.Web.Core.Models;

namespace Enterspeed.Umbraco.Demo.Web.Core.Services
{
    public interface ISsgConfigurationService
    {
        SsgConfiguration Get();
        void Save(SsgConfiguration configuration);
    }
}