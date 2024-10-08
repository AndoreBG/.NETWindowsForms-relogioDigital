using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace relogioDigital
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer Segundos = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            IniTimer();
        }

        private void IniTimer()
        {
            Segundos.Interval = 1000;
            Segundos.Tick += new EventHandler(Segundos_Tick);

            Segundos.Enabled = false;

            btnSelec.Text = "Iniciar";
        }

        private void Segundos_Tick(object Sender, EventArgs e) => relDig.Text = DateTime.Now.ToString("HH:mm:ss");

        private void btnSelec_Click(object sender, EventArgs e)
        {
            if (!Segundos.Enabled)
            {
                Segundos.Start();
                btnSelec.Text = "Parar";
            }
            else
            {
                Segundos.Stop();
                btnSelec.Text = "Iniciar";
            }
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            SoundPlayer engineerVoice = new SoundPlayer();
            engineerVoice.Stream = Properties.Resources.engineer;
            engineerVoice.Play();
        }
    }
}
