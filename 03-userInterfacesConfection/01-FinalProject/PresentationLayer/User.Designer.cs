namespace PresentationLayer
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerLbl = new System.Windows.Forms.Label();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passAgainBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.provinceBox = new System.Windows.Forms.ComboBox();
            this.townBox = new System.Windows.Forms.ComboBox();
            this.bornBox = new System.Windows.Forms.TextBox();
            this.postalCodeBox2 = new System.Windows.Forms.MaskedTextBox();
            this.idBox2 = new System.Windows.Forms.MaskedTextBox();
            this.bornDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, -88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 273);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // registerLbl
            // 
            this.registerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerLbl.AutoSize = true;
            this.registerLbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.registerLbl.Location = new System.Drawing.Point(461, 31);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(269, 70);
            this.registerLbl.TabIndex = 2;
            this.registerLbl.Text = "Register";
            // 
            // mailBox
            // 
            this.mailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.mailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.mailBox.Location = new System.Drawing.Point(48, 153);
            this.mailBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(425, 45);
            this.mailBox.TabIndex = 5;
            this.mailBox.Text = "Mail";
            this.mailBox.UseWaitCursor = true;
            this.mailBox.Enter += new System.EventHandler(this.SetEmpty);
            this.mailBox.Leave += new System.EventHandler(this.MailLeave);
            this.mailBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingMail);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.nameBox.Location = new System.Drawing.Point(48, 232);
            this.nameBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(425, 45);
            this.nameBox.TabIndex = 6;
            this.nameBox.Text = "Name";
            this.nameBox.UseWaitCursor = true;
            this.nameBox.Enter += new System.EventHandler(this.SetEmpty);
            this.nameBox.Leave += new System.EventHandler(this.NameLeave);
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingName);
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.surnameBox.Location = new System.Drawing.Point(48, 313);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(425, 45);
            this.surnameBox.TabIndex = 7;
            this.surnameBox.Text = "Surname";
            this.surnameBox.UseWaitCursor = true;
            this.surnameBox.Enter += new System.EventHandler(this.SetEmpty);
            this.surnameBox.Leave += new System.EventHandler(this.SurnameLeave);
            // 
            // passBox
            // 
            this.passBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.passBox.Location = new System.Drawing.Point(48, 392);
            this.passBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(425, 45);
            this.passBox.TabIndex = 8;
            this.passBox.Text = "Password";
            this.passBox.Enter += new System.EventHandler(this.HidePassword);
            this.passBox.Leave += new System.EventHandler(this.ShowPassword);
            this.passBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingPassword);
            // 
            // passAgainBox
            // 
            this.passAgainBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passAgainBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.passAgainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAgainBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.passAgainBox.Location = new System.Drawing.Point(48, 473);
            this.passAgainBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passAgainBox.Name = "passAgainBox";
            this.passAgainBox.Size = new System.Drawing.Size(425, 45);
            this.passAgainBox.TabIndex = 9;
            this.passAgainBox.Text = "Password again";
            this.passAgainBox.Enter += new System.EventHandler(this.HidePassword);
            this.passAgainBox.Leave += new System.EventHandler(this.ShowPassword);
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.registerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.registerBtn.Location = new System.Drawing.Point(393, 618);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(188, 42);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.RegisterOrModify);
            // 
            // idBox
            // 
            this.idBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.idBox.Location = new System.Drawing.Point(48, 552);
            this.idBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(425, 45);
            this.idBox.TabIndex = 11;
            this.idBox.Text = "ID";
            this.idBox.UseWaitCursor = true;
            this.idBox.Click += new System.EventHandler(this.IdEnter);
            this.idBox.Enter += new System.EventHandler(this.IdEnter);
            this.idBox.Leave += new System.EventHandler(this.IDLeave);
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.phoneBox.Location = new System.Drawing.Point(540, 153);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(425, 45);
            this.phoneBox.TabIndex = 12;
            this.phoneBox.Text = "Phone";
            this.phoneBox.UseWaitCursor = true;
            this.phoneBox.Enter += new System.EventHandler(this.SetEmpty);
            this.phoneBox.Leave += new System.EventHandler(this.PhoneLeave);
            // 
            // addressBox
            // 
            this.addressBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.addressBox.Location = new System.Drawing.Point(540, 232);
            this.addressBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(425, 45);
            this.addressBox.TabIndex = 13;
            this.addressBox.Text = "Address";
            this.addressBox.UseWaitCursor = true;
            this.addressBox.Enter += new System.EventHandler(this.SetEmpty);
            this.addressBox.Leave += new System.EventHandler(this.AddressLeave);
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.postalCodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.postalCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.postalCodeBox.Location = new System.Drawing.Point(540, 313);
            this.postalCodeBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(425, 45);
            this.postalCodeBox.TabIndex = 14;
            this.postalCodeBox.Text = "Postal code";
            this.postalCodeBox.UseWaitCursor = true;
            this.postalCodeBox.Enter += new System.EventHandler(this.PostalCodeEnter);
            // 
            // provinceBox
            // 
            this.provinceBox.AccessibleName = "";
            this.provinceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.provinceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.provinceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.provinceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.provinceBox.FormattingEnabled = true;
            this.provinceBox.Location = new System.Drawing.Point(540, 391);
            this.provinceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(425, 45);
            this.provinceBox.TabIndex = 16;
            this.provinceBox.Text = "Province";
            this.provinceBox.SelectedValueChanged += new System.EventHandler(this.FillTowns);
            // 
            // townBox
            // 
            this.townBox.AccessibleName = "";
            this.townBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.townBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.townBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.townBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.townBox.FormattingEnabled = true;
            this.townBox.Location = new System.Drawing.Point(540, 474);
            this.townBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.townBox.Name = "townBox";
            this.townBox.Size = new System.Drawing.Size(425, 45);
            this.townBox.TabIndex = 17;
            this.townBox.Text = "Town";
            // 
            // bornBox
            // 
            this.bornBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bornBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.bornBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.bornBox.Location = new System.Drawing.Point(540, 551);
            this.bornBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.bornBox.Name = "bornBox";
            this.bornBox.Size = new System.Drawing.Size(425, 45);
            this.bornBox.TabIndex = 18;
            this.bornBox.Text = "Born";
            this.bornBox.UseWaitCursor = true;
            this.bornBox.Enter += new System.EventHandler(this.BornEnter);
            this.bornBox.Leave += new System.EventHandler(this.BornLeave);
            // 
            // postalCodeBox2
            // 
            this.postalCodeBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.postalCodeBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.postalCodeBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.postalCodeBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.postalCodeBox2.Location = new System.Drawing.Point(540, 313);
            this.postalCodeBox2.Margin = new System.Windows.Forms.Padding(4);
            this.postalCodeBox2.Mask = "00000";
            this.postalCodeBox2.Name = "postalCodeBox2";
            this.postalCodeBox2.Size = new System.Drawing.Size(425, 45);
            this.postalCodeBox2.TabIndex = 15;
            this.postalCodeBox2.Visible = false;
            this.postalCodeBox2.Validated += new System.EventHandler(this.PostalCodeLostFocus);
            // 
            // idBox2
            // 
            this.idBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.idBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.idBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.idBox2.Location = new System.Drawing.Point(48, 601);
            this.idBox2.Margin = new System.Windows.Forms.Padding(4);
            this.idBox2.Mask = "A0000000L";
            this.idBox2.Name = "idBox2";
            this.idBox2.Size = new System.Drawing.Size(425, 45);
            this.idBox2.TabIndex = 11;
            this.idBox2.Visible = false;
            this.idBox2.Validating += new System.ComponentModel.CancelEventHandler(this.IdLostFocus);
            // 
            // bornDate
            // 
            this.bornDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bornDate.Location = new System.Drawing.Point(540, 573);
            this.bornDate.Margin = new System.Windows.Forms.Padding(4);
            this.bornDate.MaxDate = new System.DateTime(2019, 10, 30, 0, 0, 0, 0);
            this.bornDate.Name = "bornDate";
            this.bornDate.Size = new System.Drawing.Size(425, 22);
            this.bornDate.TabIndex = 19;
            this.bornDate.Value = new System.DateTime(2019, 10, 25, 0, 0, 0, 0);
            this.bornDate.Visible = false;
            this.bornDate.ValueChanged += new System.EventHandler(this.DateChange);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1000, 690);
            this.Controls.Add(this.bornDate);
            this.Controls.Add(this.idBox2);
            this.Controls.Add(this.postalCodeBox2);
            this.Controls.Add(this.townBox);
            this.Controls.Add(this.provinceBox);
            this.Controls.Add(this.bornBox);
            this.Controls.Add(this.postalCodeBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passAgainBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.registerLbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label registerLbl;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox passAgainBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.ComboBox provinceBox;
        private System.Windows.Forms.ComboBox townBox;
        private System.Windows.Forms.TextBox bornBox;
        private System.Windows.Forms.MaskedTextBox postalCodeBox2;
        private System.Windows.Forms.MaskedTextBox idBox2;
        private System.Windows.Forms.DateTimePicker bornDate;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}