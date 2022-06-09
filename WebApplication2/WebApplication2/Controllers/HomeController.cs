using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<TblSample> Get()
        {
            SampleDb1Context db = new SampleDb1Context();
            return db.tblsamples.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string sample)
        {
            SampleDb1Context db = new SampleDb1Context();
            TblSample s = new TblSample();
            s.Text = sample;
            db.tblsamples.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] TblSample tblsample)
        {
            SampleDb1Context db = new SampleDb1Context();
            var tblsampleObj = db.tblsamples.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.tblsamples.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            SampleDb1Context db = new SampleDb1Context();
            var tblsampleObj = db.tblsamples.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.tblsamples.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

    }
}
