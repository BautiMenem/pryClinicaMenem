namespace pryClinicaMenem
{
    partial class frmMedico
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
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.lblNumeroIden = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumeroMat = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(130, 152);
            this.txtIdent.MaxLength = 10;
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(100, 20);
            this.txtIdent.TabIndex = 27;
            // 
            // lblNumeroIden
            // 
            this.lblNumeroIden.AutoSize = true;
            this.lblNumeroIden.Location = new System.Drawing.Point(22, 155);
            this.lblNumeroIden.Name = "lblNumeroIden";
            this.lblNumeroIden.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroIden.TabIndex = 26;
            this.lblNumeroIden.Text = "Nro Identificacion";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(261, 198);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(261, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnRegistrar.Location = new System.Drawing.Point(261, 72);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(130, 72);
            this.txtMatricula.MaxLength = 10;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 21;
            // 
            // lblNumeroMat
            // 
            this.lblNumeroMat.AutoSize = true;
            this.lblNumeroMat.Location = new System.Drawing.Point(22, 77);
            this.lblNumeroMat.Name = "lblNumeroMat";
            this.lblNumeroMat.Size = new System.Drawing.Size(70, 13);
            this.lblNumeroMat.TabIndex = 20;
            this.lblNumeroMat.Text = "Nro Matricula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(110, 18);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(134, 24);
            this.lblMedico.TabIndex = 18;
            this.lblMedico.Text = "Nuevo Medico";
            this.lblMedico.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(367, 233);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.lblNumeroIden);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNumeroMat);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMedico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica - Nuevo Médico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.Label lblNumeroIden;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumeroMat;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMedico;
    }
}