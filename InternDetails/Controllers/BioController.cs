using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InternDetails.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class BioController : ControllerBase
    {
        private readonly ILogger<BioController> _logger;

        public BioController(ILogger<BioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public InternDetails Get()
        {
            return new InternDetails
            {
                Age = 28,
                Backend = true,
                Bio = "I am a fulltime .NET Developer with an Insurance firm. " +
                "Besides coding, I enjoy listening to music, driving and surfing the internet for new technologies. Cheers!",
                SlackUsername = "DamoFC"
            };

        }
    }
}
