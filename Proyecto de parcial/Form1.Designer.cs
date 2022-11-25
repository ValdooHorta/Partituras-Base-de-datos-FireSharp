namespace Proyecto_de_parcial
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
            this.Crear = new System.Windows.Forms.Button();
            this.Leer = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.TextBox();
            this.Año = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(45, 221);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(75, 23);
            this.Crear.TabIndex = 0;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Leer
            // 
            this.Leer.Location = new System.Drawing.Point(164, 221);
            this.Leer.Name = "Leer";
            this.Leer.Size = new System.Drawing.Size(75, 23);
            this.Leer.TabIndex = 1;
            this.Leer.Text = "Leer";
            this.Leer.UseVisualStyleBackColor = true;
            this.Leer.Click += new System.EventHandler(this.Leer_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(164, 267);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 2;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(45, 267);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 3;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(130, 27);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 7;
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(130, 69);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(100, 20);
            this.Autor.TabIndex = 8;
            // 
            // Año
            // 
            this.Año.Location = new System.Drawing.Point(130, 118);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(100, 20);
            this.Año.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo";
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(130, 163);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 20);
            this.Codigo.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 317);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Leer);
            this.Controls.Add(this.Crear);
            this.Name = "Form1";
            this.Text = "Base de datos de Partituras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Leer;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.TextBox Año;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Codigo;
    }
}

