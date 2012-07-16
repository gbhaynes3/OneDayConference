using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneDayConference.Web.Models
{
    public interface IRepository<T>
    {
        IQueryable<T> All { get; }
        T Find(int id);
        void InsertOrUpdate(T entity);
        void Delete(int id);
        void Save();
    }
}
