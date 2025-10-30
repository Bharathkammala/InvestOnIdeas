using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestOnIdeas
{
    public partial class Bookmarks : Form
    {
        public Bookmarks()
        {
            InitializeComponent();
        }

        private void Bookmarks_Load(object sender, EventArgs e)
        {
            AddPost("John Doe", "Investing in renewable energy startups is the future!", DateTime.Now.AddMinutes(-30));
            AddPost("Sarah Lee", "Top 5 fintech stocks for long-term growth 🚀", DateTime.Now.AddHours(-2));
            AddPost("Ravi Kumar", "AI is changing how we predict stock market trends.", DateTime.Now.AddDays(-1));
        }

        private void AddPost(string name, string postText, DateTime time)
        {
            Panel postPanel = new Panel();
            postPanel.BorderStyle = BorderStyle.FixedSingle;
            postPanel.BackColor = Color.WhiteSmoke;
            postPanel.Size = new Size(680, 140);
            postPanel.Margin = new Padding(10);

            
            Label lblName = new Label();
            lblName.Text = name;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.Location = new Point(10, 10);
            lblName.AutoSize = true;

            
            Label lblTime = new Label();
            lblTime.Text = time.ToString("g");
            lblTime.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblTime.ForeColor = Color.Gray;
            lblTime.Location = new Point(550, 10);
            lblTime.AutoSize = true;

            
            Label lblPost = new Label();
            lblPost.Text = postText;
            lblPost.Font = new Font("Segoe UI", 10F);
            lblPost.Location = new Point(10, 40);
            lblPost.Size = new Size(650, 50);
            lblPost.AutoEllipsis = true;

            
            Button btnComment = new Button();
            btnComment.Text = "💬 Comment";
            btnComment.Font = new Font("Segoe UI", 9F);
            btnComment.Size = new Size(100, 30);
            btnComment.Location = new Point(10, 100);
            btnComment.Click += (s, e) =>
            {
                MessageBox.Show($"Comment clicked on {name}'s post!", "Comment", MessageBoxButtons.OK);
            };

            
            Button btnShare = new Button();
            btnShare.Text = "🔗 Share";
            btnShare.Font = new Font("Segoe UI", 9F);
            btnShare.Size = new Size(100, 30);
            btnShare.Location = new Point(120, 100);
            btnShare.Click += (s, e) =>
            {
                MessageBox.Show($"Shared {name}'s post successfully!", "Share", MessageBoxButtons.OK);
            };

            
            postPanel.Controls.Add(lblName);
            postPanel.Controls.Add(lblTime);
            postPanel.Controls.Add(lblPost);
            postPanel.Controls.Add(btnComment);
            postPanel.Controls.Add(btnShare);

            
            PostsPanel.Controls.Add(postPanel);
        }
    }
}
