namespace PruebaTecnica.Forms
{
    partial class FormCompanyList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            empresaIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ciudadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaCreacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaModificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empresaBindingSource = new BindingSource(components);
            btnAnadir = new Button();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtFiltrar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empresaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { empresaIDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, ciudadDataGridViewTextBoxColumn, departamentoDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn, fechaCreacionDataGridViewTextBoxColumn, fechaModificacionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = empresaBindingSource;
            dataGridView1.Location = new Point(37, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(721, 188);
            dataGridView1.TabIndex = 0;
            // 
            // empresaIDDataGridViewTextBoxColumn
            // 
            empresaIDDataGridViewTextBoxColumn.DataPropertyName = "EmpresaID";
            empresaIDDataGridViewTextBoxColumn.HeaderText = "EmpresaID";
            empresaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            empresaIDDataGridViewTextBoxColumn.Name = "empresaIDDataGridViewTextBoxColumn";
            empresaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            ciudadDataGridViewTextBoxColumn.MinimumWidth = 6;
            ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            ciudadDataGridViewTextBoxColumn.Width = 125;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            departamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            departamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            paisDataGridViewTextBoxColumn.MinimumWidth = 6;
            paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            paisDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            fechaCreacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            fechaModificacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            fechaModificacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // empresaBindingSource
            // 
            empresaBindingSource.DataSource = typeof(Models.Empresa);
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(664, 42);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(94, 29);
            btnAnadir.TabIndex = 1;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 42);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 2;
            label1.Text = "Lista de empresas";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(268, 329);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(487, 333);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Location = new Point(37, 80);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(219, 27);
            txtFiltrar.TabIndex = 5;
            // 
            // FormCompanyList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFiltrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(btnAnadir);
            Controls.Add(dataGridView1);
            Name = "FormCompanyList";
            Text = "FormCompanyList";
            Load += FormCompanyList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)empresaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn empresaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private BindingSource empresaBindingSource;
        private Button btnAnadir;
        private Label label1;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtFiltrar;
    }
}