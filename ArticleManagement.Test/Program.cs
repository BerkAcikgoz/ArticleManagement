using ArticleManagement.BusinessLogic.Message.Request;
using ArticleManagement.BusinessLogic.Services;
using ArticleManagement.DataLibrary.Entity;
using System;

namespace ArticleManagement.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      // Article
      var AddArticle = ArticleService.AddArticle(new Article { AuthorId = 1, CategoryId = 1, IsActive = true, Like = 1, Title = "TestRequest", CreatedDate = new DateTime(2019, 10, 10), Content = " - ", Description = " - ", });

      var UpdateArticle = ArticleService.UpdateArticle(new Article { Id = 1, AuthorId = 1, CategoryId = 1, IsActive = true, Like = 1, Title = "TestRequestUpdate", CreatedDate = new DateTime(2019, 10, 10), Content = " - ", Description = " - ", UpdatedDate = new DateTime(2019, 10, 11) });

      var FindArticle = ArticleService.FindArticle(new BaseRequest { Value = "Test" });

      var GetListOfCategory = ArticleService.GetListOfCategory(new BaseRequest { Id = 1 });

      //Category
      var AddCategory = CategoryService.AddCategory(new Category { Name = "Yazılım", IsActive = true, CreatedDate = new DateTime(2019, 10, 10) });

      var UpdateCategory = CategoryService.UpdateCategory(new Category {Id = 2, Name = "Yazılım", IsActive = true, CreatedDate = new DateTime(2019, 10, 10), UpdatedDate = new DateTime(2019, 10, 11), });

    }
  }
}
