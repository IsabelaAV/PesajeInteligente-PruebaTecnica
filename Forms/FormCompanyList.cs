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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = empresas;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Codigo",
                HeaderText = "Código"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Direccion",
                HeaderText = "Dirección"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Ciudad",
                HeaderText = "Ciudad"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Departamento",
                HeaderText = "Departamento"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Pais",
                HeaderText = "País"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaCreacion",
                HeaderText = "Fecha de creación"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaModificacion",
                HeaderText = "Fecha de modificación"
            });
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
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar las empresas seleccionadas?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var empresa = (Empresa)row.DataBoundItem;
                        _service.Eliminar(empresa.EmpresaID);
                    }
                    CargarEmpresas();
                }
                   
            }
            else
            {
                MessageBox.Show("Seleccione al menos una empresa para eliminar.");
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrar.Text.ToLower();

            var empresasFiltradas = _service.ObtenerTodas()
                .Where(e => e.Nombre.ToLower().Contains(filtro))
                .ToList();

            dataGridView1.DataSource = empresasFiltradas;
        }
    }

}
