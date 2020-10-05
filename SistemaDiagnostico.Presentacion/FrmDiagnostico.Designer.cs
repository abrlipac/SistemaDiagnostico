namespace SistemaDiagnostico.Presentacion
{
    partial class FrmDiagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiagnostico));
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkbSeleccionar = new System.Windows.Forms.CheckBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbldiagnostico = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstDiagnostico = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkmalestargeneral = new System.Windows.Forms.CheckBox();
            this.chktosseca = new System.Windows.Forms.CheckBox();
            this.chkperdidagustoolfato = new System.Windows.Forms.CheckBox();
            this.chkfiebreyescalofrios = new System.Windows.Forms.CheckBox();
            this.chktosconstante = new System.Windows.Forms.CheckBox();
            this.chkdolorarticulaciones = new System.Windows.Forms.CheckBox();
            this.chkdolorpecho = new System.Windows.Forms.CheckBox();
            this.chkerupcionespiel = new System.Windows.Forms.CheckBox();
            this.chkojosrojos = new System.Windows.Forms.CheckBox();
            this.chkescalofrios = new System.Windows.Forms.CheckBox();
            this.chkcansancio = new System.Windows.Forms.CheckBox();
            this.chkdificultadrespirar = new System.Windows.Forms.CheckBox();
            this.chkvomito = new System.Windows.Forms.CheckBox();
            this.chknauseas = new System.Windows.Forms.CheckBox();
            this.chkperdidaapetito = new System.Windows.Forms.CheckBox();
            this.chkdolormuscular = new System.Windows.Forms.CheckBox();
            this.chkfiebre = new System.Windows.Forms.CheckBox();
            this.chkcongestionnasal = new System.Windows.Forms.CheckBox();
            this.chkTos = new System.Windows.Forms.CheckBox();
            this.chkdolorcabeza = new System.Windows.Forms.CheckBox();
            this.chkdolorgarganta = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDiagnosticar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.tabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(12, 54);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(959, 492);
            this.tabGeneral.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.dgvGrilla);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(951, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar Diagnostico";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEliminar);
            this.groupBox5.Controls.Add(this.chkbSeleccionar);
            this.groupBox5.Controls.Add(this.lblCantidad);
            this.groupBox5.Location = new System.Drawing.Point(99, 370);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(730, 67);
            this.groupBox5.TabIndex = 120;
            this.groupBox5.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(139, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 124;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkbSeleccionar
            // 
            this.chkbSeleccionar.AutoSize = true;
            this.chkbSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.chkbSeleccionar.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkbSeleccionar.Location = new System.Drawing.Point(22, 28);
            this.chkbSeleccionar.Name = "chkbSeleccionar";
            this.chkbSeleccionar.Size = new System.Drawing.Size(98, 20);
            this.chkbSeleccionar.TabIndex = 116;
            this.chkbSeleccionar.Text = "Seleccionar";
            this.chkbSeleccionar.UseVisualStyleBackColor = true;
            this.chkbSeleccionar.CheckedChanged += new System.EventHandler(this.chkbSeleccionar_CheckedChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCantidad.Location = new System.Drawing.Point(443, 28);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 17);
            this.lblCantidad.TabIndex = 115;
            this.lblCantidad.Text = "Cantidad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Location = new System.Drawing.Point(99, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(730, 73);
            this.groupBox4.TabIndex = 119;
            this.groupBox4.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(598, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 40);
            this.btnBuscar.TabIndex = 113;
            this.btnBuscar.Text = "            BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(17, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 18);
            this.label10.TabIndex = 112;
            this.label10.Text = "Ingrese DNI del paciente:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(222, 29);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtBuscar.MaxLength = 8;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(314, 23);
            this.txtBuscar.TabIndex = 111;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AllowUserToOrderColumns = true;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvGrilla.Location = new System.Drawing.Point(99, 143);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(730, 212);
            this.dgvGrilla.TabIndex = 118;
            this.dgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(256, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 22);
            this.label9.TabIndex = 112;
            this.label9.Text = "LISTA DE DIAGNOSTICO";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tabPage2.Controls.Add(this.lbldiagnostico);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblfecha);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnDiagnosticar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnInsertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(951, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento Diagnostico";
            // 
            // lbldiagnostico
            // 
            this.lbldiagnostico.AutoSize = true;
            this.lbldiagnostico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lbldiagnostico.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbldiagnostico.Location = new System.Drawing.Point(750, 434);
            this.lbldiagnostico.Name = "lbldiagnostico";
            this.lbldiagnostico.Size = new System.Drawing.Size(31, 16);
            this.lbldiagnostico.TabIndex = 133;
            this.lbldiagnostico.Text = "rpta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(652, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 132;
            this.label6.Text = "Enfermedad:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 20);
            this.txtCodigo.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(19, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 131;
            this.label5.Text = "Codigo:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblfecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblfecha.Location = new System.Drawing.Point(761, 18);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(65, 15);
            this.lblfecha.TabIndex = 130;
            this.lblfecha.Text = "00/00/0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(706, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 118;
            this.label1.Text = "Fecha:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstDiagnostico);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(663, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 224);
            this.groupBox3.TabIndex = 128;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diagnóstico";
            // 
            // lstDiagnostico
            // 
            this.lstDiagnostico.FormattingEnabled = true;
            this.lstDiagnostico.ItemHeight = 15;
            this.lstDiagnostico.Location = new System.Drawing.Point(29, 26);
            this.lstDiagnostico.Name = "lstDiagnostico";
            this.lstDiagnostico.Size = new System.Drawing.Size(205, 184);
            this.lstDiagnostico.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkmalestargeneral);
            this.groupBox2.Controls.Add(this.chktosseca);
            this.groupBox2.Controls.Add(this.chkperdidagustoolfato);
            this.groupBox2.Controls.Add(this.chkfiebreyescalofrios);
            this.groupBox2.Controls.Add(this.chktosconstante);
            this.groupBox2.Controls.Add(this.chkdolorarticulaciones);
            this.groupBox2.Controls.Add(this.chkdolorpecho);
            this.groupBox2.Controls.Add(this.chkerupcionespiel);
            this.groupBox2.Controls.Add(this.chkojosrojos);
            this.groupBox2.Controls.Add(this.chkescalofrios);
            this.groupBox2.Controls.Add(this.chkcansancio);
            this.groupBox2.Controls.Add(this.chkdificultadrespirar);
            this.groupBox2.Controls.Add(this.chkvomito);
            this.groupBox2.Controls.Add(this.chknauseas);
            this.groupBox2.Controls.Add(this.chkperdidaapetito);
            this.groupBox2.Controls.Add(this.chkdolormuscular);
            this.groupBox2.Controls.Add(this.chkfiebre);
            this.groupBox2.Controls.Add(this.chkcongestionnasal);
            this.groupBox2.Controls.Add(this.chkTos);
            this.groupBox2.Controls.Add(this.chkdolorcabeza);
            this.groupBox2.Controls.Add(this.chkdolorgarganta);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(21, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 244);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sintomas";
            // 
            // chkmalestargeneral
            // 
            this.chkmalestargeneral.AutoSize = true;
            this.chkmalestargeneral.Location = new System.Drawing.Point(161, 219);
            this.chkmalestargeneral.Name = "chkmalestargeneral";
            this.chkmalestargeneral.Size = new System.Drawing.Size(116, 19);
            this.chkmalestargeneral.TabIndex = 149;
            this.chkmalestargeneral.Text = "malestar general";
            this.chkmalestargeneral.UseVisualStyleBackColor = true;
            // 
            // chktosseca
            // 
            this.chktosseca.AutoSize = true;
            this.chktosseca.Location = new System.Drawing.Point(317, 219);
            this.chktosseca.Name = "chktosseca";
            this.chktosseca.Size = new System.Drawing.Size(70, 19);
            this.chktosseca.TabIndex = 148;
            this.chktosseca.Text = "tos seca";
            this.chktosseca.UseVisualStyleBackColor = true;
            // 
            // chkperdidagustoolfato
            // 
            this.chkperdidagustoolfato.AutoSize = true;
            this.chkperdidagustoolfato.Location = new System.Drawing.Point(317, 189);
            this.chkperdidagustoolfato.Name = "chkperdidagustoolfato";
            this.chkperdidagustoolfato.Size = new System.Drawing.Size(162, 19);
            this.chkperdidagustoolfato.TabIndex = 146;
            this.chkperdidagustoolfato.Text = "perdida del gusto y olfato";
            this.chkperdidagustoolfato.UseVisualStyleBackColor = true;
            // 
            // chkfiebreyescalofrios
            // 
            this.chkfiebreyescalofrios.AutoSize = true;
            this.chkfiebreyescalofrios.Location = new System.Drawing.Point(15, 220);
            this.chkfiebreyescalofrios.Name = "chkfiebreyescalofrios";
            this.chkfiebreyescalofrios.Size = new System.Drawing.Size(127, 19);
            this.chkfiebreyescalofrios.TabIndex = 145;
            this.chkfiebreyescalofrios.Text = "fiebre y escalofrios";
            this.chkfiebreyescalofrios.UseVisualStyleBackColor = true;
            // 
            // chktosconstante
            // 
            this.chktosconstante.AutoSize = true;
            this.chktosconstante.Location = new System.Drawing.Point(317, 158);
            this.chktosconstante.Name = "chktosconstante";
            this.chktosconstante.Size = new System.Drawing.Size(97, 19);
            this.chktosconstante.TabIndex = 144;
            this.chktosconstante.Text = "tos constante";
            this.chktosconstante.UseVisualStyleBackColor = true;
            // 
            // chkdolorarticulaciones
            // 
            this.chkdolorarticulaciones.AutoSize = true;
            this.chkdolorarticulaciones.Location = new System.Drawing.Point(317, 93);
            this.chkdolorarticulaciones.Name = "chkdolorarticulaciones";
            this.chkdolorarticulaciones.Size = new System.Drawing.Size(169, 19);
            this.chkdolorarticulaciones.TabIndex = 143;
            this.chkdolorarticulaciones.Text = "dolor en las articulaciones";
            this.chkdolorarticulaciones.UseVisualStyleBackColor = true;
            // 
            // chkdolorpecho
            // 
            this.chkdolorpecho.AutoSize = true;
            this.chkdolorpecho.Location = new System.Drawing.Point(317, 125);
            this.chkdolorpecho.Name = "chkdolorpecho";
            this.chkdolorpecho.Size = new System.Drawing.Size(122, 19);
            this.chkdolorpecho.TabIndex = 142;
            this.chkdolorpecho.Text = "dolor en el pecho";
            this.chkdolorpecho.UseVisualStyleBackColor = true;
            // 
            // chkerupcionespiel
            // 
            this.chkerupcionespiel.AutoSize = true;
            this.chkerupcionespiel.Location = new System.Drawing.Point(317, 60);
            this.chkerupcionespiel.Name = "chkerupcionespiel";
            this.chkerupcionespiel.Size = new System.Drawing.Size(140, 19);
            this.chkerupcionespiel.TabIndex = 141;
            this.chkerupcionespiel.Text = "erupciones en la piel";
            this.chkerupcionespiel.UseVisualStyleBackColor = true;
            // 
            // chkojosrojos
            // 
            this.chkojosrojos.AutoSize = true;
            this.chkojosrojos.Location = new System.Drawing.Point(317, 24);
            this.chkojosrojos.Name = "chkojosrojos";
            this.chkojosrojos.Size = new System.Drawing.Size(77, 19);
            this.chkojosrojos.TabIndex = 140;
            this.chkojosrojos.Text = "ojos rojos";
            this.chkojosrojos.UseVisualStyleBackColor = true;
            // 
            // chkescalofrios
            // 
            this.chkescalofrios.AutoSize = true;
            this.chkescalofrios.Location = new System.Drawing.Point(161, 189);
            this.chkescalofrios.Name = "chkescalofrios";
            this.chkescalofrios.Size = new System.Drawing.Size(84, 19);
            this.chkescalofrios.TabIndex = 138;
            this.chkescalofrios.Text = "escalofrios";
            this.chkescalofrios.UseVisualStyleBackColor = true;
            // 
            // chkcansancio
            // 
            this.chkcansancio.AutoSize = true;
            this.chkcansancio.Location = new System.Drawing.Point(161, 126);
            this.chkcansancio.Name = "chkcansancio";
            this.chkcansancio.Size = new System.Drawing.Size(83, 19);
            this.chkcansancio.TabIndex = 137;
            this.chkcansancio.Text = "cansancio";
            this.chkcansancio.UseVisualStyleBackColor = true;
            // 
            // chkdificultadrespirar
            // 
            this.chkdificultadrespirar.AutoSize = true;
            this.chkdificultadrespirar.Location = new System.Drawing.Point(161, 158);
            this.chkdificultadrespirar.Name = "chkdificultadrespirar";
            this.chkdificultadrespirar.Size = new System.Drawing.Size(148, 19);
            this.chkdificultadrespirar.TabIndex = 136;
            this.chkdificultadrespirar.Text = "dificultad para respirar";
            this.chkdificultadrespirar.UseVisualStyleBackColor = true;
            // 
            // chkvomito
            // 
            this.chkvomito.AutoSize = true;
            this.chkvomito.Location = new System.Drawing.Point(161, 93);
            this.chkvomito.Name = "chkvomito";
            this.chkvomito.Size = new System.Drawing.Size(61, 19);
            this.chkvomito.TabIndex = 135;
            this.chkvomito.Text = "vomito";
            this.chkvomito.UseVisualStyleBackColor = true;
            // 
            // chknauseas
            // 
            this.chknauseas.AutoSize = true;
            this.chknauseas.Location = new System.Drawing.Point(161, 57);
            this.chknauseas.Name = "chknauseas";
            this.chknauseas.Size = new System.Drawing.Size(71, 19);
            this.chknauseas.TabIndex = 134;
            this.chknauseas.Text = "nauseas";
            this.chknauseas.UseVisualStyleBackColor = true;
            // 
            // chkperdidaapetito
            // 
            this.chkperdidaapetito.AutoSize = true;
            this.chkperdidaapetito.Location = new System.Drawing.Point(161, 23);
            this.chkperdidaapetito.Name = "chkperdidaapetito";
            this.chkperdidaapetito.Size = new System.Drawing.Size(125, 19);
            this.chkperdidaapetito.TabIndex = 133;
            this.chkperdidaapetito.Text = "perdida de apetito";
            this.chkperdidaapetito.UseVisualStyleBackColor = true;
            // 
            // chkdolormuscular
            // 
            this.chkdolormuscular.AutoSize = true;
            this.chkdolormuscular.Location = new System.Drawing.Point(15, 191);
            this.chkdolormuscular.Name = "chkdolormuscular";
            this.chkdolormuscular.Size = new System.Drawing.Size(106, 19);
            this.chkdolormuscular.TabIndex = 132;
            this.chkdolormuscular.Text = "dolor muscular";
            this.chkdolormuscular.UseVisualStyleBackColor = true;
            // 
            // chkfiebre
            // 
            this.chkfiebre.AutoSize = true;
            this.chkfiebre.Location = new System.Drawing.Point(15, 158);
            this.chkfiebre.Name = "chkfiebre";
            this.chkfiebre.Size = new System.Drawing.Size(57, 19);
            this.chkfiebre.TabIndex = 131;
            this.chkfiebre.Text = "fiebre";
            this.chkfiebre.UseVisualStyleBackColor = true;
            // 
            // chkcongestionnasal
            // 
            this.chkcongestionnasal.AutoSize = true;
            this.chkcongestionnasal.Location = new System.Drawing.Point(15, 126);
            this.chkcongestionnasal.Name = "chkcongestionnasal";
            this.chkcongestionnasal.Size = new System.Drawing.Size(118, 19);
            this.chkcongestionnasal.TabIndex = 130;
            this.chkcongestionnasal.Text = "congestion nasal";
            this.chkcongestionnasal.UseVisualStyleBackColor = true;
            // 
            // chkTos
            // 
            this.chkTos.AutoSize = true;
            this.chkTos.Location = new System.Drawing.Point(15, 24);
            this.chkTos.Name = "chkTos";
            this.chkTos.Size = new System.Drawing.Size(41, 19);
            this.chkTos.TabIndex = 127;
            this.chkTos.Text = "tos";
            this.chkTos.UseVisualStyleBackColor = true;
            // 
            // chkdolorcabeza
            // 
            this.chkdolorcabeza.AutoSize = true;
            this.chkdolorcabeza.Location = new System.Drawing.Point(15, 93);
            this.chkdolorcabeza.Name = "chkdolorcabeza";
            this.chkdolorcabeza.Size = new System.Drawing.Size(114, 19);
            this.chkdolorcabeza.TabIndex = 129;
            this.chkdolorcabeza.Text = "dolor de cabeza";
            this.chkdolorcabeza.UseVisualStyleBackColor = true;
            // 
            // chkdolorgarganta
            // 
            this.chkdolorgarganta.AutoSize = true;
            this.chkdolorgarganta.Location = new System.Drawing.Point(15, 57);
            this.chkdolorgarganta.Name = "chkdolorgarganta";
            this.chkdolorgarganta.Size = new System.Drawing.Size(123, 19);
            this.chkdolorgarganta.TabIndex = 128;
            this.chkdolorgarganta.Text = "dolor de garganta";
            this.chkdolorgarganta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPaciente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(21, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 105);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPaciente.Image")));
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(282, 17);
            this.btnBuscarPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(135, 36);
            this.btnBuscarPaciente.TabIndex = 117;
            this.btnBuscarPaciente.Text = "               BUSCAR";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 108;
            this.label3.Text = "Dni:";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(136, 25);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(136, 21);
            this.txtdni.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 110;
            this.label4.Text = "Nombre y Apellido: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(281, 21);
            this.txtNombre.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(354, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 22);
            this.label2.TabIndex = 109;
            this.label2.Text = "DATOS DEL DIAGNOSTICO";
            // 
            // btnDiagnosticar
            // 
            this.btnDiagnosticar.BackColor = System.Drawing.Color.Black;
            this.btnDiagnosticar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosticar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiagnosticar.Image = ((System.Drawing.Image)(resources.GetObject("btnDiagnosticar.Image")));
            this.btnDiagnosticar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnosticar.Location = new System.Drawing.Point(518, 229);
            this.btnDiagnosticar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDiagnosticar.Name = "btnDiagnosticar";
            this.btnDiagnosticar.Size = new System.Drawing.Size(138, 48);
            this.btnDiagnosticar.TabIndex = 129;
            this.btnDiagnosticar.Text = "              Diagnosticar";
            this.btnDiagnosticar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnosticar.UseVisualStyleBackColor = false;
            this.btnDiagnosticar.Click += new System.EventHandler(this.btnDiagnosticar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(709, 106);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 50);
            this.btnCancelar.TabIndex = 124;
            this.btnCancelar.Text = "               CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Black;
            this.btnInsertar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(709, 52);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(150, 50);
            this.btnInsertar.TabIndex = 123;
            this.btnInsertar.Text = "               INSERTAR";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::SistemaDiagnostico.Presentacion.Properties.Resources._1904666_calculate_close_delete_hide_minimize_minus_remove_122516;
            this.btnMinimizar.Location = new System.Drawing.Point(901, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::SistemaDiagnostico.Presentacion.Properties.Resources._1492790846_9cancel_84247;
            this.btnCerrar.Location = new System.Drawing.Point(937, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(979, 561);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDiagnostico";
            this.Load += new System.EventHandler(this.FrmDiagnostico_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTos;
        private System.Windows.Forms.CheckBox chkdolorcabeza;
        private System.Windows.Forms.CheckBox chkdolorgarganta;
        private System.Windows.Forms.Button btnDiagnosticar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstDiagnostico;
        private System.Windows.Forms.CheckBox chkcansancio;
        private System.Windows.Forms.CheckBox chkdificultadrespirar;
        private System.Windows.Forms.CheckBox chkvomito;
        private System.Windows.Forms.CheckBox chknauseas;
        private System.Windows.Forms.CheckBox chkperdidaapetito;
        private System.Windows.Forms.CheckBox chkdolormuscular;
        private System.Windows.Forms.CheckBox chkfiebre;
        private System.Windows.Forms.CheckBox chkcongestionnasal;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.CheckBox chktosseca;
        private System.Windows.Forms.CheckBox chkperdidagustoolfato;
        private System.Windows.Forms.CheckBox chkfiebreyescalofrios;
        private System.Windows.Forms.CheckBox chktosconstante;
        private System.Windows.Forms.CheckBox chkdolorarticulaciones;
        private System.Windows.Forms.CheckBox chkdolorpecho;
        private System.Windows.Forms.CheckBox chkerupcionespiel;
        private System.Windows.Forms.CheckBox chkojosrojos;
        private System.Windows.Forms.CheckBox chkescalofrios;
        private System.Windows.Forms.CheckBox chkmalestargeneral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbldiagnostico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkbSeleccionar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
    }
}