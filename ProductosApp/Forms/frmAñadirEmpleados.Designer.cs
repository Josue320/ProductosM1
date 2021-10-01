namespace ProductosApp.Forms
{
    partial class frmAñadirEmpleados
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
            this.cmbCategoriaDocente = new System.Windows.Forms.ComboBox();
            this.cmbTrabajador = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFechaContratacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.nudSalario = new System.Windows.Forms.NumericUpDown();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblCategoriaDocente = new System.Windows.Forms.Label();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.nudHorasExtras = new System.Windows.Forms.NumericUpDown();
            this.pnlHorasExtras = new System.Windows.Forms.Panel();
            this.pnlCategoriaDocente = new System.Windows.Forms.Panel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasExtras)).BeginInit();
            this.pnlHorasExtras.SuspendLayout();
            this.pnlCategoriaDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoriaDocente
            // 
            this.cmbCategoriaDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaDocente.FormattingEnabled = true;
            this.cmbCategoriaDocente.Items.AddRange(new object[] {
            "Titular",
            "Asistente Catedra",
            "AdjuntoA",
            "Encargado Catedra"});
            this.cmbCategoriaDocente.Location = new System.Drawing.Point(109, 5);
            this.cmbCategoriaDocente.Name = "cmbCategoriaDocente";
            this.cmbCategoriaDocente.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaDocente.TabIndex = 0;
            // 
            // cmbTrabajador
            // 
            this.cmbTrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrabajador.FormattingEnabled = true;
            this.cmbTrabajador.Items.AddRange(new object[] {
            "Docente",
            "Administrativo"});
            this.cmbTrabajador.Location = new System.Drawing.Point(119, 186);
            this.cmbTrabajador.Name = "cmbTrabajador";
            this.cmbTrabajador.Size = new System.Drawing.Size(121, 21);
            this.cmbTrabajador.TabIndex = 1;
            this.cmbTrabajador.SelectedIndexChanged += new System.EventHandler(this.CmbTrabajador_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombres";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(6, 84);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario";
            // 
            // lblFechaContratacion
            // 
            this.lblFechaContratacion.AutoSize = true;
            this.lblFechaContratacion.Location = new System.Drawing.Point(6, 148);
            this.lblFechaContratacion.Name = "lblFechaContratacion";
            this.lblFechaContratacion.Size = new System.Drawing.Size(100, 13);
            this.lblFechaContratacion.TabIndex = 5;
            this.lblFechaContratacion.Text = "Fecha Contratacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cedula";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCargo);
            this.groupBox1.Controls.Add(this.cmbTrabajador);
            this.groupBox1.Controls.Add(this.pnlHorasExtras);
            this.groupBox1.Controls.Add(this.pnlCategoriaDocente);
            this.groupBox1.Controls.Add(this.dtpFechaContratacion);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.nudSalario);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblFechaContratacion);
            this.groupBox1.Controls.Add(this.lblSalario);
            this.groupBox1.Location = new System.Drawing.Point(36, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 309);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtpFechaContratacion
            // 
            this.dtpFechaContratacion.Location = new System.Drawing.Point(118, 142);
            this.dtpFechaContratacion.Name = "dtpFechaContratacion";
            this.dtpFechaContratacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaContratacion.TabIndex = 11;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(118, 111);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 10;
            // 
            // nudSalario
            // 
            this.nudSalario.Location = new System.Drawing.Point(118, 82);
            this.nudSalario.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSalario.Name = "nudSalario";
            this.nudSalario.Size = new System.Drawing.Size(120, 20);
            this.nudSalario.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(118, 55);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(118, 26);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // lblCategoriaDocente
            // 
            this.lblCategoriaDocente.AutoSize = true;
            this.lblCategoriaDocente.Location = new System.Drawing.Point(3, 8);
            this.lblCategoriaDocente.Name = "lblCategoriaDocente";
            this.lblCategoriaDocente.Size = new System.Drawing.Size(94, 13);
            this.lblCategoriaDocente.TabIndex = 0;
            this.lblCategoriaDocente.Text = "Categoria docente";
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Location = new System.Drawing.Point(3, 5);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(66, 13);
            this.lblHorasExtras.TabIndex = 9;
            this.lblHorasExtras.Text = "Horas extras";
            // 
            // nudHorasExtras
            // 
            this.nudHorasExtras.Location = new System.Drawing.Point(110, 3);
            this.nudHorasExtras.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudHorasExtras.Name = "nudHorasExtras";
            this.nudHorasExtras.Size = new System.Drawing.Size(120, 20);
            this.nudHorasExtras.TabIndex = 10;
            // 
            // pnlHorasExtras
            // 
            this.pnlHorasExtras.Controls.Add(this.nudHorasExtras);
            this.pnlHorasExtras.Controls.Add(this.lblHorasExtras);
            this.pnlHorasExtras.Location = new System.Drawing.Point(9, 233);
            this.pnlHorasExtras.Name = "pnlHorasExtras";
            this.pnlHorasExtras.Size = new System.Drawing.Size(250, 49);
            this.pnlHorasExtras.TabIndex = 9;
            this.pnlHorasExtras.Visible = false;
            // 
            // pnlCategoriaDocente
            // 
            this.pnlCategoriaDocente.Controls.Add(this.cmbCategoriaDocente);
            this.pnlCategoriaDocente.Controls.Add(this.lblCategoriaDocente);
            this.pnlCategoriaDocente.Location = new System.Drawing.Point(9, 233);
            this.pnlCategoriaDocente.Name = "pnlCategoriaDocente";
            this.pnlCategoriaDocente.Size = new System.Drawing.Size(250, 49);
            this.pnlCategoriaDocente.TabIndex = 10;
            this.pnlCategoriaDocente.Visible = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(6, 189);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 8;
            this.lblCargo.Text = "Cargo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(51, 371);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // frmAñadirEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAñadirEmpleados";
            this.Text = "frmAñadirEmpleados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasExtras)).EndInit();
            this.pnlHorasExtras.ResumeLayout(false);
            this.pnlHorasExtras.PerformLayout();
            this.pnlCategoriaDocente.ResumeLayout(false);
            this.pnlCategoriaDocente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTrabajador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaContratacion;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.NumericUpDown nudSalario;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.ComboBox cmbCategoriaDocente;
        private System.Windows.Forms.Label lblCategoriaDocente;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.NumericUpDown nudHorasExtras;
        private System.Windows.Forms.Panel pnlHorasExtras;
        private System.Windows.Forms.Panel pnlCategoriaDocente;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnAceptar;
    }
}