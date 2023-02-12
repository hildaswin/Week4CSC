using Microsoft.AspNetCore.Mvc;

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
                System.Console.WriteLine(returnString(doge.Name));
            }

            return Accepted(input);
        }
        string returnString(string input)
        {
            return input;
        }
    }

    public class Doge
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}