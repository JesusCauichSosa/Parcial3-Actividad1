using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Actividad_1.Domain;

namespace Actividad_1
{
    public partial class Form1 : Form
    {
        private ArbolBusquedaBinario arbol = new ArbolBusquedaBinario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var libro = new Libro()
            {
                ISBN = txtISBN.Text,
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text
            };
            arbol.Insertar(libro);
            txtISBN.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtISBN.Focus();
            txtListado.Clear();
            txtListado.Text = arbol.Listar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            arbol.Eliminar(txtISBN.Text);
            txtISBN.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtISBN.Focus();

            txtListado.Clear();
            txtListado.Text = arbol.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtListado.Clear();

            var libro = arbol.buscar(txtISBN.Text);
            if (libro != null)
            {
                txtListado.Text = $"Titulo: {libro.Titulo} - Autor: {libro.Autor}";

            }
            else
            {
                MessageBox.Show("No se encontró el libro");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
