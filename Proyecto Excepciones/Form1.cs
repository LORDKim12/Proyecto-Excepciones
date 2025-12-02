namespace Proyecto_Excepciones
{
    public partial class Form1 : Form
    {
        
        GestorUsuarios gestor = new GestorUsuarios();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
        }

     
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarLista()
        {
            
            listBox2.Items.Clear();

            
            List<Usuarios> lista = gestor.ObtenerUsuarios();

            for (int i = 0; i < lista.Count; i++)
            {
                listBox2.Items.Add($"[{i}] Nombre: {lista[i].nombre} - Edad: {lista[i].edad}");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            try
            {
                
                gestor.RegistrarUsuario(textBox1.Text, textBox2.Text, textBox3.Text);

                MessageBox.Show("Usuario registrado con éxito.");
                ActualizarLista();
            }
          
            catch (FormatException)
            {
                string msg = "Error Técnico: La edad debe ser un número entero válido.";
                MessageBox.Show(msg, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(msg);
            }
            
            catch (OverflowException)
            {
                string msg = "Error Técnico: El número ingresado es demasiado grande.";
                MessageBox.Show(msg, "Desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(msg);
            }
            
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBox1.Items.Add($"Error Argumento: {ex.Message}");
            }
            
            catch (RegistroUsuarioException ex)
            {
                MessageBox.Show(ex.Message, "Regla de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Items.Add($"Error Negocio: {ex.Message}");
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
            finally
            {
                
                textBox1.Clear(); // Limpiar nombre
                textBox2.Clear(); // Limpiar edad
                textBox3.Clear(); // Limpiar correo
                textBox1.Focus(); // Poner el cursor al inicio
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            try
            {
                string busqueda = textBox4.Text;

               
                Usuarios usuarioEncontrado = gestor.BuscarPorIndice(busqueda);

                if (usuarioEncontrado != null)
                {
                    listBox2.Items.Add($"Encontrado: {usuarioEncontrado.nombre} - {usuarioEncontrado.correo}");
                }
                else
                {
                    
                    var lista = gestor.ObtenerUsuarios();
                    if (lista == null) throw new NullReferenceException("La lista de usuarios no ha sido inicializada.");

                    bool encontrado = false;
                    foreach (var u in lista)
                    {
                        if (u.nombre.Contains(busqueda))
                        {
                            listBox2.Items.Add($"Nombre: {u.nombre}, Edad: {u.edad}");
                            encontrado = true;
                        }
                    }
                    if (!encontrado) listBox2.Items.Add("No se encontraron coincidencias.");
                }
            }
            
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No existe un usuario en esa posición numérica.", "Índice fuera de rango");
            }
            
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error crítico de referencia nula: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en consulta: " + ex.Message);
            }



        }
    }
}    

       
    


