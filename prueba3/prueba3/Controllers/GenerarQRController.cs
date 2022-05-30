using Microsoft.AspNetCore.Mvc;
using prueba3.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenerarQRController : ControllerBase
    {
        [HttpGet("QR")]
        public ActionResult<byte[]> GetTareas(string dato)
        {
            return GenQR.GenerarQR(dato);
        }
    }
}
