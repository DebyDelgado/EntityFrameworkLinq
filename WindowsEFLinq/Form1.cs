using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFLinq.Data;

namespace WindowsEFLinq
{
    public partial class Form1 : Form
    {
        //crear una instancia del dbcontext
        NorthwindContext context = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            //traer todos
            var lista = (from p in context.Products
                         select p).ToList();


            gridProductos.DataSource = lista;
        }

        private void btnTraerPorCategoria_Click(object sender, EventArgs e)
        {
            //trae todos los productos con categoria 2
            int categoriaId = 2;

            var lista = (from p in context.Products
                         where p.CategoryID==categoriaId
                         select p).ToList();
            gridProductos.DataSource = lista;

        }

        private void btnTraerPorNombreProduct_Click(object sender, EventArgs e)
        {
            //trae el producto hardcodeado y el precio
            string producto = "Queso Cabrales";
            var product = (from p in context.Products
                            where p.ProductName == producto
                            select p).SingleOrDefault();
            //lo muestra en message box porque la grid no muestra un objeto (product)
            MessageBox.Show(product.ProductName + " " + product.UnitPrice.ToString());

        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            int id = 2;
            var producto = (from p in context.Products
                            where p.ProductID == id
                            select p).SingleOrDefault();
            MessageBox.Show(producto.ProductName + " " + producto.UnitPrice.ToString());
        }

        private void btnTraerProductoCategoria_Click(object sender, EventArgs e)
        {
            //muestra 4 columnas (id, name cat, name prod y precio)
            var lista = (
                from c in context.Categories
                join
                p in context.Products
                on c.CategoryID equals p.CategoryID
                select new
                {
                    c.CategoryID, 
                    //le podes modificar el nombre de la lista (nombrequequieras=c.CategoryX)
                    Category=c.CategoryName,
                    Product=p.ProductName, 
                    p.UnitPrice
                }
                ).ToList();


            gridProductos.DataSource = lista;
        }
    }
}
