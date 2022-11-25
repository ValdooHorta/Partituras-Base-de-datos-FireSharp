using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Proyecto_de_parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "UcYVVtG7ckMXbVQo6g1lrvSnVTC4pmQXlaN9GeBJ",
            BasePath = "https://mizuno-3f764-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Existe un problema en la conexión de la internet");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mizuno std = new Mizuno
            {
                Nombre = Nombre.Text,
                Codigo = Codigo.Text,
                Autor = Autor.Text,
                Año = Año.Text
            };
            var setter = client.Set("ListaPartituras/" + Codigo.Text, std);
            Nombre.Text = "";
            Codigo.Text = "";
            Autor.Text = "";
            Año.Text = "";
            MessageBox.Show("Datos insertados correctamente");
        }

        private void Leer_Click(object sender, EventArgs e)
        {
            var resultado = client.Get("ListaPartituras/" + Codigo.Text);
            Mizuno std = resultado.ResultAs<Mizuno>();
            Nombre.Text = std.Nombre;
            Autor.Text = std.Autor;
            Año.Text = std.Año;
            MessageBox.Show("Datos encontrados en la base de datos.");
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Mizuno std = new Mizuno
            {
                Nombre = Nombre.Text,
                Codigo = Codigo.Text,
                Autor = Autor.Text,
                Año = Año.Text
            };
            var setter = client.Update("ListaPartituras/" + Codigo.Text, std);
            Nombre.Text = "";
            Codigo.Text = "";
            Autor.Text = "";
            Año.Text = "";
            MessageBox.Show("Datos actualizados correctamente");
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            var resultado = client.Delete("ListaPartituras/" + Codigo.Text);
            Nombre.Text = "";
            Codigo.Text = "";
            Autor.Text = "";
            Año.Text = "";
            MessageBox.Show("Datos eliminados correctamente");
        }
    }
}
