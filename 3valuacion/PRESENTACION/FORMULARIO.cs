using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3valuacion.CAPADATOS;



namespace _3valuacion.PRESENTACION
{
    public partial class FORMULARIO : Form
    {
        ClsEmpresas clsEmpresas = new ClsEmpresas();
        public FORMULARIO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FORMULARIO_Load(object sender, EventArgs e)
        {
            ListarIblEmpresas(); 
        }

            private void ListarIblEmpresas()
        {
            ClsEmpresas objProd = new ClsEmpresas();
            cmbCodigo.DataSource = objProd.ListarEmpresas();
            cmbCodigo.DisplayMember = "EmpresaCodigo";
            cmbCodigo.ValueMember = "Nombre";

        }
            private void ListarCodigo()  {   
            ClsEmpresas objPro = new ClsEmpresas();
            cmbCodigo.DisplayMember = "Codigo";
            cmbCodigo.ValueMember = "IDEmpresa";

                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objEmpresas.InsertarCodigo( Convert.ToInt32(cmbCodigo.SelectedValue),Convert.ToInt32(CmbNombre.SelectedValue);

        }
    }
}
