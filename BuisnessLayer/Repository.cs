using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UrunYonetim.DataAccess;
using UrunYonetimi.Entites;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace BuisnessLayer
{
    public class Repository<T> : IRepository<T> where T : class , IEntity , new()
    {
        /*üstteki yapının anlamı T adındaki entity nesnesi bir sınıf olmalı , 
         aynı zamanda bu sınıf bir IEntity interface'inden kalıtım almalı 
        ayrıca bu sınıf New ile örnek alınabilir olmalı,*/

        private ModelDb _context;
        private DbSet<T> _objectDataSet;
        public Repository()
        {
            if (_context == null)
            {
                _context = new ModelDb();
                _objectDataSet = _context.Set<T>();
            }
        }
        public int Add(T entity)
        {
            var AddObj = _objectDataSet.Add(entity);
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            _objectDataSet.Remove(Get(id));
            return _context.SaveChanges();
            
        }
        
        public T Find(Expression<Func<T, bool>> expression)
        {
            return _objectDataSet.FirstOrDefault(expression);
        }

        public T Get(int id)
        {
            return _objectDataSet.Find(id);
        }

        public List<T> GetAll()
        {
            return _objectDataSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T,bool>> expression)
        {
            return _objectDataSet.Where(expression).ToList();
        }
        public int Update(T entity)
        {
            _objectDataSet.AddOrUpdate(entity);
            return _context.SaveChanges();
        }
    }
}
