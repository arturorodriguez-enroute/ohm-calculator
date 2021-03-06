using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OhmCalculatorApi.Abstractions;
using OhmCalculatorApi.Models;

namespace OhmCalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistorDefaultsController : ControllerBase
    {
        private readonly IOhmCalculatorUnitOfWork unitOfWork;

        public ResistorDefaultsController(IOhmCalculatorUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Gets the color bands configuration (default position and color) for the resistor displayed in the Front End application.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IEnumerable<ResistorDefault> Get()
        {
            return unitOfWork.ResistorDefaultsRepository.Get(includeProperties: "Color", orderBy: (queryable) => queryable.OrderBy(element => element.Id));
        }
    }
}