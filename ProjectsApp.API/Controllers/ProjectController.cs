using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectsApp.API.Data;
using ProjectsApp.API.Models;

[Route("api/[controller]")]
[ApiController]
public class ProjectController : ControllerBase 
{
    private readonly IProject _repo;
    private readonly IMapper _mapper;
    public ProjectController(IProject repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpPost("addproject")]
    public async Task<IActionResult> AddProject(ProjectToAddDto projectToAddDto)
    { 
        if (await _repo.ProjectsExist(projectToAddDto.ProjectName))
            return BadRequest("Project Name already exists");

        var projectToAdd = _mapper.Map<Project>(projectToAddDto);

        _repo.Add<Project>(projectToAdd);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to add project");        
    }

    [HttpPost("addinvoice")]
    public async Task<IActionResult> AddInvoice(InvoiceToAddDto invoiceToAddDto)
    { 
        var invoiceToAdd = _mapper.Map<Invoice>(invoiceToAddDto);

        _repo.Add<Invoice>(invoiceToAdd);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to add invoice");        
    }
    
    [HttpPost("addexecution")]
    public async Task<IActionResult> AddExecution(ExecutionToAddDto executionToAddDto)
    { 
        var executionToAdd = _mapper.Map<Execution>(executionToAddDto);

        _repo.Add<Execution>(executionToAdd);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to add execution");        
    }

    [HttpPost("addrisk")]
    public async Task<IActionResult> AddRisk(RiskToAddDto riskToAddDto)
    { 
        var riskToAdd = _mapper.Map<Risk>(riskToAddDto);

        _repo.Add<Risk>(riskToAdd);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to add risk");        
    }

    [HttpPost("addexpense")]
    public async Task<IActionResult> AddExpense(ExpenseToAddDto expenseToAddDto)
    { 
        var expenseToAdd = _mapper.Map<Expense>(expenseToAddDto);

        _repo.Add<Expense>(expenseToAdd);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to add expense");        
    }

}