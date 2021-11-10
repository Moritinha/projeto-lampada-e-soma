using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class Form1 : Form
    {
      private int bateria = 100;
        private Lanterna lanterna = new Lanterna();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lanterna.status = "LIGADO";
            teste.Text = this.lanterna.status;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.lanterna.status == "LIGADO")
            {
            label2.Text = this.lanterna.bateria.carga.ToString();
            this.lanterna.bateria.carga -= 1;
            }
            


        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lanterna.status = "DESLIGADO";
            teste.Text = this.lanterna.status;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.lanterna.bateria.carga = 100;

        }
    }
}
