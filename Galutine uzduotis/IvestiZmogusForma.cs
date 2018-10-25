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
    public partial class IvestiZmogusForma : Form
    {

        public zmogus zmogus { get; set; }

        public IvestiZmogusForma()
        {
            InitializeComponent();
        }

        private void textBoxVardas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        var vardas = textBoxVardas.Text;
        var amzius = Convert.ToInt32(textAmzius.Text);
        var profesija = textProfesija.Text;
        zmogus = new zmogus(vardas, amzius, profesija);
        }
    }
}
