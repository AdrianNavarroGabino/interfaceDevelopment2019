namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.number = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hexadecimalBtn = new System.Windows.Forms.RadioButton();
            this.decimalBtn = new System.Windows.Forms.RadioButton();
            this.octalBtn = new System.Windows.Forms.RadioButton();
            this.resultLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(129, 44);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(120, 22);
            this.number.TabIndex = 0;
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.number.Click += new System.EventHandler(this.Reset);
            this.number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Reset);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hexadecimalBtn);
            this.groupBox1.Controls.Add(this.decimalBtn);
            this.groupBox1.Controls.Add(this.octalBtn);
            this.groupBox1.Location = new System.Drawing.Point(94, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // hexadecimalBtn
            // 
            this.hexadecimalBtn.AutoSize = true;
            this.hexadecimalBtn.Location = new System.Drawing.Point(38, 123);
            this.hexadecimalBtn.Name = "hexadecimalBtn";
            this.hexadecimalBtn.Size = new System.Drawing.Size(109, 21);
            this.hexadecimalBtn.TabIndex = 2;
            this.hexadecimalBtn.TabStop = true;
            this.hexadecimalBtn.Text = "Hexadecimal";
            this.hexadecimalBtn.UseVisualStyleBackColor = true;
            this.hexadecimalBtn.CheckedChanged += new System.EventHandler(this.Convert);
            // 
            // decimalBtn
            // 
            this.decimalBtn.AutoSize = true;
            this.decimalBtn.Location = new System.Drawing.Point(38, 85);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(79, 21);
            this.decimalBtn.TabIndex = 1;
            this.decimalBtn.TabStop = true;
            this.decimalBtn.Text = "Decimal";
            this.decimalBtn.UseVisualStyleBackColor = true;
            this.decimalBtn.CheckedChanged += new System.EventHandler(this.Convert);
            // 
            // octalBtn
            // 
            this.octalBtn.AutoSize = true;
            this.octalBtn.Location = new System.Drawing.Point(38, 47);
            this.octalBtn.Name = "octalBtn";
            this.octalBtn.Size = new System.Drawing.Size(62, 21);
            this.octalBtn.TabIndex = 0;
            this.octalBtn.TabStop = true;
            this.octalBtn.Text = "Octal";
            this.octalBtn.UseVisualStyleBackColor = true;
            this.octalBtn.CheckedChanged += new System.EventHandler(this.Convert);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(194, 346);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 17);
            this.resultLbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.number);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton hexadecimalBtn;
        private System.Windows.Forms.RadioButton decimalBtn;
        private System.Windows.Forms.RadioButton octalBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

