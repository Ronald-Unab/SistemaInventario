namespace CapaPresentacion
{
    partial class FActualizarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoriaIdLabel;
            System.Windows.Forms.Label codigoInternoLabel;
            System.Windows.Forms.Label marcaIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label productoIdLabel;
            System.Windows.Forms.Label proveedorIdLabel;
            this.categoriaIdTextBox = new System.Windows.Forms.TextBox();
            this.codigoInternoTextBox = new System.Windows.Forms.TextBox();
            this.marcaIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.productoIdTextBox = new System.Windows.Forms.TextBox();
            this.proveedorIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            categoriaIdLabel = new System.Windows.Forms.Label();
            codigoInternoLabel = new System.Windows.Forms.Label();
            marcaIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            productoIdLabel = new System.Windows.Forms.Label();
            proveedorIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(54, 172);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(66, 13);
            categoriaIdLabel.TabIndex = 10;
            categoriaIdLabel.Text = "categoria Id:";
            // 
            // categoriaIdTextBox
            // 
            this.categoriaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "categoriaId", true));
            this.categoriaIdTextBox.Location = new System.Drawing.Point(138, 169);
            this.categoriaIdTextBox.Name = "categoriaIdTextBox";
            this.categoriaIdTextBox.Size = new System.Drawing.Size(234, 20);
            this.categoriaIdTextBox.TabIndex = 11;
            // 
            // codigoInternoLabel
            // 
            codigoInternoLabel.AutoSize = true;
            codigoInternoLabel.Location = new System.Drawing.Point(54, 42);
            codigoInternoLabel.Name = "codigoInternoLabel";
            codigoInternoLabel.Size = new System.Drawing.Size(78, 13);
            codigoInternoLabel.TabIndex = 0;
            codigoInternoLabel.Text = "codigo Interno:";
            // 
            // codigoInternoTextBox
            // 
            this.codigoInternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "codigoInterno", true));
            this.codigoInternoTextBox.Location = new System.Drawing.Point(138, 39);
            this.codigoInternoTextBox.Name = "codigoInternoTextBox";
            this.codigoInternoTextBox.Size = new System.Drawing.Size(234, 20);
            this.codigoInternoTextBox.TabIndex = 1;
            // 
            // marcaIdLabel
            // 
            marcaIdLabel.AutoSize = true;
            marcaIdLabel.Location = new System.Drawing.Point(54, 68);
            marcaIdLabel.Name = "marcaIdLabel";
            marcaIdLabel.Size = new System.Drawing.Size(51, 13);
            marcaIdLabel.TabIndex = 2;
            marcaIdLabel.Text = "marca Id:";
            // 
            // marcaIdTextBox
            // 
            this.marcaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "marcaId", true));
            this.marcaIdTextBox.Location = new System.Drawing.Point(138, 65);
            this.marcaIdTextBox.Name = "marcaIdTextBox";
            this.marcaIdTextBox.Size = new System.Drawing.Size(234, 20);
            this.marcaIdTextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(54, 94);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(138, 91);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(234, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // productoIdLabel
            // 
            productoIdLabel.AutoSize = true;
            productoIdLabel.Location = new System.Drawing.Point(54, 120);
            productoIdLabel.Name = "productoIdLabel";
            productoIdLabel.Size = new System.Drawing.Size(64, 13);
            productoIdLabel.TabIndex = 6;
            productoIdLabel.Text = "producto Id:";
            // 
            // productoIdTextBox
            // 
            this.productoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "productoId", true));
            this.productoIdTextBox.Location = new System.Drawing.Point(138, 117);
            this.productoIdTextBox.Name = "productoIdTextBox";
            this.productoIdTextBox.Size = new System.Drawing.Size(234, 20);
            this.productoIdTextBox.TabIndex = 7;
            // 
            // proveedorIdLabel
            // 
            proveedorIdLabel.AutoSize = true;
            proveedorIdLabel.Location = new System.Drawing.Point(54, 146);
            proveedorIdLabel.Name = "proveedorIdLabel";
            proveedorIdLabel.Size = new System.Drawing.Size(70, 13);
            proveedorIdLabel.TabIndex = 8;
            proveedorIdLabel.Text = "proveedor Id:";
            // 
            // proveedorIdTextBox
            // 
            this.proveedorIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "proveedorId", true));
            this.proveedorIdTextBox.Location = new System.Drawing.Point(138, 143);
            this.proveedorIdTextBox.Name = "proveedorIdTextBox";
            this.proveedorIdTextBox.Size = new System.Drawing.Size(234, 20);
            this.proveedorIdTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CapaPresentacion.Entidades.Producto);
            // 
            // FActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 323);
            this.Controls.Add(this.categoriaIdTextBox);
            this.Controls.Add(this.proveedorIdTextBox);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(proveedorIdLabel);
            this.Controls.Add(this.marcaIdTextBox);
            this.Controls.Add(this.productoIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(codigoInternoLabel);
            this.Controls.Add(marcaIdLabel);
            this.Controls.Add(productoIdLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.codigoInternoTextBox);
            this.Name = "FActualizarProducto";
            this.Text = "FActualizarProducto";
            this.Load += new System.EventHandler(this.FActualizarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox categoriaIdTextBox;
        private System.Windows.Forms.TextBox codigoInternoTextBox;
        private System.Windows.Forms.TextBox marcaIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox productoIdTextBox;
        private System.Windows.Forms.TextBox proveedorIdTextBox;
        private System.Windows.Forms.Button button1;
    }
}