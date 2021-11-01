
namespace WindowsEFLinq
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.btnTraerPorCategoria = new System.Windows.Forms.Button();
            this.btnTraerPorNombreProduct = new System.Windows.Forms.Button();
            this.btnTraerPorId = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.btnTraerProductoCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(144, 114);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(283, 23);
            this.btnTraerTodos.TabIndex = 0;
            this.btnTraerTodos.Text = "Traer todos los Products";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // btnTraerPorCategoria
            // 
            this.btnTraerPorCategoria.Location = new System.Drawing.Point(144, 168);
            this.btnTraerPorCategoria.Name = "btnTraerPorCategoria";
            this.btnTraerPorCategoria.Size = new System.Drawing.Size(283, 23);
            this.btnTraerPorCategoria.TabIndex = 1;
            this.btnTraerPorCategoria.Text = "Traer todos los Products x categoria";
            this.btnTraerPorCategoria.UseVisualStyleBackColor = true;
            this.btnTraerPorCategoria.Click += new System.EventHandler(this.btnTraerPorCategoria_Click);
            // 
            // btnTraerPorNombreProduct
            // 
            this.btnTraerPorNombreProduct.Location = new System.Drawing.Point(144, 216);
            this.btnTraerPorNombreProduct.Name = "btnTraerPorNombreProduct";
            this.btnTraerPorNombreProduct.Size = new System.Drawing.Size(283, 23);
            this.btnTraerPorNombreProduct.TabIndex = 2;
            this.btnTraerPorNombreProduct.Text = "Traer por Product Name";
            this.btnTraerPorNombreProduct.UseVisualStyleBackColor = true;
            this.btnTraerPorNombreProduct.Click += new System.EventHandler(this.btnTraerPorNombreProduct_Click);
            // 
            // btnTraerPorId
            // 
            this.btnTraerPorId.Location = new System.Drawing.Point(144, 262);
            this.btnTraerPorId.Name = "btnTraerPorId";
            this.btnTraerPorId.Size = new System.Drawing.Size(283, 23);
            this.btnTraerPorId.TabIndex = 3;
            this.btnTraerPorId.Text = "Traer Product por ID";
            this.btnTraerPorId.UseVisualStyleBackColor = true;
            this.btnTraerPorId.Click += new System.EventHandler(this.btnTraerPorId_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(63, 321);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(447, 171);
            this.gridProductos.TabIndex = 4;
            // 
            // btnTraerProductoCategoria
            // 
            this.btnTraerProductoCategoria.Location = new System.Drawing.Point(144, 62);
            this.btnTraerProductoCategoria.Name = "btnTraerProductoCategoria";
            this.btnTraerProductoCategoria.Size = new System.Drawing.Size(283, 23);
            this.btnTraerProductoCategoria.TabIndex = 5;
            this.btnTraerProductoCategoria.Text = "Traer Producto Categoria";
            this.btnTraerProductoCategoria.UseVisualStyleBackColor = true;
            this.btnTraerProductoCategoria.Click += new System.EventHandler(this.btnTraerProductoCategoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btnTraerProductoCategoria);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnTraerPorId);
            this.Controls.Add(this.btnTraerPorNombreProduct);
            this.Controls.Add(this.btnTraerPorCategoria);
            this.Controls.Add(this.btnTraerTodos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.Button btnTraerPorCategoria;
        private System.Windows.Forms.Button btnTraerPorNombreProduct;
        private System.Windows.Forms.Button btnTraerPorId;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button btnTraerProductoCategoria;
    }
}

