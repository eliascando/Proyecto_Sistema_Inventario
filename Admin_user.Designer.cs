namespace Proyecto_Sistema_Inventario
{
    partial class Admin_user
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_user));
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(119, 93);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(42, 15);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(167, 90);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(188, 23);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "Id",
            "Apellido",
            "Nombre"});
            this.cboFilter.Location = new System.Drawing.Point(370, 90);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(121, 23);
            this.cboFilter.TabIndex = 2;
            this.cboFilter.Text = "Buscar por...";
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // gridUsers
            // 
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Location = new System.Drawing.Point(42, 132);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.RowTemplate.Height = 25;
            this.gridUsers.Size = new System.Drawing.Size(554, 249);
            this.gridUsers.TabIndex = 3;
            this.gridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsers_CellClick);
            this.gridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gridUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridUsers_CellFormatting);
            this.gridUsers.Enter += new System.EventHandler(this.gridUsers_Enter);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(291, 398);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(167, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(288, 37);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Administrar Usuarios";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // Admin_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 435);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimrket JipiJapa";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBuscar;
        private TextBox txtFiltro;
        private ComboBox cboFilter;
        private DataGridView gridUsers;
        private Button btnActualizar;
        private Label lblHeader;
    }
}