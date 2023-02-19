namespace Proyecto_Sistema_Inventario
{
    partial class Registro_de_Actividades
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
            this.gridActividades = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // gridActividades
            // 
            this.gridActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActividades.Location = new System.Drawing.Point(32, 114);
            this.gridActividades.Name = "gridActividades";
            this.gridActividades.ReadOnly = true;
            this.gridActividades.RowTemplate.Height = 25;
            this.gridActividades.Size = new System.Drawing.Size(543, 249);
            this.gridActividades.TabIndex = 0;
            this.gridActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(156, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(321, 37);
            this.lblHeader.TabIndex = 15;
            this.lblHeader.Text = "Registro de Actividades";
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "Id",
            "Apellido",
            "Nombre"});
            this.cboFilter.Location = new System.Drawing.Point(284, 82);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(121, 23);
            this.cboFilter.TabIndex = 14;
            this.cboFilter.Text = "Buscar por...";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(81, 82);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(188, 23);
            this.txtFiltro.TabIndex = 13;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(33, 85);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(42, 15);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar";
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(422, 82);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(153, 23);
            this.dateTime.TabIndex = 16;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(32, 386);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 17;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Registro_de_Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 421);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.gridActividades);
            this.Name = "Registro_de_Actividades";
            this.Text = "Minimarket JipiJapa";
            this.Load += new System.EventHandler(this.Registro_de_Actividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridActividades;
        private Label lblHeader;
        private ComboBox cboFilter;
        private TextBox txtFiltro;
        private Label lblBuscar;
        private DateTimePicker dateTime;
        private Button btn_Cancelar;
    }
}