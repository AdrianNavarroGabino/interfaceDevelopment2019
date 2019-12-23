namespace PresentationLayer
{
    partial class OrderSummary
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
            this.productsLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noIVALbl = new System.Windows.Forms.Label();
            this.IVA = new System.Windows.Forms.Label();
            this.finalPriceLbl = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.updateBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productsLbl
            // 
            this.productsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productsLbl.AutoSize = true;
            this.productsLbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.productsLbl.Location = new System.Drawing.Point(265, 9);
            this.productsLbl.Name = "productsLbl";
            this.productsLbl.Size = new System.Drawing.Size(474, 70);
            this.productsLbl.TabIndex = 5;
            this.productsLbl.Text = "Order summary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(488, 432);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(529, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 30);
            this.label4.TabIndex = 44;
            this.label4.Text = "Price without  IVA:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(529, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 45;
            this.label1.Text = "IVA:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(529, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 30);
            this.label2.TabIndex = 46;
            this.label2.Text = "Final price:";
            // 
            // noIVALbl
            // 
            this.noIVALbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noIVALbl.AutoSize = true;
            this.noIVALbl.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noIVALbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.noIVALbl.Location = new System.Drawing.Point(790, 220);
            this.noIVALbl.Name = "noIVALbl";
            this.noIVALbl.Size = new System.Drawing.Size(55, 30);
            this.noIVALbl.TabIndex = 47;
            this.noIVALbl.Text = "123";
            this.noIVALbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IVA
            // 
            this.IVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IVA.AutoSize = true;
            this.IVA.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.IVA.Location = new System.Drawing.Point(790, 345);
            this.IVA.Name = "IVA";
            this.IVA.Size = new System.Drawing.Size(59, 30);
            this.IVA.TabIndex = 48;
            this.IVA.Text = "21%";
            this.IVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // finalPriceLbl
            // 
            this.finalPriceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.finalPriceLbl.AutoSize = true;
            this.finalPriceLbl.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.finalPriceLbl.Location = new System.Drawing.Point(790, 470);
            this.finalPriceLbl.Name = "finalPriceLbl";
            this.finalPriceLbl.Size = new System.Drawing.Size(55, 30);
            this.finalPriceLbl.TabIndex = 49;
            this.finalPriceLbl.Text = "123";
            this.finalPriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.orderBtn.Location = new System.Drawing.Point(674, 589);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(171, 50);
            this.orderBtn.TabIndex = 50;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.Order);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(12, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 51;
            this.label3.Text = "Amount:";
            // 
            // amountBox
            // 
            this.amountBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.amountBox.Location = new System.Drawing.Point(152, 575);
            this.amountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(120, 36);
            this.amountBox.TabIndex = 52;
            this.amountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.updateBtn.Location = new System.Drawing.Point(327, 576);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(135, 34);
            this.updateBtn.TabIndex = 53;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.UpdateAmount);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.removeBtn.Location = new System.Drawing.Point(162, 630);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(197, 48);
            this.removeBtn.TabIndex = 54;
            this.removeBtn.Text = "Remove product";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.RemoveProduct);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1000, 690);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.finalPriceLbl);
            this.Controls.Add(this.IVA);
            this.Controls.Add(this.noIVALbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.productsLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderSummary";
            this.Text = "OrderSummary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productsLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noIVALbl;
        private System.Windows.Forms.Label IVA;
        private System.Windows.Forms.Label finalPriceLbl;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown amountBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button removeBtn;
    }
}