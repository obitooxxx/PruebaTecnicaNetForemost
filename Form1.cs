
using System.Windows.Forms;

namespace PruebaTecnicaNetForemost
{
    public partial class Form1 : Form
    {
        // Constructor del formulario
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionDB conexion = new ConexionDB();
            conexion.EjecutarProcedimientoAlmacenado(dgv_Gestores);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConexionDB conexion = new ConexionDB();
            conexion.ConectarYConsultar(dgv_Gestores);            
            
        }
    }
}
