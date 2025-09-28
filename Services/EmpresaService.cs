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

        public List<Empresa> ObtenerTodas() => _repository.GetAll();
        public Empresa? ObtenerPorId(int id) => _repository.GetById(id);
        public void Crear(Empresa empresa) => _repository.Add(empresa);
        public void Actualizar(Empresa empresa) => _repository.Update(empresa);
        public void Eliminar(int id) => _repository.Delete(id);
    }
}
