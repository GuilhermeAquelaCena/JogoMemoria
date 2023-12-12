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
    public partial class Form1 : Form
    {        
        private int horas = 0;
        private int minutos = 0;
        private int segundos = 0;
        int pontos = 0;
        static public bool login = false;
        const int nCartas = 20;        
        int nCliques = 0;
        Button cartaAnterior;
        byte restanteCt = nCartas / 2;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            timerCronometro.Enabled = true;
            Ocultar();
            toolStripStatusLbData.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLbHora.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
        }

        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "c"))
                    x.Visible = false;
        }

        private void bot_login_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();

            if (login)
            {
                DistribuirCartas();
                atribuirTags();
            }
        }

        private void DistribuirCartas()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "c"))
                {
                    x.BackgroundImage = Properties.Resources.logo;
                    x.Visible = true;
                }
        }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLbHora.Text = DateTime.Now.ToLongTimeString();
        }


        private void but_mostrar_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "_" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }
            Application.DoEvents();
            System.Threading.Thread.Sleep(800);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.logo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button cartaAtual = sender as Button;
            string s = "_" + (cartaAtual).Tag.ToString();
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
        private void CompararCartas(Button cAnt, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            if (cAnt == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.logo;
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
                    cAnt.BackgroundImage = Properties.Resources.logo;
                    cAtual.BackgroundImage = Properties.Resources.logo;
                }
            }


        }
        private void VerificarSeGanhou()
        {
            if (restanteCt == 0)
                MessageBox.Show("Parabéns!! Ganhou");
            MessageBox.Show($"{pontos}");
        }

        private void but_jgrdnv_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timerCronometro.Start();

        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            timerCronometro.Stop();
            AtualizarDisplayCronometro();
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            TempoJogo();
        }
        private void TempoJogo()
        {
            segundos++;
            if (segundos == 60)
            {
                minutos++;
                segundos = 0;
                if (minutos == 60)
                {
                    horas++;
                    minutos = 0;
                }
            }
        }
        private void AtualizarDisplayCronometro()
        {
            labelCronometro.Text = $"{horas.ToString("00")}:{minutos.ToString("00")}:{segundos.ToString("00")}";
            labelCronometro.Refresh();
        }
    /*    private void EscolherNivel(string dificuldade)
        {
            switch (dificuldade)
            {
                case "facil":
                    nCartas = 12;
                    break;
                case "normal":
                    nCartas = 20;
                    break;
                case "dificil":
                    nCartas = 30;
                    break;
                default:
                    nCartas = 20; 
                    break;
            }
            restanteCt = (byte)(nCartas / 2);
          
        }
    */

        private void but_difi_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLbData_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLbHora_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
