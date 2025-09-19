namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtMarca = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(690, 237);
            dataGridView1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(814, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(726, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(726, 82);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(814, 82);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(215, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(726, 126);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(814, 126);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(215, 27);
            txtMarca.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(726, 168);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(814, 168);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(215, 27);
            txtPrecio.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(726, 215);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 10;
            label5.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(814, 215);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(215, 27);
            txtStock.TabIndex = 9;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 284);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(150, 284);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(872, 264);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtMarca);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtMarca;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtStock;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}
