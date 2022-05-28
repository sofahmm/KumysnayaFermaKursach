using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.MyDb;
using Core.DB;

using Newtonsoft.Json;
using KumFermaApi.Models;

namespace KumFermaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorseController : Controller
    {
        [HttpGet()]
        public IEnumerable<HorseModel> GetHorses()
        {
            var horses =  ToGetData.GetHorses1().Select(h => new HorseModel(h)).ToList();
            return horses;
        }


    }
}
