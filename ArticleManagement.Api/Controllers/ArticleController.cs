using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleManagement.DataLibrary.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ArticleManagement.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ArticleController : ControllerBase
  {

    [HttpGet]
    public string Get()
    {
      ArticleDbContext context = new ArticleDbContext();
      var a = context.Article.FirstOrDefault();
      return a.Content;
    }


  }
}
