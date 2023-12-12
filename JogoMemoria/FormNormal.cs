using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class FormNormal : Form
    {
        public FormNormal()
        {
            InitializeComponent();
        }
         private void FormNormal_Load(object sender, EventArgs e)
         {
            DistribuirCartas();
            atribuirTags();
         }
        
        int pontos = 0;
        static public bool login = false;
        const int nCartas = 24;
        int nCliques = 0;
        Button cartaAnterior;
        byte restanteCt = nCartas / 2;
       

       
        private void atribuirTags()
        {
            int[] tags = new int[nCartas];
            Random rnd = new Random();
            for (int i = 0; i < nCartas; i++)
            {
                tags[i] = i % (nCartas / 2) + 1;
            }


            for (int i = 0; i < nCartas; i++)
            {
                int temp = tags[i];
                int randomIndex = rnd.Next(i, nCartas);
                tags[i] = tags[randomIndex];
                tags[randomIndex] = temp;
            }


            int j = 0;
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[j];
                    j++;
                }
            }
        }
        private void CompararCartas(Button cAnt, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            if (cAnt == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.miata;
            }
            else
            {
                if (cAtual.Tag.ToString() == cAnt.Tag.ToString())
                {
                    restanteCt--;
                    nCliques = 0;
                    pontos += 10;
                    cAnt.Visible = false;
                    cAtual.Visible = false;
                    VerificarSeGanhou();
                }
                else
                {
                    nCliques = 0;
                    cAnt.BackgroundImage = Properties.Resources.miata;
                    cAtual.BackgroundImage = Properties.Resources.miata;
                }
            }

        }
        private void VerificarSeGanhou()
        {
            if (restanteCt == 0)
                MessageBox.Show("Parabéns!! Ganhou");
            MessageBox.Show($"{pontos}");
        }

 
        private void DistribuirCartas()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "c"))
                {
                    x.BackgroundImage = Properties.Resources.miata;
                    x.Visible = true;
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button cartaAtual = sender as Button;
            string s = "." + (cartaAtual).Tag.ToString();
            Object o = Properties.Resources.ResourceManager.GetObject(s);
            cartaAtual.BackgroundImage = (System.Drawing.Image)o;
            if (nCliques == 0)
            {
                cartaAnterior = cartaAtual;
                nCliques++;
            }
            else
                CompararCartas(cartaAtual, cartaAnterior);
        }
       

        private void but_mostrar_Click_1(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "." + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }
            Application.DoEvents();
            System.Threading.Thread.Sleep(800);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.miata;
        }

        private void but_jgrdnv_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       
    }
}

    
