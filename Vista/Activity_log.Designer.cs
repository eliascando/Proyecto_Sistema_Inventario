namespace Vista
{
    partial class Activity_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity_log));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.gridActividades = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(32, 386);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 24;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(423, 78);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(153, 23);
            this.dateTime.TabIndex = 23;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(136, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(321, 37);
            this.lblHeader.TabIndex = 22;
            this.lblHeader.Text = "Registro de Actividades";
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Apellido",
            "Codigo Producto",
            "Nombre Producto"});
            this.cboFilter.Location = new System.Drawing.Point(104, 79);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(121, 23);
            this.cboFilter.TabIndex = 21;
            this.cboFilter.Text = "Id";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(231, 78);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(186, 23);
            this.txtFiltro.TabIndex = 20;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // gridActividades
            // 
            this.gridActividades.AllowUserToResizeColumns = false;
            this.gridActividades.AllowUserToResizeRows = false;
            this.gridActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActividades.Location = new System.Drawing.Point(32, 114);
            this.gridActividades.Name = "gridActividades";
            this.gridActividades.ReadOnly = true;
            this.gridActividades.RowTemplate.Height = 25;
            this.gridActividades.Size = new System.Drawing.Size(543, 249);
            this.gridActividades.TabIndex = 18;
            this.gridActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridActividades_CellContentClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(32, 84);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(66, 15);
            this.lblBuscar.TabIndex = 25;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // Activity_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 421);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.gridActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Activity_log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimarket JipiJapa";
            this.Load += new System.EventHandler(this.Activity_log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Cancelar;
        private DateTimePicker dateTime;
        private Label lblHeader;
        private ComboBox cboFilter;
        private TextBox txtFiltro;
        private DataGridView gridActividades;
        private Label lblBuscar;
    }
}