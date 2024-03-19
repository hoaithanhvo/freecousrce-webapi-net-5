using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApiApp.Data;
using MyWebApiApp.Models;
using System;
using System.Linq;

namespace MyWebApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VanChuyen : Controller
    {
        private readonly MyDBContext _context;
        public VanChuyen(MyDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var VanChuyen = _context.VanChuyen.ToList();
            return Ok(VanChuyen);
        }
        [HttpGet("{id}")]     
        
        public IActionResult GetByID(int id) {
            var data = _context.VanChuyen.SingleOrDefault(hh=>hh.Id == id);

            if(data == null) {
            return NotFound(); }
            return Ok(data);
        
        
        
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleteVanchuyen  = _context.VanChuyen.SingleOrDefault(hh=>hh.Id== id);
            if(deleteVanchuyen == null)
            {
                return NotFound();

            }
            _context.Remove(deleteVanchuyen);
            _context.SaveChanges();
            return Ok(deleteVanchuyen);
        }

        [HttpPost]

        public IActionResult Create(VanChuyens model)
        {
            var create = new VanChuyenss()
            {
                
                Name = model.Name,
                ChiPhi = model.ChiPhi,
                Description = model.Description


            };
            _context.Add(create);
            _context.SaveChanges();
            return Ok(create);


        }

        [HttpPut("{id}")]
        public IActionResult Put(VanChuyens model, int id) {

            var check = _context.VanChuyen.SingleOrDefault(vc=>vc.Id== id);
            if(check == null)
            {
                return NotFound();  
            }

            check.Name= model.Name;
            check.ChiPhi= model.ChiPhi;
            check.Description= model.Description;
            _context.SaveChanges();
            return Ok(check);
            
            
        
           


        
        
        }

        
    }
}
