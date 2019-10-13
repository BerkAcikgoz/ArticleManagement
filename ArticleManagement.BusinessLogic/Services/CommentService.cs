using ArticleManagement.BusinessLogic.Enums;
using ArticleManagement.BusinessLogic.Message.Request;
using ArticleManagement.BusinessLogic.Model;
using ArticleManagement.DataLibrary.Entity;
using ArticleManagement.DataLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleManagement.BusinessLogic.Services
{
  public static class CommentService
  {
    public static ResultModel AddComment(Comment request)
    {
      if (request != null)
      {
        try
        {
          Comment response = GenericRepository.Add<Comment>(request);
          return new ResultModel { Data = response, Status = ResultStatus.Success, Message = "Başarılı bir şekilde kaydedildi" };
        }
        catch (Exception ex)
        {
          return new ResultModel { Data = null, Status = ResultStatus.ServerInternalError, Message = "Hata oluştu" };
        }
      }
      else
        return new ResultModel { Data = null, Status = ResultStatus.BadRequest, Message = "Geçersiz değer" };

    }
    public static ResultModel DeleteComment(BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          GenericRepository.Delete<Comment>(request.Id);
          return new ResultModel { Data = null, Status = ResultStatus.Success, Message = "Başarılı bir şekilde silindi" };
        }
        catch (Exception ex)
        {
          return new ResultModel { Data = null, Status = ResultStatus.ServerInternalError, Message = "Hata oluştu" };
        }
      }
      else
        return new ResultModel { Data = null, Status = ResultStatus.BadRequest, Message = "Geçersiz değer" };

    }
    public static ResultModel GetListCommentOfArticle(BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          List<Comment> response = GenericRepository.GetList<Comment>(x => x.ArticleId == request.Id && x.IsActive == true);
          return new ResultModel { Data = response, Status = ResultStatus.Success, Message = "Başarılı bir şekilde listelendi" };
        }
        catch (Exception ex)
        {
          return new ResultModel { Data = null, Status = ResultStatus.ServerInternalError, Message = "Hata oluştu" };
        }
      }
      else
        return new ResultModel { Data = null, Status = ResultStatus.BadRequest, Message = "Geçersiz değer" };
    }
    public static ResultModel UpdateComment(Comment request)
    {
      if (request != null)
      {
        try
        {
          BaseEntity response = GenericRepository.Update(request);
          return new ResultModel { Data = response, Status = ResultStatus.Success, Message = "Başarılı bir şekilde güncellendi" };
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
