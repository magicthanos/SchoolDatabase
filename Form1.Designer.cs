namespace DatabaseTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.labSurName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbSurName = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labList = new System.Windows.Forms.Label();
            this.labInfo = new System.Windows.Forms.Label();
            this.disAge = new System.Windows.Forms.Label();
            this.disSurname = new System.Windows.Forms.Label();
            this.disName = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.txtbAge = new System.Windows.Forms.TextBox();
            this.disAddress = new System.Windows.Forms.Label();
            this.labdisAddress = new System.Windows.Forms.Label();
            this.labdisAge = new System.Windows.Forms.Label();
            this.labdisSur = new System.Windows.Forms.Label();
            this.labdisName = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labName.Location = new System.Drawing.Point(41, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(188, 43);
            this.labName.TabIndex = 0;
            this.labName.Text = "Enter Name:";
            // 
            // labSurName
            // 
            this.labSurName.AutoSize = true;
            this.labSurName.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labSurName.Location = new System.Drawing.Point(20, 92);
            this.labSurName.Name = "labSurName";
            this.labSurName.Size = new System.Drawing.Size(230, 43);
            this.labSurName.TabIndex = 1;
            this.labSurName.Text = "Enter Surname:";
            // 
            // txtbName
            // 
            this.txtbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbName.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbName.Location = new System.Drawing.Point(20, 47);
            this.txtbName.Name = "txtbName";
            this.txtbName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbName.Size = new System.Drawing.Size(230, 41);
            this.txtbName.TabIndex = 2;
            // 
            // txtbSurName
            // 
            this.txtbSurName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbSurName.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbSurName.Location = new System.Drawing.Point(20, 139);
            this.txtbSurName.Name = "txtbSurName";
            this.txtbSurName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbSurName.Size = new System.Drawing.Size(230, 41);
            this.txtbSurName.TabIndex = 3;
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReg.Location = new System.Drawing.Point(20, 368);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(230, 70);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 32;
            this.listBox.Location = new System.Drawing.Point(260, 55);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(335, 388);
            this.listBox.TabIndex = 7;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // labList
            // 
            this.labList.AutoSize = true;
            this.labList.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labList.Location = new System.Drawing.Point(354, 0);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(146, 43);
            this.labList.TabIndex = 7;
            this.labList.Text = "Students:";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labInfo.Location = new System.Drawing.Point(609, 0);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(77, 43);
            this.labInfo.TabIndex = 8;
            this.labInfo.Text = "Info:";
            // 
            // disAge
            // 
            this.disAge.AutoSize = true;
            this.disAge.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disAge.Location = new System.Drawing.Point(610, 238);
            this.disAge.Name = "disAge";
            this.disAge.Size = new System.Drawing.Size(81, 43);
            this.disAge.TabIndex = 9;
            this.disAge.Text = "Age:";
            // 
            // disSurname
            // 
            this.disSurname.AutoSize = true;
            this.disSurname.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disSurname.Location = new System.Drawing.Point(610, 144);
            this.disSurname.Name = "disSurname";
            this.disSurname.Size = new System.Drawing.Size(150, 43);
            this.disSurname.TabIndex = 10;
            this.disSurname.Text = "Surname:";
            // 
            // disName
            // 
            this.disName.AutoSize = true;
            this.disName.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disName.Location = new System.Drawing.Point(610, 50);
            this.disName.Name = "disName";
            this.disName.Size = new System.Drawing.Size(108, 43);
            this.disName.TabIndex = 11;
            this.disName.Text = "Name:";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAge.Location = new System.Drawing.Point(55, 184);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(161, 43);
            this.labAge.TabIndex = 12;
            this.labAge.Text = "Enter Age:";
            // 
            // txtbAge
            // 
            this.txtbAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbAge.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbAge.Location = new System.Drawing.Point(20, 231);
            this.txtbAge.Name = "txtbAge";
            this.txtbAge.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbAge.Size = new System.Drawing.Size(230, 41);
            this.txtbAge.TabIndex = 4;
            // 
            // disAddress
            // 
            this.disAddress.AutoSize = true;
            this.disAddress.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disAddress.Location = new System.Drawing.Point(610, 332);
            this.disAddress.Name = "disAddress";
            this.disAddress.Size = new System.Drawing.Size(103, 43);
            this.disAddress.TabIndex = 14;
            this.disAddress.Text = "Email:";
            // 
            // labdisAddress
            // 
            this.labdisAddress.AutoSize = true;
            this.labdisAddress.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labdisAddress.Location = new System.Drawing.Point(610, 385);
            this.labdisAddress.Name = "labdisAddress";
            this.labdisAddress.Size = new System.Drawing.Size(23, 31);
            this.labdisAddress.TabIndex = 15;
            this.labdisAddress.Text = "*";
            // 
            // labdisAge
            // 
            this.labdisAge.AutoSize = true;
            this.labdisAge.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labdisAge.Location = new System.Drawing.Point(610, 291);
            this.labdisAge.Name = "labdisAge";
            this.labdisAge.Size = new System.Drawing.Size(23, 31);
            this.labdisAge.TabIndex = 16;
            this.labdisAge.Text = "*";
            // 
            // labdisSur
            // 
            this.labdisSur.AutoSize = true;
            this.labdisSur.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labdisSur.Location = new System.Drawing.Point(610, 197);
            this.labdisSur.Name = "labdisSur";
            this.labdisSur.Size = new System.Drawing.Size(23, 31);
            this.labdisSur.TabIndex = 17;
            this.labdisSur.Text = "*";
            // 
            // labdisName
            // 
            this.labdisName.AutoSize = true;
            this.labdisName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labdisName.Location = new System.Drawing.Point(610, 103);
            this.labdisName.Name = "labdisName";
            this.labdisName.Size = new System.Drawing.Size(23, 31);
            this.labdisName.TabIndex = 18;
            this.labdisName.Text = "*";
            // 
            // txtbEmail
            // 
            this.txtbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbEmail.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbEmail.Location = new System.Drawing.Point(20, 323);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbEmail.Size = new System.Drawing.Size(230, 41);
            this.txtbEmail.TabIndex = 5;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labEmail.Location = new System.Drawing.Point(44, 276);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(183, 43);
            this.labEmail.TabIndex = 20;
            this.labEmail.Text = "Enter Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 460);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labdisName);
            this.Controls.Add(this.labdisSur);
            this.Controls.Add(this.labdisAge);
            this.Controls.Add(this.labdisAddress);
            this.Controls.Add(this.disAddress);
            this.Controls.Add(this.txtbAge);
            this.Controls.Add(this.labAge);
            this.Controls.Add(this.disName);
            this.Controls.Add(this.disSurname);
            this.Controls.Add(this.disAge);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtbSurName);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.labSurName);
            this.Controls.Add(this.labName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labName;
        private Label labSurName;
        private TextBox txtbName;
        private TextBox txtbSurName;
        private Button btnReg;
        private ListBox listBox;
        private Label labList;
        private Label labInfo;
        private Label disAge;
        private Label disSurname;
        private Label disName;
        private Label labAge;
        private TextBox txtbAge;
        private Label disAddress;
        private Label labdisAddress;
        private Label labdisAge;
        private Label labdisSur;
        private Label labdisName;
        private TextBox txtbEmail;
        private Label labEmail;
    }
}