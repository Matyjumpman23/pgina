using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime a;
        private void button_inicio_Click(object sender, EventArgs e)
        {
            
            a = DateTime.Now;
            textBox_tiempoi.Text = a.ToString();
            button_terminar.Enabled =  true;
            
            
        }

        private void button_terminar_Click(object sender, EventArgs e)
        {
            DateTime at;
            at = DateTime.Now;
            textBox_tiempodt.Text=at.ToString();
            TimeSpan t;
            t=a-at;
            textBox_Tiempotra.Text=t.ToString();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
     
        }
    }
}
