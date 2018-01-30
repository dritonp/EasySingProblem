using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detyra2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlgoritmi_Click(object sender, EventArgs e)
        {
            if (ValidoFushat())
            {
                var varguIntonacioneve = FillList();
                var objSingingEasy = new SingingEasy();

                var llogaritVeshtersine = objSingingEasy.solve(varguIntonacioneve.ToArray());
                var mesazhi = string.Format("Vështërsia më e vogel e mundshme për këndimin e këngës nga dy persona është: {0}. ", llogaritVeshtersine);
                MessageBox.Show(mesazhi);
            }
        }
        private bool ValidoFushat()
        {
            if (string.IsNullOrEmpty(txtVargu.Text))
            {
                MessageBox.Show("Shenoni anetaret e vargut, duke i ndare me prejse ose me hapesire mes tyre");
                return false;
            }
            return true;
        }
        private List<int> FillList()
        {
            var varguFillestar = new List<int>();
            var vleratInput = Regex.Replace(txtVargu.Text, @"\s+", " ");
            var seksionet = vleratInput.Split(',', ' ');
            foreach (var item in seksionet)
            {
                int no;
                bool isNumeric = int.TryParse(item, out no);

                if (isNumeric)
                    if (no <= 1000000)
                        varguFillestar.Add(no);
                    else
                        MessageBox.Show("Shenoni anetaret e vargut, duke filluar nga 1 - 1000000");


            }
            return varguFillestar;
        }

    }
}
