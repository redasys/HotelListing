using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListingApi.Data;
using HotelListingApi.Models.Country;
using AutoMapper;
using HotelListingApi.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace HotelListingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CountriesController : ControllerBase
    {
        private readonly ICountriesRepository _repo;
        private readonly IMapper _mapper;

        public CountriesController(ICountriesRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryDto>>> GetCountries()
        {
            var countries = await _repo.GetAllAsync();
            var records = _mapper.Map<List<CountryDto>>(countries);
            return Ok(records);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryDetailDto>> GetCountry(int id)
        {
            var country = await _repo.GetDetails(id);

            if (country == null)
            {
                return NotFound();
            }

            var result = _mapper.Map<CountryDetailDto>(country);

            return Ok(result);
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, UpdateCountryDto updateCountryDto)
        {
            if (id != updateCountryDto.Id)
            {
                return BadRequest();
            }

            var country = await _repo.GetAsync(id);
            
            if (country == null) return NotFound();

            _mapper.Map(updateCountryDto, country);

            try
            {
                await _repo.UpdateAsync(country);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _repo.ExistsAsync(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            return NoContent();
        }

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(CreateCountryDto createCountryDto)
        {
            var country = _mapper.Map<Country>(createCountryDto);

            country = await _repo.AddAsync(country);

            return Ok(country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            await _repo.DeleteAsync(id);

            return NoContent();
        }
    }
}
