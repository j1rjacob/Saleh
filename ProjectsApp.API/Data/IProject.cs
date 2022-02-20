using System.Threading.Tasks;

namespace ProjectsApp.API.Data
{
    public interface IProject
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<bool> ProjectsExist(string projectName);
    }
}