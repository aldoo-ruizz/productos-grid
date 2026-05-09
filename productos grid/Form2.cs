using productos_grid.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productos_grid
{
    /// <summary>
    /// 08052026
    /// se realizo la modificacion de los datos del registro seleccionado en el grid, se agrego un nuevo formulario para realizar esta accion, se agrego un nuevo metodo en el formulario principal para obtener el registro seleccionado y otro metodo para actualizar el registro modificado, se agrego un nuevo constructor a la clase constructor para poder crear un nuevo objeto con los datos modificados, se agrego un nuevo boton en el formulario de modificacion para guardar los cambios realizados, se agrego un nuevo evento click para el boton de modificacion que llama al metodo de actualizarregistro del formulario principal pasando el objeto con los datos modificados, se agrego una nueva variable idmodifica para almacenar el id del registro que se va a modificar, se inicializa esta variable con el id del registro seleccionado al cargar el formulario de modificacion, se actualiza esta variable cada vez que se selecciona un nuevo registro en el grid, se actualiza el metodo de inicializacajas para cargar los datos del registro seleccionado en las cajas de texto correspondientes.
    /// </summary>
    public partial class Form2 : Form
    {
        Form1 objform1 = new Form1();
        int idmodifica = 0;

        public Form2(Form1 formulario1)
        {
            InitializeComponent();
            objform1 = formulario1;


            inicializacajas();
        }
        private void inicializacajas()
        {
            constructor registroseleccionado = objform1.obtenerregistroseleccionado();

            textBox1.Text = registroseleccionado.Nombre;
            textBox2.Text = registroseleccionado.Apellidopaterno;
            textBox3.Text = registroseleccionado.Apellidomaterno;
            idmodifica = registroseleccionado.Id;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            constructor resitromodif = new constructor(idmodifica, textBox1.Text, textBox2.Text, textBox3.Text);
            objform1.actualizarregistro(resitromodif);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

