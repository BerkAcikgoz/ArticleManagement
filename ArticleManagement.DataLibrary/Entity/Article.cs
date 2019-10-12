using System;
using System.Collections.Generic;

namespace ArticleManagement.DataLibrary.Entity
{
  public partial class Article : BaseEntity
  {
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }
    public int? Like { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
  }
}
