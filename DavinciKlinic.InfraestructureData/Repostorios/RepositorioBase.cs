using DavinciKlinic.InfraestructureData.Modelos;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavinciKlinic.InfraestructureData.SeedWork;

namespace DavinciKlinic.InfraestructureData.Repostorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : Entidad, new()
    {
        public void Delete(T Entidad)
        {
            using (var Db = new DavinciKlinicDBContext())
            {

                Db.Entry(Entidad).State = EntityState.Deleted;
                Db.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                using (var context = new DavinciKlinicDBContext())
                {
                    return context.Set<T>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registros", ex);
            }
        }

        public T GetById(int id)
        {
            using (var Db = new DavinciKlinicDBContext())
            {
                return Db.Set<T>().FirstOrDefault(x => x.Id == id);
            }
        }

        public void Insert(T entidad)
        {
            using (var Db = new DavinciKlinicDBContext())
            {

                Db.Entry(entidad).State = EntityState.Added;
                Db.SaveChanges();
            }
        }

        public void Update(T entidad)
        {
            using (var db = new DavinciKlinicDBContext())
            {
                db.Entry(entidad).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }

}
