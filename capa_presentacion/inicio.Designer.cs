using System.Windows.Forms;
using capa_negocio;
using FontAwesome.Sharp;

namespace capa_presentacion
{
    partial class inicio
    {
       
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.marcarasistencia = new FontAwesome.Sharp.IconMenuItem();
            this.estadousuario = new FontAwesome.Sharp.IconMenuItem();
            this.usuarios = new FontAwesome.Sharp.IconMenuItem();
            this.admindocentes = new FontAwesome.Sharp.IconMenuItem();
            this.agregardocente = new FontAwesome.Sharp.IconMenuItem();
            this.modificardocente = new FontAwesome.Sharp.IconMenuItem();
            this.adminempleados = new FontAwesome.Sharp.IconMenuItem();
            this.agregarempleado = new FontAwesome.Sharp.IconMenuItem();
            this.eliminarempleado = new FontAwesome.Sharp.IconMenuItem();
            this.reportes = new FontAwesome.Sharp.IconMenuItem();
            this.listaasistencias = new FontAwesome.Sharp.IconMenuItem();
            this.listadocentes = new FontAwesome.Sharp.IconMenuItem();
            this.listaempleados = new FontAwesome.Sharp.IconMenuItem();
            this.informacion = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarasistencia,
            this.estadousuario,
            this.usuarios,
            this.reportes,
            this.informacion});
            this.menu.Location = new System.Drawing.Point(0, 84);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1184, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // marcarasistencia
            // 
            this.marcarasistencia.AutoSize = false;
            this.marcarasistencia.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.marcarasistencia.IconColor = System.Drawing.Color.Black;
            this.marcarasistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.marcarasistencia.IconSize = 50;
            this.marcarasistencia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.marcarasistencia.Name = "marcarasistencia";
            this.marcarasistencia.Size = new System.Drawing.Size(122, 69);
            this.marcarasistencia.Text = "MARCAR ASISTENCIA";
            this.marcarasistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.marcarasistencia.Click += new System.EventHandler(this.marcarasistencia_Click);
            // 
            // estadousuario
            // 
            this.estadousuario.AutoSize = false;
            this.estadousuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.estadousuario.IconColor = System.Drawing.Color.Black;
            this.estadousuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.estadousuario.IconSize = 50;
            this.estadousuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.estadousuario.Name = "estadousuario";
            this.estadousuario.Size = new System.Drawing.Size(186, 69);
            this.estadousuario.Text = "PERFIL";
            this.estadousuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.estadousuario.Click += new System.EventHandler(this.estadousuario_Click);
            // 
            // usuarios
            // 
            this.usuarios.AutoSize = false;
            this.usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admindocentes,
            this.adminempleados});
            this.usuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.usuarios.IconColor = System.Drawing.Color.Black;
            this.usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usuarios.IconSize = 50;
            this.usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(122, 69);
            this.usuarios.Text = "USUARIOS";
            this.usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // admindocentes
            // 
            this.admindocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregardocente,
            this.modificardocente});
            this.admindocentes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.admindocentes.IconColor = System.Drawing.Color.Black;
            this.admindocentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.admindocentes.Name = "admindocentes";
            this.admindocentes.Size = new System.Drawing.Size(220, 22);
            this.admindocentes.Text = "ADMINISTRAR DOCENTES";
            this.admindocentes.Click += new System.EventHandler(this.admindocentes_Click);
            // 
            // agregardocente
            // 
            this.agregardocente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.agregardocente.IconColor = System.Drawing.Color.Black;
            this.agregardocente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregardocente.Name = "agregardocente";
            this.agregardocente.Size = new System.Drawing.Size(192, 22);
            this.agregardocente.Text = "AGREGAR DOCENTE";
            this.agregardocente.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // modificardocente
            // 
            this.modificardocente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.modificardocente.IconColor = System.Drawing.Color.Black;
            this.modificardocente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modificardocente.Name = "modificardocente";
            this.modificardocente.Size = new System.Drawing.Size(192, 22);
            this.modificardocente.Text = "MODIFICAR DOCENTE";
            this.modificardocente.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // adminempleados
            // 
            this.adminempleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarempleado,
            this.eliminarempleado});
            this.adminempleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.adminempleados.IconColor = System.Drawing.Color.Black;
            this.adminempleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adminempleados.Name = "adminempleados";
            this.adminempleados.Size = new System.Drawing.Size(220, 22);
            this.adminempleados.Text = "ADMINISTRAR EMPLEADOS";
            this.adminempleados.Click += new System.EventHandler(this.adminempleados_Click);
            // 
            // agregarempleado
            // 
            this.agregarempleado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.agregarempleado.IconColor = System.Drawing.Color.Black;
            this.agregarempleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarempleado.Name = "agregarempleado";
            this.agregarempleado.Size = new System.Drawing.Size(201, 22);
            this.agregarempleado.Text = "AGREGAR EMPLEADO";
            this.agregarempleado.Click += new System.EventHandler(this.agregarempleado_Click);
            // 
            // eliminarempleado
            // 
            this.eliminarempleado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.eliminarempleado.IconColor = System.Drawing.Color.Black;
            this.eliminarempleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eliminarempleado.Name = "eliminarempleado";
            this.eliminarempleado.Size = new System.Drawing.Size(201, 22);
            this.eliminarempleado.Text = "MODIFICAR EMPLEADO";
            this.eliminarempleado.Click += new System.EventHandler(this.eliminarempleado_Click);
            // 
            // reportes
            // 
            this.reportes.AutoSize = false;
            this.reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaasistencias,
            this.listadocentes,
            this.listaempleados});
            this.reportes.IconChar = FontAwesome.Sharp.IconChar.List;
            this.reportes.IconColor = System.Drawing.Color.Black;
            this.reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportes.IconSize = 50;
            this.reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportes.Name = "reportes";
            this.reportes.Size = new System.Drawing.Size(122, 69);
            this.reportes.Text = "REPORTES";
            this.reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // listaasistencias
            // 
            this.listaasistencias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.listaasistencias.IconColor = System.Drawing.Color.Black;
            this.listaasistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.listaasistencias.Name = "listaasistencias";
            this.listaasistencias.Size = new System.Drawing.Size(249, 22);
            this.listaasistencias.Text = "LISTA ASISTENCIA DOCENTES";
            this.listaasistencias.Click += new System.EventHandler(this.listaasistencias_Click);
            // 
            // listadocentes
            // 
            this.listadocentes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.listadocentes.IconColor = System.Drawing.Color.Black;
            this.listadocentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.listadocentes.Name = "listadocentes";
            this.listadocentes.Size = new System.Drawing.Size(249, 22);
            this.listadocentes.Text = "LITA DOCENTES REGISTRADOS";
            this.listadocentes.Click += new System.EventHandler(this.listadocentes_Click);
            // 
            // listaempleados
            // 
            this.listaempleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.listaempleados.IconColor = System.Drawing.Color.Black;
            this.listaempleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.listaempleados.Name = "listaempleados";
            this.listaempleados.Size = new System.Drawing.Size(249, 22);
            this.listaempleados.Text = "LISTA EMPLEADOS REGISTRADOS";
            this.listaempleados.Click += new System.EventHandler(this.listaempleados_Click);
            // 
            // informacion
            // 
            this.informacion.AutoSize = false;
            this.informacion.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.informacion.IconColor = System.Drawing.Color.Black;
            this.informacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.informacion.IconSize = 50;
            this.informacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(122, 69);
            this.informacion.Text = "INFORMACION";
            this.informacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.informacion.Click += new System.EventHandler(this.informacion_Click);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1184, 84);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA CONTROL ASISTENCIA DOCENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 157);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1184, 504);
            this.contenedor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1093, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem marcarasistencia;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem usuarios;
        private FontAwesome.Sharp.IconMenuItem admindocentes;
        private FontAwesome.Sharp.IconMenuItem adminempleados;
        private FontAwesome.Sharp.IconMenuItem reportes;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem listaasistencias;
        private FontAwesome.Sharp.IconMenuItem listadocentes;
        private FontAwesome.Sharp.IconMenuItem listaempleados;
        private FontAwesome.Sharp.IconMenuItem informacion;
        private IconMenuItem agregardocente;
        private IconMenuItem modificardocente;
        private IconMenuItem agregarempleado;
        private IconMenuItem eliminarempleado;
        private IconMenuItem estadousuario;
        private PictureBox pictureBox1;
    }
}

