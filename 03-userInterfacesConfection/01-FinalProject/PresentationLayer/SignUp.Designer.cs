namespace PresentationLayer
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passAgainBox = new System.Windows.Forms.TextBox();
            this.loginButon = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.mailError = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.surnameError = new System.Windows.Forms.Label();
            this.passError = new System.Windows.Forms.Label();
            this.passAgainError = new System.Windows.Forms.Label();
            this.IDError = new System.Windows.Forms.Label();
            this.bornError = new System.Windows.Forms.Label();
            this.provinceError = new System.Windows.Forms.Label();
            this.townError = new System.Windows.Forms.Label();
            this.postalCodeError = new System.Windows.Forms.Label();
            this.addressError = new System.Windows.Forms.Label();
            this.phoneError = new System.Windows.Forms.Label();
            this.provinceBox = new System.Windows.Forms.ComboBox();
            this.townBox = new System.Windows.Forms.ComboBox();
            this.bornBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, -88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 273);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(504, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign up";
            // 
            // mailBox
            // 
            this.mailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.mailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.mailBox.Location = new System.Drawing.Point(178, 185);
            this.mailBox.Margin = new System.Windows.Forms.Padding(10);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(360, 45);
            this.mailBox.TabIndex = 5;
            this.mailBox.Text = "Mail";
            this.mailBox.UseWaitCursor = true;
            this.mailBox.Enter += new System.EventHandler(this.SetEmpty);
            this.mailBox.Leave += new System.EventHandler(this.MailLeave);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.nameBox.Location = new System.Drawing.Point(178, 265);
            this.nameBox.Margin = new System.Windows.Forms.Padding(10);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(360, 45);
            this.nameBox.TabIndex = 6;
            this.nameBox.Text = "Name";
            this.nameBox.UseWaitCursor = true;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.nameBox.Enter += new System.EventHandler(this.SetEmpty);
            this.nameBox.Leave += new System.EventHandler(this.NameLeave);
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.surnameBox.Location = new System.Drawing.Point(178, 345);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(10);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(360, 45);
            this.surnameBox.TabIndex = 7;
            this.surnameBox.Text = "Surname";
            this.surnameBox.UseWaitCursor = true;
            this.surnameBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.surnameBox.Enter += new System.EventHandler(this.SetEmpty);
            this.surnameBox.Leave += new System.EventHandler(this.SurnameLeave);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.passBox.Location = new System.Drawing.Point(178, 425);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(360, 45);
            this.passBox.TabIndex = 8;
            this.passBox.Text = "Password";
            this.passBox.Enter += new System.EventHandler(this.HidePassword);
            this.passBox.Leave += new System.EventHandler(this.ShowPassword);
            // 
            // passAgainBox
            // 
            this.passAgainBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.passAgainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAgainBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.passAgainBox.Location = new System.Drawing.Point(178, 505);
            this.passAgainBox.Name = "passAgainBox";
            this.passAgainBox.Size = new System.Drawing.Size(360, 45);
            this.passAgainBox.TabIndex = 9;
            this.passAgainBox.Text = "Password again";
            this.passAgainBox.Enter += new System.EventHandler(this.HidePassword);
            this.passAgainBox.Leave += new System.EventHandler(this.ShowPassword);
            // 
            // loginButon
            // 
            this.loginButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.loginButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.loginButon.Location = new System.Drawing.Point(500, 680);
            this.loginButon.Name = "loginButon";
            this.loginButon.Size = new System.Drawing.Size(256, 67);
            this.loginButon.TabIndex = 1;
            this.loginButon.Text = "REGISTER";
            this.loginButon.UseVisualStyleBackColor = false;
            this.loginButon.Click += new System.EventHandler(this.ValidateSignUp);
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.idBox.Location = new System.Drawing.Point(178, 585);
            this.idBox.Margin = new System.Windows.Forms.Padding(10);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(360, 45);
            this.idBox.TabIndex = 11;
            this.idBox.Text = "ID";
            this.idBox.UseWaitCursor = true;
            this.idBox.Enter += new System.EventHandler(this.SetEmpty);
            this.idBox.Leave += new System.EventHandler(this.IDLeave);
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.phoneBox.Location = new System.Drawing.Point(718, 185);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(10);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(360, 45);
            this.phoneBox.TabIndex = 12;
            this.phoneBox.Text = "Phone";
            this.phoneBox.UseWaitCursor = true;
            this.phoneBox.Enter += new System.EventHandler(this.SetEmpty);
            this.phoneBox.Leave += new System.EventHandler(this.PhoneLeave);
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.addressBox.Location = new System.Drawing.Point(718, 265);
            this.addressBox.Margin = new System.Windows.Forms.Padding(10);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(360, 45);
            this.addressBox.TabIndex = 13;
            this.addressBox.Text = "Address";
            this.addressBox.UseWaitCursor = true;
            this.addressBox.Enter += new System.EventHandler(this.SetEmpty);
            this.addressBox.Leave += new System.EventHandler(this.AddressLeave);
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.postalCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.postalCodeBox.Location = new System.Drawing.Point(718, 345);
            this.postalCodeBox.Margin = new System.Windows.Forms.Padding(10);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(360, 45);
            this.postalCodeBox.TabIndex = 14;
            this.postalCodeBox.Text = "Postal code";
            this.postalCodeBox.UseWaitCursor = true;
            this.postalCodeBox.Enter += new System.EventHandler(this.SetEmpty);
            this.postalCodeBox.Leave += new System.EventHandler(this.PostalCodeLeave);
            // 
            // mailError
            // 
            this.mailError.AutoSize = true;
            this.mailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailError.ForeColor = System.Drawing.Color.Red;
            this.mailError.Location = new System.Drawing.Point(173, 230);
            this.mailError.Name = "mailError";
            this.mailError.Size = new System.Drawing.Size(0, 25);
            this.mailError.TabIndex = 18;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(173, 310);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(0, 25);
            this.nameError.TabIndex = 19;
            // 
            // surnameError
            // 
            this.surnameError.AutoSize = true;
            this.surnameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameError.ForeColor = System.Drawing.Color.Red;
            this.surnameError.Location = new System.Drawing.Point(173, 390);
            this.surnameError.Name = "surnameError";
            this.surnameError.Size = new System.Drawing.Size(0, 25);
            this.surnameError.TabIndex = 20;
            // 
            // passError
            // 
            this.passError.AutoSize = true;
            this.passError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passError.ForeColor = System.Drawing.Color.Red;
            this.passError.Location = new System.Drawing.Point(173, 470);
            this.passError.Name = "passError";
            this.passError.Size = new System.Drawing.Size(0, 25);
            this.passError.TabIndex = 21;
            // 
            // passAgainError
            // 
            this.passAgainError.AutoSize = true;
            this.passAgainError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAgainError.ForeColor = System.Drawing.Color.Red;
            this.passAgainError.Location = new System.Drawing.Point(173, 550);
            this.passAgainError.Name = "passAgainError";
            this.passAgainError.Size = new System.Drawing.Size(0, 25);
            this.passAgainError.TabIndex = 22;
            // 
            // IDError
            // 
            this.IDError.AutoSize = true;
            this.IDError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDError.ForeColor = System.Drawing.Color.Red;
            this.IDError.Location = new System.Drawing.Point(173, 630);
            this.IDError.Name = "IDError";
            this.IDError.Size = new System.Drawing.Size(0, 25);
            this.IDError.TabIndex = 23;
            // 
            // bornError
            // 
            this.bornError.AutoSize = true;
            this.bornError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornError.ForeColor = System.Drawing.Color.Red;
            this.bornError.Location = new System.Drawing.Point(713, 630);
            this.bornError.Name = "bornError";
            this.bornError.Size = new System.Drawing.Size(0, 25);
            this.bornError.TabIndex = 29;
            // 
            // provinceError
            // 
            this.provinceError.AutoSize = true;
            this.provinceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceError.ForeColor = System.Drawing.Color.Red;
            this.provinceError.Location = new System.Drawing.Point(713, 550);
            this.provinceError.Name = "provinceError";
            this.provinceError.Size = new System.Drawing.Size(0, 25);
            this.provinceError.TabIndex = 28;
            // 
            // townError
            // 
            this.townError.AutoSize = true;
            this.townError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.townError.ForeColor = System.Drawing.Color.Red;
            this.townError.Location = new System.Drawing.Point(713, 470);
            this.townError.Name = "townError";
            this.townError.Size = new System.Drawing.Size(0, 25);
            this.townError.TabIndex = 27;
            // 
            // postalCodeError
            // 
            this.postalCodeError.AutoSize = true;
            this.postalCodeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeError.ForeColor = System.Drawing.Color.Red;
            this.postalCodeError.Location = new System.Drawing.Point(713, 390);
            this.postalCodeError.Name = "postalCodeError";
            this.postalCodeError.Size = new System.Drawing.Size(0, 25);
            this.postalCodeError.TabIndex = 26;
            // 
            // addressError
            // 
            this.addressError.AutoSize = true;
            this.addressError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressError.ForeColor = System.Drawing.Color.Red;
            this.addressError.Location = new System.Drawing.Point(713, 310);
            this.addressError.Name = "addressError";
            this.addressError.Size = new System.Drawing.Size(0, 25);
            this.addressError.TabIndex = 25;
            // 
            // phoneError
            // 
            this.phoneError.AutoSize = true;
            this.phoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneError.ForeColor = System.Drawing.Color.Red;
            this.phoneError.Location = new System.Drawing.Point(713, 230);
            this.phoneError.Name = "phoneError";
            this.phoneError.Size = new System.Drawing.Size(0, 25);
            this.phoneError.TabIndex = 24;
            // 
            // provinceBox
            // 
            this.provinceBox.AccessibleName = "";
            this.provinceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.provinceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.provinceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.provinceBox.FormattingEnabled = true;
            this.provinceBox.Location = new System.Drawing.Point(718, 425);
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(360, 45);
            this.provinceBox.TabIndex = 15;
            this.provinceBox.Text = "Province";
            this.provinceBox.SelectedValueChanged += new System.EventHandler(this.FillTowns);
            // 
            // townBox
            // 
            this.townBox.AccessibleName = "";
            this.townBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.townBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.townBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.townBox.FormattingEnabled = true;
            this.townBox.Location = new System.Drawing.Point(718, 505);
            this.townBox.Name = "townBox";
            this.townBox.Size = new System.Drawing.Size(360, 45);
            this.townBox.TabIndex = 16;
            this.townBox.Text = "Town";
            // 
            // bornBox
            // 
            this.bornBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.bornBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.bornBox.Location = new System.Drawing.Point(718, 585);
            this.bornBox.Margin = new System.Windows.Forms.Padding(10);
            this.bornBox.Name = "bornBox";
            this.bornBox.Size = new System.Drawing.Size(360, 45);
            this.bornBox.TabIndex = 17;
            this.bornBox.Text = "Born";
            this.bornBox.UseWaitCursor = true;
            this.bornBox.Enter += new System.EventHandler(this.SetEmpty);
            this.bornBox.Leave += new System.EventHandler(this.BornLeave);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1256, 810);
            this.Controls.Add(this.townBox);
            this.Controls.Add(this.provinceBox);
            this.Controls.Add(this.bornError);
            this.Controls.Add(this.provinceError);
            this.Controls.Add(this.townError);
            this.Controls.Add(this.postalCodeError);
            this.Controls.Add(this.addressError);
            this.Controls.Add(this.phoneError);
            this.Controls.Add(this.IDError);
            this.Controls.Add(this.passAgainError);
            this.Controls.Add(this.passError);
            this.Controls.Add(this.surnameError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.mailError);
            this.Controls.Add(this.bornBox);
            this.Controls.Add(this.postalCodeBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.loginButon);
            this.Controls.Add(this.passAgainBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox passAgainBox;
        private System.Windows.Forms.Button loginButon;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.Label mailError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label surnameError;
        private System.Windows.Forms.Label passError;
        private System.Windows.Forms.Label passAgainError;
        private System.Windows.Forms.Label IDError;
        private System.Windows.Forms.Label bornError;
        private System.Windows.Forms.Label provinceError;
        private System.Windows.Forms.Label townError;
        private System.Windows.Forms.Label postalCodeError;
        private System.Windows.Forms.Label addressError;
        private System.Windows.Forms.Label phoneError;
        private System.Windows.Forms.ComboBox provinceBox;
        private System.Windows.Forms.ComboBox townBox;
        private System.Windows.Forms.TextBox bornBox;
    }
}