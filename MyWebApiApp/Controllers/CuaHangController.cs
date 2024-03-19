using Microsoft.AspNetCore.Mvc;
using MyWebApiApp.Data;
using MyWebApiApp.Models;
using System.Linq;
using CuaHang = MyWebApiApp.Models.CuaHang;

namespace MyWebApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuaHangController : Controller
    {
        private readonly MyDBContext _context;
        public CuaHangController(MyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var getCuahang = _context.CuaHangs.ToList();

            return Ok(getCuahang);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {


            var getById = _context.CuaHangs.SingleOrDefault(hh => hh.MaCuaHang == id);
            if (getById == null)
            {
                return NotFound();
            }
            return Ok(getById);

        }

        [HttpPost]
        public IActionResult CreateCuahang(CuaHang model)
        {


            var create = new CuaHangData()
            {
                TenCuaHang = model.TenCuaHang,
                ChieuDai = model.ChieuDai,
                ChieuRong = model.ChieuRong,
                MaCuaHang = model.MaCuaHang,
                Diachi = model.Diachi,
                PhoneyNumber = model.PhoneyNumber,
            };
            _context.Add(create);
            _context.SaveChanges();
            return Ok(create);


        }


        [HttpPut("{id}")]

        public IActionResult UpdateCuaHang(CuaHang model, int id)
        {
            var checkCuahang = _context.CuaHangs.SingleOrDefault(hh => hh.MaCuaHang == id);
        if (checkCuahang == null)
            {

                return NotFound();
            }

            checkCuahang.TenCuaHang = model.TenCuaHang;
            checkCuahang.ChieuRong = model.ChieuRong;
            checkCuahang.ChieuDai = model.ChieuDai;
            checkCuahang.Diachi = model.Diachi;
            _context.SaveChanges();
            return Ok(checkCuahang);



        }

    }
}
