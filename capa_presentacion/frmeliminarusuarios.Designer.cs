﻿namespace capa_presentacion
{
    partial class frmeliminarusuarios
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
            this.user = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.carnetidentidad = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guadarcambios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombrecombox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fotousuario = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.modificarhorario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numerocelular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotousuario)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Impact", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(684, 29);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(140, 46);
            this.user.TabIndex = 24;
            this.user.Text = "usuario";
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(502, 273);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(299, 20);
            this.contraseña.TabIndex = 22;
            // 
            // carnetidentidad
            // 
            this.carnetidentidad.Location = new System.Drawing.Point(502, 219);
            this.carnetidentidad.Name = "carnetidentidad";
            this.carnetidentidad.Size = new System.Drawing.Size(299, 20);
            this.carnetidentidad.TabIndex = 21;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(502, 163);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(299, 20);
            this.apellido.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "CONTRASEÑA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "CARNET DE IDENTIDAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "APELLIDO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "NOMBRE:";
            // 
            // guadarcambios
            // 
            this.guadarcambios.Location = new System.Drawing.Point(711, 443);
            this.guadarcambios.Name = "guadarcambios";
            this.guadarcambios.Size = new System.Drawing.Size(148, 42);
            this.guadarcambios.TabIndex = 15;
            this.guadarcambios.Text = "GUARDAR CAMBIOS";
            this.guadarcambios.UseVisualStyleBackColor = true;
            this.guadarcambios.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "MODIFICAR";
            // 
            // nombrecombox
            // 
            this.nombrecombox.FormattingEnabled = true;
            this.nombrecombox.Location = new System.Drawing.Point(502, 119);
            this.nombrecombox.Name = "nombrecombox";
            this.nombrecombox.Size = new System.Drawing.Size(299, 21);
            this.nombrecombox.TabIndex = 25;
            this.nombrecombox.SelectedIndexChanged += new System.EventHandler(this.nombrecombox_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fotousuario
            // 
            this.fotousuario.Location = new System.Drawing.Point(43, 107);
            this.fotousuario.Name = "fotousuario";
            this.fotousuario.Size = new System.Drawing.Size(179, 177);
            this.fotousuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotousuario.TabIndex = 27;
            this.fotousuario.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(865, 153);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(307, 243);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(882, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 34);
            this.label6.TabIndex = 29;
            this.label6.Text = "HORARIOS DEL DOCENTE";
            // 
            // modificarhorario
            // 
            this.modificarhorario.Location = new System.Drawing.Point(479, 443);
            this.modificarhorario.Name = "modificarhorario";
            this.modificarhorario.Size = new System.Drawing.Size(148, 42);
            this.modificarhorario.TabIndex = 30;
            this.modificarhorario.Text = "MODIFICAR HORARIOS";
            this.modificarhorario.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "CORREO ELECTRONICO: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "FOTO DEL USUARIO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 32);
            this.label9.TabIndex = 34;
            this.label9.Text = "NUMERO DE CELULAR:";
            // 
            // numerocelular
            // 
            this.numerocelular.Location = new System.Drawing.Point(502, 382);
            this.numerocelular.Name = "numerocelular";
            this.numerocelular.Size = new System.Drawing.Size(299, 20);
            this.numerocelular.TabIndex = 35;
            // 
            // frmeliminarusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.numerocelular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modificarhorario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fotousuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombrecombox);
            this.Controls.Add(this.user);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.carnetidentidad);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guadarcambios);
            this.Controls.Add(this.label1);
            this.Name = "frmeliminarusuarios";
            this.Text = "frmeliminardocentes";
            this.Load += new System.EventHandler(this.frmeliminarusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotousuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox carnetidentidad;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guadarcambios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nombrecombox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox fotousuario;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modificarhorario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numerocelular;
    }
}