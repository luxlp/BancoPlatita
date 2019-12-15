namespace TPFinal
{
    partial class ucTarjeta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBlanquearPin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelTipo.Location = new System.Drawing.Point(3, 50);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(40, 21);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "Tipo";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(3, 25);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(196, 25);
            this.labelNumero.TabIndex = 1;
            this.labelNumero.Text = "0000-0000-0000-0000";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Indigo;
            this.labelNombre.Location = new System.Drawing.Point(3, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(299, 25);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Tarjeta Mastercard Banco del Sur";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Controls.Add(this.buttonBlanquearPin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNumero, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTipo, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonBlanquearPin
            // 
            this.buttonBlanquearPin.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonBlanquearPin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBlanquearPin.FlatAppearance.BorderSize = 0;
            this.buttonBlanquearPin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBlanquearPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonBlanquearPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlanquearPin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlanquearPin.ForeColor = System.Drawing.Color.White;
            this.buttonBlanquearPin.Location = new System.Drawing.Point(541, 3);
            this.buttonBlanquearPin.Name = "buttonBlanquearPin";
            this.tableLayoutPanel1.SetRowSpan(this.buttonBlanquearPin, 3);
            this.buttonBlanquearPin.Size = new System.Drawing.Size(100, 68);
            this.buttonBlanquearPin.TabIndex = 2;
            this.buttonBlanquearPin.Text = "Blanquear PIN";
            this.buttonBlanquearPin.UseVisualStyleBackColor = false;
            this.buttonBlanquearPin.Click += new System.EventHandler(this.buttonBlanquearPin_Click);
            // 
            // ucTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucTarjeta";
            this.Size = new System.Drawing.Size(644, 80);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonBlanquearPin;
    }
}
