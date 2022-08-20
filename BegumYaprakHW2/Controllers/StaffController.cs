using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BegumYaprakHW2.Model;
using Microsoft.AspNetCore.Mvc;



namespace BegumYaprakHW2.Controllers

{
 
    [Route("api/[controller]")]
    [ApiController]

    public class StaffController : ControllerBase
    {

        public StaffController()
        {


        }


        private CommonResponse<List<Staff>> GetList()
        {
            List<Staff> list = new();

            //list.Add(new Staff { Id = 1, Name = "Begum ", Lastname = "Yaprak", DateOfBirth = new DateTime(1999,08,21) ,Email = "begmyaprak@gmail.com", PhoneNumber = 53463448, Salary = 5000 });

            return new CommonResponse<List<Staff>>(list);
        }



        [HttpGet("GetAll")]
      
        public CommonResponse<List<Staff>> GetAll()
        {
            return GetList();
        }


        [HttpGet("GetById/{id}")]

        public CommonResponse<Staff> GetById([FromRoute] int id)
        {
            CommonResponse<List<Staff>> list = GetList();

            Staff staff = list.Data.Where(a => a.Id == id).FirstOrDefault();

            return new CommonResponse<Staff>(staff);

        }


        [HttpPost]
        public CommonResponse<List<Staff>> Add([FromBody] Staff staff)
        {
            var list = GetList().Data;
            list.Add(staff);

            return new CommonResponse<List<Staff>>(list);

        }

        [HttpPut("{id}")]
        public CommonResponse<List<Staff>> Update(int id, [FromBody] Staff request)
        {
            var list = GetList().Data;
            Staff staff = list.Where(a => a.Id == id).FirstOrDefault();
            list.Remove(staff);
            request.Id = id;
            list.Add(request);
            return new CommonResponse<List<Staff>>(list.ToList());


        }

        [HttpDelete("{id}")]
        public CommonResponse<List<Staff>> Delete([FromRoute] int id)
        {

            var list = GetList().Data;
            Staff staff = list.Where(a => a.Id == id).FirstOrDefault();
            list.Remove(staff);
            return new CommonResponse<List<Staff>>(list);

        }



    }
}


   


