using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjPromedio
{
    public partial class FrmPromedio : Form
    {
        public FrmPromedio()
        {
            InitializeComponent();
        }
        ClPromedio obj = new ClPromedio();
        bool Verdad = true;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtEstudiante.Text.Trim();
            if (String.IsNullOrWhiteSpace(txtEstudiante.Text) || String.IsNullOrWhiteSpace(txtNota1.Text) || String.IsNullOrWhiteSpace(txtNota2.Text)
              || String.IsNullOrWhiteSpace(txtNota3.Text) || String.IsNullOrWhiteSpace(txtNota4.Text))
            {
                MessageBox.Show("Por favor ingrese datos en todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Limpiar();
                return;
                
            }
          
            Validacion();
                Resultados();
                Ejecutador();
           

        }

        private void Ejecutador()
        {
            txtEstudiante.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;
            txtNota3.Enabled = false;
            txtNota4.Enabled = false;

            txtCondicion.Enabled = false;
            txtPromedio.Enabled = false;
            txtMinimo.Enabled = false;
            btnCalcular.Enabled = false;
            btnLimpiar.Enabled = true;
        }

        private void Resultados()
        {
            if (String.IsNullOrWhiteSpace(txtEstudiante.Text) || String.IsNullOrWhiteSpace(txtNota1.Text) || String.IsNullOrWhiteSpace(txtNota2.Text)
             || String.IsNullOrWhiteSpace(txtNota3.Text) || String.IsNullOrWhiteSpace(txtNota4.Text))
            {

                return;
            }
            
           
            obj.nota1 = Convert.ToDouble(txtNota1.Text);
            obj.nota2 = Convert.ToDouble(txtNota2.Text);
            obj.nota3 = Convert.ToDouble(txtNota3.Text);
            obj.nota4 = Convert.ToDouble(txtNota4.Text);

            obj.NotaMinima();
            obj.CondicionNota();
            txtPromedio.Text = Convert.ToString(obj.PromedioNota());
            txtCondicion.Text = Convert.ToString(obj.CondicionNota());
            txtMinimo.Text = Convert.ToString(obj.NotaMinima());
        }

        private void Validacion()
        {
         


            if (Convert.ToDouble(txtNota1.Text) > 100 || Convert.ToDouble(txtNota2.Text) > 100 || Convert.ToDouble(txtNota3.Text) > 100 || Convert.ToDouble(txtNota4.Text) > 100)
            {
                MessageBox.Show("Los datos deben ser menor a 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Ejecutador2();

        }

        private void Ejecutador2()
        {
            txtEstudiante.Enabled = true;
            txtNota1.Enabled = true;
            txtNota2.Enabled = true;
            txtNota3.Enabled = true;
            txtNota4.Enabled = true;

            txtCondicion.Enabled = true;
            txtPromedio.Enabled = true;
            txtMinimo.Enabled = true;
            btnCalcular.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void Limpiar()
        {
            txtEstudiante.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtCondicion.Text = "";
            txtPromedio.Text = "";
            txtMinimo.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("¿Está seguro que dese salir?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }
    }

}
