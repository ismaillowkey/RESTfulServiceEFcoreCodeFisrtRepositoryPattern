using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RESTfulServiceEFcoreCodeFisrtRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomDataController : ControllerBase
    {
        private IRepositoryWrapper _repositoryWrapper;

        public RandomDataController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<RandomData>>> GetAll()
        {
            var res = await _repositoryWrapper.RandomData.FindAll().ToListAsync();
            return res;
        }
    }
}
