namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.SsgServices
{
    public interface ISsgService
    {
        string Alias { get; }
        string Name { get; }
        string ConfigurationView { get; }
        string ContentView { get; }
    }
}