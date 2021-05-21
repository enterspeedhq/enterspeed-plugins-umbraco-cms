using Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Models;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Services
{
    public interface ISsgConfigurationService
    {
        SsgConfiguration Get();
        void Save(SsgConfiguration configuration);
    }
}