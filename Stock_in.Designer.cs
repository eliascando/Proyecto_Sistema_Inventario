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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_in));
            this.lbHeader = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.gridSelect = new System.Windows.Forms.DataGridView();
            this.lblDA = new System.Windows.Forms.Label();
            this.txtUStock = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(197, 35);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(204, 32);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Ingreso de Stock";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.cmbFiltro.Location = new System.Drawing.Point(67, 80);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(158, 23);
            this.cmbFiltro.TabIndex = 2;
            this.cmbFiltro.Text = "Buscar por...";
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(240, 80);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(303, 23);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // gridSelect
            // 
            this.gridSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSelect.Location = new System.Drawing.Point(32, 114);
            this.gridSelect.Name = "gridSelect";
            this.gridSelect.ReadOnly = true;
            this.gridSelect.RowTemplate.Height = 25;
            this.gridSelect.Size = new System.Drawing.Size(543, 249);
            this.gridSelect.TabIndex = 4;
            this.gridSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSelect_CellContentClick);
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(361, 392);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(58, 15);
            this.lblDA.TabIndex = 5;
            this.lblDA.Text = "Cantidad:";
            this.lblDA.Click += new System.EventHandler(this.lblDA_Click);
            // 
            // txtUStock
            // 
            this.txtUStock.Location = new System.Drawing.Point(425, 387);
            this.txtUStock.Name = "txtUStock";
            this.txtUStock.Size = new System.Drawing.Size(69, 23);
            this.txtUStock.TabIndex = 6;
            this.txtUStock.TextChanged += new System.EventHandler(this.txtUStock_TextChanged);
            this.txtUStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUStock_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(500, 386);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(32, 386);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Stock_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 421);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtUStock);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.gridSelect);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.lbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimarket JipiJapa";
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
        private Button btn_Cancelar;
    }
}