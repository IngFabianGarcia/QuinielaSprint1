﻿namespace QuinielaSprint1
{
    partial class vistaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaAdministrador));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsuariosRegistrados = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnPronostico = new System.Windows.Forms.Button();
            this.btnAgregarPartido = new System.Windows.Forms.Button();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.BarraSuperior.Controls.Add(this.btnRestaurar);
            this.BarraSuperior.Controls.Add(this.btnMinimizar);
            this.BarraSuperior.Controls.Add(this.btnMaximizar);
            this.BarraSuperior.Controls.Add(this.btnSalir);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1733, 47);
            this.BarraSuperior.TabIndex = 1;
            this.BarraSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraSuperior_Paint);
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1551, 9);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(33, 31);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1613, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 31);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1655, 9);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(33, 31);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1696, 9);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 31);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.btnUsuariosRegistrados);
            this.MenuVertical.Controls.Add(this.btnResultado);
            this.MenuVertical.Controls.Add(this.btnPronostico);
            this.MenuVertical.Controls.Add(this.btnAgregarPartido);
            this.MenuVertical.Controls.Add(this.btnAgregarEquipo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 47);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(323, 753);
            this.MenuVertical.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnUsuariosRegistrados
            // 
            this.btnUsuariosRegistrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuariosRegistrados.FlatAppearance.BorderSize = 0;
            this.btnUsuariosRegistrados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.btnUsuariosRegistrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosRegistrados.ForeColor = System.Drawing.Color.White;
            this.btnUsuariosRegistrados.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuariosRegistrados.Image")));
            this.btnUsuariosRegistrados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuariosRegistrados.Location = new System.Drawing.Point(0, 519);
            this.btnUsuariosRegistrados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuariosRegistrados.Name = "btnUsuariosRegistrados";
            this.btnUsuariosRegistrados.Size = new System.Drawing.Size(323, 75);
            this.btnUsuariosRegistrados.TabIndex = 11;
            this.btnUsuariosRegistrados.Text = "Usuarios Registrados";
            this.btnUsuariosRegistrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuariosRegistrados.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            this.btnResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultado.FlatAppearance.BorderSize = 0;
            this.btnResultado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.Color.White;
            this.btnResultado.Image = ((System.Drawing.Image)(resources.GetObject("btnResultado.Image")));
            this.btnResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResultado.Location = new System.Drawing.Point(4, 437);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(319, 75);
            this.btnResultado.TabIndex = 9;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultado.UseVisualStyleBackColor = true;
            // 
            // btnPronostico
            // 
            this.btnPronostico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPronostico.FlatAppearance.BorderSize = 0;
            this.btnPronostico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.btnPronostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPronostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronostico.ForeColor = System.Drawing.Color.White;
            this.btnPronostico.Image = ((System.Drawing.Image)(resources.GetObject("btnPronostico.Image")));
            this.btnPronostico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPronostico.Location = new System.Drawing.Point(4, 354);
            this.btnPronostico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPronostico.Name = "btnPronostico";
            this.btnPronostico.Size = new System.Drawing.Size(319, 75);
            this.btnPronostico.TabIndex = 8;
            this.btnPronostico.Text = "Pronostico";
            this.btnPronostico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPronostico.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPartido
            // 
            this.btnAgregarPartido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPartido.FlatAppearance.BorderSize = 0;
            this.btnAgregarPartido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.btnAgregarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPartido.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPartido.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPartido.Image")));
            this.btnAgregarPartido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPartido.Location = new System.Drawing.Point(0, 272);
            this.btnAgregarPartido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarPartido.Name = "btnAgregarPartido";
            this.btnAgregarPartido.Size = new System.Drawing.Size(323, 75);
            this.btnAgregarPartido.TabIndex = 7;
            this.btnAgregarPartido.Text = "Agregar Partido";
            this.btnAgregarPartido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPartido.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEquipo.FlatAppearance.BorderSize = 0;
            this.btnAgregarEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.btnAgregarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEquipo.Image")));
            this.btnAgregarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEquipo.Location = new System.Drawing.Point(0, 190);
            this.btnAgregarEquipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(323, 75);
            this.btnAgregarEquipo.TabIndex = 6;
            this.btnAgregarEquipo.Text = "Agregar Equipo";
            this.btnAgregarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(323, 47);
            this.panelCentral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1410, 753);
            this.panelCentral.TabIndex = 3;
            // 
            // vistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "vistaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vistaAdministrador";
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel BarraSuperior;
        public System.Windows.Forms.PictureBox btnRestaurar;
        public System.Windows.Forms.PictureBox btnMinimizar;
        public System.Windows.Forms.PictureBox btnMaximizar;
        public System.Windows.Forms.PictureBox btnSalir;
        public System.Windows.Forms.Button btnUsuariosRegistrados;
        public System.Windows.Forms.Button btnResultado;
        public System.Windows.Forms.Button btnPronostico;
        public System.Windows.Forms.Button btnAgregarPartido;
        public System.Windows.Forms.Button btnAgregarEquipo;
        public System.Windows.Forms.Panel MenuVertical;
        public System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}