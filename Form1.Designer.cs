namespace examen3aParcial
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clickDerechoJug = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumEquipo = new System.Windows.Forms.TextBox();
            this.grupoEquipo = new System.Windows.Forms.GroupBox();
            this.btnAgEquipo = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.txtNombreJug = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdadJug = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroJug = new System.Windows.Forms.TextBox();
            this.grupoJugador = new System.Windows.Forms.GroupBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarJug = new System.Windows.Forms.Button();
            this.listaEquipos = new System.Windows.Forms.ListBox();
            this.clickDerechoEquipo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasarA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaJugadores = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grupoJornada = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGoles = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardarJornada = new System.Windows.Forms.Button();
            this.txtEquipo2 = new System.Windows.Forms.TextBox();
            this.txtEquipo1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numJornada = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.listaEquiposJornada = new System.Windows.Forms.ListBox();
            this.clickDerechoEquiJornada = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.equipo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaJornada = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.clickDerechoJug.SuspendLayout();
            this.grupoEquipo.SuspendLayout();
            this.grupoJugador.SuspendLayout();
            this.clickDerechoEquipo.SuspendLayout();
            this.grupoJornada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJornada)).BeginInit();
            this.clickDerechoEquiJornada.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.clickDerechoJug;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposToolStripMenuItem,
            this.jugadoresToolStripMenuItem,
            this.jornadaToolStripMenuItem,
            this.generarReporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clickDerechoJug
            // 
            this.clickDerechoJug.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem2});
            this.clickDerechoJug.Name = "clickDerechoJug";
            this.clickDerechoJug.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            this.eliminarToolStripMenuItem2.Click += new System.EventHandler(this.eliminarToolStripMenuItem2_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1});
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jugadoresToolStripMenuItem.Text = "Jugadores";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // jornadaToolStripMenuItem
            // 
            this.jornadaToolStripMenuItem.Name = "jornadaToolStripMenuItem";
            this.jornadaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.jornadaToolStripMenuItem.Text = "Jornada";
            this.jornadaToolStripMenuItem.Click += new System.EventHandler(this.jornadaToolStripMenuItem_Click);
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.generarReporteToolStripMenuItem.Text = "Generar Reporte";
            this.generarReporteToolStripMenuItem.Click += new System.EventHandler(this.generarReporteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.Location = new System.Drawing.Point(72, 18);
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNomEquipo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero";
            // 
            // txtNumEquipo
            // 
            this.txtNumEquipo.Location = new System.Drawing.Point(72, 53);
            this.txtNumEquipo.Name = "txtNumEquipo";
            this.txtNumEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNumEquipo.TabIndex = 4;
            // 
            // grupoEquipo
            // 
            this.grupoEquipo.Controls.Add(this.btnAgEquipo);
            this.grupoEquipo.Controls.Add(this.txtNumEquipo);
            this.grupoEquipo.Controls.Add(this.label1);
            this.grupoEquipo.Controls.Add(this.txtNomEquipo);
            this.grupoEquipo.Controls.Add(this.label2);
            this.grupoEquipo.Location = new System.Drawing.Point(12, 27);
            this.grupoEquipo.Name = "grupoEquipo";
            this.grupoEquipo.Size = new System.Drawing.Size(200, 117);
            this.grupoEquipo.TabIndex = 5;
            this.grupoEquipo.TabStop = false;
            this.grupoEquipo.Text = "Equipo";
            this.grupoEquipo.Visible = false;
            this.grupoEquipo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAgEquipo
            // 
            this.btnAgEquipo.Location = new System.Drawing.Point(59, 79);
            this.btnAgEquipo.Name = "btnAgEquipo";
            this.btnAgEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnAgEquipo.TabIndex = 0;
            this.btnAgEquipo.Text = "Agregar";
            this.btnAgEquipo.UseVisualStyleBackColor = true;
            this.btnAgEquipo.Click += new System.EventHandler(this.btnAgEquipo_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(27, 60);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 6;
            this.nombre.Text = "Nombre";
            // 
            // txtNombreJug
            // 
            this.txtNombreJug.Location = new System.Drawing.Point(86, 60);
            this.txtNombreJug.Name = "txtNombreJug";
            this.txtNombreJug.Size = new System.Drawing.Size(100, 20);
            this.txtNombreJug.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Edad";
            // 
            // txtEdadJug
            // 
            this.txtEdadJug.Location = new System.Drawing.Point(86, 91);
            this.txtEdadJug.Name = "txtEdadJug";
            this.txtEdadJug.Size = new System.Drawing.Size(100, 20);
            this.txtEdadJug.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero";
            // 
            // txtNumeroJug
            // 
            this.txtNumeroJug.Location = new System.Drawing.Point(86, 128);
            this.txtNumeroJug.Name = "txtNumeroJug";
            this.txtNumeroJug.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroJug.TabIndex = 11;
            // 
            // grupoJugador
            // 
            this.grupoJugador.Controls.Add(this.txtNombreEquipo);
            this.grupoJugador.Controls.Add(this.label5);
            this.grupoJugador.Controls.Add(this.btnAgregarJug);
            this.grupoJugador.Controls.Add(this.txtNumeroJug);
            this.grupoJugador.Controls.Add(this.label4);
            this.grupoJugador.Controls.Add(this.nombre);
            this.grupoJugador.Controls.Add(this.txtEdadJug);
            this.grupoJugador.Controls.Add(this.txtNombreJug);
            this.grupoJugador.Controls.Add(this.label3);
            this.grupoJugador.Location = new System.Drawing.Point(218, 27);
            this.grupoJugador.Name = "grupoJugador";
            this.grupoJugador.Size = new System.Drawing.Size(220, 199);
            this.grupoJugador.TabIndex = 12;
            this.grupoJugador.TabStop = false;
            this.grupoJugador.Text = "Jugadores";
            this.grupoJugador.Visible = false;
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(86, 25);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEquipo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Equipo";
            // 
            // btnAgregarJug
            // 
            this.btnAgregarJug.Location = new System.Drawing.Point(73, 154);
            this.btnAgregarJug.Name = "btnAgregarJug";
            this.btnAgregarJug.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarJug.TabIndex = 0;
            this.btnAgregarJug.Text = "Agregar";
            this.btnAgregarJug.UseVisualStyleBackColor = true;
            this.btnAgregarJug.Click += new System.EventHandler(this.btnAgregarJug_Click);
            // 
            // listaEquipos
            // 
            this.listaEquipos.ContextMenuStrip = this.clickDerechoEquipo;
            this.listaEquipos.FormattingEnabled = true;
            this.listaEquipos.Location = new System.Drawing.Point(461, 27);
            this.listaEquipos.Name = "listaEquipos";
            this.listaEquipos.Size = new System.Drawing.Size(206, 199);
            this.listaEquipos.TabIndex = 13;
            // 
            // clickDerechoEquipo
            // 
            this.clickDerechoEquipo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasarA1ToolStripMenuItem});
            this.clickDerechoEquipo.Name = "contextMenuStrip1";
            this.clickDerechoEquipo.Size = new System.Drawing.Size(118, 26);
            this.clickDerechoEquipo.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // pasarA1ToolStripMenuItem
            // 
            this.pasarA1ToolStripMenuItem.Name = "pasarA1ToolStripMenuItem";
            this.pasarA1ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.pasarA1ToolStripMenuItem.Text = "Eliminar";
            this.pasarA1ToolStripMenuItem.Click += new System.EventHandler(this.pasarA1ToolStripMenuItem_Click);
            // 
            // listaJugadores
            // 
            this.listaJugadores.ContextMenuStrip = this.clickDerechoJug;
            this.listaJugadores.FormattingEnabled = true;
            this.listaJugadores.Location = new System.Drawing.Point(684, 27);
            this.listaJugadores.Name = "listaJugadores";
            this.listaJugadores.Size = new System.Drawing.Size(190, 199);
            this.listaJugadores.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Equipos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(753, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Jugadores";
            // 
            // grupoJornada
            // 
            this.grupoJornada.Controls.Add(this.label14);
            this.grupoJornada.Controls.Add(this.txtGoles);
            this.grupoJornada.Controls.Add(this.txtEstado);
            this.grupoJornada.Controls.Add(this.label12);
            this.grupoJornada.Controls.Add(this.label13);
            this.grupoJornada.Controls.Add(this.listaJornada);
            this.grupoJornada.Controls.Add(this.label11);
            this.grupoJornada.Controls.Add(this.btnGuardarJornada);
            this.grupoJornada.Controls.Add(this.txtEquipo2);
            this.grupoJornada.Controls.Add(this.listaEquiposJornada);
            this.grupoJornada.Controls.Add(this.txtEquipo1);
            this.grupoJornada.Controls.Add(this.label10);
            this.grupoJornada.Controls.Add(this.label9);
            this.grupoJornada.Controls.Add(this.numJornada);
            this.grupoJornada.Controls.Add(this.label8);
            this.grupoJornada.Location = new System.Drawing.Point(12, 232);
            this.grupoJornada.Name = "grupoJornada";
            this.grupoJornada.Size = new System.Drawing.Size(886, 189);
            this.grupoJornada.TabIndex = 16;
            this.grupoJornada.TabStop = false;
            this.grupoJornada.Text = "Jornada";
            this.grupoJornada.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(203, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Goles";
            // 
            // txtGoles
            // 
            this.txtGoles.Location = new System.Drawing.Point(206, 85);
            this.txtGoles.Name = "txtGoles";
            this.txtGoles.Size = new System.Drawing.Size(34, 20);
            this.txtGoles.TabIndex = 26;
            this.txtGoles.Text = "0-0";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(34, 153);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Estado (Jugado / no jugado)";
            // 
            // btnGuardarJornada
            // 
            this.btnGuardarJornada.Location = new System.Drawing.Point(167, 150);
            this.btnGuardarJornada.Name = "btnGuardarJornada";
            this.btnGuardarJornada.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarJornada.TabIndex = 21;
            this.btnGuardarJornada.Text = "Guardar";
            this.btnGuardarJornada.UseVisualStyleBackColor = true;
            this.btnGuardarJornada.Click += new System.EventHandler(this.btnGuardarJornada_Click);
            // 
            // txtEquipo2
            // 
            this.txtEquipo2.Location = new System.Drawing.Point(88, 89);
            this.txtEquipo2.Name = "txtEquipo2";
            this.txtEquipo2.Size = new System.Drawing.Size(100, 20);
            this.txtEquipo2.TabIndex = 20;
            // 
            // txtEquipo1
            // 
            this.txtEquipo1.Location = new System.Drawing.Point(88, 59);
            this.txtEquipo1.Name = "txtEquipo1";
            this.txtEquipo1.Size = new System.Drawing.Size(100, 20);
            this.txtEquipo1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Equipo 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Equipo 1";
            // 
            // numJornada
            // 
            this.numJornada.Location = new System.Drawing.Point(88, 29);
            this.numJornada.Name = "numJornada";
            this.numJornada.Size = new System.Drawing.Size(120, 20);
            this.numJornada.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numero";
            // 
            // listaEquiposJornada
            // 
            this.listaEquiposJornada.ContextMenuStrip = this.clickDerechoEquiJornada;
            this.listaEquiposJornada.FormattingEnabled = true;
            this.listaEquiposJornada.Location = new System.Drawing.Point(272, 59);
            this.listaEquiposJornada.Name = "listaEquiposJornada";
            this.listaEquiposJornada.Size = new System.Drawing.Size(154, 108);
            this.listaEquiposJornada.TabIndex = 22;
            // 
            // clickDerechoEquiJornada
            // 
            this.clickDerechoEquiJornada.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipo1ToolStripMenuItem,
            this.equipo2ToolStripMenuItem});
            this.clickDerechoEquiJornada.Name = "clickDerechoEquiJornada";
            this.clickDerechoEquiJornada.Size = new System.Drawing.Size(121, 48);
            // 
            // equipo1ToolStripMenuItem
            // 
            this.equipo1ToolStripMenuItem.Name = "equipo1ToolStripMenuItem";
            this.equipo1ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.equipo1ToolStripMenuItem.Text = "Equipo 1";
            this.equipo1ToolStripMenuItem.Click += new System.EventHandler(this.equipo1ToolStripMenuItem_Click);
            // 
            // equipo2ToolStripMenuItem
            // 
            this.equipo2ToolStripMenuItem.Name = "equipo2ToolStripMenuItem";
            this.equipo2ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.equipo2ToolStripMenuItem.Text = "Equipo 2";
            this.equipo2ToolStripMenuItem.Click += new System.EventHandler(this.equipo2ToolStripMenuItem_Click);
            // 
            // listaJornada
            // 
            this.listaJornada.FormattingEnabled = true;
            this.listaJornada.Location = new System.Drawing.Point(449, 59);
            this.listaJornada.Name = "listaJornada";
            this.listaJornada.Size = new System.Drawing.Size(413, 108);
            this.listaJornada.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Click derecho al equipo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(629, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Jornadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 433);
            this.Controls.Add(this.grupoJornada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listaJugadores);
            this.Controls.Add(this.listaEquipos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grupoEquipo);
            this.Controls.Add(this.grupoJugador);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.clickDerechoJug.ResumeLayout(false);
            this.grupoEquipo.ResumeLayout(false);
            this.grupoEquipo.PerformLayout();
            this.grupoJugador.ResumeLayout(false);
            this.grupoJugador.PerformLayout();
            this.clickDerechoEquipo.ResumeLayout(false);
            this.grupoJornada.ResumeLayout(false);
            this.grupoJornada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJornada)).EndInit();
            this.clickDerechoEquiJornada.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumEquipo;
        private System.Windows.Forms.GroupBox grupoEquipo;
        private System.Windows.Forms.Button btnAgEquipo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox txtNombreJug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdadJug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroJug;
        private System.Windows.Forms.GroupBox grupoJugador;
        private System.Windows.Forms.ListBox listaEquipos;
        private System.Windows.Forms.Button btnAgregarJug;
        private System.Windows.Forms.ListBox listaJugadores;
        private System.Windows.Forms.ContextMenuStrip clickDerechoEquipo;
        private System.Windows.Forms.ToolStripMenuItem pasarA1ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip clickDerechoJug;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.GroupBox grupoJornada;
        private System.Windows.Forms.Button btnGuardarJornada;
        private System.Windows.Forms.TextBox txtEquipo2;
        private System.Windows.Forms.TextBox txtEquipo1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numJornada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listaEquiposJornada;
        private System.Windows.Forms.ListBox listaJornada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGoles;
        private System.Windows.Forms.ContextMenuStrip clickDerechoEquiJornada;
        private System.Windows.Forms.ToolStripMenuItem equipo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jornadaToolStripMenuItem;
    }
}

