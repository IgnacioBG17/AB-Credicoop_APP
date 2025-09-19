namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private readonly CapaNegocio.Producto _productoN = new CapaNegocio.Producto();
        private string IdProducto = string.Empty;
        private bool esEditar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!ValidarFormulario())
            {
                return;
            }

            CapaModelo.Producto producto = new CapaModelo.Producto();
            producto.IdProducto = (string.IsNullOrWhiteSpace(IdProducto)) ? 0 : int.Parse(IdProducto);
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Marca = txtMarca.Text;
            producto.precio = float.Parse(txtPrecio.Text);
            producto.Stock = int.Parse(txtStock.Text);

            if (esEditar)
            {
                try
                {
                    _productoN.Editar(producto);
                    MessageBox.Show("Producto Editado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al intentar Editar" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }
            else
            {
                try
                {
                    _productoN.Insertar(producto);
                    MessageBox.Show("Producto Insertado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al intentar Insertar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }

            esEditar = false;
            Mostar();
        }

        public void Mostar()
        {
            dataGridView1.DataSource = _productoN.Mostrar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                esEditar = true;
                IdProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CapaModelo.Producto produto = new CapaModelo.Producto();
                produto.IdProducto = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

                try
                {
                    _productoN.Eliminar(produto);
                    MessageBox.Show("Producto Elimando correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al intentar Eliminar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            
                Mostar();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            IdProducto = string.Empty;
            esEditar = false;
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripcion es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("La marca es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!float.TryParse(txtPrecio.Text, out var precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtStock.Text, out var stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
