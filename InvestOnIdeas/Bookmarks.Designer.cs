namespace InvestOnIdeas
{
    partial class Bookmarks
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
            this.PostsPanel = new FlowLayoutPanel();
            this.labelHeader = new Label();
            this.SuspendLayout();
             
            this.PostsPanel.AutoScroll = true;
            this.PostsPanel.Location = new System.Drawing.Point(40, 80);
            this.PostsPanel.Name = "PostsPanel";
            this.PostsPanel.Size = new System.Drawing.Size(720, 340);
            this.PostsPanel.TabIndex = 0;
             
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(320, 20);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(140, 32);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Bookmarks";
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.PostsPanel);
            this.Name = "Bookmarks";
            this.Text = "Bookmarks";
            this.Load += new System.EventHandler(this.Bookmarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private FlowLayoutPanel PostsPanel;
        private Label labelHeader;

        #endregion
    }
}