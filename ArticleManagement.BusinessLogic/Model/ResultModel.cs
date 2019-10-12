using ArticleManagement.BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleManagement.BusinessLogic.Model
{
  public class ResultModel
  {
    public string Message { get; set; }
    public object Data { get; set; }
    public ResultStatus Status { get; set; }
  }
}
