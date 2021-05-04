using DavinciKlinic.InfraestructureData.SeedWork;
using System.Collections.Generic;

namespace DavinciKlinic.InfraestructureData.Repostorios
{
    public interface IRepositorioBase<T>
    {
        /// <summary>
        /// Metodo utilizado para Insertar Objeto
        /// </summary>
        /// <param name="Entidad"></param>
        void Insert(T Entidad);

        /// <summary>
        /// Metodo utilizado para Eliminar Objeto
        /// </summary>
        /// <param name="Entidad"></param>
        void Delete(T Entidad);

        /// <summary>
        /// Actualiza el Entidad que recibe
        /// </summary>
        /// <param name="Entidad"></param>
        void Update(T Entidad);

        /// <summary>
        /// Permite obtener todas las Entidad
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Permite obtener un Entidad por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

    }

}