using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    /// <summary>
    /// temel crud islemleri icin kullanılacak repo. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IRepository<T>
    {
        /// <summary>
        /// Secilen türdeki bütün dataları getirecektir.
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();


        /// <summary>
        /// parametre olarak gelen id'ye göre tür döndürür bize
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);

        /*
         icerisinde delegate kullanabildiğimiz t türü parametre alan 
        ve Bool türde değer donduren bir delegate kullanabildiğimiz bir ifade ile bu fonksiyonu 
        kullanırız ve değeri bulabiliriz.*/
        /// <summary>
        /// içerisinde where ile filtrelenebilen kayıtları bize döndürür.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        T Find(Expression<Func<T , bool>> expression);

        int Add(T entity); //ekleme
        int Update(T entity);//guncelleme
        int Delete(int id);//silme

    }
}
