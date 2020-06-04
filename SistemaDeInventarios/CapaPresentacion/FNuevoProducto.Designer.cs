namespace CapaPresentacion
{
    partial class FNuevoProducto
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
            System.Windows.Forms.Label codigoInternoLabel;
            System.Windows.Forms.Label marcaIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label proveedorIdLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            this.codigoInternoTextBox = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.categoriaIdTextBox = new System.Windows.Forms.TextBox();
            this.marcaIdComboBox = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorIdComboBox = new System.Windows.Forms.ComboBox();
            codigoInternoLabel = new System.Windows.Forms.Label();
            marcaIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            proveedorIdLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoInternoLabel
            // 
            codigoInternoLabel.AutoSize = true;
            codigoInternoLabel.Location = new System.Drawing.Point(30, 87);
            codigoInternoLabel.Name = "codigoInternoLabel";
            codigoInternoLabel.Size = new System.Drawing.Size(78, 13);
            codigoInternoLabel.TabIndex = 3;
            codigoInternoLabel.Text = "codigo Interno:";
            // 
            // marcaIdLabel
            // 
            marcaIdLabel.AutoSize = true;
            marcaIdLabel.Location = new System.Drawing.Point(30, 113);
            marcaIdLabel.Name = "marcaIdLabel";
            marcaIdLabel.Size = new System.Drawing.Size(51, 13);
            marcaIdLabel.TabIndex = 5;
            marcaIdLabel.Text = "marca Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(30, 139);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "nombre:";
            // 
            // proveedorIdLabel
            // 
            proveedorIdLabel.AutoSize = true;
            proveedorIdLabel.Location = new System.Drawing.Point(30, 165);
            proveedorIdLabel.Name = "proveedorIdLabel";
            proveedorIdLabel.Size = new System.Drawing.Size(70, 13);
            proveedorIdLabel.TabIndex = 11;
            proveedorIdLabel.Text = "proveedor Id:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(30, 61);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(66, 13);
            categoriaIdLabel.TabIndex = 13;
            categoriaIdLabel.Text = "categoria Id:";
            // 
            // codigoInternoTextBox
            // 
            this.codigoInternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "codigoInterno", true));
            this.codigoInternoTextBox.Location = new System.Drawing.Point(114, 84);
            this.codigoInternoTextBox.Name = "codigoInternoTextBox";
            this.codigoInternoTextBox.Size = new System.Drawing.Size(215, 20);
            this.codigoInternoTextBox.TabIndex = 4;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CapaPresentacion.Entidades.Producto);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(114, 136);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(215, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoriaIdTextBox
            // 
            this.categoriaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "categoriaId", true));
            this.categoriaIdTextBox.Location = new System.Drawing.Point(114, 61);
            this.categoriaIdTextBox.Name = "categoriaIdTextBox";
            this.categoriaIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoriaIdTextBox.TabIndex = 14;
            // 
            // marcaIdComboBox
            // 
            this.marcaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "marcaId", true));
            this.marcaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "marcaId", true));
            this.marcaIdComboBox.DataSource = this.marcaBindingSource;
            this.marcaIdComboBox.DisplayMember = "nombre";
            this.marcaIdComboBox.FormattingEnabled = true;
            this.marcaIdComboBox.Location = new System.Drawing.Point(114, 110);
            this.marcaIdComboBox.Name = "marcaIdComboBox";
            this.marcaIdComboBox.Size = new System.Drawing.Size(215, 21);
            this.marcaIdComboBox.TabIndex = 15;
            this.marcaIdComboBox.ValueMember = "marcaId";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(CapaPresentacion.Entidades.Marca);
            // 
            // proveedorIdComboBox
            // 
            this.proveedorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "proveedorId", true));
            this.proveedorIdComboBox.FormattingEnabled = true;
            this.proveedorIdComboBox.Location = new System.Drawing.Point(114, 165);
            this.proveedorIdComboBox.Name = "proveedorIdComboBox";
            this.proveedorIdComboBox.Size = new System.Drawing.Size(215, 21);
            this.proveedorIdComboBox.TabIndex = 16;
            // 
            // FNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 317);
            this.Controls.Add(this.proveedorIdComboBox);
            this.Controls.Add(this.marcaIdComboBox);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(codigoInternoLabel);
            this.Controls.Add(this.codigoInternoTextBox);
            this.Controls.Add(marcaIdLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(proveedorIdLabel);
            this.Name = "FNuevoProducto";
            this.Text = "FNuevoProducto";
            this.Load += new System.EventHandler(this.FNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox codigoInternoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox categoriaIdTextBox;
        private System.Windows.Forms.ComboBox marcaIdComboBox;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private System.Windows.Forms.ComboBox proveedorIdComboBox;
    }
}