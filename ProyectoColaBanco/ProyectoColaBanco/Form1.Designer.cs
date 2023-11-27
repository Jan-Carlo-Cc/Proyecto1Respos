namespace ProyectoColaBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.dtgvCiudadanoOro = new System.Windows.Forms.DataGridView();
            this.dtgvPlataforma = new System.Windows.Forms.DataGridView();
            this.dtgvCreditoBancario = new System.Windows.Forms.DataGridView();
            this.dtgvTramiteUnico = new System.Windows.Forms.DataGridView();
            this.btnCaja1 = new System.Windows.Forms.Button();
            this.btnCaja2 = new System.Windows.Forms.Button();
            this.btnCaja3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCaja1 = new System.Windows.Forms.Label();
            this.lblCaja2 = new System.Windows.Forms.Label();
            this.lblCaja3 = new System.Windows.Forms.Label();
            this.NombreCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FichaCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TramiteCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FichaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TramiteCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FichaPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TramitePL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FichaTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TramiteTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCiudadanoOro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlataforma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCreditoBancario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTramiteUnico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(24, 44);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(274, 29);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(38, 93);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(106, 39);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dtgvCiudadanoOro
            // 
            this.dtgvCiudadanoOro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvCiudadanoOro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCiudadanoOro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCO,
            this.FichaCO,
            this.TramiteCO});
            this.dtgvCiudadanoOro.Location = new System.Drawing.Point(24, 202);
            this.dtgvCiudadanoOro.Name = "dtgvCiudadanoOro";
            this.dtgvCiudadanoOro.ReadOnly = true;
            this.dtgvCiudadanoOro.Size = new System.Drawing.Size(344, 145);
            this.dtgvCiudadanoOro.TabIndex = 6;
            // 
            // dtgvPlataforma
            // 
            this.dtgvPlataforma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvPlataforma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPlataforma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePL,
            this.FichaPL,
            this.TramitePL});
            this.dtgvPlataforma.Location = new System.Drawing.Point(24, 416);
            this.dtgvPlataforma.Name = "dtgvPlataforma";
            this.dtgvPlataforma.ReadOnly = true;
            this.dtgvPlataforma.Size = new System.Drawing.Size(344, 145);
            this.dtgvPlataforma.TabIndex = 7;
            // 
            // dtgvCreditoBancario
            // 
            this.dtgvCreditoBancario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvCreditoBancario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCreditoBancario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCB,
            this.FichaCB,
            this.TramiteCB});
            this.dtgvCreditoBancario.Location = new System.Drawing.Point(374, 202);
            this.dtgvCreditoBancario.Name = "dtgvCreditoBancario";
            this.dtgvCreditoBancario.ReadOnly = true;
            this.dtgvCreditoBancario.Size = new System.Drawing.Size(344, 145);
            this.dtgvCreditoBancario.TabIndex = 8;
            // 
            // dtgvTramiteUnico
            // 
            this.dtgvTramiteUnico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvTramiteUnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTramiteUnico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreTU,
            this.FichaTU,
            this.TramiteTU});
            this.dtgvTramiteUnico.Location = new System.Drawing.Point(374, 416);
            this.dtgvTramiteUnico.Name = "dtgvTramiteUnico";
            this.dtgvTramiteUnico.ReadOnly = true;
            this.dtgvTramiteUnico.Size = new System.Drawing.Size(344, 145);
            this.dtgvTramiteUnico.TabIndex = 9;
            // 
            // btnCaja1
            // 
            this.btnCaja1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaja1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja1.Location = new System.Drawing.Point(752, 127);
            this.btnCaja1.Name = "btnCaja1";
            this.btnCaja1.Size = new System.Drawing.Size(79, 33);
            this.btnCaja1.TabIndex = 10;
            this.btnCaja1.Text = "Caja 1";
            this.btnCaja1.UseVisualStyleBackColor = true;
            this.btnCaja1.Click += new System.EventHandler(this.btnCaja1_Click);
            // 
            // btnCaja2
            // 
            this.btnCaja2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaja2.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja2.Location = new System.Drawing.Point(752, 319);
            this.btnCaja2.Name = "btnCaja2";
            this.btnCaja2.Size = new System.Drawing.Size(79, 33);
            this.btnCaja2.TabIndex = 11;
            this.btnCaja2.Text = "Caja 2";
            this.btnCaja2.UseVisualStyleBackColor = true;
            this.btnCaja2.Click += new System.EventHandler(this.btnCaja2_Click);
            // 
            // btnCaja3
            // 
            this.btnCaja3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaja3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja3.Location = new System.Drawing.Point(752, 512);
            this.btnCaja3.Name = "btnCaja3";
            this.btnCaja3.Size = new System.Drawing.Size(79, 33);
            this.btnCaja3.TabIndex = 12;
            this.btnCaja3.Text = "Caja 3";
            this.btnCaja3.UseVisualStyleBackColor = true;
            this.btnCaja3.Click += new System.EventHandler(this.btnCaja3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Atendiendo al cliente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(749, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Atendiendo al cliente :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(749, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Atendiendo al cliente :";
            // 
            // lblCaja1
            // 
            this.lblCaja1.AutoSize = true;
            this.lblCaja1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCaja1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCaja1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja1.Location = new System.Drawing.Point(752, 180);
            this.lblCaja1.Name = "lblCaja1";
            this.lblCaja1.Size = new System.Drawing.Size(2, 19);
            this.lblCaja1.TabIndex = 17;
            // 
            // lblCaja2
            // 
            this.lblCaja2.AutoSize = true;
            this.lblCaja2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCaja2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCaja2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja2.Location = new System.Drawing.Point(752, 372);
            this.lblCaja2.Name = "lblCaja2";
            this.lblCaja2.Size = new System.Drawing.Size(2, 19);
            this.lblCaja2.TabIndex = 18;
            // 
            // lblCaja3
            // 
            this.lblCaja3.AutoSize = true;
            this.lblCaja3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCaja3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCaja3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja3.Location = new System.Drawing.Point(752, 565);
            this.lblCaja3.Name = "lblCaja3";
            this.lblCaja3.Size = new System.Drawing.Size(2, 19);
            this.lblCaja3.TabIndex = 19;
            // 
            // NombreCO
            // 
            this.NombreCO.HeaderText = "Nombre";
            this.NombreCO.Name = "NombreCO";
            this.NombreCO.ReadOnly = true;
            // 
            // FichaCO
            // 
            this.FichaCO.HeaderText = "Ficha";
            this.FichaCO.Name = "FichaCO";
            this.FichaCO.ReadOnly = true;
            // 
            // TramiteCO
            // 
            this.TramiteCO.HeaderText = "Tramite";
            this.TramiteCO.Name = "TramiteCO";
            this.TramiteCO.ReadOnly = true;
            // 
            // NombreCB
            // 
            this.NombreCB.HeaderText = "Nombre";
            this.NombreCB.Name = "NombreCB";
            this.NombreCB.ReadOnly = true;
            // 
            // FichaCB
            // 
            this.FichaCB.HeaderText = "Ficha";
            this.FichaCB.Name = "FichaCB";
            this.FichaCB.ReadOnly = true;
            // 
            // TramiteCB
            // 
            this.TramiteCB.HeaderText = "Tramite";
            this.TramiteCB.Name = "TramiteCB";
            this.TramiteCB.ReadOnly = true;
            // 
            // NombrePL
            // 
            this.NombrePL.HeaderText = "Nombre";
            this.NombrePL.Name = "NombrePL";
            this.NombrePL.ReadOnly = true;
            // 
            // FichaPL
            // 
            this.FichaPL.HeaderText = "Ficha";
            this.FichaPL.Name = "FichaPL";
            this.FichaPL.ReadOnly = true;
            // 
            // TramitePL
            // 
            this.TramitePL.HeaderText = "Tramite";
            this.TramitePL.Name = "TramitePL";
            this.TramitePL.ReadOnly = true;
            // 
            // NombreTU
            // 
            this.NombreTU.HeaderText = "Nombre";
            this.NombreTU.Name = "NombreTU";
            this.NombreTU.ReadOnly = true;
            // 
            // FichaTU
            // 
            this.FichaTU.HeaderText = "Ficha";
            this.FichaTU.Name = "FichaTU";
            this.FichaTU.ReadOnly = true;
            // 
            // TramiteTU
            // 
            this.TramiteTU.HeaderText = "Tramite";
            this.TramiteTU.Name = "TramiteTU";
            this.TramiteTU.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cola De Ciudadano de Oro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cola De Creditos Bancarios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cola De Plataforma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cola De Tramite Unico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(752, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(752, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(752, 394);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(138, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1167, 689);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCaja3);
            this.Controls.Add(this.lblCaja2);
            this.Controls.Add(this.lblCaja1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaja3);
            this.Controls.Add(this.btnCaja2);
            this.Controls.Add(this.btnCaja1);
            this.Controls.Add(this.dtgvTramiteUnico);
            this.Controls.Add(this.dtgvCreditoBancario);
            this.Controls.Add(this.dtgvPlataforma);
            this.Controls.Add(this.dtgvCiudadanoOro);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCiudadanoOro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlataforma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCreditoBancario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTramiteUnico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DataGridView dtgvCiudadanoOro;
        private System.Windows.Forms.DataGridView dtgvPlataforma;
        private System.Windows.Forms.DataGridView dtgvCreditoBancario;
        private System.Windows.Forms.DataGridView dtgvTramiteUnico;
        private System.Windows.Forms.Button btnCaja1;
        private System.Windows.Forms.Button btnCaja2;
        private System.Windows.Forms.Button btnCaja3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCaja1;
        private System.Windows.Forms.Label lblCaja2;
        private System.Windows.Forms.Label lblCaja3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FichaCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TramiteCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FichaPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TramitePL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn FichaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TramiteCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn FichaTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TramiteTU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

