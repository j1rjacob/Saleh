using System.Threading.Tasks;
using ProjectsApp.API.Models;

namespace ProjectsApp.API.Data
{
    public interface IProject
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<bool> ProjectsExist(string projectName);
        Task<Project> GetProject(int id);
        Task<Expense> GetExpense(int projectId, int expenseId);
        Task<Risk> GetRisk(int projectId, int riskId);
        Task<Execution> GetExecution(int projectId, int exeId);
        Task<Invoice> GetInvoice(int projectId, int invoiceId);
    }
}