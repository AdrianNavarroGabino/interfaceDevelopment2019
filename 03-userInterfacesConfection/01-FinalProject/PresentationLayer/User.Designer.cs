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
            this.postalCodeBox2 = new System.Windows.Forms.MaskedTextBox();
            this.idBox2 = new System.Windows.Forms.MaskedTextBox();
            this.bornDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, -74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 222);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // registerLbl
            // 
            this.registerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerLbl.AutoSize = true;
            this.registerLbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.registerLbl.Location = new System.Drawing.Point(346, 23);
            this.registerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(217, 56);
            this.registerLbl.TabIndex = 2;
            this.registerLbl.Text = "Register";
            // 
            // mailBox
            // 
            this.mailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.mailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.mailBox.Location = new System.Drawing.Point(36, 122);
            this.mailBox.Margin = new System.Windows.Forms.Padding(8);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(320, 37);
            this.mailBox.TabIndex = 5;
            this.mailBox.Text = "Mail";
            this.mailBox.UseWaitCursor = true;
            this.mailBox.Enter += new System.EventHandler(this.SetEmpty);
            this.mailBox.Leave += new System.EventHandler(this.MailLeave);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.nameBox.Location = new System.Drawing.Point(36, 186);
            this.nameBox.Margin = new System.Windows.Forms.Padding(8);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(320, 37);
            this.nameBox.TabIndex = 6;
            this.nameBox.Text = "Name";
            this.nameBox.UseWaitCursor = true;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.nameBox.Enter += new System.EventHandler(this.SetEmpty);
            this.nameBox.Leave += new System.EventHandler(this.NameLeave);
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.surnameBox.Location = new System.Drawing.Point(36, 252);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(8);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(320, 37);
            this.surnameBox.TabIndex = 7;
            this.surnameBox.Text = "Surname";
            this.surnameBox.UseWaitCursor = true;
            this.surnameBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.surnameBox.Enter += new System.EventHandler(this.SetEmpty);
            this.surnameBox.Leave += new System.EventHandler(this.SurnameLeave);
            // 
            // passBox
            // 
            this.passBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.passBox.Location = new System.Drawing.Point(36, 316);
            this.passBox.Margin = new System.Windows.Forms.Padding(2);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(320, 37);
            this.passBox.TabIndex = 8;
            this.passBox.Text = "Password";
            this.passBox.Enter += new System.EventHandler(this.HidePassword);
            this.passBox.Leave += new System.EventHandler(this.ShowPassword);
            // 
            // passAgainBox
            // 
            this.passAgainBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passAgainBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.passAgainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAgainBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.passAgainBox.Location = new System.Drawing.Point(36, 382);
            this.passAgainBox.Margin = new System.Windows.Forms.Padding(2);
            this.passAgainBox.Name = "passAgainBox";
            this.passAgainBox.Size = new System.Drawing.Size(320, 37);
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
            this.registerBtn.Location = new System.Drawing.Point(295, 500);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(141, 34);
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
            this.idBox.Location = new System.Drawing.Point(36, 446);
            this.idBox.Margin = new System.Windows.Forms.Padding(8);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(320, 37);
            this.idBox.TabIndex = 11;
            this.idBox.Text = "ID";
            this.idBox.UseWaitCursor = true;
            this.idBox.Enter += new System.EventHandler(this.IdEnter);
            this.idBox.Leave += new System.EventHandler(this.IDLeave);
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.phoneBox.Location = new System.Drawing.Point(405, 122);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(8);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(320, 37);
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
            this.addressBox.Location = new System.Drawing.Point(405, 186);
            this.addressBox.Margin = new System.Windows.Forms.Padding(8);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(320, 37);
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
            this.postalCodeBox.Location = new System.Drawing.Point(405, 252);
            this.postalCodeBox.Margin = new System.Windows.Forms.Padding(8);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(320, 37);
            this.postalCodeBox.TabIndex = 14;
            this.postalCodeBox.Text = "Postal code";
            this.postalCodeBox.UseWaitCursor = true;
            this.postalCodeBox.Enter += new System.EventHandler(this.PostalCodeEnter);
            // 
            // mailError
            // 
            this.mailError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mailError.AutoSize = true;
            this.mailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailError.ForeColor = System.Drawing.Color.Red;
            this.mailError.Location = new System.Drawing.Point(130, 185);
            this.mailError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mailError.Name = "mailError";
            this.mailError.Size = new System.Drawing.Size(0, 20);
            this.mailError.TabIndex = 18;
            // 
            // nameError
            // 
            this.nameError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(130, 250);
            this.nameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(0, 20);
            this.nameError.TabIndex = 19;
            // 
            // surnameError
            // 
            this.surnameError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameError.AutoSize = true;
            this.surnameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameError.ForeColor = System.Drawing.Color.Red;
            this.surnameError.Location = new System.Drawing.Point(130, 315);
            this.surnameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameError.Name = "surnameError";
            this.surnameError.Size = new System.Drawing.Size(0, 20);
            this.surnameError.TabIndex = 20;
            // 
            // passError
            // 
            this.passError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passError.AutoSize = true;
            this.passError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passError.ForeColor = System.Drawing.Color.Red;
            this.passError.Location = new System.Drawing.Point(130, 380);
            this.passError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passError.Name = "passError";
            this.passError.Size = new System.Drawing.Size(0, 20);
            this.passError.TabIndex = 21;
            // 
            // passAgainError
            // 
            this.passAgainError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passAgainError.AutoSize = true;
            this.passAgainError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAgainError.ForeColor = System.Drawing.Color.Red;
            this.passAgainError.Location = new System.Drawing.Point(130, 445);
            this.passAgainError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passAgainError.Name = "passAgainError";
            this.passAgainError.Size = new System.Drawing.Size(0, 20);
            this.passAgainError.TabIndex = 22;
            // 
            // IDError
            // 
            this.IDError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IDError.AutoSize = true;
            this.IDError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDError.ForeColor = System.Drawing.Color.Red;
            this.IDError.Location = new System.Drawing.Point(130, 510);
            this.IDError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDError.Name = "IDError";
            this.IDError.Size = new System.Drawing.Size(0, 20);
            this.IDError.TabIndex = 23;
            // 
            // bornError
            // 
            this.bornError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bornError.AutoSize = true;
            this.bornError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornError.ForeColor = System.Drawing.Color.Red;
            this.bornError.Location = new System.Drawing.Point(535, 510);
            this.bornError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bornError.Name = "bornError";
            this.bornError.Size = new System.Drawing.Size(0, 20);
            this.bornError.TabIndex = 29;
            // 
            // provinceError
            // 
            this.provinceError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.provinceError.AutoSize = true;
            this.provinceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceError.ForeColor = System.Drawing.Color.Red;
            this.provinceError.Location = new System.Drawing.Point(535, 445);
            this.provinceError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.provinceError.Name = "provinceError";
            this.provinceError.Size = new System.Drawing.Size(0, 20);
            this.provinceError.TabIndex = 28;
            // 
            // townError
            // 
            this.townError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.townError.AutoSize = true;
            this.townError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.townError.ForeColor = System.Drawing.Color.Red;
            this.townError.Location = new System.Drawing.Point(535, 380);
            this.townError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.townError.Name = "townError";
            this.townError.Size = new System.Drawing.Size(0, 20);
            this.townError.TabIndex = 27;
            // 
            // postalCodeError
            // 
            this.postalCodeError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.postalCodeError.AutoSize = true;
            this.postalCodeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeError.ForeColor = System.Drawing.Color.Red;
            this.postalCodeError.Location = new System.Drawing.Point(535, 315);
            this.postalCodeError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postalCodeError.Name = "postalCodeError";
            this.postalCodeError.Size = new System.Drawing.Size(0, 20);
            this.postalCodeError.TabIndex = 26;
            // 
            // addressError
            // 
            this.addressError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressError.AutoSize = true;
            this.addressError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressError.ForeColor = System.Drawing.Color.Red;
            this.addressError.Location = new System.Drawing.Point(535, 250);
            this.addressError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressError.Name = "addressError";
            this.addressError.Size = new System.Drawing.Size(0, 20);
            this.addressError.TabIndex = 25;
            // 
            // phoneError
            // 
            this.phoneError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneError.AutoSize = true;
            this.phoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneError.ForeColor = System.Drawing.Color.Red;
            this.phoneError.Location = new System.Drawing.Point(535, 185);
            this.phoneError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneError.Name = "phoneError";
            this.phoneError.Size = new System.Drawing.Size(0, 20);
            this.phoneError.TabIndex = 24;
            // 
            // provinceBox
            // 
            this.provinceBox.AccessibleName = "";
            this.provinceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.provinceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.provinceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.provinceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.provinceBox.FormattingEnabled = true;
            this.provinceBox.Location = new System.Drawing.Point(405, 315);
            this.provinceBox.Margin = new System.Windows.Forms.Padding(2);
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(320, 37);
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
            this.townBox.Location = new System.Drawing.Point(405, 383);
            this.townBox.Margin = new System.Windows.Forms.Padding(2);
            this.townBox.Name = "townBox";
            this.townBox.Size = new System.Drawing.Size(320, 37);
            this.townBox.TabIndex = 17;
            this.townBox.Text = "Town";
            // 
            // bornBox
            // 
            this.bornBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bornBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.bornBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.bornBox.Location = new System.Drawing.Point(405, 445);
            this.bornBox.Margin = new System.Windows.Forms.Padding(8);
            this.bornBox.Name = "bornBox";
            this.bornBox.Size = new System.Drawing.Size(320, 37);
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
            this.postalCodeBox2.Location = new System.Drawing.Point(405, 252);
            this.postalCodeBox2.Mask = "00000";
            this.postalCodeBox2.Name = "postalCodeBox2";
            this.postalCodeBox2.Size = new System.Drawing.Size(320, 37);
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
            this.idBox2.Location = new System.Drawing.Point(36, 446);
            this.idBox2.Mask = "A0000000L";
            this.idBox2.Name = "idBox2";
            this.idBox2.Size = new System.Drawing.Size(320, 37);
            this.idBox2.TabIndex = 11;
            this.idBox2.Visible = false;
            this.idBox2.Validated += new System.EventHandler(this.IdLostFocus);
            // 
            // bornDate
            // 
            this.bornDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bornDate.Location = new System.Drawing.Point(405, 463);
            this.bornDate.Name = "bornDate";
            this.bornDate.Size = new System.Drawing.Size(320, 20);
            this.bornDate.TabIndex = 19;
            this.bornDate.Value = new System.DateTime(2019, 10, 25, 0, 0, 0, 0);
            this.bornDate.Visible = false;
            this.bornDate.ValueChanged += new System.EventHandler(this.DateChange);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(750, 556);
            this.Controls.Add(this.bornDate);
            this.Controls.Add(this.idBox2);
            this.Controls.Add(this.postalCodeBox2);
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
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passAgainBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.registerLbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox postalCodeBox2;
        private System.Windows.Forms.MaskedTextBox idBox2;
        private System.Windows.Forms.DateTimePicker bornDate;
    }
}