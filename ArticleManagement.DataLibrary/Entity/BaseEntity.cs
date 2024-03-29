﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleManagement.DataLibrary.Entity
{
  public class BaseEntity
  {
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; }
  }
}
