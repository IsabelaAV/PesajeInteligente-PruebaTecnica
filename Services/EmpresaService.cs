using PruebaTecnica.Data.Repositories;
using PruebaTecnica.Data.Repositories.Impl;
using PruebaTecnica.Models;
using PruebaTecnica.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _repository;

        public EmpresaService(IEmpresaRepository repository)
        {
            _repository = repository;
        }

        public List<Empresa> ObtenerTodas()
        {
            try
            {
                return _repository.GetAll();
            }catch (Exception ex)
            {
                throw new Exception("Error al obtener las empresas: " + ex.Message);
            }
        }
        public Empresa? ObtenerPorId(int id)
        {
            try
            {
                return _repository.GetById(id);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la empresa: " + ex.Message);
            }
        }
        public void Crear(Empresa empresa)
        {
            try
            {
                _repository.Add(empresa);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la empresa: " + ex.Message);
            }
        }
        public void Actualizar(Empresa empresa)
        {
            try
            {
                _repository.Update(empresa);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la empresa: " + ex.Message);
            }
        }
        public void Eliminar(int id)
        {
            try
            {
                _repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la empresa: " + ex.Message);
            }
        }
    }
}
