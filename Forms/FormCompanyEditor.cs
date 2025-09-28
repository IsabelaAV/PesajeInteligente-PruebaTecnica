using PruebaTecnica.Data;
using PruebaTecnica.Interfaces;
using PruebaTecnica.Models;
using PruebaTecnica.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica.Forms
{
    public partial class FormCompanyEditor : Form
    {
        private readonly IEmpresaService _service;
        private Empresa _empresa;

        // Constructor para añadir
        public FormCompanyEditor(IEmpresaService service)
        {
            InitializeComponent();
            _service = service;
            _empresa = new Empresa();
            lblTitulo.Text = "Creando nueva Empresa";
        }

        // Constructor para editar
        public FormCompanyEditor(IEmpresaService service, int empresaId)
        {
            InitializeComponent();
            _service = service;
            _empresa = _service.ObtenerPorId(empresaId);

            if (_empresa != null)
            {
                lblTitulo.Text = "Editando Empresa";
                txtNombre.Text = _empresa.Nombre;
                txtCodigo.Text = _empresa.Codigo.ToString();
                txtDireccion.Text = _empresa.Direccion;
                txtTelefono.Text = _empresa.Telefono;
                txtCiudad.Text = _empresa.Ciudad;
                txtDepartamento.Text = _empresa.Departamento;
                txtPais.Text = _empresa.Pais;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Nombre y Código son obligatorios.");
                return;
            }

            _empresa.Nombre = txtNombre.Text;
            _empresa.Codigo = int.Parse(txtCodigo.Text);
            _empresa.Direccion = txtDireccion.Text;
            _empresa.Telefono = txtTelefono.Text;
            _empresa.Ciudad = txtCiudad.Text;
            _empresa.Departamento = txtDepartamento.Text;
            _empresa.Pais = txtPais.Text;

            if (_empresa.EmpresaID == 0)
                _service.Crear(_empresa);
            else
                _service.Actualizar(_empresa);

            DialogResult = DialogResult.OK;
            Close();
        }
    
    }
}
