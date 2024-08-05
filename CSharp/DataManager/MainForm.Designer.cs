namespace CSharp.DataManager
{
    partial class MainForm
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
            btnSave = new Button();
            btnSearch = new Button();
            btnList = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Red;
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(26, 92);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(256, 471);
            btnSave.TabIndex = 0;
            btnSave.Text = "Insert Record";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.Font = new Font("Segoe UI", 20F);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(289, 92);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(256, 232);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Ceyhun           Aghayev";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            btnList.BackColor = Color.FromArgb(192, 64, 0);
            btnList.Font = new Font("Segoe UI", 20F);
            btnList.ForeColor = SystemColors.ControlLightLight;
            btnList.Location = new Point(289, 331);
            btnList.Margin = new Padding(3, 4, 3, 4);
            btnList.Name = "btnList";
            btnList.Size = new Size(256, 232);
            btnList.TabIndex = 2;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 600);
            Controls.Add(btnList);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Padding = new Padding(23, 80, 23, 27);
            Text = "Menu";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnSearch;
        private Button btnList;
    }
}