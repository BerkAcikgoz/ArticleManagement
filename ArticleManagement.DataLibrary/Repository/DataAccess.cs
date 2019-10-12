using ArticleManagement.DataLibrary.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleManagement.DataLibrary.Repository
{
  public static class DataAccess
  {
    static ArticleDbContext ctx = null;
    static DataAccess()
    {
      ctx = new ArticleDbContext();
    }


    public static ArticleDbContext Context
    {

      get
      {
        if (ctx == null)
          ctx = new ArticleDbContext();
        return ctx;

      }



    }
  }
}
