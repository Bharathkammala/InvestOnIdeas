using System;
using System.Windows.Forms;
using System.Drawing;

namespace InvestOnIdeas
{
    partial class TimelineFeed : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private TextBox txtSearch;
        private Button btnCreatePost;
        private Button btnFilter;
        private FlowLayoutPanel flowFeed;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.txtSearch = new TextBox();
            this.btnFilter = new Button();
            this.btnCreatePost = new Button();
            this.flowFeed = new FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.btnFilter);
            this.panelHeader.Controls.Add(this.btnCreatePost);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Margin = new Padding(3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new Padding(24, 12, 24, 12);
            this.panelHeader.Size = new Size(1664, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(10, 10, 10);
            this.lblTitle.Location = new Point(24, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(262, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "InvestOnIdeas";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.txtSearch.BackColor = Color.FromArgb(245, 248, 250);
            this.txtSearch.BorderStyle = BorderStyle.FixedSingle;
            this.txtSearch.Font = new Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = Color.FromArgb(51, 51, 51);
            this.txtSearch.Location = new Point(1050, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Search ideas...";
            this.txtSearch.Size = new Size(350, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnFilter.BackColor = Color.FromArgb(245, 248, 250);
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = FlatStyle.Flat;
            this.btnFilter.Font = new Font("Segoe UI", 10F);
            this.btnFilter.ForeColor = Color.FromArgb(51, 51, 51);
            this.btnFilter.Location = new Point(1410, 20);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new Size(90, 34);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new EventHandler(this.btnFilter_Click);
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnCreatePost.BackColor = Color.FromArgb(37, 99, 235);
            this.btnCreatePost.FlatAppearance.BorderSize = 0;
            this.btnCreatePost.FlatStyle = FlatStyle.Flat;
            this.btnCreatePost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCreatePost.ForeColor = Color.White;
            this.btnCreatePost.Location = new Point(1510, 20);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new Size(120, 34);
            this.btnCreatePost.TabIndex = 3;
            this.btnCreatePost.Text = "Post";
            this.btnCreatePost.UseVisualStyleBackColor = false;
            this.btnCreatePost.Click += new EventHandler(this.btnCreatePost_Click);
            // 
            // flowFeed
            // 
            this.flowFeed.AutoScroll = true;
            this.flowFeed.BackColor = Color.FromArgb(248, 250, 252);
            this.flowFeed.Dock = DockStyle.Fill;
            this.flowFeed.FlowDirection = FlowDirection.TopDown;
            this.flowFeed.Location = new Point(0, 70);
            this.flowFeed.Name = "flowFeed";
            this.flowFeed.Padding = new Padding(80, 32, 80, 32);
            this.flowFeed.Size = new Size(1664, 908);
            this.flowFeed.TabIndex = 0;
            this.flowFeed.WrapContents = false;
            // 
            // TimelineFeed
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1664, 978);
            this.Controls.Add(this.flowFeed);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "TimelineFeed";
            this.Text = "InvestOnIdeas - Timeline";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}
