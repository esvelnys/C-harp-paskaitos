using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galutine_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "naujas tekstas";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pirmas = Convert.ToInt32(textBoxPirmasSkaicius.Text);
            var antras = Convert.ToInt32(TextBoxAntrasSkaicius.Text);

            var suma = pirmas + antras;
            //mbox
            MessageBox.Show(@"suma: " + suma);
            textBoxPirmasSkaicius.Text = "";
            TextBoxAntrasSkaicius.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var vardas = ivedimasVardas.Text;
            var forma = new SiustasVardasForma(vardas);
            forma.ShowDialog();
        }

        private void ivedimasVardas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var forma = new IvestiZmogusForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    label5.Text = String.Format("{0} ({1} m. ) dirba {2}",
                        forma.zmogus.Vardas, forma.zmogus.Amzius,
                        forma.zmogus.Profesija);
                }
                else
                {
                    label5.Text = "atstok";
                }
            
            }
        }
    }
}
