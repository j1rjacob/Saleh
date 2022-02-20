using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectsApp.API.Data
{
    public class ProjectRepository : IProject
    {
        private readonly DataContext _context;
        public ProjectRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ProjectsExist(string projectName) 
        {
            if(await _context.Projects.AnyAsync(x => x.ProjectName == projectName))
                return true;

            return false;
        }
    }
}