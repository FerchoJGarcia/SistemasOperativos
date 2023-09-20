using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorDeTareas
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent(); //Inicializa los componentes
            UpdateProcessList(); //Manda a llamar a la clase que lleva las funcions
            timer1.Enabled = true; //Activa el Timer para actualizar automatico
            timer2.Enabled = true; //Activa el Timer de los graficos
        }

        private void UpdateProcessList()
        {
            //Limpiador de procesos
            dgvAdmon.Rows.Clear();

            //Coloca todos los procesos mandados a llamar
            foreach (Process p in Process.GetProcesses())
            {
                int n = dgvAdmon.Rows.Add();
                dgvAdmon.Rows[n].Cells[0].Value = p.ProcessName;
                dgvAdmon.Rows[n].Cells[1].Value = p.Id;
                dgvAdmon.Rows[n].Cells[2].Value = p.WorkingSet64;
                dgvAdmon.Rows[n].Cells[3].Value = p.VirtualMemorySize64;
                dgvAdmon.Rows[n].Cells[4].Value = p.SessionId;
            }

            //Para que el usuario no seleccione más de un proceso
            dgvAdmon.MultiSelect = false;

            //Contador de procesos
            LblContador.Text = "Procesos Actuales: " + dgvAdmon.Rows.Count.ToString();
        }

        private void FrmAdmon_Load(object sender, EventArgs e)
        {
            timer2.Start();
            btnProcesos.Visible = false;
            lblCPU.Visible = false;
            lblRAM.Visible = false;
            mpbCPU.Visible = false;
            mpbRAM.Visible = false;
            lblporCPU.Visible = false;
            lblporRAM.Visible = false;
            GraficaCPURAM.Visible = false;
        }

        private void dgvAdmon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Coloca la fila seleccionada en el label de abajo para eliminar el proceso
            LblNombre.Text = dgvAdmon.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Al presionar el boton se actualizan los procesos
            UpdateProcessList();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            //Un try para que el proceso seleccionado se detenga al presionar el boton y se actualice
            try
            {
                foreach (Process p in Process.GetProcesses())
                {

                    if (p.ProcessName == LblNombre.Text)
                    {
                        p.Kill();
                        UpdateProcessList();
                    }
                }
            }
            //Un catch en caso no haya ningun proceso seleccionado
            catch (Exception x)
            {
                MessageBox.Show("No se selecciono ningun proceso " + x, "Error al eliminar", MessageBoxButtons.OK);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Para cerrar el programa
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // UpdateProcessList();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Se declaran variables para los performance counters y de esa forma nos de valores
           float varCPU = pfcCPU.NextValue();
           float varRAM = pfcRAM.NextValue();
            //Se les da el valor obtenido de los PFC a las barras
            mpbCPU.Value = (int)varCPU; 
            mpbRAM.Value = (int)varRAM;
            //Se coloca el siguiente formato para que los Labels nos den los porcentajes obtenidos de los PFC
            lblCPU.Text = string.Format("{0:0.00}%", varCPU); 
            lblRAM.Text = string.Format("{0:0.00}%", varRAM);
            //Para que nos muestre valores en la grafica
            GraficaCPURAM.Series["CPU"].Points.AddY(varCPU);
            GraficaCPURAM.Series["RAM"].Points.AddY(varRAM);
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            btnProcesos.Visible = true;
            btnProcesos.Visible = true;
            lblCPU.Visible = true;
            lblRAM.Visible = true;
            mpbCPU.Visible = true;
            mpbRAM.Visible = true;
            lblporCPU.Visible = true;
            lblporRAM.Visible = true;
            GraficaCPURAM.Visible = true;

            btnActualizar.Visible = false;
            btnDetener.Visible = false;
            LblContador.Visible = false;
            LblNombre.Visible = false;
            LblNombreProceso.Visible = false;
            dgvAdmon.Visible = false;
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            lblCPU.Visible = false;
            lblRAM.Visible = false;
            mpbCPU.Visible = false;
            mpbRAM.Visible = false;
            lblporCPU.Visible = false;
            lblporRAM.Visible = false;
            GraficaCPURAM.Visible = false;
            btnProcesos.Visible = false;

            btnActualizar.Visible = true;
            btnDetener.Visible = true;
            LblContador.Visible = true;
            LblNombre.Visible = true;
            LblNombreProceso.Visible = true;
            dgvAdmon.Visible = true;
        }
    }
}
