namespace capa_presentacion
{
    partial class frmagregarusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmagregarusuarios));
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrardocente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.carnetidentidad = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.fotousuario = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.añadirhorario = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.user2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listahorarios = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.numerocelular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotousuario)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(518, 106);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(296, 20);
            this.nombre.TabIndex = 1;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRAR";
            // 
            // registrardocente
            // 
            this.registrardocente.Location = new System.Drawing.Point(756, 437);
            this.registrardocente.Name = "registrardocente";
            this.registrardocente.Size = new System.Drawing.Size(148, 42);
            this.registrardocente.TabIndex = 3;
            this.registrardocente.Text = "REGISTRAR";
            this.registrardocente.UseVisualStyleBackColor = true;
            this.registrardocente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "CARNET DE IDENTIDAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "CONTRASEÑA:";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(515, 154);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(299, 20);
            this.apellido.TabIndex = 8;
            this.apellido.TextChanged += new System.EventHandler(this.apellido_TextChanged);
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_KeyPress);
            // 
            // carnetidentidad
            // 
            this.carnetidentidad.Location = new System.Drawing.Point(574, 218);
            this.carnetidentidad.Name = "carnetidentidad";
            this.carnetidentidad.Size = new System.Drawing.Size(240, 20);
            this.carnetidentidad.TabIndex = 9;
            this.carnetidentidad.TextChanged += new System.EventHandler(this.carnetidentidad_TextChanged);
            this.carnetidentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carnetidentidad_KeyPress);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(515, 268);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(296, 20);
            this.contraseña.TabIndex = 10;
            this.contraseña.Click += new System.EventHandler(this.contraseña_Click);
            this.contraseña.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            this.contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contraseña_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Impact", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(716, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(175, 59);
            this.user.TabIndex = 12;
            this.user.Text = "usuario";
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(352, 315);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(90, 28);
            this.email.TabIndex = 13;
            this.email.Text = "CORREO:";
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(512, 315);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(299, 20);
            this.correo.TabIndex = 14;
            this.correo.TextChanged += new System.EventHandler(this.correo_TextChanged);
            this.correo.Leave += new System.EventHandler(this.correo_Leave);
            // 
            // fotousuario
            // 
            this.fotousuario.InitialImage = ((System.Drawing.Image)(resources.GetObject("fotousuario.InitialImage")));
            this.fotousuario.Location = new System.Drawing.Point(80, 106);
            this.fotousuario.Name = "fotousuario";
            this.fotousuario.Size = new System.Drawing.Size(202, 208);
            this.fotousuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotousuario.TabIndex = 25;
            this.fotousuario.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "SELECCIONAR FOTO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // añadirhorario
            // 
            this.añadirhorario.Location = new System.Drawing.Point(503, 437);
            this.añadirhorario.Name = "añadirhorario";
            this.añadirhorario.Size = new System.Drawing.Size(206, 42);
            this.añadirhorario.TabIndex = 27;
            this.añadirhorario.Text = "AÑADIR HORARIO";
            this.añadirhorario.UseVisualStyleBackColor = true;
            this.añadirhorario.Click += new System.EventHandler(this.button3_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(105, 327);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 17);
            this.label.TabIndex = 28;
            this.label.Text = "FOTO DEL ";
            // 
            // user2
            // 
            this.user2.AutoSize = true;
            this.user2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.user2.ForeColor = System.Drawing.Color.Black;
            this.user2.Location = new System.Drawing.Point(184, 326);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(55, 17);
            this.user2.TabIndex = 29;
            this.user2.Text = "usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(875, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 34);
            this.label6.TabIndex = 31;
            this.label6.Text = "HORARIOS DEL DOCENTE:";
            // 
            // listahorarios
            // 
            this.listahorarios.HideSelection = false;
            this.listahorarios.Location = new System.Drawing.Point(848, 164);
            this.listahorarios.Name = "listahorarios";
            this.listahorarios.Size = new System.Drawing.Size(324, 240);
            this.listahorarios.TabIndex = 32;
            this.listahorarios.UseCompatibleStateImageBehavior = false;
            this.listahorarios.View = System.Windows.Forms.View.List;
            this.listahorarios.SelectedIndexChanged += new System.EventHandler(this.listahorarios_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "NUMERO DE CELULAR:";
            // 
            // numerocelular
            // 
            this.numerocelular.Location = new System.Drawing.Point(574, 367);
            this.numerocelular.Name = "numerocelular";
            this.numerocelular.Size = new System.Drawing.Size(240, 20);
            this.numerocelular.TabIndex = 34;
            this.numerocelular.TextChanged += new System.EventHandler(this.numerocelular_TextChanged);
            this.numerocelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerocelular_KeyPress);
            // 
            // frmagregarusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.numerocelular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listahorarios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.añadirhorario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotousuario);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.user);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.carnetidentidad);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrardocente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Name = "frmagregarusuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmadmindocentes";
            this.Load += new System.EventHandler(this.frmagregarusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotousuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrardocente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox carnetidentidad;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.PictureBox fotousuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button añadirhorario;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label user2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listahorarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numerocelular;
    }
}