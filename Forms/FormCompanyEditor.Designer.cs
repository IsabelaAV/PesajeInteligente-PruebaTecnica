namespace PruebaTecnica.Forms
{
    partial class FormCompanyEditor
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
            lblTitulo = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblCiudad = new Label();
            txtCiudad = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblPais = new Label();
            txtPais = new TextBox();
            lblDepartamento = new Label();
            txtDepartamento = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(371, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(50, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(230, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(464, 392);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(341, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(417, 76);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(417, 99);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(341, 27);
            txtCodigo.TabIndex = 5;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(40, 153);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(40, 176);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(718, 27);
            txtDireccion.TabIndex = 7;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(417, 229);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(56, 20);
            lblCiudad.TabIndex = 12;
            lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(417, 252);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(341, 27);
            txtCiudad.TabIndex = 11;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(40, 229);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(40, 252);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(341, 27);
            txtTelefono.TabIndex = 9;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(417, 308);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(34, 20);
            lblPais.TabIndex = 16;
            lblPais.Text = "País";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(417, 331);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(341, 27);
            txtPais.TabIndex = 15;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(40, 308);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(106, 20);
            lblDepartamento.TabIndex = 14;
            lblDepartamento.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(40, 331);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(341, 27);
            txtDepartamento.TabIndex = 13;
            // 
            // FormCompanyEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPais);
            Controls.Add(txtPais);
            Controls.Add(lblDepartamento);
            Controls.Add(txtDepartamento);
            Controls.Add(lblCiudad);
            Controls.Add(txtCiudad);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTitulo);
            Name = "FormCompanyEditor";
            Text = "FormCompanyEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblCiudad;
        private TextBox txtCiudad;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblPais;
        private TextBox txtPais;
        private Label lblDepartamento;
        private TextBox txtDepartamento;
    }
}