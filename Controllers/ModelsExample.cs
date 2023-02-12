using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ModelDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModelsExample : ControllerBase
    {
        

        [HttpPost(Name = "ModelsExample")]
        public ActionResult<List<Doge>> Post([FromBody]List<Doge> input)
        {
            foreach(Doge doge in input)
            {
                System.Console.WriteLine(LogObject(doge));
            }

            return Accepted(input);
        }
        string LogObject(Doge input)
        {
            PropertyInfo[] properties = input.GetType().GetProperties();
            foreach (var p in properties)
            {
                var value = p.GetValue(input);
                System.Diagnostics.Debug.WriteLine(value);
            }
            return input.Name;
        }
    }

    public class Doge
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}