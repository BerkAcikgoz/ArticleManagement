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
  public static class AuthorService
  {
    public static ResultModel AddAuthor(Author request)
    {
      if (request != null)
      {
        try
        {
          Author response = GenericRepository.Add<Author>(request);
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
    public static ResultModel DeleteAuthor(BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          GenericRepository.Delete<Author>(request.Id);
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
    public static ResultModel GetAuthor(BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          Author response = GenericRepository.Get<Author>(x => x.Id == request.Id && x.IsActive == true);
          if (response == null)
            return new ResultModel { Data = null, Status = ResultStatus.Success, Message = "Sonuç bulunamadı" };
          else
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
    public static ResultModel UpdateAuthor(Author request)
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
    public static ResultModel GetListArticleOfAuthor(BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          List<Article> response = GenericRepository.GetList<Article>(x => x.AuthorId == request.Id && x.IsActive == true);
          if (response == null)
            return new ResultModel { Data = null, Status = ResultStatus.Success, Message = "Sonuç bulunamadı" };
          else
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
  }
}
