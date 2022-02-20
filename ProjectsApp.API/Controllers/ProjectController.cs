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


}