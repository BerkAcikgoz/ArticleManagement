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
  public static class ArticleService
  {
    public static ResultModel AddArticle(Article request)
    {
      if (request != null)
      {
        try
        {
          Article response = GenericRepository.Add<Article>(request);
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
    public static ResultModel DeleteArticle(BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          GenericRepository.Delete<Article>(request.Id);
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
    public static ResultModel GetListOfCategory(BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          List<Article> response = GenericRepository.GetList<Article>(x => x.CategoryId == request.Id && x.IsActive == true);
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
    public static ResultModel FindArticle(BaseRequest request)
    {
      if (!string.IsNullOrEmpty(request.Value))
      {
        try
        {
          List<Article> response = GenericRepository.GetList<Article>(x =>x.Title.Contains("Test"));
          //List<Article> response = GenericRepository.GetList<Article>(x=>x.Id==1);
          if (response.Count == 0)
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
    public static ResultModel UpdateArticle(Article request)
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
