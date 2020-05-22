using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClubBeykersStreet.DomainObjects;

namespace ClubBeykersStreet.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClubBeykerStreetesController : ControllerBase
    {
        private readonly ILogger<ClubBeykerStreetesController> _logger;

        public ClubBeykerStreetesController(ILogger<ClubBeykerStreetesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ClubBeykerStreet> GetRoute()
        {
            return new List<ClubBeykersStreet>() 
            { 
                new ClubBeykersStreet() 
                { 
                    Id = 1,
                    Number = "748",
                    Name = "Ст. Ховрино - Ст. МЦД Бескудниково",
                    Type = TransportType.Bus,
                    Organization = new TransportOrganization()
                    {
                        Id = 1,
                        Name = "ГУП \"Мосгортранс\"",
                        TimeZone = "Europe/Moscow",
                        WebSite = "http://mosgortrans.ru"
                    }
                } 
            };
        }
    }
}
