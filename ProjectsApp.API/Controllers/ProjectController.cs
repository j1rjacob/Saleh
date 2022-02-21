using System;
using System.Security.Claims;
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
    
    [HttpPost("{id}")]
    public async Task<IActionResult> DeleteProject(int id)
    {           
        var projectToDel = await _repo.GetProject(id);
        _repo.Delete<Project>(projectToDel);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to delete project");        
    }

    [HttpPost("delinvoice")]
    public async Task<IActionResult> DeleteInvoice(ExpenseToDelDto expenseToDelDto)
    {           
        var invoiceToDel = await _repo.GetInvoice(expenseToDelDto.ProjectId,expenseToDelDto.Id);
        _repo.Delete<Invoice>(invoiceToDel);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to delete invoice");        
    }

    [HttpPost("delexecution")]
    public async Task<IActionResult> DeleteExecution(ExpenseToDelDto expenseToDelDto)
    {           
        var exeToDel = await _repo.GetExecution(expenseToDelDto.ProjectId,expenseToDelDto.Id);
        _repo.Delete<Execution>(exeToDel);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to delete execution");        
    }

    [HttpPost("delrisk")]
    public async Task<IActionResult> DeleteRisk(ExpenseToDelDto expenseToDelDto)
    {           
        var riskToDel = await _repo.GetRisk(expenseToDelDto.ProjectId,expenseToDelDto.Id);
        _repo.Delete<Risk>(riskToDel);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to delete risk");        
    }

    [HttpPost("delexpense")]
    public async Task<IActionResult> DeleteExpense(ExpenseToDelDto expenseToDelDto)
    {           
        var expenseToDel = await _repo.GetExpense(expenseToDelDto.ProjectId,expenseToDelDto.Id);
        _repo.Delete<Expense>(expenseToDel);
        
        if (await _repo.SaveAll())
            return Ok();

        return BadRequest("Failed to delete expense");        
    }   

    [HttpPut("updexpense")]
    public async Task<IActionResult> UpdateExpense(ExpenseToUpdDto expenseToUpdDto)
    {           
        var expenseToUpd = await _repo.GetExpense(expenseToUpdDto.ProjectId,expenseToUpdDto.Id);
        _mapper.Map(expenseToUpdDto, expenseToUpd);

        if (await _repo.SaveAll())
            return NoContent();

        throw new Exception($"Updating expense failed on save");       
    } 

    [HttpPut("updrisk")]
    public async Task<IActionResult> UpdateRisk(RiskToUpdDto riskToUpdDto)
    {           
        var riskToUpd = await _repo.GetRisk(riskToUpdDto.ProjectId,riskToUpdDto.Id);
        _mapper.Map(riskToUpdDto, riskToUpd);

        if (await _repo.SaveAll())
            return NoContent();

        throw new Exception($"Updating risk failed on save");       
    }
    
    [HttpPut("updexecution")]
    public async Task<IActionResult> UpdateExecution(ExecutionToUpdDto exeToUpdDto)
    {           
        var exeToUpd = await _repo.GetExecution(exeToUpdDto.ProjectId,exeToUpdDto.Id);
        _mapper.Map(exeToUpdDto, exeToUpd);

        if (await _repo.SaveAll())
            return NoContent();

        throw new Exception($"Updating execution failed on save");       
    }
    
    [HttpPut("updinvoice")]
    public async Task<IActionResult> UpdateInvoice(InvoiceToUpdDto invToUpdDto)
    {           
        var invToUpd = await _repo.GetInvoice(invToUpdDto.ProjectId,invToUpdDto.Id);
        _mapper.Map(invToUpdDto, invToUpd);

        if (await _repo.SaveAll())
            return NoContent();

        throw new Exception($"Updating invoice failed on save");       
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateProject(ProjectToUpdDto prjToUpdDto)
    {           
        var prjToUpd = await _repo.GetProject(prjToUpdDto.Id);
        _mapper.Map(prjToUpdDto, prjToUpd);

        if (await _repo.SaveAll())
            return NoContent();

        throw new Exception($"Updating project failed on save");       
    }
}