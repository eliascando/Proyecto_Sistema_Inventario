﻿namespace Proyecto_Sistema_Inventario
{
    partial class Update_products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_products));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtUPVP = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtUCosto = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtUStock = new System.Windows.Forms.TextBox();
            this.txtUCodigo = new System.Windows.Forms.TextBox();
            this.txtUNombre = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBoxDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(27, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(114, 271);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.txtUPVP);
            this.groupBoxDatosPersonales.Controls.Add(this.lblEstado);
            this.groupBoxDatosPersonales.Controls.Add(this.txtUCosto);
            this.groupBoxDatosPersonales.Controls.Add(this.lblTelefono);
            this.groupBoxDatosPersonales.Controls.Add(this.txtUStock);
            this.groupBoxDatosPersonales.Controls.Add(this.txtUCodigo);
            this.groupBoxDatosPersonales.Controls.Add(this.txtUNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.lblId);
            this.groupBoxDatosPersonales.Controls.Add(this.lblApellidos);
            this.groupBoxDatosPersonales.Controls.Add(this.lblNombre);
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(27, 69);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(280, 188);
            this.groupBoxDatosPersonales.TabIndex = 13;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Producto";
            // 
            // txtUPVP
            // 
            this.txtUPVP.Location = new System.Drawing.Point(87, 146);
            this.txtUPVP.Name = "txtUPVP";
            this.txtUPVP.Size = new System.Drawing.Size(175, 23);
            this.txtUPVP.TabIndex = 13;
            this.txtUPVP.TextChanged += new System.EventHandler(this.txtUPVP_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 154);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 15);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Precio:";
            // 
            // txtUCosto
            // 
            this.txtUCosto.Location = new System.Drawing.Point(87, 116);
            this.txtUCosto.Name = "txtUCosto";
            this.txtUCosto.Size = new System.Drawing.Size(175, 23);
            this.txtUCosto.TabIndex = 8;
            this.txtUCosto.TextChanged += new System.EventHandler(this.txtUCosto_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(13, 124);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(41, 15);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Costo:";
            // 
            // txtUStock
            // 
            this.txtUStock.Location = new System.Drawing.Point(87, 86);
            this.txtUStock.Name = "txtUStock";
            this.txtUStock.Size = new System.Drawing.Size(175, 23);
            this.txtUStock.TabIndex = 6;
            this.txtUStock.TextChanged += new System.EventHandler(this.txtUStock_TextChanged);
            // 
            // txtUCodigo
            // 
            this.txtUCodigo.Location = new System.Drawing.Point(87, 55);
            this.txtUCodigo.Name = "txtUCodigo";
            this.txtUCodigo.Size = new System.Drawing.Size(175, 23);
            this.txtUCodigo.TabIndex = 5;
            this.txtUCodigo.TextChanged += new System.EventHandler(this.txtUCodigo_TextChanged);
            // 
            // txtUNombre
            // 
            this.txtUNombre.Location = new System.Drawing.Point(87, 25);
            this.txtUNombre.Name = "txtUNombre";
            this.txtUNombre.Size = new System.Drawing.Size(175, 23);
            this.txtUNombre.TabIndex = 4;
            this.txtUNombre.TextChanged += new System.EventHandler(this.txtUNombre_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 94);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Stock:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(13, 63);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 15);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(63, 21);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(202, 32);
            this.lbHeader.TabIndex = 12;
            this.lbHeader.Text = "Actualizar Datos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(221, 271);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBoxDatosPersonales);
            this.Controls.Add(this.lbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimarket JipiJapa";
            this.Load += new System.EventHandler(this.Update_products_Load);
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelar;
        private Button btnActualizar;
        private GroupBox groupBoxDatosPersonales;
        private Label lblEstado;
        public TextBox txtUCosto;
        private Label lblTelefono;
        public TextBox txtUStock;
        public TextBox txtUCodigo;
        public TextBox txtUNombre;
        private Label lblId;
        private Label lblApellidos;
        private Label lblNombre;
        private Label lbHeader;
        private Button btnEliminar;
        public TextBox txtUPVP;
    }
}