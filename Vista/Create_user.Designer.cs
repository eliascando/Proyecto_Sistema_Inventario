namespace Vista
{
    partial class Create_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_user));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBoxDatosLogin = new System.Windows.Forms.GroupBox();
            this.mostrarPass = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBoxDatosLogin.SuspendLayout();
            this.groupBoxDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(228, 362);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 34);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBoxDatosLogin
            // 
            this.groupBoxDatosLogin.Controls.Add(this.mostrarPass);
            this.groupBoxDatosLogin.Controls.Add(this.txtPass);
            this.groupBoxDatosLogin.Controls.Add(this.txtUser);
            this.groupBoxDatosLogin.Controls.Add(this.lblPass);
            this.groupBoxDatosLogin.Controls.Add(this.lblUser);
            this.groupBoxDatosLogin.Location = new System.Drawing.Point(33, 225);
            this.groupBoxDatosLogin.Name = "groupBoxDatosLogin";
            this.groupBoxDatosLogin.Size = new System.Drawing.Size(280, 115);
            this.groupBoxDatosLogin.TabIndex = 9;
            this.groupBoxDatosLogin.TabStop = false;
            this.groupBoxDatosLogin.Text = "Datos Inicio de Sesión";
            // 
            // mostrarPass
            // 
            this.mostrarPass.AutoSize = true;
            this.mostrarPass.Location = new System.Drawing.Point(108, 82);
            this.mostrarPass.Name = "mostrarPass";
            this.mostrarPass.Size = new System.Drawing.Size(130, 19);
            this.mostrarPass.TabIndex = 4;
            this.mostrarPass.Text = "Mostrar Contraseña";
            this.mostrarPass.UseVisualStyleBackColor = true;
            this.mostrarPass.CheckedChanged += new System.EventHandler(this.mostrarPass_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(87, 53);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(175, 23);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(87, 24);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(175, 23);
            this.txtUser.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(13, 61);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 15);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(13, 32);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.txtTelefono);
            this.groupBoxDatosPersonales.Controls.Add(this.lblTelefono);
            this.groupBoxDatosPersonales.Controls.Add(this.txtId);
            this.groupBoxDatosPersonales.Controls.Add(this.txtApellido);
            this.groupBoxDatosPersonales.Controls.Add(this.txtNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.lblId);
            this.groupBoxDatosPersonales.Controls.Add(this.lblApellidos);
            this.groupBoxDatosPersonales.Controls.Add(this.lblNombre);
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(33, 66);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(280, 153);
            this.groupBoxDatosPersonales.TabIndex = 8;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos Personales";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(87, 116);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 23);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(13, 124);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(87, 86);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(175, 23);
            this.txtId.TabIndex = 6;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(87, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(175, 23);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 23);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 94);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(13, 63);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(59, 15);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres:";
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(91, 19);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(170, 32);
            this.lbHeader.TabIndex = 7;
            this.lbHeader.Text = "Crear Usuario";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(33, 362);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(85, 34);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Create_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 408);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBoxDatosLogin);
            this.Controls.Add(this.groupBoxDatosPersonales);
            this.Controls.Add(this.lbHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Create_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimarket JipiJapa";
            this.Load += new System.EventHandler(this.Create_user_Load);
            this.groupBoxDatosLogin.ResumeLayout(false);
            this.groupBoxDatosLogin.PerformLayout();
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrar;
        private GroupBox groupBoxDatosLogin;
        private CheckBox mostrarPass;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label lblPass;
        private Label lblUser;
        private GroupBox groupBoxDatosPersonales;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtId;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblId;
        private Label lblApellidos;
        private Label lblNombre;
        private Label lbHeader;
        private Button btn_Cancelar;
    }
}