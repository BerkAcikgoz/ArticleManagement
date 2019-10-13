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
  public class AuthorController : ControllerBase
  {
    [HttpPost("Add")]
    public ResultModel Add([FromBody] Author request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = AuthorService.AddAuthor(request);
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
          ResultModel result = AuthorService.DeleteAuthor(request);
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
    public ResultModel Update([FromBody] Author request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = AuthorService.UpdateAuthor(request);
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
    [HttpPost("GetAuthor")]
    public ResultModel GetAuthor([FromBody] BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          ResultModel result = AuthorService.GetAuthor(request);
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
    [HttpPost("GetListArticleOfAuthor")]
    public ResultModel GetListArticleOfAuthor([FromBody] BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          ResultModel result = AuthorService.GetListArticleOfAuthor(request);
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