using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uow_EfCore_App.Interface;
using Uow_EfCore_Domain.Dto;
using Uow_EfCore_Domain.Entities;

namespace Uow_EfCore_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService Professor;

        public ProfessorController(IProfessorService _professor)
        {
            Professor = _professor;
        }
        [HttpPost("Create")]
        public async Task<ActionResult<ProfessorDto>> Insert([FromBody] ProfessorDto dto)
        {
            try
            {
                
                return Ok(await Professor.Create(dto));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}