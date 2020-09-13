using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TradeMicroservices.Data;
using TradeMicroservices.Domain.Models.Currencies;
using TradeMicroservices.Services;

namespace TradeMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private ICountries _countries;

        public CountriesController(ICountries countries)
        {
            _countries = countries;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await _countries.GetCountries();
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(int id)
        {
            var country = await _countries.GetCountry(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }

        // PUT: api/Countries
        [HttpPut]
        public async Task<ActionResult<Country>> PutCountry(Country country)
        {         
            var update = await _countries.UpdateCountry(country);
            return update;
        }

        // POST: api/Countries
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(Country country)
        {
            return await _countries.AddCountry(country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Country>> DeleteCountry(int id)
        {
            var country = await _countries.DeleteCountry(id);
            if (country == null)
            {
                return NotFound();
            }

            return country;
        }
    }
}
