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
  public class CommentController : ControllerBase
  {
    [HttpPost("Add")]
    public ResultModel Add([FromBody] Comment request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = CommentService.AddComment(request);
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
      if (request.Id>0)
      {
        try
        {
          ResultModel result = CommentService.DeleteComment(request);
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
    public ResultModel Update([FromBody] Comment request)
    {
      if (request != null)
      {
        try
        {
          ResultModel result = CommentService.UpdateComment(request);
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
    [HttpPost("GetListCommentOfArticle")]
    public ResultModel GetListCommentOfArticle([FromBody] BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          ResultModel result = CommentService.GetListCommentOfArticle(request);
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