using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
    public class TestController : Controller
    {
        public static List<string> names = new List<string>() { "Parthib", "Rajdeep", "Deb", "Tausif" };

        //Get Request without id
        [Route("/Get")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return names;
        }

        //Get Request with id
        [Route("/Get/{id}")]
        [HttpGet]
        public string Get(int id)
        {
            return names[id];
        }

        //Post Request
        [Route("/Post")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
            names.Add(value);
        }

        //Delete Request
        [Route("/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            names.RemoveAt(id);
        }

        //Put or Update Request
        [Route("/Put/{id}")]
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
            names[id] = value;
        }
    }
}
