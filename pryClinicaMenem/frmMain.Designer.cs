namespace pryClinicaMenem
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvInformacion = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEspecial = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.brnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(81, 33);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(136, 21);
            this.cboEspecialidad.TabIndex = 0;
            this.cboEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cboEspecialidad_SelectedIndexChanged);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(8, 33);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultar.Location = new System.Drawing.Point(227, 31);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvInformacion
            // 
            this.dgvInformacion.AllowUserToAddRows = false;
            this.dgvInformacion.AllowUserToDeleteRows = false;
            this.dgvInformacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dgvInformacion.Location = new System.Drawing.Point(12, 68);
            this.dgvInformacion.Name = "dgvInformacion";
            this.dgvInformacion.ReadOnly = true;
            this.dgvInformacion.Size = new System.Drawing.Size(290, 150);
            this.dgvInformacion.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nro. Matricula";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // btnMedico
            // 
            this.btnMedico.AccessibleName = "lblSalir";
            this.btnMedico.BackColor = System.Drawing.SystemColors.Control;
            this.btnMedico.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMedico.Location = new System.Drawing.Point(11, 274);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(115, 24);
            this.btnMedico.TabIndex = 10;
            this.btnMedico.Text = "Nuevo Médico";
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleName = "";
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(227, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 21);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEspecial
            // 
            this.btnEspecial.AccessibleName = "lblSalir";
            this.btnEspecial.BackColor = System.Drawing.SystemColors.Control;
            this.btnEspecial.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnEspecial.Location = new System.Drawing.Point(12, 240);
            this.btnEspecial.Name = "btnEspecial";
            this.btnEspecial.Size = new System.Drawing.Size(114, 24);
            this.btnEspecial.TabIndex = 8;
            this.btnEspecial.Text = "Nueva Especialidad";
            this.btnEspecial.UseVisualStyleBackColor = false;
            this.btnEspecial.Click += new System.EventHandler(this.btnEspecial_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleName = "";
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(305, 197);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 21);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // brnReiniciar
            // 
            this.brnReiniciar.AccessibleName = "";
            this.brnReiniciar.BackColor = System.Drawing.SystemColors.Control;
            this.brnReiniciar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.brnReiniciar.Location = new System.Drawing.Point(305, 170);
            this.brnReiniciar.Name = "brnReiniciar";
            this.brnReiniciar.Size = new System.Drawing.Size(75, 21);
            this.brnReiniciar.TabIndex = 12;
            this.brnReiniciar.Text = "Reiniciar";
            this.brnReiniciar.UseVisualStyleBackColor = false;
            this.brnReiniciar.Click += new System.EventHandler(this.brnReiniciar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(392, 309);
            this.Controls.Add(this.brnReiniciar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEspecial);
            this.Controls.Add(this.dgvInformacion);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cboEspecialidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica - Consulta";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvInformacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEspecial;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button brnReiniciar;
    }
}

