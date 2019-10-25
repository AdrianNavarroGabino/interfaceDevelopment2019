namespace PresentationLayer
{
    partial class ModifyUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox2 = new System.Windows.Forms.MaskedTextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(976, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.nameBox.Location = new System.Drawing.Point(35, 545);
            this.nameBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(360, 45);
            this.nameBox.TabIndex = 7;
            this.nameBox.Text = "Name";
            this.nameBox.UseWaitCursor = true;
            this.nameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filter);
            // 
            // idBox2
            // 
            this.idBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.idBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.idBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.idBox2.Location = new System.Drawing.Point(447, 545);
            this.idBox2.Margin = new System.Windows.Forms.Padding(4);
            this.idBox2.Mask = "A0000000L";
            this.idBox2.Name = "idBox2";
            this.idBox2.Size = new System.Drawing.Size(360, 45);
            this.idBox2.TabIndex = 12;
            this.idBox2.Visible = false;
            this.idBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filter);
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.idBox.Location = new System.Drawing.Point(447, 545);
            this.idBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(360, 45);
            this.idBox.TabIndex = 13;
            this.idBox.Text = "ID";
            this.idBox.UseWaitCursor = true;
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.surnameBox.Location = new System.Drawing.Point(35, 604);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(360, 45);
            this.surnameBox.TabIndex = 14;
            this.surnameBox.Text = "Surname";
            this.surnameBox.UseWaitCursor = true;
            this.surnameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filter);
            // 
            // mailBox
            // 
            this.mailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.mailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.mailBox.Location = new System.Drawing.Point(447, 604);
            this.mailBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(360, 45);
            this.mailBox.TabIndex = 15;
            this.mailBox.Text = "Mail";
            this.mailBox.UseWaitCursor = true;
            this.mailBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filter);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1000, 690);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.idBox2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyUser";
            this.Text = "ModifyUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.MaskedTextBox idBox2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox mailBox;
    }
}