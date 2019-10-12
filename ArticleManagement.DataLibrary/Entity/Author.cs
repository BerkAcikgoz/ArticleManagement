using System;
using System.Collections.Generic;

namespace ArticleManagement.DataLibrary.Entity
{
  public partial class Author : BaseEntity
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
  }
}
