using Core.Repositories;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppSort.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityServices _cityServices;

        public CityController(ICityServices cityServices)
        {
            _cityServices = cityServices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortNumber"></param>
        /// <returns>Reorder the strings within an array</returns>

        [HttpPost]
        [Route("SortCity")]
        public ActionResult SortCity(int[] sortNumber)
        {
            var citiesSort = _cityServices.SortCities(sortNumber);

            return Ok(citiesSort);
        }
    }
}
