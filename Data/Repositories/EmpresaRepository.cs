using PruebaTecnica.Interfaces;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Data.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly AppDbContext _context;
        private readonly IEmpresaRepository _repository;

        public EmpresaRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Empresa> GetAll() => _context.Empresas.ToList();

        public Empresa? GetById(int id) =>
            _context.Empresas.FirstOrDefault(e => e.EmpresaID == id);

        public void Add(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
        }

        public void Update(Empresa empresa)
        {
            _context.Empresas.Update(empresa);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var empresa = GetById(id);
            if (empresa != null)
            {
                _context.Empresas.Remove(empresa);
                _context.SaveChanges();
            }
        }
    }
}
