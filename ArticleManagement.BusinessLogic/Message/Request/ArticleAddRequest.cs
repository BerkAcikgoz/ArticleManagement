using System;
using System.Collections.Generic;
using System.Text;
using ArticleManagement.BusinessLogic.Message.Request;
namespace ArticleManagement.BusinessLogic
{
  public class ArticleAddRequest : BaseRequest
  {
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }
    public int? Like { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }

  }
}
