namespace InvestOnIdeas
{
    partial class Profile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ProfileHeadTxt = new Label();
            ProfileNameLbl = new Label();
            ProfileEmailLbl = new Label();
            ProfileGenderLbl = new Label();
            ProfilePhoneLbl = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnConfirm = new Button();
            ProfileEditLbl = new Label();
            ProfileGendercomboBox = new ComboBox();
            SuspendLayout();
            
            ProfileHeadTxt.AutoSize = true;
            ProfileHeadTxt.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ProfileHeadTxt.Location = new Point(358, 41);
            ProfileHeadTxt.Name = "ProfileHeadTxt";
            ProfileHeadTxt.Size = new Size(90, 32);
            ProfileHeadTxt.TabIndex = 0;
            ProfileHeadTxt.Text = "Profile";
            
            ProfileNameLbl.AutoSize = true;
            ProfileNameLbl.Font = new Font("Segoe UI", 10F);
            ProfileNameLbl.Location = new Point(179, 116);
            ProfileNameLbl.Name = "ProfileNameLbl";
            ProfileNameLbl.Size = new Size(56, 23);
            ProfileNameLbl.TabIndex = 1;
            ProfileNameLbl.Text = "Name";
            
            ProfileEmailLbl.AutoSize = true;
            ProfileEmailLbl.Font = new Font("Segoe UI", 10F);
            ProfileEmailLbl.Location = new Point(179, 180);
            ProfileEmailLbl.Name = "ProfileEmailLbl";
            ProfileEmailLbl.Size = new Size(51, 23);
            ProfileEmailLbl.TabIndex = 2;
            ProfileEmailLbl.Text = "Email";
             
            ProfileGenderLbl.AutoSize = true;
            ProfileGenderLbl.Font = new Font("Segoe UI", 10F);
            ProfileGenderLbl.Location = new Point(179, 244);
            ProfileGenderLbl.Name = "ProfileGenderLbl";
            ProfileGenderLbl.Size = new Size(66, 23);
            ProfileGenderLbl.TabIndex = 3;
            ProfileGenderLbl.Text = "Gender";
             
            ProfilePhoneLbl.AutoSize = true;
            ProfilePhoneLbl.Font = new Font("Segoe UI", 10F);
            ProfilePhoneLbl.Location = new Point(179, 304);
            ProfilePhoneLbl.Name = "ProfilePhoneLbl";
            ProfilePhoneLbl.Size = new Size(127, 23);
            ProfilePhoneLbl.TabIndex = 4;
            ProfilePhoneLbl.Text = "Phone Number";
             
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(433, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 30);
            txtName.TabIndex = 5;
             
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(433, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 30);
            txtEmail.TabIndex = 6;
             
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(433, 303);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(236, 30);
            txtPhone.TabIndex = 8;
            txtPhone.KeyPress += txtPhone_KeyPress;
             
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Segoe UI", 12F);
            btnConfirm.Location = new Point(358, 367);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(123, 47);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
             
            ProfileEditLbl.AutoSize = true;
            ProfileEditLbl.Cursor = Cursors.Hand;
            ProfileEditLbl.ForeColor = Color.FromArgb(0, 192, 192);
            ProfileEditLbl.Location = new Point(722, 50);
            ProfileEditLbl.Name = "ProfileEditLbl";
            ProfileEditLbl.Size = new Size(35, 20);
            ProfileEditLbl.TabIndex = 10;
            ProfileEditLbl.Text = "Edit";
            ProfileEditLbl.Click += ProfileEditLbl_Click;
             
            ProfileGendercomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProfileGendercomboBox.FormattingEnabled = true;
            ProfileGendercomboBox.Items.AddRange(new object[] { "Male", "Female", "Others" });
            ProfileGendercomboBox.Location = new Point(433, 243);
            ProfileGendercomboBox.Name = "ProfileGendercomboBox";
            ProfileGendercomboBox.Size = new Size(236, 28);
            ProfileGendercomboBox.TabIndex = 11;
             
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProfileGendercomboBox);
            Controls.Add(ProfileEditLbl);
            Controls.Add(btnConfirm);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(ProfilePhoneLbl);
            Controls.Add(ProfileGenderLbl);
            Controls.Add(ProfileEmailLbl);
            Controls.Add(ProfileNameLbl);
            Controls.Add(ProfileHeadTxt);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProfileHeadTxt;
        private Label ProfileNameLbl;
        private Label ProfileEmailLbl;
        private Label ProfileGenderLbl;
        private Label ProfilePhoneLbl;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnConfirm;
        private Label ProfileEditLbl;
        private ComboBox ProfileGendercomboBox;
    }
}
