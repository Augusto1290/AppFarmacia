namespace FinalProgramcionIIIAugustoLorenzo
{
    partial class NuevoMedicamento
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbxFormato = new System.Windows.Forms.ComboBox();
            this.txtPc = new System.Windows.Forms.TextBox();
            this.txtPv = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.Label();
            this.lblPc = new System.Windows.Forms.Label();
            this.lblPv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLabo = new System.Windows.Forms.Label();
            this.lblLaboratorioSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(280, 80);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(280, 128);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(218, 22);
            this.txtDes.TabIndex = 1;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(280, 182);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(118, 22);
            this.dtp.TabIndex = 2;
            // 
            // cbxFormato
            // 
            this.cbxFormato.FormattingEnabled = true;
            this.cbxFormato.Location = new System.Drawing.Point(271, 233);
            this.cbxFormato.Name = "cbxFormato";
            this.cbxFormato.Size = new System.Drawing.Size(209, 24);
            this.cbxFormato.TabIndex = 3;
            // 
            // txtPc
            // 
            this.txtPc.Location = new System.Drawing.Point(271, 287);
            this.txtPc.Name = "txtPc";
            this.txtPc.Size = new System.Drawing.Size(144, 22);
            this.txtPc.TabIndex = 4;
            // 
            // txtPv
            // 
            this.txtPv.Location = new System.Drawing.Point(271, 338);
            this.txtPv.Name = "txtPv";
            this.txtPv.Size = new System.Drawing.Size(144, 22);
            this.txtPv.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(612, 397);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(101, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(333, 445);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 40);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(211, 86);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(183, 134);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(82, 16);
            this.lblDes.TabIndex = 9;
            this.lblDes.Text = "Descripcion:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AutoSize = true;
            this.dtpFecha.Location = new System.Drawing.Point(217, 187);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(48, 16);
            this.dtpFecha.TabIndex = 10;
            this.dtpFecha.Text = "Fecha:";
            // 
            // lblPc
            // 
            this.lblPc.AutoSize = true;
            this.lblPc.Location = new System.Drawing.Point(178, 287);
            this.lblPc.Name = "lblPc";
            this.lblPc.Size = new System.Drawing.Size(87, 16);
            this.lblPc.TabIndex = 11;
            this.lblPc.Text = "Precio Costo:";
            // 
            // lblPv
            // 
            this.lblPv.AutoSize = true;
            this.lblPv.Location = new System.Drawing.Point(178, 344);
            this.lblPv.Name = "lblPv";
            this.lblPv.Size = new System.Drawing.Size(87, 16);
            this.lblPv.TabIndex = 12;
            this.lblPv.Text = "Precio Venta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Formato:";
            // 
            // lblLabo
            // 
            this.lblLabo.AutoSize = true;
            this.lblLabo.Location = new System.Drawing.Point(178, 400);
            this.lblLabo.Name = "lblLabo";
            this.lblLabo.Size = new System.Drawing.Size(79, 16);
            this.lblLabo.TabIndex = 14;
            this.lblLabo.Text = "Laboratorio:";
            // 
            // lblLaboratorioSelect
            // 
            this.lblLaboratorioSelect.AutoSize = true;
            this.lblLaboratorioSelect.Location = new System.Drawing.Point(264, 397);
            this.lblLaboratorioSelect.Name = "lblLaboratorioSelect";
            this.lblLaboratorioSelect.Size = new System.Drawing.Size(0, 16);
            this.lblLaboratorioSelect.TabIndex = 15;
            // 
            // NuevoMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.lblLaboratorioSelect);
            this.Controls.Add(this.lblLabo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPv);
            this.Controls.Add(this.lblPc);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtPv);
            this.Controls.Add(this.txtPc);
            this.Controls.Add(this.cbxFormato);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtCodigo);
            this.Name = "NuevoMedicamento";
            this.Text = "Nuevo Medicamento";
            this.Activated += new System.EventHandler(this.NuevoMedicamento_Activated);
            this.Load += new System.EventHandler(this.NuevoMedicamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cbxFormato;
        private System.Windows.Forms.TextBox txtPc;
        private System.Windows.Forms.TextBox txtPv;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label dtpFecha;
        private System.Windows.Forms.Label lblPc;
        private System.Windows.Forms.Label lblPv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLabo;
        private System.Windows.Forms.Label lblLaboratorioSelect;
    }
}

