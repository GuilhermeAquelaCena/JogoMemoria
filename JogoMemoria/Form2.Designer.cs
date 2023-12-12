
namespace JogoMemoria
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_cancelar = new System.Windows.Forms.Button();
            this.but_entrar = new System.Windows.Forms.Button();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.linkLabelMostrar = new System.Windows.Forms.LinkLabel();
            this.botao_registro = new System.Windows.Forms.LinkLabel();
            this.but_regis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_cancelar
            // 
            this.but_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_cancelar.Location = new System.Drawing.Point(682, 293);
            this.but_cancelar.Name = "but_cancelar";
            this.but_cancelar.Size = new System.Drawing.Size(74, 29);
            this.but_cancelar.TabIndex = 25;
            this.but_cancelar.Text = "Cancelar";
            this.but_cancelar.UseVisualStyleBackColor = true;
            this.but_cancelar.Click += new System.EventHandler(this.but_cancelar_Click);
            // 
            // but_entrar
            // 
            this.but_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_entrar.Location = new System.Drawing.Point(589, 293);
            this.but_entrar.Name = "but_entrar";
            this.but_entrar.Size = new System.Drawing.Size(74, 29);
            this.but_entrar.TabIndex = 26;
            this.but_entrar.Text = "Entrar";
            this.but_entrar.UseVisualStyleBackColor = true;
            this.but_entrar.Click += new System.EventHandler(this.but_entrar_Click);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUser.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxUser.Location = new System.Drawing.Point(589, 191);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(167, 19);
            this.TextBoxUser.TabIndex = 27;
            this.TextBoxUser.Text = "username";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPass.Location = new System.Drawing.Point(589, 225);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(167, 19);
            this.textBoxPass.TabIndex = 28;
            this.textBoxPass.Text = "password";
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // linkLabelMostrar
            // 
            this.linkLabelMostrar.AutoSize = true;
            this.linkLabelMostrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelMostrar.Location = new System.Drawing.Point(762, 231);
            this.linkLabelMostrar.Name = "linkLabelMostrar";
            this.linkLabelMostrar.Size = new System.Drawing.Size(42, 13);
            this.linkLabelMostrar.TabIndex = 29;
            this.linkLabelMostrar.TabStop = true;
            this.linkLabelMostrar.Text = "Mostrar";
            this.linkLabelMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostrar_LinkClicked);
            // 
            // botao_registro
            // 
            this.botao_registro.AutoSize = true;
            this.botao_registro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.botao_registro.Location = new System.Drawing.Point(126, 152);
            this.botao_registro.Name = "botao_registro";
            this.botao_registro.Size = new System.Drawing.Size(0, 13);
            this.botao_registro.TabIndex = 32;
            // 
            // but_regis
            // 
            this.but_regis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_regis.Location = new System.Drawing.Point(641, 348);
            this.but_regis.Name = "but_regis";
            this.but_regis.Size = new System.Drawing.Size(74, 29);
            this.but_regis.TabIndex = 33;
            this.but_regis.Text = "Registrar";
            this.but_regis.UseVisualStyleBackColor = true;
            this.but_regis.Click += new System.EventHandler(this.but_regis_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.but_regis);
            this.Controls.Add(this.botao_registro);
            this.Controls.Add(this.linkLabelMostrar);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.but_entrar);
            this.Controls.Add(this.but_cancelar);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancelar;
        private System.Windows.Forms.Button but_entrar;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.LinkLabel linkLabelMostrar;
        private System.Windows.Forms.LinkLabel botao_registro;
        private System.Windows.Forms.Button but_regis;
    }
}