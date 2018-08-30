using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AprendeNetCore2.Services;
using AprendeNetCore2.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;


namespace AprendeNetCore2.Controllers
{


    //[Authorize]
    [Route("api/[controller]")]
    public class FileController : Controller
    {

        private readonly IFileAzureService _fileAzureService;
        //private readonly Address _settings;



        public FileController(IFileAzureService fileAzureService) //, IOptions<Address> settings)
        {
            _fileAzureService = fileAzureService;
            //_settings = settings.Value;
        }


        [HttpGet]      
        public async Task<string> GetText()
        {

            //var city = _settings.City;

            return await _fileAzureService.GetText();
        }

        
    }
}
