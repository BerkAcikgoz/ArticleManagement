using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleManagement.BusinessLogic.Enums
{
  public enum ResultStatus
  {
    Success = 200,
    NotFound = 404,
    BadRequest = 400,
    ServerInternalError = 500,
    Failed = 417,
  }
}
