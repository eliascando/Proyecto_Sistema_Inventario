namespace Vista
{
    partial class Main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            menuStrip1 = new MenuStrip();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            registrarProductoToolStripMenuItem = new ToolStripMenuItem();
            ingresarProductoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            usuario_menu = new ToolStripMenuItem();
            registrarNuevoToolStripMenuItem = new ToolStripMenuItem();
            administrarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            actividades_menu = new ToolStripMenuItem();
            registro_actividades = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            btnCerrarSesion = new Button();
            lblUser = new Label();
            registroDeInicioDeSesionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem, usuario_menu, actividades_menu, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(793, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarProductoToolStripMenuItem, ingresarProductoToolStripMenuItem, consultarToolStripMenuItem });
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(72, 20);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // registrarProductoToolStripMenuItem
            // 
            registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            registrarProductoToolStripMenuItem.Size = new Size(172, 22);
            registrarProductoToolStripMenuItem.Text = "Registrar Producto";
            registrarProductoToolStripMenuItem.Click += registrarProductoToolStripMenuItem_Click;
            // 
            // ingresarProductoToolStripMenuItem
            // 
            ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            ingresarProductoToolStripMenuItem.Size = new Size(172, 22);
            ingresarProductoToolStripMenuItem.Text = "Ingresar Producto";
            ingresarProductoToolStripMenuItem.Click += ingresarProductoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(172, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // usuario_menu
            // 
            usuario_menu.DropDownItems.AddRange(new ToolStripItem[] { registrarNuevoToolStripMenuItem, administrarUsuariosToolStripMenuItem });
            usuario_menu.Name = "usuario_menu";
            usuario_menu.Size = new Size(64, 20);
            usuario_menu.Text = "Usuarios";
            // 
            // registrarNuevoToolStripMenuItem
            // 
            registrarNuevoToolStripMenuItem.Name = "registrarNuevoToolStripMenuItem";
            registrarNuevoToolStripMenuItem.Size = new Size(184, 22);
            registrarNuevoToolStripMenuItem.Text = "Registrar Nuevo";
            registrarNuevoToolStripMenuItem.Click += registrarNuevoToolStripMenuItem_Click;
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            administrarUsuariosToolStripMenuItem.Size = new Size(184, 22);
            administrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios";
            administrarUsuariosToolStripMenuItem.Click += administrarUsuariosToolStripMenuItem_Click;
            // 
            // actividades_menu
            // 
            actividades_menu.DropDownItems.AddRange(new ToolStripItem[] { registro_actividades, registroDeInicioDeSesionToolStripMenuItem });
            actividades_menu.Name = "actividades_menu";
            actividades_menu.Size = new Size(80, 20);
            actividades_menu.Text = "Actividades";
            // 
            // registro_actividades
            // 
            registro_actividades.Name = "registro_actividades";
            registro_actividades.Size = new Size(218, 22);
            registro_actividades.Text = "Registro de Actividades";
            registro_actividades.Click += registro_actividades_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(126, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.Location = new Point(645, 402);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(136, 36);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(12, 411);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(86, 30);
            lblUser.TabIndex = 3;
            lblUser.Text = "usuario";
            // 
            // registroDeInicioDeSesionToolStripMenuItem
            // 
            registroDeInicioDeSesionToolStripMenuItem.Name = "registroDeInicioDeSesionToolStripMenuItem";
            registroDeInicioDeSesionToolStripMenuItem.Size = new Size(218, 22);
            registroDeInicioDeSesionToolStripMenuItem.Text = "Registro de Inicio de Sesion";
            registroDeInicioDeSesionToolStripMenuItem.Click += registroDeInicioDeSesionToolStripMenuItem_Click;
            // 
            // Main_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(793, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblUser);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main_window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minimarket JipiJapa";
            Load += Main_window_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem registrarProductoToolStripMenuItem;
        private ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem usuario_menu;
        private ToolStripMenuItem registrarNuevoToolStripMenuItem;
        private ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private ToolStripMenuItem actividades_menu;
        private ToolStripMenuItem registro_actividades;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Button btnCerrarSesion;
        private Label lblUser;
        private ToolStripMenuItem registroDeInicioDeSesionToolStripMenuItem;
    }
}