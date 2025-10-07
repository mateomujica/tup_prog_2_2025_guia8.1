using Ejercicio_1._Sueldos.Models;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_1._Sueldos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Empleado> empleados = new List<Empleado>();

        private void btnMostrarListado_Click(object sender, EventArgs e) //RECORRER LISTA 
        {
            lsbDatosFormPrincipal.Items.Clear();
            foreach (Empleado empleado in empleados)
            {
                lsbDatosFormPrincipal.Items.Add(empleado.ToString());
            }
        }

        private void btnImportar_Click(object sender, EventArgs e) //IMPORTAR EMPLEADOS DESDE ARCHIVOS CSV
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Archivos CSV(*.csv)|*.csv|Todos los archivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                FileStream fs = null;
                StreamReader sr = null;

                try
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    sr.ReadLine();
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {

                        string linea = sr.ReadLine();
                        string[] separador = linea.Split(';');

                        string tipo = separador[0];
                        int dni = Convert.ToInt32(separador[1]);
                        string nombre = separador[2];

                        Empleado N = null;
                        if (separador[0] == "Asalariado")
                        {
                            double basico = Convert.ToDouble(separador[3]);
                            double aportes = Convert.ToDouble(separador[4]);
                            N = new Asalariado(dni, nombre, basico, aportes);
                        }
                        else if (separador[0] == "Jornalero")
                        {
                            int horas = Convert.ToInt32(separador[3]);
                            double importe = Convert.ToDouble(separador[4]);
                            double retencion = Convert.ToDouble(separador[5]);
                            N = new Jornalero(dni, nombre, horas, importe, retencion);
                        }

                        empleados.Sort();
                        int idx = empleados.BinarySearch(N);

                        if (idx >= 0)
                        {
                            if (N is Asalariado)
                            {
                                ((Asalariado)empleados[idx]).Basico = ((Asalariado)N).Basico;
                            }
                            else if (N is Jornalero)
                            {
                                ((Jornalero)empleados[idx]).Importe = ((Jornalero)N).Importe;
                            }
                        }
                        else
                        {
                            empleados.Add(N);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    fs.Close();
                    sr.Close();
                }
                lsbDatosFormPrincipal.Items.Clear();
                foreach (Empleado E in empleados)
                {
                    lsbDatosFormPrincipal.Items.Add(E);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e) //EXPORTAR EMPLEADOS 
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "exportar.csv";
            sfd.Filter = "Fichero csv|*csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                    sw = new StreamWriter(fs);

                    //agrego primeras 2 lineas descriptivas 

                    sw.WriteLine("Tipo:Asalariado;DNI;Nombre;Básico,Aportes provisionales");
                    sw.WriteLine("Tipo: Jornalero; DNI; Nombre; Horas Trabajadas; Importe Por Hora; Retenciones");

                    //luego debajo agrego empleados 

                    foreach (IExportable N in empleados)
                    {
                        sw.WriteLine(N.Exportar());
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Close();
                    fs.Close();
                }
            }
        }
        private void lsbDatosFormPrincipal_SelectedIndexChanged(object sender, EventArgs e) //VER RECIBO DE EMPLEADO EN VENTANA MODAL 
        {
            if (lsbDatosFormPrincipal.SelectedIndex >= 0)
            {
                Empleado seleccionar = empleados[lsbDatosFormPrincipal.SelectedIndex];

                StringBuilder sb = new StringBuilder();
                foreach (string linea in seleccionar.GenerarRecibo())
                {
                    sb.AppendLine(linea); //ingreso de texto y salto de linea automatico 
                }

                
                FormRecibo frm = new FormRecibo(sb.ToString());
                frm.ShowDialog(); 
            }
        }

        private void btnRecibos_Click(object sender, EventArgs e) //GENERAR RECIBOS
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "recibos.txt";
            sfd.Filter = "Fichero txt|*txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                    sw = new StreamWriter(fs);

                    foreach (Empleado E in empleados)
                    {
                        foreach (string linea in E.GenerarRecibo())
                        {
                            sw.WriteLine(linea);
                        }
                        sw.WriteLine("---");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                   sw.Close();
                   fs.Close();
                }
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e) //CREAR EMPLEADOS 
        {
            FormModal fm = new FormModal();
            fm.ShowDialog();

            if (fm.rbAsalariado.Checked) 
            {
                string nombre = fm.tbxNombre.Text;
                int dni = Convert.ToInt32(fm.tbxDNI.Text);
                double basico = Convert.ToDouble(fm.tbxBasico.Text);
                double aportes = Convert.ToDouble(fm.tbxAportes.Text);

                Empleado A = new Asalariado(dni, nombre, basico, aportes);
                empleados.Sort();
                int idxA = empleados.BinarySearch(A);

                if (idxA >= 0)
                {
                    if (empleados[idxA] is Asalariado existente) 
                    {
                        existente.Basico += basico; // acumulo si ya existe 
                    }
                    else
                    {
                        MessageBox.Show("Ya existe este empleado pero es Jornalero");
                    }
                }
                else
                {
                    empleados.Add(A); // agrego si no existe 
                }
            }
            if (fm.rbJornalero.Checked)
            {
                string nombre = fm.tbxNombre.Text;
                int dni = Convert.ToInt32(fm.tbxDNI.Text);
                double importe = Convert.ToDouble(fm.tbxImporte.Text);
                int horas = Convert.ToInt32(fm.tbxHoras.Text);
                double retencion = Convert.ToDouble(fm.tbxRetenciones.Text);

                Empleado J = new Jornalero(dni, nombre, horas, importe, retencion);
                empleados.Sort();
                int idxJ = empleados.BinarySearch(J);

                if (idxJ >= 0)
                {
                    if (empleados[idxJ] is Jornalero existente)
                    {
                        existente.Importe += importe; // acumulo si ya existe 
                    }
                    else
                    {
                        MessageBox.Show("Ya existe este empleado pero es Asalariado");
                    }
                }
                else
                {
                    empleados.Add(J); // agrego si no existe 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
