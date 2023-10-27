using CodeFirstInveonOrnek.Data;
using CodeFirstInveonOrnek.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstInveonOrnek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        ApplicationDbContext _context;

        public KitapController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kitap>>> KitaplariGetir()
        {
            List<Kitap> kitapListesi;
            kitapListesi = await _context.Kitap.ToListAsync();
            return kitapListesi;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Kitap>>> KitapEkle(Kitap kitap)
        {
            try
            {
                _context.Kitap.Add(kitap);
                await _context.SaveChangesAsync();
            }catch(Exception ex)
            {

            }
            return Ok(kitap); ;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Kitap>> KitapDetayGetir(int id)
        {
            var kitap = await _context.Kitap.FindAsync(id);
            if(kitap == null)
            {
                return NotFound();
            }
            return Ok(kitap);
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<Kitap>>> KitapGuncelle(Kitap kitap)
        {
            _context.Entry(kitap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }catch(Exception ex)
            {
                return NotFound(kitap);
            }
            return Ok(kitap);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Kitap>> KitapSil(int id)
        {
            Kitap silinecekKitap = await _context.Kitap.FindAsync(id);
            _context.Kitap.Remove(silinecekKitap);
            await _context.SaveChangesAsync();
            return Ok(silinecekKitap);
        }




    }
}
