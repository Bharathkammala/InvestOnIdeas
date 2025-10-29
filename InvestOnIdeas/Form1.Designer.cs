namespace InvestOnIdeas
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
            sidebarpanel = new Panel();
            btnPostIdea = new Button();
            btnDashboard = new Button();
            lblAppName = new Label();
            maincontrolpanel = new Panel();
            friendspanel = new Panel();
            btnSearch = new Button();
            btnprofile = new Button();
            label1 = new Label();
            flpfriends = new FlowLayoutPanel();
            searchOverviewPanel = new Panel();
            label2 = new Label();
            ideaShowcasePanel = new Panel();
            label3 = new Label();
            flpIdeas = new FlowLayoutPanel();
            sidebarpanel.SuspendLayout();
            maincontrolpanel.SuspendLayout();
            friendspanel.SuspendLayout();
            searchOverviewPanel.SuspendLayout();
            ideaShowcasePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarpanel
            // 
            sidebarpanel.BackColor = Color.LavenderBlush;
            sidebarpanel.Controls.Add(btnprofile);
            sidebarpanel.Controls.Add(btnSearch);
            sidebarpanel.Controls.Add(btnPostIdea);
            sidebarpanel.Controls.Add(btnDashboard);
            sidebarpanel.Controls.Add(lblAppName);
            sidebarpanel.Dock = DockStyle.Left;
            sidebarpanel.Location = new Point(0, 0);
            sidebarpanel.Name = "sidebarpanel";
            sidebarpanel.Size = new Size(230, 529);
            sidebarpanel.TabIndex = 0;
            // 
            // btnPostIdea
            // 
            btnPostIdea.Location = new Point(12, 112);
            btnPostIdea.Name = "btnPostIdea";
            btnPostIdea.Size = new Size(168, 29);
            btnPostIdea.TabIndex = 2;
            btnPostIdea.Text = "Post an Idea";
            btnPostIdea.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(12, 65);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 30);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.Location = new Point(12, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(157, 28);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Invest On Ideas";
            // 
            // maincontrolpanel
            // 
            maincontrolpanel.BackColor = Color.WhiteSmoke;
            maincontrolpanel.Controls.Add(ideaShowcasePanel);
            maincontrolpanel.Controls.Add(searchOverviewPanel);
            maincontrolpanel.Controls.Add(friendspanel);
            maincontrolpanel.Dock = DockStyle.Fill;
            maincontrolpanel.Location = new Point(230, 0);
            maincontrolpanel.Name = "maincontrolpanel";
            maincontrolpanel.Size = new Size(883, 529);
            maincontrolpanel.TabIndex = 1;
            maincontrolpanel.Paint += maincontrolpanel_Paint;
            // 
            // friendspanel
            // 
            friendspanel.BorderStyle = BorderStyle.FixedSingle;
            friendspanel.Controls.Add(flpfriends);
            friendspanel.Controls.Add(label1);
            friendspanel.Location = new Point(6, 3);
            friendspanel.Name = "friendspanel";
            friendspanel.Size = new Size(452, 295);
            friendspanel.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLightLight;
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(12, 164);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(168, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnprofile
            // 
            btnprofile.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnprofile.Location = new Point(12, 209);
            btnprofile.Name = "btnprofile";
            btnprofile.Size = new Size(157, 29);
            btnprofile.TabIndex = 4;
            btnprofile.Text = "Profile";
            btnprofile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 16);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 0;
            label1.Text = "Friends";
            // 
            // flpfriends
            // 
            flpfriends.AutoScroll = true;
            flpfriends.Location = new Point(32, 61);
            flpfriends.Name = "flpfriends";
            flpfriends.Size = new Size(351, 185);
            flpfriends.TabIndex = 1;
            // 
            // searchOverviewPanel
            // 
            searchOverviewPanel.Controls.Add(label2);
            searchOverviewPanel.Location = new Point(464, 3);
            searchOverviewPanel.Name = "searchOverviewPanel";
            searchOverviewPanel.Size = new Size(394, 295);
            searchOverviewPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 22);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 0;
            label2.Text = "Search Overview";
            // 
            // ideaShowcasePanel
            // 
            ideaShowcasePanel.Controls.Add(flpIdeas);
            ideaShowcasePanel.Controls.Add(label3);
            ideaShowcasePanel.Location = new Point(39, 315);
            ideaShowcasePanel.Name = "ideaShowcasePanel";
            ideaShowcasePanel.Size = new Size(651, 202);
            ideaShowcasePanel.TabIndex = 3;
            ideaShowcasePanel.Paint += ideaShowcasePanel_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 20);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Idea Showcase";
            // 
            // flpIdeas
            // 
            flpIdeas.AutoScroll = true;
            flpIdeas.Location = new Point(31, 63);
            flpIdeas.Name = "flpIdeas";
            flpIdeas.Size = new Size(388, 124);
            flpIdeas.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 529);
            Controls.Add(maincontrolpanel);
            Controls.Add(sidebarpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            sidebarpanel.ResumeLayout(false);
            sidebarpanel.PerformLayout();
            maincontrolpanel.ResumeLayout(false);
            friendspanel.ResumeLayout(false);
            friendspanel.PerformLayout();
            searchOverviewPanel.ResumeLayout(false);
            searchOverviewPanel.PerformLayout();
            ideaShowcasePanel.ResumeLayout(false);
            ideaShowcasePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarpanel;
        private Panel maincontrolpanel;
        private Label lblAppName;
        private Button btnPostIdea;
        private Button btnDashboard;
        private Panel friendspanel;
        private Button btnprofile;
        private Button btnSearch;
        private FlowLayoutPanel flpfriends;
        private Label label1;
        private Panel searchOverviewPanel;
        private Label label2;
        private Panel ideaShowcasePanel;
        private FlowLayoutPanel flpIdeas;
        private Label label3;
    }
}
