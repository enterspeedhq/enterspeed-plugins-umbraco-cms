namespace Enterspeed.Umbraco.Demo.Web.Core.SsgServices
{
    public interface ISsgService
    {
        string Alias { get; }
        string Name { get; }
        string ConfigurationView { get; }
        string ContentView { get; }
    }
}