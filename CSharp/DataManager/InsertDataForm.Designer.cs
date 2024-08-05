namespace CSharp.DataManager
{
    partial class InsertDataForm
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
            grbSavePerson = new GroupBox();
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtMail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            grbSavePerson.SuspendLayout();
            SuspendLayout();
            // 
            // grbSavePerson
            // 
            grbSavePerson.Controls.Add(btnSave);
            grbSavePerson.Controls.Add(label4);
            grbSavePerson.Controls.Add(label3);
            grbSavePerson.Controls.Add(label2);
            grbSavePerson.Controls.Add(label1);
            grbSavePerson.Controls.Add(txtPhone);
            grbSavePerson.Controls.Add(txtMail);
            grbSavePerson.Controls.Add(txtLastName);
            grbSavePerson.Controls.Add(txtFirstName);
            grbSavePerson.Location = new Point(26, 84);
            grbSavePerson.Margin = new Padding(3, 4, 3, 4);
            grbSavePerson.Name = "grbSavePerson";
            grbSavePerson.Padding = new Padding(3, 4, 3, 4);
            grbSavePerson.Size = new Size(598, 485);
            grbSavePerson.TabIndex = 0;
            grbSavePerson.TabStop = false;
            grbSavePerson.Enter += grbSavePerson_Enter;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(158, 373);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(433, 75);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(27, 273);
            label4.Name = "label4";
            label4.Size = new Size(85, 35);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(27, 220);
            label3.Name = "label3";
            label3.Size = new Size(62, 35);
            label3.TabIndex = 6;
            label3.Text = "Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(27, 167);
            label2.Name = "label2";
            label2.Size = new Size(113, 35);
            label2.TabIndex = 5;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(27, 109);
            label1.Name = "label1";
            label1.Size = new Size(82, 35);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 15F);
            txtPhone.Location = new Point(146, 273);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(433, 41);
            txtPhone.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 15F);
            txtMail.Location = new Point(146, 220);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(433, 41);
            txtMail.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(146, 167);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(433, 41);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(146, 109);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(433, 41);
            txtFirstName.TabIndex = 0;
            // 
            // InsertDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 600);
            Controls.Add(grbSavePerson);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InsertDataForm";
            Padding = new Padding(23, 80, 23, 27);
            Text = "Data Insertion Form";
            FormClosed += InsertDataForm_FormClosed;
            grbSavePerson.ResumeLayout(false);
            grbSavePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSavePerson;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtMail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnSave;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
