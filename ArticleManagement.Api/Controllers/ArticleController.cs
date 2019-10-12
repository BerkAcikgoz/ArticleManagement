﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ArticleManagement.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ArticleController : ControllerBase
  {

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "Berkk" };
    }

   
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

 
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }


  }
}
