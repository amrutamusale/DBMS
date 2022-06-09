using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;
namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home1Controller : ControllerBase
    {
        [HttpGet]
        public List<TblSample> Get()
        {
            SampleDb1Context db = new SampleDb1Context();
            return db.Tblsamples.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string sample)
        {
            SampleDb1Context db = new SampleDb1Context();
            TblSample s = new TblSample();
            s.Text = sample;
            db.Tblsamples.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] Tblsample tblsample)
        {
            SampleDb1Context db = new SampleDb1Context();
            var tblsampleObj = db.Tblsamples.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.Tblsamples.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            SampleDb1Context db = new SampleDb1Context();
            var tblsampleObj = db.Tblsamples.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Tblsamples.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

    }
}