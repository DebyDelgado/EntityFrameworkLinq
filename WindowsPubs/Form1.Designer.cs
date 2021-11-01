
namespace WindowsPubs
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
            this.btnTraerTodosAutores = new System.Windows.Forms.Button();
            this.btnTraerTodosPublisher = new System.Windows.Forms.Button();
            this.TraerAutoresxCiudad = new System.Windows.Forms.Button();
            this.btnAutorxId = new System.Windows.Forms.Button();
            this.btnPublisherxName = new System.Windows.Forms.Button();
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.btnMismoPais = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblAutores = new System.Windows.Forms.Label();
            this.lblPublicadores = new System.Windows.Forms.Label();
            this.lblMostrarSales = new System.Windows.Forms.Label();
            this.btnMostrarEP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodosAutores
            // 
            this.btnTraerTodosAutores.Location = new System.Drawing.Point(15, 31);
            this.btnTraerTodosAutores.Name = "btnTraerTodosAutores";
            this.btnTraerTodosAutores.Size = new System.Drawing.Size(169, 23);
            this.btnTraerTodosAutores.TabIndex = 0;
            this.btnTraerTodosAutores.Text = "Traer todos los Autores";
            this.btnTraerTodosAutores.UseVisualStyleBackColor = true;
            this.btnTraerTodosAutores.Click += new System.EventHandler(this.btnTraerTodosAutores_Click);
            // 
            // btnTraerTodosPublisher
            // 
            this.btnTraerTodosPublisher.Location = new System.Drawing.Point(15, 261);
            this.btnTraerTodosPublisher.Name = "btnTraerTodosPublisher";
            this.btnTraerTodosPublisher.Size = new System.Drawing.Size(169, 23);
            this.btnTraerTodosPublisher.TabIndex = 1;
            this.btnTraerTodosPublisher.Text = "Traer todos los Publicadores";
            this.btnTraerTodosPublisher.UseVisualStyleBackColor = true;
            this.btnTraerTodosPublisher.Click += new System.EventHandler(this.btnTraerTodosPublisher_Click);
            // 
            // TraerAutoresxCiudad
            // 
            this.TraerAutoresxCiudad.Location = new System.Drawing.Point(405, 31);
            this.TraerAutoresxCiudad.Name = "TraerAutoresxCiudad";
            this.TraerAutoresxCiudad.Size = new System.Drawing.Size(190, 23);
            this.TraerAutoresxCiudad.TabIndex = 2;
            this.TraerAutoresxCiudad.Text = "Traer todos los Autores por Ciudad";
            this.TraerAutoresxCiudad.UseVisualStyleBackColor = true;
            this.TraerAutoresxCiudad.Click += new System.EventHandler(this.TraerAutoresxCiudad_Click);
            // 
            // btnAutorxId
            // 
            this.btnAutorxId.Location = new System.Drawing.Point(207, 31);
            this.btnAutorxId.Name = "btnAutorxId";
            this.btnAutorxId.Size = new System.Drawing.Size(169, 23);
            this.btnAutorxId.TabIndex = 3;
            this.btnAutorxId.Text = "Traer Autor por ID";
            this.btnAutorxId.UseVisualStyleBackColor = true;
            this.btnAutorxId.Click += new System.EventHandler(this.btnAutorxId_Click);
            // 
            // btnPublisherxName
            // 
            this.btnPublisherxName.Location = new System.Drawing.Point(207, 262);
            this.btnPublisherxName.Name = "btnPublisherxName";
            this.btnPublisherxName.Size = new System.Drawing.Size(169, 23);
            this.btnPublisherxName.TabIndex = 4;
            this.btnPublisherxName.Text = "Traer Publicador por Nombre";
            this.btnPublisherxName.UseVisualStyleBackColor = true;
            this.btnPublisherxName.Click += new System.EventHandler(this.btnPublisherxName_Click);
            // 
            // gridAutores
            // 
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Location = new System.Drawing.Point(15, 60);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.Size = new System.Drawing.Size(580, 173);
            this.gridAutores.TabIndex = 8;
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(678, 210);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(115, 23);
            this.btnMostrarLista.TabIndex = 9;
            this.btnMostrarLista.Text = "Mostrar Lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // gridPublisher
            // 
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Location = new System.Drawing.Point(15, 290);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.Size = new System.Drawing.Size(580, 173);
            this.gridPublisher.TabIndex = 10;
            // 
            // gridLista
            // 
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Location = new System.Drawing.Point(678, 245);
            this.gridLista.Name = "gridLista";
            this.gridLista.Size = new System.Drawing.Size(240, 117);
            this.gridLista.TabIndex = 11;
            // 
            // btnMismoPais
            // 
            this.btnMismoPais.Location = new System.Drawing.Point(799, 146);
            this.btnMismoPais.Name = "btnMismoPais";
            this.btnMismoPais.Size = new System.Drawing.Size(119, 23);
            this.btnMismoPais.TabIndex = 12;
            this.btnMismoPais.Text = "Mostrar Mismo País";
            this.btnMismoPais.UseVisualStyleBackColor = true;
            this.btnMismoPais.Click += new System.EventHandler(this.btnMismoPais_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(675, 130);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(147, 13);
            this.lblMostrar.TabIndex = 13;
            this.lblMostrar.Text = "Mostrar Employee/Publishers:";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Location = new System.Drawing.Point(30, 9);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(46, 13);
            this.lblAutores.TabIndex = 14;
            this.lblAutores.Text = "Autores:";
            // 
            // lblPublicadores
            // 
            this.lblPublicadores.AutoSize = true;
            this.lblPublicadores.Location = new System.Drawing.Point(30, 245);
            this.lblPublicadores.Name = "lblPublicadores";
            this.lblPublicadores.Size = new System.Drawing.Size(71, 13);
            this.lblPublicadores.TabIndex = 15;
            this.lblPublicadores.Text = "Publicadores:";
            // 
            // lblMostrarSales
            // 
            this.lblMostrarSales.AutoSize = true;
            this.lblMostrarSales.Location = new System.Drawing.Point(678, 189);
            this.lblMostrarSales.Name = "lblMostrarSales";
            this.lblMostrarSales.Size = new System.Drawing.Size(109, 13);
            this.lblMostrarSales.TabIndex = 16;
            this.lblMostrarSales.Text = "Mostrar Sales/Stores:";
            // 
            // btnMostrarEP
            // 
            this.btnMostrarEP.Location = new System.Drawing.Point(678, 146);
            this.btnMostrarEP.Name = "btnMostrarEP";
            this.btnMostrarEP.Size = new System.Drawing.Size(115, 23);
            this.btnMostrarEP.TabIndex = 17;
            this.btnMostrarEP.Text = "Mostrar Lista";
            this.btnMostrarEP.UseVisualStyleBackColor = true;
            this.btnMostrarEP.Click += new System.EventHandler(this.btnMostrarEP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 506);
            this.Controls.Add(this.btnMostrarEP);
            this.Controls.Add(this.lblMostrarSales);
            this.Controls.Add(this.lblPublicadores);
            this.Controls.Add(this.lblAutores);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnMismoPais);
            this.Controls.Add(this.gridLista);
            this.Controls.Add(this.gridPublisher);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.gridAutores);
            this.Controls.Add(this.btnPublisherxName);
            this.Controls.Add(this.btnAutorxId);
            this.Controls.Add(this.TraerAutoresxCiudad);
            this.Controls.Add(this.btnTraerTodosPublisher);
            this.Controls.Add(this.btnTraerTodosAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodosAutores;
        private System.Windows.Forms.Button btnTraerTodosPublisher;
        private System.Windows.Forms.Button TraerAutoresxCiudad;
        private System.Windows.Forms.Button btnAutorxId;
        private System.Windows.Forms.Button btnPublisherxName;
        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.DataGridView gridPublisher;
        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.Button btnMismoPais;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Label lblPublicadores;
        private System.Windows.Forms.Label lblMostrarSales;
        private System.Windows.Forms.Button btnMostrarEP;
    }
}

