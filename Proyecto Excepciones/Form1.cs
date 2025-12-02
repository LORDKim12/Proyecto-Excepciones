namespace Proyecto_Excepciones
{
    public partial class Form1 : Form
    {
        // Instanciamos nuestra clase de lógica
        GestorUsuarios gestor = new GestorUsuarios();

        public Form1()
        {
            InitializeComponent();
        }

        // --- BOTÓN REGISTRAR ---
        private void button1_Click(object sender, EventArgs e)
        {
        }

        // --- BOTÓN BUSCAR ---
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarLista()
        {
            // Método auxiliar para ver qué llevamos guardado (opcional)
            // Podrías mostrarlo en el ListBox2 si quisieras ver todos.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limpiamos el log de errores previos

            try
            {
                // Llamamos al gestor. Si algo falla allá, saltará a los catch de aquí.
                gestor.RegistrarUsuario(textBox1.Text, textBox2.Text, textBox3.Text);

                MessageBox.Show("Usuario registrado con éxito.");
                ActualizarLista();
            }
            // 1. Error técnico: Formato de número incorrecto (letras en edad)
            catch (FormatException)
            {
                string msg = "Error Técnico: La edad debe ser un número entero válido.";
                MessageBox.Show(msg, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(msg);
            }
            // 2. Error técnico: Número demasiado grande
            catch (OverflowException)
            {
                string msg = "Error Técnico: El número ingresado es demasiado grande.";
                MessageBox.Show(msg, "Desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox1.Items.Add(msg);
            }
            // 3. Error técnico: Argumento nulo (Nombre vacío)
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBox1.Items.Add($"Error Argumento: {ex.Message}");
            }
            // 4. ERROR DE NEGOCIO (Nuestra excepción personalizada)
            catch (RegistroUsuarioException ex)
            {
                MessageBox.Show(ex.Message, "Regla de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Items.Add($"Error Negocio: {ex.Message}");
            }
            // 5. Error Genérico (cualquier otra cosa)
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
            finally
            {
                // Requisito: Usar finally para limpieza
                // Esto se ejecuta SIEMPRE, haya error o no.
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

                // Intentamos buscar por índice para forzar el IndexOutOfRangeException
                // Si escribes "0", traerá al primero. Si escribes "100" y no hay tantos, fallará.
                Usuarios usuarioEncontrado = gestor.BuscarPorIndice(busqueda);

                if (usuarioEncontrado != null)
                {
                    listBox2.Items.Add($"Encontrado: {usuarioEncontrado.nombre} - {usuarioEncontrado.correo}");
                }
                else
                {
                    // Si no es un número, buscamos por nombre simple (lógica básica)
                    // Simulamos NullReferenceException si la lista estuviera nula (forzado para el ejemplo)
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
            // Requisito: IndexOutOfRangeException
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No existe un usuario en esa posición numérica.", "Índice fuera de rango");
            }
            // Requisito: NullReferenceException
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

        // --- BOTÓN BUSCAR ---
    


