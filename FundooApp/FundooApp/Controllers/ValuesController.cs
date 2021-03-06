using FundooApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooApp.Controllers
{
    /*

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }


        */
    /////////////////////
    ///

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
            ValueSamples.Initialize();
        }

        // GET api/values  
        [HttpGet]
        public ActionResult<Dictionary<int, string>> Get()
        {
            return ValueSamples.MyValue;
        }

        // GET api/values/5  
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return ValueSamples.MyValue.GetValueOrDefault(id);
        }

        // POST api/values  
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var maxKey = ValueSamples.MyValue.Max(x => x.Key);

            ValueSamples.MyValue.Add(maxKey + 1, value);
        }

        // PUT api/values/5  
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            ValueSamples.MyValue.Add(id, value);
        }

        // DELETE api/values/5  
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ValueSamples.MyValue.Remove(id);
        }
    }


}
