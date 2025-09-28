using Microsoft.EntityFrameworkCore;
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
    public partial class FormCompanyList : Form
    {
        private readonly IEmpresaService _service;
        public FormCompanyList(IEmpresaService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void FormCompanyList_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
        }

        private void CargarEmpresas()
        {
            var empresas = _service.ObtenerTodas();
            dataGridView1.DataSource = empresas;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            var form = new FormCompanyEditor(_service);
            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarEmpresas();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var empresa = (Empresa)dataGridView1.SelectedRows[0].DataBoundItem;
                var form = new FormCompanyEditor(_service, empresa.EmpresaID);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    CargarEmpresas();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una sola empresa para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = (int)row.Cells["EmpresaID"].Value;
                    _service.Eliminar(id);
                }
                CargarEmpresas();
            }
            else
            {
                MessageBox.Show("Seleccione al menos una empresa para eliminar.");
            }
        }
    }
    
}
