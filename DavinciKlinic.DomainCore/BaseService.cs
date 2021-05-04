using DavinciKlinic.InfraestructureData.Repostorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavinciKlinic.DomainCore
{
    public class BaseService<TEntity> :  IBaseService<TEntity> where TEntity : class
    {
        //IDisposable,
        private readonly IRepositorioBase<TEntity> baseRepository;

        public BaseService(IRepositorioBase<TEntity> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public void Add(TEntity entity)
        {
            this.baseRepository.Insert (entity);
        }

        public void Delete(int id)
        {
            var getTheId = baseRepository.GetById(id);
            if (getTheId != null)
                this.baseRepository.Delete(getTheId);
        }

        //public void Dispose()
        //{
        //    this.baseRepository.Dispose();
        //}

        public IEnumerable<TEntity> GetAll()
        {
            return this.baseRepository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return this.baseRepository.GetById(id);
        }

        public void Modify(TEntity entity)
        {
            //var getTheId = baseRepository.GetById(id);
            //if (getTheId != null)
                this.baseRepository.Update(entity);
        }
    }
}
