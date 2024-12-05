namespace capa_presentacion
{
    partial class frmagregarhorarios
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
            this.horafin = new System.Windows.Forms.ComboBox();
            this.horainicio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labealm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cursoscarrera = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.agregarhorario = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.diassemana = new System.Windows.Forms.CheckedListBox();
            this.finalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.laboratorio = new System.Windows.Forms.Label();
            this.laboratoriox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materianom = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listamaterias = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // horafin
            // 
            this.horafin.FormattingEnabled = true;
            this.horafin.Location = new System.Drawing.Point(659, 280);
            this.horafin.Name = "horafin";
            this.horafin.Size = new System.Drawing.Size(163, 21);
            this.horafin.TabIndex = 31;
            // 
            // horainicio
            // 
            this.horainicio.FormattingEnabled = true;
            this.horainicio.Location = new System.Drawing.Point(286, 280);
            this.horainicio.Name = "horainicio";
            this.horainicio.Size = new System.Drawing.Size(163, 21);
            this.horainicio.TabIndex = 30;
            this.horainicio.SelectedIndexChanged += new System.EventHandler(this.horainicio_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 34);
            this.label8.TabIndex = 29;
            this.label8.Text = "HORA DE SALIDA: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 34);
            this.label7.TabIndex = 28;
            this.label7.Text = "INICIO DE CLASES: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 34);
            this.label6.TabIndex = 27;
            this.label6.Text = "SELECCIONAR DIAS DE LA SEMANA:";
            // 
            // labealm
            // 
            this.labealm.AutoSize = true;
            this.labealm.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labealm.Location = new System.Drawing.Point(72, 115);
            this.labealm.Name = "labealm";
            this.labealm.Size = new System.Drawing.Size(268, 34);
            this.labealm.TabIndex = 25;
            this.labealm.Text = "NOMBRE DE LA MATERIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 59);
            this.label1.TabIndex = 33;
            this.label1.Text = "REGISTRAR HORARIO DOCENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 34);
            this.label2.TabIndex = 34;
            this.label2.Text = "CURSO:";
            // 
            // cursoscarrera
            // 
            this.cursoscarrera.FormattingEnabled = true;
            this.cursoscarrera.Location = new System.Drawing.Point(173, 173);
            this.cursoscarrera.Name = "cursoscarrera";
            this.cursoscarrera.Size = new System.Drawing.Size(189, 21);
            this.cursoscarrera.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "AGREGAR MATERIA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agregarhorario
            // 
            this.agregarhorario.Location = new System.Drawing.Point(438, 479);
            this.agregarhorario.Name = "agregarhorario";
            this.agregarhorario.Size = new System.Drawing.Size(143, 39);
            this.agregarhorario.TabIndex = 37;
            this.agregarhorario.Text = "AGREGAR HORARIO";
            this.agregarhorario.UseVisualStyleBackColor = true;
            this.agregarhorario.Click += new System.EventHandler(this.agregarhorario_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(79, 568);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(143, 58);
            this.cancelar.TabIndex = 38;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // diassemana
            // 
            this.diassemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diassemana.FormattingEnabled = true;
            this.diassemana.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO",
            "DOMINGO"});
            this.diassemana.Location = new System.Drawing.Point(173, 367);
            this.diassemana.Name = "diassemana";
            this.diassemana.Size = new System.Drawing.Size(138, 151);
            this.diassemana.TabIndex = 39;
            // 
            // finalizar
            // 
            this.finalizar.Location = new System.Drawing.Point(679, 568);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(143, 58);
            this.finalizar.TabIndex = 40;
            this.finalizar.Text = "FINALIZAR";
            this.finalizar.UseVisualStyleBackColor = true;
            this.finalizar.Click += new System.EventHandler(this.finalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(603, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 34);
            this.label3.TabIndex = 42;
            this.label3.Text = "LISTA DE MATERIAS:";
            // 
            // laboratorio
            // 
            this.laboratorio.AutoSize = true;
            this.laboratorio.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laboratorio.Location = new System.Drawing.Point(465, 164);
            this.laboratorio.Name = "laboratorio";
            this.laboratorio.Size = new System.Drawing.Size(168, 34);
            this.laboratorio.TabIndex = 43;
            this.laboratorio.Text = "LABORATORIO:";
            // 
            // laboratoriox
            // 
            this.laboratoriox.FormattingEnabled = true;
            this.laboratoriox.Location = new System.Drawing.Point(639, 173);
            this.laboratoriox.Name = "laboratoriox";
            this.laboratoriox.Size = new System.Drawing.Size(207, 21);
            this.laboratoriox.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 34);
            this.label4.TabIndex = 45;
            this.label4.Text = "O";
            // 
            // materianom
            // 
            this.materianom.FormattingEnabled = true;
            this.materianom.Location = new System.Drawing.Point(346, 115);
            this.materianom.Name = "materianom";
            this.materianom.Size = new System.Drawing.Size(380, 21);
            this.materianom.TabIndex = 46;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 27);
            this.button2.TabIndex = 47;
            this.button2.Text = "AGREGAR CURSO\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 27);
            this.button3.TabIndex = 48;
            this.button3.Text = "AGREGAR LABORATORIO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 40);
            this.button4.TabIndex = 49;
            this.button4.Text = "ELIMINAR HORARIO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listamaterias
            // 
            this.listamaterias.HideSelection = false;
            this.listamaterias.Location = new System.Drawing.Point(587, 367);
            this.listamaterias.Name = "listamaterias";
            this.listamaterias.Size = new System.Drawing.Size(319, 195);
            this.listamaterias.TabIndex = 50;
            this.listamaterias.UseCompatibleStateImageBehavior = false;
            this.listamaterias.SelectedIndexChanged += new System.EventHandler(this.listamaterias_SelectedIndexChanged_2);
            // 
            // frmagregarhorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 661);
            this.Controls.Add(this.listamaterias);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.materianom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.laboratoriox);
            this.Controls.Add(this.laboratorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.diassemana);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.agregarhorario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cursoscarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horafin);
            this.Controls.Add(this.horainicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labealm);
            this.Name = "frmagregarhorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmagregarhorarios";
            this.Load += new System.EventHandler(this.frmagregarhorarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox horafin;
        private System.Windows.Forms.ComboBox horainicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labealm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cursoscarrera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button agregarhorario;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.CheckedListBox diassemana;
        private System.Windows.Forms.Button finalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laboratorio;
        private System.Windows.Forms.ComboBox laboratoriox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox materianom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listamaterias;
    }
}