
namespace JogoMemoria
{
    partial class Form3
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
            this.linkLabelMostrar = new System.Windows.Forms.LinkLabel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.but_Registro = new System.Windows.Forms.Button();
            this.but_cancelar = new System.Windows.Forms.Button();
            this.textBoxRepetirPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabelMostrar
            // 
            this.linkLabelMostrar.AutoSize = true;
            this.linkLabelMostrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelMostrar.Location = new System.Drawing.Point(373, 206);
            this.linkLabelMostrar.Name = "linkLabelMostrar";
            this.linkLabelMostrar.Size = new System.Drawing.Size(42, 13);
            this.linkLabelMostrar.TabIndex = 36;
            this.linkLabelMostrar.TabStop = true;
            this.linkLabelMostrar.Text = "Mostrar";
            this.linkLabelMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostrar_LinkClicked);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPass.Location = new System.Drawing.Point(200, 198);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(167, 19);
            this.textBoxPass.TabIndex = 35;
            this.textBoxPass.Text = "password";
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUser.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxUser.Location = new System.Drawing.Point(200, 168);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(167, 19);
            this.TextBoxUser.TabIndex = 34;
            this.TextBoxUser.Text = "username";
            // 
            // but_Registro
            // 
            this.but_Registro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_Registro.Location = new System.Drawing.Point(200, 253);
            this.but_Registro.Name = "but_Registro";
            this.but_Registro.Size = new System.Drawing.Size(74, 29);
            this.but_Registro.TabIndex = 33;
            this.but_Registro.Text = "Registrar";
            this.but_Registro.UseVisualStyleBackColor = true;
            this.but_Registro.Click += new System.EventHandler(this.but_Registro_Click);
            // 
            // but_cancelar
            // 
            this.but_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_cancelar.Location = new System.Drawing.Point(293, 253);
            this.but_cancelar.Name = "but_cancelar";
            this.but_cancelar.Size = new System.Drawing.Size(74, 29);
            this.but_cancelar.TabIndex = 32;
            this.but_cancelar.Text = "Cancelar";
            this.but_cancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxRepetirPass
            // 
            this.textBoxRepetirPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRepetirPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepetirPass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRepetirPass.Location = new System.Drawing.Point(200, 223);
            this.textBoxRepetirPass.Name = "textBoxRepetirPass";
            this.textBoxRepetirPass.Size = new System.Drawing.Size(167, 19);
            this.textBoxRepetirPass.TabIndex = 39;
            this.textBoxRepetirPass.Text = "Repetir pasword";
            this.textBoxRepetirPass.UseSystemPasswordChar = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRepetirPass);
            this.Controls.Add(this.linkLabelMostrar);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.but_Registro);
            this.Controls.Add(this.but_cancelar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelMostrar;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.Button but_Registro;
        private System.Windows.Forms.Button but_cancelar;
        private System.Windows.Forms.TextBox textBoxRepetirPass;
    }
}