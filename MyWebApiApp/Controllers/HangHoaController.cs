using Microsoft.AspNetCore.Mvc;
using MyWebApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HangHoaController : Controller
    {
        
        public static List<HangHoa> hangHoas = new List<HangHoa>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hangHoas);
        }


        [HttpPost]
        public IActionResult Create(HangHoaVM hoangHoaVm) {

            var hanghoa = new HangHoa
            {
                MaHoangHoa = Guid.NewGuid(),
                TenHangHoa = hoangHoaVm.TenHangHoa,
                DonGia = hoangHoaVm.DonGia,


            };
            hangHoas.Add(hanghoa);
            return Ok(new
            {
                success = true,
                Data = hanghoa
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try {
                var hanghoa = hangHoas.SingleOrDefault(hh => hh.MaHoangHoa == Guid.Parse(id));
                if (hanghoa == null)
                {
                    return NotFound();

                }
                return Ok(hanghoa);

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(string id)
        {
            try
            {
                var hanghoa = hangHoas.SingleOrDefault(hh => hh.MaHoangHoa == Guid.Parse(id));
                if(hanghoa == null)
                {
                    return NotFound();

                }
                hangHoas.Remove(hanghoa);
                return Ok(hanghoa);
            }
            catch (Exception ex) { 
            return BadRequest(ex.Message);
            
            
            }
        }
        [HttpPut("{id}")]
        public IActionResult PutHangHoaByID(string id,HangHoa hangHoaEdit) {
            try
            {
                var hanghoa = hangHoas.SingleOrDefault(hh => hh.MaHoangHoa == Guid.Parse(id));
                if(hangHoas == null)
                {
                    return NotFound();
                }

                hanghoa.TenHangHoa = hangHoaEdit.TenHangHoa;
                hanghoa.DonGia = hangHoaEdit.DonGia;
                return Ok(hanghoa);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        
        
        }
    }
}
