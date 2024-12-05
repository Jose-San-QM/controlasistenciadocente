namespace capa_presentacion
{
    partial class frmmarcarasistencia
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
            this.leerqr1 = new System.Windows.Forms.PictureBox();
            this.qrdenuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leerqr1)).BeginInit();
            this.SuspendLayout();
            // 
            // leerqr1
            // 
            this.leerqr1.Location = new System.Drawing.Point(372, 12);
            this.leerqr1.Name = "leerqr1";
            this.leerqr1.Size = new System.Drawing.Size(460, 383);
            this.leerqr1.TabIndex = 0;
            this.leerqr1.TabStop = false;
            // 
            // qrdenuevo
            // 
            this.qrdenuevo.Location = new System.Drawing.Point(470, 428);
            this.qrdenuevo.Name = "qrdenuevo";
            this.qrdenuevo.Size = new System.Drawing.Size(241, 48);
            this.qrdenuevo.TabIndex = 1;
            this.qrdenuevo.Text = "MANDAR CODIGO QR";
            this.qrdenuevo.UseVisualStyleBackColor = true;
            this.qrdenuevo.Click += new System.EventHandler(this.qrdenuevo_Click);
            // 
            // frmmarcarasistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.qrdenuevo);
            this.Controls.Add(this.leerqr1);
            this.Name = "frmmarcarasistencia";
            this.Text = "frmempleado";
            this.Load += new System.EventHandler(this.frmmarcarasistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leerqr1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox leerqr1;
        private System.Windows.Forms.Button qrdenuevo;
    }
}