using System;
using System.Threading.Tasks;
using clen_code_project.Application.Common.Models;
using clen_code_project.Application.Common.Security;
using clen_code_project.Application.Students.Queries.GetStudentsWithPagination;
using clen_code_project.Application.Students.Commands.CreateStudent;
using clen_code_project.Application.Students.Commands.UpdateStudent;
using clen_code_project.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using clen_code_project.Application.Students.Commands.DeleteStudent;

namespace clen_code_project.WebUI.Controllers
{
    [Authorize]
    public class StudentsController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<PaginatedList<Student>>> GetStudentsWithPagination([FromQuery] GetStudentsWithPaginationQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateStudentCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateStudentCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteStudentCommand { Id = id });

            return NoContent();
        }
    }
}
