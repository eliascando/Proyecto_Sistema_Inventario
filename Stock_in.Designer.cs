namespace Proyecto_Sistema_Inventario
{
    partial class Stock_in
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.gridSelect = new System.Windows.Forms.DataGridView();
            this.lblDA = new System.Windows.Forms.Label();
            this.txtUStock = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(41, 26);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(204, 32);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Ingreso de Stock";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Código",
            "Nombre"});
            this.cmbFiltro.Location = new System.Drawing.Point(63, 80);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(158, 23);
            this.cmbFiltro.TabIndex = 2;
            this.cmbFiltro.Text = "Buscar por...";
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(41, 109);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(204, 23);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // gridSelect
            // 
            this.gridSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSelect.Location = new System.Drawing.Point(23, 148);
            this.gridSelect.Name = "gridSelect";
            this.gridSelect.ReadOnly = true;
            this.gridSelect.RowTemplate.Height = 25;
            this.gridSelect.Size = new System.Drawing.Size(246, 102);
            this.gridSelect.TabIndex = 4;
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(30, 269);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(58, 15);
            this.lblDA.TabIndex = 5;
            this.lblDA.Text = "Cantidad:";
            // 
            // txtUStock
            // 
            this.txtUStock.Location = new System.Drawing.Point(94, 266);
            this.txtUStock.Name = "txtUStock";
            this.txtUStock.Size = new System.Drawing.Size(69, 23);
            this.txtUStock.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(183, 266);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Stock_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtUStock);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.gridSelect);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.lbHeader);
            this.Name = "Stock_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Stock_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbHeader;
        private ComboBox cmbFiltro;
        private TextBox txtFiltro;
        private DataGridView gridSelect;
        private Label lblDA;
        private TextBox txtUStock;
        private Button btnAgregar;
    }
}