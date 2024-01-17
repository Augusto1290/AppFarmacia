using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProgramcionIIIAugustoLorenzo
{
    public interface IForm
    {
        void transferir(string labo);

        void transferirId(int id);
    }
    public partial class NuevoMedicamento : Form, IForm
    {
        

        private string fecha(DateTime fecha)
        {
            return fecha.Month + "/" + fecha.Day + "/" + fecha.Year;
        }
        ListadoDeLaboratorios listadoDeLaboratorios = new ListadoDeLaboratorios();

        public bool validar()
        {
            bool todoOK=true;
            if(todoOK)
            {
                todoOK = false;
                if (txtCodigo.Text.Trim()==string.Empty)
                {
                    MessageBox.Show("Debe ingresar un valor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    todoOK = true;
                }
            }
            if (todoOK)
            {
                todoOK = false;
                if (txtDes.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar una cadena", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    todoOK = true;
                }
            }
            if (todoOK)
            {
                todoOK = false;
                int valor = 0;
                if (txtPc.Text.Trim() == string.Empty)
                {
                    todoOK = false;
                    MessageBox.Show("Debe ingresar un valor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.TryParse(txtPc.Text, out valor))
                    {
                        if (valor > 0)
                        {
                            todoOK = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar un valor mayor a cero", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un valor numerico", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  }
                   
                }
            if(todoOK)
            {
                todoOK = false;
                int valor = 0;
                if (txtPv.Text.Trim() == string.Empty)
                {
                   
                    MessageBox.Show("Debe ingresar un valor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.TryParse(txtPv.Text, out valor))
                    {
                        if (valor > 0)
                        {
                            todoOK = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar un valor mayor a cero", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un valor numerico", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if(todoOK)
            {
                todoOK = false;
                if (int.Parse(txtPc.Text)>int.Parse(txtPv.Text))
                {
                    
                    MessageBox.Show("El Precio de venta debe ser mayor al de compra", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    todoOK=true;
                }
            }

            return todoOK;  
        }
        public NuevoMedicamento()
        {
            InitializeComponent();
        }

        private void NuevoMedicamento_Load(object sender, EventArgs e)
        {
            dtp.MaxDate = DateTime.Today;

            txtCodigo.MaxLength = 6;
            txtDes.MaxLength = 50;

            cbxFormato.Items.Add("Comprimidos");
            cbxFormato.Items.Add("Ampollas");
            cbxFormato.Items.Add("Solucion");
            cbxFormato.SelectedValue = 0;
            cbxFormato.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           

            listadoDeLaboratorios.Show(this);
        }
        
        public void transferir (string labo)
        {
            lblLaboratorioSelect.Text=labo;
        }
        int id;
        public void transferirId(int idSelect)
        {
            id = idSelect;
        }

       
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
               
                string fechaPost = fecha(dtp.Value);
               
                Libreria.Ejecutar("insert into Medicamentos (Codigo,Descripcion,FechaLanzamiento,Formato,PrecioCosto,PrecioVenta,IdLaboratorio)values('" + txtCodigo.Text + "','" + txtDes.Text + "','" + fechaPost + "','" + cbxFormato.SelectedValue + "'," + txtPc.Text + "," + txtPv.Text + "," + id + ")");
            }
        }

        private void NuevoMedicamento_Activated(object sender, EventArgs e)
        {
            lblLaboratorioSelect.Text=listadoDeLaboratorios.NombreLabo;
        }
    }
}
