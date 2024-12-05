namespace capa_presentacion
{
    partial class frmestadousuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmestadousuario));
            this.fotoperfil = new System.Windows.Forms.PictureBox();
            this.nombreusuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.editarperfil = new System.Windows.Forms.Button();
            this.numerodelular = new System.Windows.Forms.Label();
            this.carnet = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.datagrid1 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.fotoperfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // fotoperfil
            // 
            this.fotoperfil.Location = new System.Drawing.Point(22, 12);
            this.fotoperfil.Name = "fotoperfil";
            this.fotoperfil.Size = new System.Drawing.Size(192, 190);
            this.fotoperfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoperfil.TabIndex = 0;
            this.fotoperfil.TabStop = false;
            // 
            // nombreusuario
            // 
            this.nombreusuario.AutoSize = true;
            this.nombreusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreusuario.Location = new System.Drawing.Point(16, 216);
            this.nombreusuario.Name = "nombreusuario";
            this.nombreusuario.Size = new System.Drawing.Size(86, 31);
            this.nombreusuario.TabIndex = 1;
            this.nombreusuario.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1186, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // editarperfil
            // 
            this.editarperfil.BackColor = System.Drawing.Color.LightSkyBlue;
            this.editarperfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editarperfil.Location = new System.Drawing.Point(1010, 129);
            this.editarperfil.Name = "editarperfil";
            this.editarperfil.Size = new System.Drawing.Size(176, 39);
            this.editarperfil.TabIndex = 3;
            this.editarperfil.Text = "EDITAR PERFIL";
            this.editarperfil.UseVisualStyleBackColor = false;
            // 
            // numerodelular
            // 
            this.numerodelular.AutoSize = true;
            this.numerodelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerodelular.Location = new System.Drawing.Point(326, 126);
            this.numerodelular.Name = "numerodelular";
            this.numerodelular.Size = new System.Drawing.Size(86, 31);
            this.numerodelular.TabIndex = 5;
            this.numerodelular.Text = "label2";
            // 
            // carnet
            // 
            this.carnet.AutoSize = true;
            this.carnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carnet.Location = new System.Drawing.Point(326, 157);
            this.carnet.Name = "carnet";
            this.carnet.Size = new System.Drawing.Size(86, 31);
            this.carnet.TabIndex = 6;
            this.carnet.Text = "label3";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(326, 188);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(86, 31);
            this.correo.TabIndex = 7;
            this.correo.Text = "label4";
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(669, 216);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(484, 307);
            this.plotView1.TabIndex = 8;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.plotView1.Click += new System.EventHandler(this.plotView1_Click);
            // 
            // datagrid1
            // 
            this.datagrid1.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.datagrid1.BackColor = System.Drawing.Color.GhostWhite;
            this.datagrid1.BackgroundColor = System.Drawing.Color.Lavender;
            this.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid1.CaptionBackColor = System.Drawing.Color.RoyalBlue;
            this.datagrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datagrid1.CaptionForeColor = System.Drawing.Color.White;
            this.datagrid1.DataMember = "";
            this.datagrid1.FlatMode = true;
            this.datagrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datagrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.datagrid1.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.datagrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.datagrid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datagrid1.HeaderForeColor = System.Drawing.Color.Lavender;
            this.datagrid1.LinkColor = System.Drawing.Color.Teal;
            this.datagrid1.Location = new System.Drawing.Point(12, 274);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.datagrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.datagrid1.SelectionBackColor = System.Drawing.Color.Teal;
            this.datagrid1.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.datagrid1.Size = new System.Drawing.Size(625, 225);
            this.datagrid1.TabIndex = 9;
            this.datagrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.datagrid1_Navigate);
            // 
            // frmestadousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.datagrid1);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.carnet);
            this.Controls.Add(this.numerodelular);
            this.Controls.Add(this.editarperfil);
            this.Controls.Add(this.fotoperfil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nombreusuario);
            this.Name = "frmestadousuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmestadousuario";
            this.Load += new System.EventHandler(this.frmestadousuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoperfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoperfil;
        private System.Windows.Forms.Label nombreusuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button editarperfil;
        private System.Windows.Forms.Label numerodelular;
        private System.Windows.Forms.Label carnet;
        private System.Windows.Forms.Label correo;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.DataGrid datagrid1;
    }
}