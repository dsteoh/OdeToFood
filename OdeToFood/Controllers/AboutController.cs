using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string phone()
        {
            return "231321313231";
        }
        public string Address()
        {
            return "AUS";
        }
    }
}
