namespace capa_presentacion
{
    partial class frmagregartexto
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
            this.titulo1 = new System.Windows.Forms.LinkLabel();
            this.agregartexto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Location = new System.Drawing.Point(267, 9);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(60, 13);
            this.titulo1.TabIndex = 0;
            this.titulo1.TabStop = true;
            this.titulo1.Text = "AGREGAR";
            // 
            // agregartexto
            // 
            this.agregartexto.Location = new System.Drawing.Point(183, 49);
            this.agregartexto.Name = "agregartexto";
            this.agregartexto.Size = new System.Drawing.Size(232, 20);
            this.agregartexto.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmagregartexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 147);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.agregartexto);
            this.Controls.Add(this.titulo1);
            this.Name = "frmagregartexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmagregartexto";
            this.Load += new System.EventHandler(this.frmagregartexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel titulo1;
        private System.Windows.Forms.TextBox agregartexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}