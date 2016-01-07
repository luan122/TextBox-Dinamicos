using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamico
{
    public partial class Caixas_dinamicas : Form
    {
        static int i = 0;
        string nomeCaixa = "Novo ";
        public Caixas_dinamicas()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            int ii = string.IsNullOrWhiteSpace(txtQuantCriar.Text) == true ? 1:Convert.ToInt16(txtQuantCriar.Text);
            int xx = 0;
            if (string.IsNullOrWhiteSpace(txtQuantCriar.Text)) ii = 1;
            while (xx < ii)
            {
                if (i < 1)
                {
                    TextBox novo = new TextBox();
                    novo.Name = nomeCaixa + i;
                    novo.Text = novo.Name;
                    Point p = new Point(txtExistente.Location.X, txtExistente.Location.Y + 26);
                    novo.Location = p;
                    this.Controls.Add(novo);
                }
                else
                {
                    string nomeAntes = nomeCaixa + (i - 1);
                    Control[] matches = this.Controls.Find(nomeAntes, true);
                    TextBox tb = (TextBox)matches[0];
                    TextBox novo = new TextBox();
                    novo.Name = nomeCaixa + i;
                    novo.Text = novo.Name;
                    Point p = new Point(tb.Location.X, tb.Location.Y + 26);
                    novo.Location = p;
                    this.Controls.Add(novo);
                }
                i++;
                xx++;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantDel.Text))
            {
                MessageBox.Show("Preencha a quantidade que deseja deletar");
                return;
            }
            int ii = Convert.ToInt16(txtQuantDel.Text);
            int xx = 0;
            var XXII = logicaDeQuantidades(ii, xx);
            if (XXII.Item1 == -1 || XXII.Item2 == -1) return;
            ii = XXII.Item1;
            xx = XXII.Item2;
            
            while(xx < ii)
            {
                string nomeAntes = nomeCaixa + (i - 1);
                Control[] matches = this.Controls.Find(nomeAntes, true);
                TextBox tb = (TextBox)matches[0];
                this.Controls.Remove(tb);
                xx++;
                i--;
            }
        }
        internal Tuple<int,int> logicaDeQuantidades(int ii, int xx)
        {
            if (i > 1 && ii > i) ii = i;
            if (i < ii && i == 1) ii = 1;
            if (i < ii) return Tuple.Create(-1,-1);
            if (ii > i) ii = i;
            return Tuple.Create(ii, xx);
        }
    }
}
