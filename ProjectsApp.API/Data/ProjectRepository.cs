using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectsApp.API.Models;

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

        public async Task<Project> GetProject(int id)
        {
            return await _context.Projects
                                .FirstOrDefaultAsync(x => x.Id == id); 
        }

        public async Task<Expense> GetExpense(int projectId, int expenseId)
        {
            return await _context.Expenses
                                .FirstOrDefaultAsync(x => x.Id == expenseId && x.ProjectId == projectId); 
        }

         public async Task<Risk> GetRisk(int projectId, int riskId)
        {
            return await _context.Risks
                                .FirstOrDefaultAsync(x => x.Id == riskId && x.ProjectId == projectId); 
        }

        public async Task<Execution> GetExecution(int projectId, int exeId)
        {
            return await _context.Executions
                                .FirstOrDefaultAsync(x => x.Id == exeId && x.ProjectId == projectId); 
        }

        public async Task<Invoice> GetInvoice(int projectId, int invoiceId)
        {
            return await _context.Invoices
                                .FirstOrDefaultAsync(x => x.Id == invoiceId && x.ProjectId == projectId); 
        }

    }
}