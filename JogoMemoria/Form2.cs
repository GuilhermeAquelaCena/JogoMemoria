using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace JogoMemoria
{
    
    public partial class FormLogin : Form
    {
        string pathCd = "credenciais.txt";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void but_entrar_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            string user = TextBoxUser.Text;
            string pass = textBoxPass.Text;
            if (user == "1" && textBoxPass.Text == "1")
            {
                Form4 frm = new Form4();
                frm.Show();
            }
            else
                Form1.login = VerificarCredenciais(user, pass);           
        }
        private bool VerificarCredenciais(string us, string ps)
        {
            if (File.Exists(pathCd))
            {
                try
                {
                    string[] users = File.ReadAllLines(pathCd);
                    foreach (string user in users)
                    {
                        string[] dadosUsers = user.Split(':');
                        if (dadosUsers[0] == us && dadosUsers[1] == ps)
                        {
                            Form4 frm = new Form4();
                            frm.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }
            MessageBox.Show("credenciais de utilizador não encontradas");
            return false;
        }

        private void linkLabelMostrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelMostrar.Text == "Mostrar")
            {
                textBoxPass.UseSystemPasswordChar = false;
                linkLabelMostrar.Text = "Ocultar";
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                linkLabelMostrar.Text = "Mostrar";
            }
        }

        private void but_regis_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void but_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
