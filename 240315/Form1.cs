using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240315
{
    public partial class Form1 : Form
    {
        Random gen = new Random();
        Nodo inicio;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Nodo nuevo = new Nodo(gen.Next(100));
            agregar(nuevo);
        }

        private void agregar(Nodo nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
                agregar(inicio, nuevo);
        }
         
        private void agregar(Nodo ultimo, Nodo nuevo)
        {
            if (ultimo.Siguiente == null)
                ultimo.Siguiente = nuevo;
            else
                agregar(ultimo.Siguiente, nuevo);
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = mostrar();
        }

        private string mostrar()
        {
            string cadenita = "";
            if(inicio != null)
                cadenita = mostrar(inicio);
            return cadenita;
        }

        private string mostrar(Nodo nodo)
        {
            string cadenita = "";
            if (nodo.Siguiente == null)
                cadenita += nodo.ToString();
            else
                cadenita += nodo.ToString() + Environment.NewLine + mostrar(nodo.Siguiente);
            return cadenita;
        }
    }
}
