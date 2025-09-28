using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Data.Repositories.Impl
{
    public interface IEmpresaRepository
    {
        List<Empresa> GetAll();
        Empresa? GetById(int id);
        void Add(Empresa empresa);
        void Update(Empresa empresa);
        void Delete(int id);
    }
}
