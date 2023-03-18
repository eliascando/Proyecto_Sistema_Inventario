namespace Vista
{
    partial class Login_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_log));
            lblBuscar = new Label();
            btn_Cancelar = new Button();
            dateTime = new DateTimePicker();
            lblHeader = new Label();
            cboFilter = new ComboBox();
            txtFiltro = new TextBox();
            gridActividades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridActividades).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(32, 84);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(66, 15);
            lblBuscar.TabIndex = 32;
            lblBuscar.Text = "Buscar por:";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(32, 386);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 31;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // dateTime
            // 
            dateTime.Format = DateTimePickerFormat.Short;
            dateTime.Location = new Point(423, 78);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(153, 23);
            dateTime.TabIndex = 30;
            dateTime.ValueChanged += dateTime_ValueChanged;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(127, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(371, 37);
            lblHeader.TabIndex = 29;
            lblHeader.Text = "Registro de Inicio de Sesión";
            // 
            // cboFilter
            // 
            cboFilter.FormattingEnabled = true;
            cboFilter.Items.AddRange(new object[] { "Usuario", "Nombre", "Apellido" });
            cboFilter.Location = new Point(104, 79);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(121, 23);
            cboFilter.TabIndex = 28;
            cboFilter.Text = "Usuario";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(231, 78);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(186, 23);
            txtFiltro.TabIndex = 27;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // gridActividades
            // 
            gridActividades.AllowUserToResizeColumns = false;
            gridActividades.AllowUserToResizeRows = false;
            gridActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridActividades.Location = new Point(32, 114);
            gridActividades.Name = "gridActividades";
            gridActividades.ReadOnly = true;
            gridActividades.RowTemplate.Height = 25;
            gridActividades.Size = new Size(543, 249);
            gridActividades.TabIndex = 26;
            // 
            // Login_log
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 421);
            Controls.Add(lblBuscar);
            Controls.Add(btn_Cancelar);
            Controls.Add(dateTime);
            Controls.Add(lblHeader);
            Controls.Add(cboFilter);
            Controls.Add(txtFiltro);
            Controls.Add(gridActividades);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login_log";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minimarket JipiJapa";
            Load += Login_log_Load;
            ((System.ComponentModel.ISupportInitialize)gridActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar;
        private Button btn_Cancelar;
        private DateTimePicker dateTime;
        private Label lblHeader;
        private ComboBox cboFilter;
        private TextBox txtFiltro;
        private DataGridView gridActividades;
    }
}