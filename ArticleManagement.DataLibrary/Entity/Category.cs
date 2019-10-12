using System;
using System.Collections.Generic;

namespace ArticleManagement.DataLibrary.Entity
{
  public partial class Category : BaseEntity
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
