using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalGabriel
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        double numero2 = 0;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {// Fondo
            this.BackColor = Color.LightSteelBlue;

            // Título
            label1.Font = new Font("Arial Black", 20, FontStyle.Bold);
            label1.ForeColor = Color.Navy;

            // Editor
            txtEditor.Font = new Font("Consolas", 12);

            // Calculadora
            txtCalculadora.Font = new Font("Arial", 14, FontStyle.Bold);
            txtCalculadora.TextAlign = HorizontalAlignment.Right;

            // Paint
            panelPaint.BorderStyle = BorderStyle.FixedSingle;

            // Botones principales
            btnEditor.FlatStyle = FlatStyle.Flat;
            btnPaint.FlatStyle = FlatStyle.Flat;
            btnCalculadora.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatStyle = FlatStyle.Flat;

            btnEditor.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnPaint.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCalculadora.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnSalir.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Botones del editor
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatStyle = FlatStyle.Flat;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        // =========================
        // PAINT
        // =========================

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColores.Text == "Rojo")
                panelPaint.BackColor = Color.Red;

            if (cmbColores.Text == "Azul")
                panelPaint.BackColor = Color.Blue;

            if (cmbColores.Text == "Verde")
                panelPaint.BackColor = Color.Green;

            if (cmbColores.Text == "Amarillo")
                panelPaint.BackColor = Color.Yellow;
        }

        // =========================
        // EDITOR
        // =========================

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
            MessageBox.Show("Nuevo documento creado");
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Archivo de texto|*.txt";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(
                    guardar.FileName,
                    txtEditor.Text
                );

                MessageBox.Show("Archivo guardado correctamente");
            }
        }

        // =========================
        // CALCULADORA
        // =========================

        private void button1_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "0";
        }

        // +
        private void button11_Click(object sender, EventArgs e)
        {
            if (txtCalculadora.Text == "") return;

            numero1 = Convert.ToDouble(txtCalculadora.Text);
            operacion = "+";
            txtCalculadora.Clear();
        }

        // -
        private void button12_Click(object sender, EventArgs e)
        {
            if (txtCalculadora.Text == "") return;

            numero1 = Convert.ToDouble(txtCalculadora.Text);
            operacion = "-";
            txtCalculadora.Clear();
        }

        // *
        private void button13_Click(object sender, EventArgs e)
        {
            if (txtCalculadora.Text == "") return;

            numero1 = Convert.ToDouble(txtCalculadora.Text);
            operacion = "*";
            txtCalculadora.Clear();
        }

        // C
        private void button14_Click(object sender, EventArgs e)
        {
            txtCalculadora.Clear();
            numero1 = 0;
            numero2 = 0;
            operacion = "";
        }

        // =
        private void button15_Click(object sender, EventArgs e)
        {
            if (txtCalculadora.Text == "") return;

            numero2 = Convert.ToDouble(txtCalculadora.Text);

            switch (operacion)
            {
                case "+":
                    txtCalculadora.Text = (numero1 + numero2).ToString();
                    break;

                case "-":
                    txtCalculadora.Text = (numero1 - numero2).ToString();
                    break;

                case "*":
                    txtCalculadora.Text = (numero1 * numero2).ToString();
                    break;

                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        txtCalculadora.Clear();
                        return;
                    }

                    txtCalculadora.Text = (numero1 / numero2).ToString();
                    break;
            }
        }

        // /
        private void button16_Click(object sender, EventArgs e)
        {
            if (txtCalculadora.Text == "") return;

            numero1 = Convert.ToDouble(txtCalculadora.Text);
            operacion = "/";
            txtCalculadora.Clear();
        }

        // =========================
        // SALIR
        // =========================

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {

        }
    }
}