
using TestDockerK8s.Models.DatabaseModels;

namespace TestDockerK8s.Helpers
{
    public interface IDataAccess
    {
        List<Clients> GetClientNames();
    }
}