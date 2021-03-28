using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace clen_code_project.presentation.Controllers
{
    public class StudentsController : ControllerBase
    {

        [ApiController]

        public async Task<ActionResult> GetStudentsWithPagination() {
            return true;
        }


    }
}
