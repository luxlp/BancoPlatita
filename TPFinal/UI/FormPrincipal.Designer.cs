namespace TPFinal
{
    partial class FormPrincipal
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
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.panelTitular = new System.Windows.Forms.Panel();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTexto = new System.Windows.Forms.Panel();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.labelCategoriaUsuario = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.panelTitular.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEntrada
            // 
            this.panelEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEntrada.BackColor = System.Drawing.Color.Transparent;
            this.panelEntrada.Location = new System.Drawing.Point(516, 0);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(260, 300);
            this.panelEntrada.TabIndex = 1;
            // 
            // panelTitular
            // 
            this.panelTitular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitular.BackColor = System.Drawing.Color.Indigo;
            this.panelTitular.Controls.Add(this.buttonCerrar);
            this.panelTitular.Controls.Add(this.buttonMinimizar);
            this.panelTitular.Controls.Add(this.label1);
            this.panelTitular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTitular.Location = new System.Drawing.Point(0, 0);
            this.panelTitular.Name = "panelTitular";
            this.panelTitular.Size = new System.Drawing.Size(800, 120);
            this.panelTitular.TabIndex = 3;
            this.panelTitular.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitular_MouseDown);
            this.panelTitular.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitular_MouseMove);
            this.panelTitular.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitular_MouseUp);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point(725, 0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.buttonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimizar.ForeColor = System.Drawing.Color.White;
            this.buttonMinimizar.Location = new System.Drawing.Point(650, 0);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(75, 23);
            this.buttonMinimizar.TabIndex = 1;
            this.buttonMinimizar.Text = "";
            this.buttonMinimizar.UseVisualStyleBackColor = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANCO PLATITA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTexto
            // 
            this.panelTexto.BackColor = System.Drawing.Color.Transparent;
            this.panelTexto.Location = new System.Drawing.Point(0, 0);
            this.panelTexto.Name = "panelTexto";
            this.panelTexto.Size = new System.Drawing.Size(510, 300);
            this.panelTexto.TabIndex = 4;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSiguiente.AutoSize = true;
            this.buttonSiguiente.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSiguiente.FlatAppearance.BorderSize = 0;
            this.buttonSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSiguiente.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSiguiente.ForeColor = System.Drawing.Color.White;
            this.buttonSiguiente.Location = new System.Drawing.Point(32, 3);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(196, 62);
            this.buttonSiguiente.TabIndex = 5;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSiguiente, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(516, 306);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 94);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.Transparent;
            this.panelContenido.Controls.Add(this.panelEntrada);
            this.panelContenido.Controls.Add(this.tableLayoutPanel1);
            this.panelContenido.Controls.Add(this.panelTexto);
            this.panelContenido.Location = new System.Drawing.Point(12, 188);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(776, 400);
            this.panelContenido.TabIndex = 7;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.labelCategoriaUsuario);
            this.panelUsuario.Controls.Add(this.labelNombreUsuario);
            this.panelUsuario.Location = new System.Drawing.Point(12, 126);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(776, 56);
            this.panelUsuario.TabIndex = 8;
            // 
            // labelCategoriaUsuario
            // 
            this.labelCategoriaUsuario.AutoSize = true;
            this.labelCategoriaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelCategoriaUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaUsuario.Location = new System.Drawing.Point(6, 35);
            this.labelCategoriaUsuario.Name = "labelCategoriaUsuario";
            this.labelCategoriaUsuario.Size = new System.Drawing.Size(81, 21);
            this.labelCategoriaUsuario.TabIndex = 1;
            this.labelCategoriaUsuario.Text = "Categoría";
            this.labelCategoriaUsuario.Visible = false;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.Location = new System.Drawing.Point(3, 0);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(335, 37);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Bienvenido Lucas Dilatro";
            this.labelNombreUsuario.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelTitular);
            this.Controls.Add(this.panelContenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelTitular.ResumeLayout(false);
            this.panelTitular.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.Panel panelTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.Panel panelTexto;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Label labelCategoriaUsuario;
        private System.Windows.Forms.Label labelNombreUsuario;
    }
}