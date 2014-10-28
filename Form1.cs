using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enviarUnMailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facebookCelegioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://wwww.facebook.com/instituto.secundario.john.f.kennedy");
        }

        private void calculoDeSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Pablo/Colegio JFK/Introducc a la prog/Trabajos Practicos/Calcular Sueldo/Calcular Sueldo/bin/Debug/CalcularSueldo.exe");
        }
    }
}
