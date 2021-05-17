using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_24._03._21
{
    public partial class Form1 : Form
    {
        string[] nomes = { "Antonio", "Carlos", "Helena", "Ariane", "Heloisa", "Antenor", "Catharine" };
        string[] senha = { "73195555", "557711", "01410", "979491", "74123698", "40100104", "84267931" };
        int[] ndx = { 5, 0, 3, 1, 6, 2, 4};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            for (int i = 0; i < 7; i++){
                listBox1.Items.Add(nomes[ndx[i]] + " - " + senha[ndx[i]]);
            }
        }
    }
}
