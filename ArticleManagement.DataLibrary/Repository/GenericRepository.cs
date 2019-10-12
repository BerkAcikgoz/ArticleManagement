using ArticleManagement.DataLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ArticleManagement.DataLibrary.Repository
{
  public class GenericRepository
  {
    public static List<T> GetList<T>(Expression<Func<T, bool>> expression) where T : BaseEntity, new()
    {
      using (var context = new ArticleDbContext())
      {
        return context.Set<T>().Where(expression).ToList();
      }
    }
    public static T Get<T>(int id) where T : BaseEntity
    {
      using (var context = new ArticleDbContext())
      {
        return context.Set<T>().Where(x => x.Id == id).FirstOrDefault();
      }
    }
    public static T Get<T>(Expression<Func<T, bool>> expression) where T : BaseEntity
    {
      using (var context = new ArticleDbContext())
      {
        return context.Set<T>().Where(expression).FirstOrDefault();
      }
    }
    public static T Add<T>(BaseEntity entity) where T : BaseEntity
    {
      DataAccess.Context.Set<T>().Add((T)entity);
      DataAccess.Context.SaveChanges();
      return (T)entity;
    }
    public static BaseEntity Add(BaseEntity entity)
    {
      DataAccess.Context.Set<BaseEntity>().Add(entity);
      DataAccess.Context.SaveChanges();
      return entity;
    }
    public static BaseEntity Update(BaseEntity entity)
    {
      using (var context = new ArticleDbContext())
      {
        context.Set<BaseEntity>().Update(entity);
        context.SaveChanges();
        return entity;
      }
    }
    public static void Delete<T>(int id) where T : BaseEntity
    {
      DataAccess.Context.Set<T>().Remove(Get<T>(id));
      DataAccess.Context.SaveChanges();
    }
    public static void Delete<T>(T entity) where T : BaseEntity
    {
      DataAccess.Context.Set<T>().Remove((T)entity);
      DataAccess.Context.SaveChanges();
    }
  }
}
