namespace Proyecto_Sistema_Inventario
{
    partial class Ver_ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_ayuda));
            this.textoAyuda1 = new System.Windows.Forms.RichTextBox();
            this.registro_producto = new System.Windows.Forms.PictureBox();
            this.VerAyuda = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textoAyuda2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textoAyuda3 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.registro_producto)).BeginInit();
            this.VerAyuda.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textoAyuda1
            // 
            this.textoAyuda1.BackColor = System.Drawing.SystemColors.Window;
            this.textoAyuda1.Location = new System.Drawing.Point(47, 37);
            this.textoAyuda1.Name = "textoAyuda1";
            this.textoAyuda1.Size = new System.Drawing.Size(288, 332);
            this.textoAyuda1.TabIndex = 0;
            this.textoAyuda1.Text = resources.GetString("textoAyuda1.Text");
            // 
            // registro_producto
            // 
            this.registro_producto.Image = global::Proyecto_Sistema_Inventario.Properties.Resources.Captura_de_pantalla_20230113_074135;
            this.registro_producto.Location = new System.Drawing.Point(356, 37);
            this.registro_producto.Name = "registro_producto";
            this.registro_producto.Size = new System.Drawing.Size(387, 332);
            this.registro_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registro_producto.TabIndex = 1;
            this.registro_producto.TabStop = false;
            // 
            // VerAyuda
            // 
            this.VerAyuda.Controls.Add(this.tabPage1);
            this.VerAyuda.Controls.Add(this.tabPage2);
            this.VerAyuda.Controls.Add(this.tabPage3);
            this.VerAyuda.Location = new System.Drawing.Point(1, -2);
            this.VerAyuda.Name = "VerAyuda";
            this.VerAyuda.SelectedIndex = 0;
            this.VerAyuda.Size = new System.Drawing.Size(800, 449);
            this.VerAyuda.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.registro_producto);
            this.tabPage1.Controls.Add(this.textoAyuda1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro de Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textoAyuda2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso de Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textoAyuda2
            // 
            this.textoAyuda2.Location = new System.Drawing.Point(82, 42);
            this.textoAyuda2.Name = "textoAyuda2";
            this.textoAyuda2.Size = new System.Drawing.Size(281, 321);
            this.textoAyuda2.TabIndex = 1;
            this.textoAyuda2.Text = resources.GetString("textoAyuda2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Sistema_Inventario.Properties.Resources.Captura_de_pantalla_20230113_075135;
            this.pictureBox1.Location = new System.Drawing.Point(396, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textoAyuda3);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta de Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // textoAyuda3
            // 
            this.textoAyuda3.Location = new System.Drawing.Point(46, 50);
            this.textoAyuda3.Name = "textoAyuda3";
            this.textoAyuda3.Size = new System.Drawing.Size(258, 207);
            this.textoAyuda3.TabIndex = 1;
            this.textoAyuda3.Text = resources.GetString("textoAyuda3.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Sistema_Inventario.Properties.Resources.Captura_de_pantalla_20230113_083334;
            this.pictureBox2.Location = new System.Drawing.Point(322, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(422, 308);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Ver_ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerAyuda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ver_ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Ayuda";
            this.Load += new System.EventHandler(this.Ver_ayuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registro_producto)).EndInit();
            this.VerAyuda.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textoAyuda1;
        private PictureBox registro_producto;
        private TabControl VerAyuda;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private RichTextBox textoAyuda2;
        private PictureBox pictureBox1;
        private RichTextBox textoAyuda3;
        private PictureBox pictureBox2;
    }
}