using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Algebra
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Guardar()
        {
            FileStream stream = new FileStream(@"..\..\alumnos.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var alumno in alumnos)
            {
                writer.WriteLine(alumno.Año);
                writer.WriteLine(alumno.Carrera);
                writer.WriteLine(alumno.Nombre);
            }

            writer.Close();
        }
        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();

            alumno.Año = textBoxAño.Text;
            alumno.Carrera = comboBoxCarrera.SelectedItem.ToString();
            alumno.Nombre = textBoxNombre.Text;
            

            alumnos.Add(alumno);

            Guardar();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su Codigo es: 202014006");
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            bool igual = alumnos.Exists(a => a.Codigo == textBoxCodigo.Text);

            if (igual)
            {
                MessageBox.Show("El codigo es correcto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("El codigo es incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"..\..\alumnos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alumno alumno = new Alumno();
                alumno.Codigo = reader.ReadLine();
                

                alumnos.Add(alumno);
            }
            reader.Close();
        }
    }
}
