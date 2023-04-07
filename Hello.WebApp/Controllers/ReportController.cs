using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_product;
using Hello.WebApp.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hello.WebApp.Controllers
{
    public class ReportController : Controller
    {
        private readonly ITbl_productApiClient _nhanSuApiClient;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ReportController(ITbl_productApiClient sinhVienApiClient, IWebHostEnvironment hostEnvironment)
        {
            _nhanSuApiClient = sinhVienApiClient;
            this._hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}