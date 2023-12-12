
namespace JogoMemoria
{
    partial class Form4
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
            this.Normal = new System.Windows.Forms.Button();
            this.Facil = new System.Windows.Forms.Button();
            this.Troll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Normal
            // 
            this.Normal.BackColor = System.Drawing.Color.DarkRed;
            this.Normal.Location = new System.Drawing.Point(280, 183);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(200, 39);
            this.Normal.TabIndex = 2;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = false;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // Facil
            // 
            this.Facil.BackColor = System.Drawing.Color.GreenYellow;
            this.Facil.Location = new System.Drawing.Point(280, 123);
            this.Facil.Name = "Facil";
            this.Facil.Size = new System.Drawing.Size(200, 39);
            this.Facil.TabIndex = 3;
            this.Facil.Text = "Facil";
            this.Facil.UseVisualStyleBackColor = false;
            this.Facil.Click += new System.EventHandler(this.Facil_Click);
            // 
            // Troll
            // 
            this.Troll.BackColor = System.Drawing.Color.Yellow;
            this.Troll.Location = new System.Drawing.Point(280, 248);
            this.Troll.Name = "Troll";
            this.Troll.Size = new System.Drawing.Size(200, 39);
            this.Troll.TabIndex = 3;
            this.Troll.Text = "Troll";
            this.Troll.UseVisualStyleBackColor = false;
            this.Troll.Click += new System.EventHandler(this.Troll_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Troll);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Facil);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button Facil;
        private System.Windows.Forms.Button Troll;
    }
}