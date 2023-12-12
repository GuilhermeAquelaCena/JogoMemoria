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
using System.Web;

namespace JogoMemoria
{
   
    public partial class Form3 : Form
    {
        string partcd = " credenciais.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void but_Registro_Click(object sender, EventArgs e)
        {
            if (TextBoxUser.Text != "" && textBoxPass.Text != "")
            {
                if (textBoxPass.Text == textBoxRepetirPass.Text)
                {
                    if (!UtilizadorJaExistente(TextBoxUser.Text))
                        RegistarDadosUtiliz(TextBoxUser.Text, textBoxPass.Text);
                    else
                        MessageBox.Show("utilizador ja existente!!");
                }
                else
                {
                    MessageBox.Show("as passwords nao cooicidem!!");
                    textBoxPass.Text = "";
                    textBoxRepetirPass.Text = "";
                    textBoxPass.Focus();
                }
                this.Close();
            }
        }
        private bool UtilizadorJaExistente(string user)
        {
            if (File.Exists(partcd))
            {
                try
                {
                    string[] users = File.ReadAllLines(partcd);
                    foreach (string linhaUser in users)
                    {
                        string[] dadosUser = linhaUser.Split(':');
                        if (dadosUser[0] == user) return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro", ex.Message);
                }

            }
            return false;

        }
        private void RegistarDadosUtiliz(string user, string pass)
        {
            try
            {
                string texto = "\n" + user + ":" + pass;
                File.AppendAllText(partcd, texto);
                MessageBox.Show("Novo utilizador registado com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            this.Close();
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
    }
}

            
         
