namespace TPFinal
{
    partial class ucOperaciones
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConsultarSaldo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBlanquearPin = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonUltimosMovimientos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonConsultarSaldo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonBlanquearPin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSalir, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonUltimosMovimientos, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 402);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonConsultarSaldo
            // 
            this.buttonConsultarSaldo.AutoSize = true;
            this.buttonConsultarSaldo.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonConsultarSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConsultarSaldo.FlatAppearance.BorderSize = 0;
            this.buttonConsultarSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonConsultarSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonConsultarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultarSaldo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarSaldo.ForeColor = System.Drawing.Color.White;
            this.buttonConsultarSaldo.Location = new System.Drawing.Point(3, 124);
            this.buttonConsultarSaldo.Name = "buttonConsultarSaldo";
            this.buttonConsultarSaldo.Size = new System.Drawing.Size(507, 47);
            this.buttonConsultarSaldo.TabIndex = 7;
            this.buttonConsultarSaldo.Text = "Consultar saldo";
            this.buttonConsultarSaldo.UseVisualStyleBackColor = false;
            this.buttonConsultarSaldo.Click += new System.EventHandler(this.buttonConsultarSaldo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escoja una operación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBlanquearPin
            // 
            this.buttonBlanquearPin.AutoSize = true;
            this.buttonBlanquearPin.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonBlanquearPin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBlanquearPin.FlatAppearance.BorderSize = 0;
            this.buttonBlanquearPin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBlanquearPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonBlanquearPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlanquearPin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlanquearPin.ForeColor = System.Drawing.Color.White;
            this.buttonBlanquearPin.Location = new System.Drawing.Point(3, 71);
            this.buttonBlanquearPin.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.buttonBlanquearPin.Name = "buttonBlanquearPin";
            this.buttonBlanquearPin.Size = new System.Drawing.Size(507, 47);
            this.buttonBlanquearPin.TabIndex = 6;
            this.buttonBlanquearPin.Text = "Blanquear PIN";
            this.buttonBlanquearPin.UseVisualStyleBackColor = false;
            this.buttonBlanquearPin.Click += new System.EventHandler(this.buttonBlanquearPin_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.AutoSize = true;
            this.buttonSalir.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(3, 230);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(507, 47);
            this.buttonSalir.TabIndex = 9;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonUltimosMovimientos
            // 
            this.buttonUltimosMovimientos.AutoSize = true;
            this.buttonUltimosMovimientos.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonUltimosMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUltimosMovimientos.FlatAppearance.BorderSize = 0;
            this.buttonUltimosMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUltimosMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonUltimosMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUltimosMovimientos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUltimosMovimientos.ForeColor = System.Drawing.Color.White;
            this.buttonUltimosMovimientos.Location = new System.Drawing.Point(3, 177);
            this.buttonUltimosMovimientos.Name = "buttonUltimosMovimientos";
            this.buttonUltimosMovimientos.Size = new System.Drawing.Size(507, 47);
            this.buttonUltimosMovimientos.TabIndex = 8;
            this.buttonUltimosMovimientos.Text = "Últimos movimientos";
            this.buttonUltimosMovimientos.UseVisualStyleBackColor = false;
            this.buttonUltimosMovimientos.Click += new System.EventHandler(this.buttonUltimosMovimientos_Click);
            // 
            // ucOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucOperaciones";
            this.Size = new System.Drawing.Size(513, 402);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonUltimosMovimientos;
        private System.Windows.Forms.Button buttonConsultarSaldo;
        private System.Windows.Forms.Button buttonBlanquearPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalir;
    }
}
