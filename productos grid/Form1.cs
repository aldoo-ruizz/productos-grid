using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using productos_grid.clases;

namespace productos_grid
{
    /// <summary>
    /// 08052026
    /// se realizo la creacion de un nuevo formulario para agregar nuevos registros al grid, se agrego un nuevo boton en el formulario principal para abrir el formulario de agregar, se agrego un nuevo evento click para el boton de agregar que abre el formulario de agregar, se agrego un nuevo metodo en el formulario principal para obtener el ultimo id registrado y asignar el nuevo id al nuevo registro, se agrego un nuevo metodo en el formulario principal para agregar el nuevo registro a la lista y actualizar el grid, se agrego un nuevo constructor a la clase constructor para crear un nuevo objeto con los datos ingresados en las cajas de texto del formulario de agregar, se agrego una nueva variable idnuevo para almacenar el id del nuevo registro que se va a agregar, se inicializa esta variable con el ultimo id registrado + 1 al cargar el formulario de agregar, se actualiza esta variable cada vez que se agrega un nuevo registro al grid, se actualiza el metodo de inicializacajas para limpiar las cajas de texto después de agregar un nuevo registro.
    /// </summary>
    public partial class Form1 : Form
    {
        List<constructor> lista = new List<constructor>();

        public Form1()
        {
            InitializeComponent();
            inicializargrid();
            constructor cons = new constructor(1, "Aldo", "Ruiz", "Delagdo");


        }
        private void inicializargrid()
        {
            lista.Add(new constructor(1, "Josua", "Mendoza", "Gomez"));
            lista.Add(new constructor(2, "Pame", "Gutierrez", "Ruiz"));
            lista.Add(new constructor(3, "Carlos", "Dominguez", "Cruz"));

            bs1.DataSource = lista;
            dgvdataa.DataSource = bs1;

            dgvdataa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdataa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdataa.MultiSelect = false;
            dgvdataa.ReadOnly = true;

            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            constructor nuevoregistro = new constructor(4, "Maria", "Lopez", "Sanchez");
            lista.Add(nuevoregistro);
            bs1.ResetBindings(false);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            constructor datoseliminar = (constructor)dgvdataa.CurrentRow.DataBoundItem;
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lista.Remove(datoseliminar);
                bs1.ResetBindings(false); 
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2(this);
            formulario2.ShowDialog();
        }
        public constructor obtenerregistroseleccionado()
        {
            return (constructor)dgvdataa.CurrentRow.DataBoundItem;
        }
        public void agregarregis(constructor registroactualizado)
        {
            lista.Add(registroactualizado);
            bs1.ResetBindings(false);
        }
        public void actualizarregistro(constructor registroactualizado)
        {
            constructor datomodificado = lista.FirstOrDefault(p => p.Id == registroactualizado.Id);

            datomodificado.Nombre = registroactualizado.Nombre;
            datomodificado.Apellidopaterno = registroactualizado.Apellidopaterno;
            datomodificado.Apellidomaterno = registroactualizado.Apellidomaterno;
            bs1.ResetBindings(true);

        }
            
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3(this);
            formulario3.ShowDialog();
        }
        public int obtener()
        {
            return lista.Count();
        }
        public void agregarregistro(constructor nuevoregistro)
        {
            lista.Add(nuevoregistro);
            bs1.ResetBindings(false);
        }
    }
}
