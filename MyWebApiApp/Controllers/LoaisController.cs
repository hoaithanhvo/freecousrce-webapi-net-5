using Microsoft.AspNetCore.Mvc;
using MyWebApiApp.Data;
using MyWebApiApp.Models;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace MyWebApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoaisController : Controller
    {
        private readonly MyDBContext _context;
        public LoaisController(MyDBContext context)
        {
            _context = context;
        }



        [HttpGet]
        public IActionResult GetAll() {
        
            var dsLoai = _context.Loais.ToList();
            return Ok(dsLoai); 
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var loai = _context.Loais.SingleOrDefault(loai => loai.MaLoai == id);
                if (loai == null)
                {
                    return NotFound();
                }
                return Ok(loai);
            }
            catch
            {
                return BadRequest();
            }

        }


        [HttpPost]
        public IActionResult CreateNew(LoaiModel model)
        {
            try
            {
                var loai = new Loai()
                {
                    TenLoai = model.TenLoai
                };
                _context.Add(loai);
                _context.SaveChanges();
                return Ok(loai);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            try
            {
                var delete = _context.Loais.SingleOrDefault(loai => loai.MaLoai == id);
                if (delete == null)
                {
                    return NotFound();

                }
                _context.Loais.Remove(delete);
                _context.SaveChanges();
                return Ok(delete);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLoad(int id , LoaiModel loai ) {
        var loaiUpdate = _context.Loais.SingleOrDefault(loai => loai.MaLoai == id);
            if(loaiUpdate == null)
            {
                return NotFound();

            }
            loaiUpdate.TenLoai = loai.TenLoai;
            _context.SaveChanges();
            return Ok(loaiUpdate);

        
        }
    }
}
