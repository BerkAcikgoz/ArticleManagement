using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleManagement.BusinessLogic.Enums;
using ArticleManagement.BusinessLogic.Message.Request;
using ArticleManagement.BusinessLogic.Model;
using ArticleManagement.BusinessLogic.Services;
using ArticleManagement.DataLibrary.Entity;
using ArticleManagement.DataLibrary.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ArticleManagement.Api.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class ArticleController : ControllerBase
  {
    [HttpPost("Add")]
    public ResultModel Add([FromBody] Article request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = ArticleService.AddArticle(request);
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
      if (request.Id > 0)
      {
        try
        {
          ResultModel result = ArticleService.DeleteArticle(request);
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
    public ResultModel Update([FromBody] Article request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = ArticleService.UpdateArticle(request);
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
    [HttpPost("GetListOfCategory")]
    public ResultModel GetListOfCategory([FromBody] BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          ResultModel result = ArticleService.GetListOfCategory(request);
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
    [HttpPost("FindArticle")]
    public ResultModel FindArticle(BaseRequest request)
    {
      if (string.IsNullOrEmpty(request.Value))
      {
        try
        {
          ResultModel result = ArticleService.FindArticle(request);
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
