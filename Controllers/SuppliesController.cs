using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_1.Data;
using Project_1.Models;

namespace Project_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliesController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public SuppliesController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: api/supplies
        [HttpGet]
        public async Task<IActionResult> GetSupplies()
        {
            var supplies = await _context.SchoolSupplies
                .Where(s => s.QuantityAvailable > 0)
                .ToListAsync();

            return Ok(supplies);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupply(int id)
        {
            var supply = await _context.SchoolSupplies.FindAsync(id);

            if (supply == null)
                return NotFound();

            return Ok(supply);
        }

        // POST
        [HttpPost]
        public async Task<IActionResult> CreateSupply(SchoolSupply supply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.SchoolSupplies.Add(supply);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSupply), new { id = supply.ItemId }, supply);
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSupply(int id, SchoolSupply supply)
        {
            if (id != supply.ItemId)
                return BadRequest();

            _context.Entry(supply).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupply(int id)
        {
            var supply = await _context.SchoolSupplies.FindAsync(id);

            if (supply == null)
                return NotFound();

            _context.SchoolSupplies.Remove(supply);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // GET: api/supplies/price/10
        [HttpGet("price/{price}")]
        public async Task<IActionResult> GetSuppliesByPrice(decimal price)
        {
            var supplies = await _context.SchoolSupplies
                .Where(s => s.Price <= price && s.QuantityAvailable > 0)
                .ToListAsync();

            return Ok(supplies);
        }
    }
}