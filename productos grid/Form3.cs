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
    /// se realizo la creacion de un nuevo formulario para agregar nuevos registros al grid, se agrego un nuevo boton en el formulario principal para abrir el formulario de agregar, se agrego un nuevo evento click para el boton de agregar que abre el formulario de agregar, se agrego un nuevo metodo en el formulario principal para obtener el ultimo id registrado y asignar el nuevo id al nuevo registro, se agrego un nuevo metodo en el formulario principal para agregar el nuevo registro a la lista y actualizar el grid, se agrego un nuevo constructor a la clase constructor para crear un nuevo objeto con los datos ingresados en las cajas de texto del formulario de agregar, se agrego una nueva variable idnuevo para almacenar el id del nuevo registro que se va a agregar, se inicializa esta variable con el ultimo id registrado + 1 al cargar el formulario de agregar, se actualiza esta variable cada vez que se agrega un nuevo registro al grid, se actualiza el metodo de inicializacajas para limpiar las cajas de texto después de agregar un nuevo registro.
    /// </summary>
    public partial class Form3 : Form
    {
        Form1 objform1 = new Form1();
        int idmodificaa = 0;
        public Form3(Form1 formulario1)  
        {
            InitializeComponent();
            objform1 = formulario1;
            constructor cons = new constructor(1, "Aldo", "Ruiz", "Delagdo");


        }
        private void inicializacajas()
        {
            constructor registroseleccionado = objform1.obtenerregistroseleccionado();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            idmodificaa = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idnuevo = 0;
            string nombre, apat, amat;
            nombre = textBox1.Text;
            apat = textBox2.Text;
            amat = textBox3.Text;
            idnuevo = objform1.obtener() + 1;

            constructor nuevo = new constructor(idnuevo, nombre, apat, amat);
            objform1.agregarregistro(nuevo);

            inicializacajas();
        }
    }
}
