namespace capa_presentacion
{
    partial class frmlistaasistencia
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
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.dgvListaDocentes = new System.Windows.Forms.DataGridView();
            this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.presente = new System.Windows.Forms.Button();
            this.falta = new System.Windows.Forms.Button();
            this.permisos = new System.Windows.Forms.Button();
            this.atrasos = new System.Windows.Forms.Button();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(33, 12);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(465, 292);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.plotView1.Click += new System.EventHandler(this.plotView1_Click);
            // 
            // dgvListaDocentes
            // 
            this.dgvListaDocentes.AllowUserToOrderColumns = true;
            this.dgvListaDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrecompleto,
            this.total});
            this.dgvListaDocentes.Location = new System.Drawing.Point(553, 12);
            this.dgvListaDocentes.Name = "dgvListaDocentes";
            this.dgvListaDocentes.Size = new System.Drawing.Size(410, 222);
            this.dgvListaDocentes.TabIndex = 1;
            // 
            // nombrecompleto
            // 
            this.nombrecompleto.HeaderText = "Nombre Completo";
            this.nombrecompleto.Name = "nombrecompleto";
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1007, 201);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label1";
            // 
            // presente
            // 
            this.presente.Location = new System.Drawing.Point(1002, 12);
            this.presente.Name = "presente";
            this.presente.Size = new System.Drawing.Size(75, 23);
            this.presente.TabIndex = 3;
            this.presente.Text = "PRESENTE";
            this.presente.UseVisualStyleBackColor = true;
            this.presente.Click += new System.EventHandler(this.presente_Click);
            // 
            // falta
            // 
            this.falta.Location = new System.Drawing.Point(1002, 101);
            this.falta.Name = "falta";
            this.falta.Size = new System.Drawing.Size(75, 23);
            this.falta.TabIndex = 4;
            this.falta.Text = "FALTAS";
            this.falta.UseVisualStyleBackColor = true;
            this.falta.Click += new System.EventHandler(this.falta_Click);
            // 
            // permisos
            // 
            this.permisos.Location = new System.Drawing.Point(1002, 146);
            this.permisos.Name = "permisos";
            this.permisos.Size = new System.Drawing.Size(75, 23);
            this.permisos.TabIndex = 5;
            this.permisos.Text = "PERMISOS";
            this.permisos.UseVisualStyleBackColor = true;
            this.permisos.Click += new System.EventHandler(this.permisos_Click);
            // 
            // atrasos
            // 
            this.atrasos.Location = new System.Drawing.Point(1002, 57);
            this.atrasos.Name = "atrasos";
            this.atrasos.Size = new System.Drawing.Size(75, 23);
            this.atrasos.TabIndex = 6;
            this.atrasos.Text = "ATRASOS";
            this.atrasos.UseVisualStyleBackColor = true;
            this.atrasos.Click += new System.EventHandler(this.atrasos_Click);
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(33, 322);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(1094, 354);
            this.plotView2.TabIndex = 7;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // frmlistaasistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.atrasos);
            this.Controls.Add(this.permisos);
            this.Controls.Add(this.falta);
            this.Controls.Add(this.presente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvListaDocentes);
            this.Controls.Add(this.plotView1);
            this.Name = "frmlistaasistencia";
            this.Text = "frmlistaasistencia";
            this.Load += new System.EventHandler(this.frmlistaasistencia_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.DataGridView dgvListaDocentes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button presente;
        private System.Windows.Forms.Button falta;
        private System.Windows.Forms.Button permisos;
        private System.Windows.Forms.Button atrasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private OxyPlot.WindowsForms.PlotView plotView2;
    }
}