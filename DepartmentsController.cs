﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("[controller]/[action]")]
    public class DepartmentsController
    {
        public string List ()
        {
            return "List() of DepartmentsController";
        }
        public string Details()
        {
            return "Details() of DepartmentsController";
        }
    }
}

