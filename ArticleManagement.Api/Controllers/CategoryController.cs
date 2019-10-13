using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleManagement.BusinessLogic.Enums;
using ArticleManagement.BusinessLogic.Message.Request;
using ArticleManagement.BusinessLogic.Model;
using ArticleManagement.BusinessLogic.Services;
using ArticleManagement.DataLibrary.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
    [HttpPost("Add")]
    public ResultModel Add([FromBody] Category request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = CategoryService.AddCategory(request);
          return result;
        }
        catch (Exception ex)
        {
          return new ResultModel { Data = null, Status = ResultStatus.ServerInternalError, Message = "Hata oluştu" };
        }
      }
      else
        return new ResultModel { Data = null, Status = ResultStatus.BadRequest, Message = "Geçersiz değer" };
    }
    [HttpPost("Delete")]
    public ResultModel Delete([FromBody] BaseRequest request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = CategoryService.DeleteCategory(request);
          return result;
        }
        catch (Exception ex)
        {
          return new ResultModel { Data = null, Status = ResultStatus.ServerInternalError, Message = "Hata oluştu" };
        }
      }
      else
        return new ResultModel { Data = null, Status = ResultStatus.BadRequest, Message = "Geçersiz değer" };
    }
    [HttpPost("Update")]
    public ResultModel Update([FromBody] Category request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = CategoryService.UpdateCategory(request);
          return result;
        }
        catch (Exception ex)
        {
          return new ResultModel { Data = null, Status = ResultStatus.ServerInternalError, Message = "Hata oluştu" };
        }
      }
      else
        return new ResultModel { Data = null, Status = ResultStatus.BadRequest, Message = "Geçersiz değer" };
    }
    [HttpPost("GetList")]
    public ResultModel GetList()
    {
      try
      {
        ResultModel result = CategoryService.GetList();
        return result;
      }
      catch (Exception ex)
      {
        return new ResultModel { Data = null, Status = ResultStatus.ServerInternalError, Message = "Hata oluştu" };
      }
    }
    [HttpPost("GetCategoryOfArticles")]
    public ResultModel GetCategoryOfArticles([FromBody] BaseRequest request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = CategoryService.GetCategoryOfArticles(request);
          return result;
        }
        catch (Exception ex)
        {
          return new ResultModel { Data = null, Status = ResultStatus.ServerInternalError, Message = "Hata oluştu" };
        }
      }
      else
        return new ResultModel { Data = null, Status = ResultStatus.BadRequest, Message = "Geçersiz değer" };
    }
   
  }
}