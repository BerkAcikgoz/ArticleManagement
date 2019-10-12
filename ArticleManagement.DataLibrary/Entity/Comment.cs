using System;
using System.Collections.Generic;

namespace ArticleManagement.DataLibrary.Entity
{
  public partial class Comment : BaseEntity
  {
    public int Id { get; set; }
    public int ArticleId { get; set; }
    public string Email { get; set; }
    public string Body { get; set; }
  }
}
