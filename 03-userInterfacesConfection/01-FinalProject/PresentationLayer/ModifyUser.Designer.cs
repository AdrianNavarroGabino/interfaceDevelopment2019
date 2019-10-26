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
            this.modifyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(732, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.nameBox.Location = new System.Drawing.Point(26, 443);
            this.nameBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(271, 37);
            this.nameBox.TabIndex = 11;
            this.nameBox.Text = "Name";
            this.nameBox.UseWaitCursor = true;
            this.nameBox.Enter += new System.EventHandler(this.SetEmpty);
            this.nameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filter);
            this.nameBox.Leave += new System.EventHandler(this.NameLeave);
            // 
            // idBox2
            // 
            this.idBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.idBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.idBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.idBox2.Location = new System.Drawing.Point(335, 443);
            this.idBox2.Mask = "A0000000L";
            this.idBox2.Name = "idBox2";
            this.idBox2.Size = new System.Drawing.Size(271, 37);
            this.idBox2.TabIndex = 13;
            this.idBox2.Visible = false;
            this.idBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filter);
            this.idBox2.Validated += new System.EventHandler(this.IdLostFocus);
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.idBox.Location = new System.Drawing.Point(335, 443);
            this.idBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(271, 37);
            this.idBox.TabIndex = 12;
            this.idBox.Text = "ID";
            this.idBox.UseWaitCursor = true;
            this.idBox.Enter += new System.EventHandler(this.IdEnter);
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.surnameBox.Location = new System.Drawing.Point(26, 491);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(271, 37);
            this.surnameBox.TabIndex = 14;
            this.surnameBox.Text = "Surname";
            this.surnameBox.UseWaitCursor = true;
            this.surnameBox.Enter += new System.EventHandler(this.SetEmpty);
            this.surnameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filter);
            this.surnameBox.Leave += new System.EventHandler(this.SurnameLeave);
            // 
            // mailBox
            // 
            this.mailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.mailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.mailBox.Location = new System.Drawing.Point(334, 491);
            this.mailBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(271, 37);
            this.mailBox.TabIndex = 15;
            this.mailBox.Text = "Mail";
            this.mailBox.UseWaitCursor = true;
            this.mailBox.Enter += new System.EventHandler(this.SetEmpty);
            this.mailBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Filter);
            this.mailBox.Leave += new System.EventHandler(this.MailLeave);
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.modifyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.modifyBtn.Location = new System.Drawing.Point(623, 461);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(107, 44);
            this.modifyBtn.TabIndex = 1;
            this.modifyBtn.Text = "MODIFY";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.GoToUserForm);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(750, 561);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.idBox2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button modifyBtn;
    }
}