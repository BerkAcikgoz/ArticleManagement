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
  public static class CategoryService
  {
    public static ResultModel AddCategory(Category request)
    {
      if (request != null)
      {
        try
        {
          Category response = GenericRepository.Add<Category>(request);
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
    public static ResultModel DeleteCategory(BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          GenericRepository.Delete<Category>(request.Id);
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
    public static ResultModel GetList(BaseRequest request)
    {
      if (request.Id > 0)
      {
        try
        {
          List<Category> response = GenericRepository.GetList<Category>(x => x.IsActive == true);
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
    public static ResultModel GetCategoryOfArticles(BaseRequest request)
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
    public static ResultModel FindCategory(BaseRequest request)
    {

      if (string.IsNullOrEmpty(request.Value))
      {
        try
        {
          List<Category> response = GenericRepository.GetList<Category>(x => request.Value.Contains(x.Name));
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
    public static ResultModel UpdateCategory(Category request)
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
