using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Interfaces
{
    public interface IEmpresaService
    {
        List<Empresa> ObtenerTodas();
        Empresa? ObtenerPorId(int id);
        void Crear(Empresa empresa);
        void Actualizar(Empresa empresa);
        void Eliminar(int id);
    }
}
