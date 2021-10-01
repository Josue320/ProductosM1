using Domain.Entities.Empleados;
using Domain.Enums;
using Infraestructure.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Forms
{
    public partial class frmAñadirEmpleados : Form
    {
        public EmpleadoModel empleadoM { get; set; }
        public frmAñadirEmpleados()
        {
            InitializeComponent();
        }

        private void CmbTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTrabajador.SelectedIndex)
            {
                case 0:
                    pnlCategoriaDocente.Visible = true;
                    pnlHorasExtras.Visible = false;
                    break;
                case 1:
                    pnlCategoriaDocente.Visible = false;
                    pnlHorasExtras.Visible = true;
                    break;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            switch (cmbTrabajador.SelectedIndex)
            {
                case 0:
                    Rellenar();
                    Docente d = new Docente()
                    {
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text,
                        Cedula = txtCedula.Text,
                        FechaContratacion = dtpFechaContratacion.Value,
                        Salario = nudSalario.Value,
                        CategoriaDocente = (CategoriaDocente)cmbCategoriaDocente.SelectedIndex
                    };
                    empleadoM.Create(d);
                    break;
                case 1:
                    Rellenar();
                    Administrativo a = new Administrativo()
                    {
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text,
                        Cedula = txtCedula.Text,
                        FechaContratacion = dtpFechaContratacion.Value,
                        Salario = nudSalario.Value,
                        Id = empleadoM.GetLastEmpleadoId()+1
                    };
                    empleadoM.Create(a);
                    break;
            }
        }
        private void Rellenar()
        {
            if (txtApellidos.Text == "" || txtCedula.Text == "" || txtNombres.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos.",
                               "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
