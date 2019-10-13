using ArticleManagement.DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleManagement.BusinessLogic.Message.Request
{
  public class BaseRequest:BaseEntity
  {
    public string Value { get; set; }
  }
}
