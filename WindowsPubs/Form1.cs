using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPubs.Data;

namespace WindowsPubs
{
    public partial class Form1 : Form
    {
        //crear una instancia del dbcontext
        PubContext context = new PubContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodosAutores_Click(object sender, EventArgs e)
        {
            //traer todos
            var lista = (from a in context.authors
                         select a).ToList();


            gridAutores.DataSource = lista;
        }

        private void btnTraerTodosPublisher_Click(object sender, EventArgs e)
        {
            var lista = (from p in context.publishers
                         select p).ToList();


            gridPublisher.DataSource = lista;
        }

        private void TraerAutoresxCiudad_Click(object sender, EventArgs e)
        {
            //trae todos los autores por ciudad oakland
            string autoresCiudad = "Oakland";

            var lista = (from a in context.authors
                         where a.city == autoresCiudad
                         select a).ToList();
            gridAutores.DataSource = lista;

        }

        private void btnAutorxId_Click(object sender, EventArgs e)
        {
            //trae todos los autores con categoria 213-46-8915
            string categoriaId = "213-46-8915";

            var lista = (from a in context.authors
                         where a.au_id == categoriaId
                         select a).ToList();
            gridAutores.DataSource = lista;
        }

        private void btnPublisherxName_Click(object sender, EventArgs e)
        {
            string publisherName = "New Moon Books";

            var lista = (from p in context.publishers
                         where p.pub_name == publisherName
                         select p).ToList();
            gridPublisher.DataSource = lista;

        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {

            //muestra 4 columnas (id, name cat, name prod y precio)
            var lista = (
                from sale in context.sales
                join
                store in context.stores
                on sale.stor_id equals store.stor_id
                select new
                {
                    IDTienda=sale.stor_id,
                    //le podes modificar el nombre de la lista (nombrequequieras=c.CategoryX)
                    NombreTienda = store.stor_name,
                    Ciudad = store.city,
                    NroOrden = sale.ord_num,
                    Fecha = sale.ord_date,
                    Cantidad= sale.qty,
                    IdTItulo= sale.title_id
                }
                ).ToList();


            gridLista.DataSource = lista;

        }

        private void btnMismoPais_Click(object sender, EventArgs e)
        {
            string pais = "Germany";
            
            var lista = (
                        from
                        employee in context.employees
                        join
                        publisher in context.publishers
                        on employee.pub_id equals publisher.pub_id
                        where publisher.country == pais
                        select new
                        {
                            Nombre = employee.fname,
                            Apellido = employee.lname,
                            Publicador = publisher.pub_name,
                        }
                ).ToList();

            gridLista.DataSource = lista;



        }

        private void btnMostrarEP_Click(object sender, EventArgs e)
        {
            var lista = (
               from employee in context.employees
               join
               publisher in context.publishers
               on employee.pub_id equals  publisher.pub_id
               select new
               {
                 
                   
                   NombreEmployee = employee.lname,
                   ApellidoEmployee = employee.fname,
                   NombrePublisher = publisher.pub_name,
                   
               }
               ).ToList();


            gridLista.DataSource = lista;
        }
    }
}
