namespace TPFinal
{
    partial class ucPin
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
            this.label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(3, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(452, 51);
            this.label.TabIndex = 7;
            this.label.Text = "Ingrese su PIN";
            this.label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 375);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.AllowPromptAsInput = false;
            this.maskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBox.BackColor = System.Drawing.Color.White;
            this.maskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox.Culture = new System.Globalization.CultureInfo("");
            this.maskedTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.maskedTextBox.HidePromptOnLeave = true;
            this.maskedTextBox.Location = new System.Drawing.Point(119, 121);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.maskedTextBox.Mask = "0000";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.PasswordChar = '*';
            this.maskedTextBox.PromptChar = ' ';
            this.maskedTextBox.ReadOnly = true;
            this.maskedTextBox.Size = new System.Drawing.Size(220, 50);
            this.maskedTextBox.TabIndex = 6;
            this.maskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // ucPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucPin";
            this.Size = new System.Drawing.Size(458, 375);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
    }
}
