using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvestOnIdeas.Services;
using InvestOnIdeas.Models;

namespace InvestOnIdeas
{
    public partial class TimelineFeed : Form
    {
        private readonly IdeaService _ideaService;

        public TimelineFeed()
        {
            InitializeComponent();
            _ideaService = new IdeaService();
            this.Load += TimelineFeed_Load;
        }

        private async void TimelineFeed_Load(object sender, EventArgs e)
        {
            await LoadFeedAsync();
        }

        private async Task LoadFeedAsync()
        {
            flowFeed.Controls.Clear();
            var ideas = await _ideaService.GetAllIdeasAsync();

            foreach (var idea in ideas)
            {
                AddFeedCard(
                    username: $"User {idea.CreatedBy}",
                    headline: "Innovator",
                    title: idea.Title,
                    content: idea.Description,
                    category: idea.Category,
                    time: DateTime.Now.ToShortTimeString(),
                    likes: new Random().Next(10, 80),
                    comments: new Random().Next(2, 20)
                );
            }
        }

        private void AddFeedCard(string username, string headline, string title, string content,
            string category, string time, int likes, int comments)
        {
            Panel card = new Panel
            {
                Width = 1400,
                Height = 280,
                Margin = new Padding(0, 0, 0, 20),
                BackColor = Color.White,
                Padding = new Padding(24)
            };

            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = GetRoundedRect(card.ClientRectangle, 8))
                {
                    card.Region = new Region(path);
                }
            };

            // Profile Section
            Panel profilePic = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(48, 48),
                BackColor = Color.FromArgb(220, 230, 245)
            };

            profilePic.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var brush = new SolidBrush(Color.FromArgb(37, 99, 235)))
                {
                    e.Graphics.FillEllipse(brush, 0, 0, 47, 47);
                }
                string initials = GetInitials(username);
                using (var font = new Font("Segoe UI", 14F, FontStyle.Bold))
                using (var fmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    e.Graphics.DrawString(initials, font, Brushes.White, new RectangleF(0, 0, 48, 48), fmt);
                }
            };

            Label lblUser = new Label
            {
                Text = username,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(10, 10, 10),
                Location = new Point(60, 0),
                AutoSize = true
            };

            Label lblHeadline = new Label
            {
                Text = headline,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                Location = new Point(60, 22),
                AutoSize = true
            };

            Label lblTime = new Label
            {
                Text = time,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                Location = new Point(60, 38),
                AutoSize = true
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(0, 70),
                AutoSize = true
            };

            Label lblContent = new Label
            {
                Text = content,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(0, 100),
                Size = new Size(1300, 60)
            };

            Panel categoryTag = new Panel
            {
                Location = new Point(0, 170),
                Size = new Size(category.Length * 7 + 20, 26),
                BackColor = Color.FromArgb(240, 245, 255)
            };
            categoryTag.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = GetRoundedRect(categoryTag.ClientRectangle, 4))
                {
                    categoryTag.Region = new Region(path);
                }
            };
            categoryTag.Controls.Add(new Label
            {
                Text = category,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(37, 99, 235),
                Location = new Point(10, 5),
                AutoSize = true
            });

            Label lblEngagement = new Label
            {
                Text = $"{likes} reactions · {comments} comments",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                Location = new Point(0, 205),
                AutoSize = true
            };

            // Action Buttons
            Panel actionsPanel = new Panel { Location = new Point(0, 230), Size = new Size(800, 36) };
            actionsPanel.Controls.Add(CreateActionButton("👍 Like", 0));
            actionsPanel.Controls.Add(CreateActionButton("💬 Comment", 160));
            actionsPanel.Controls.Add(CreateActionButton("🤝 Collaborate", 320));
            actionsPanel.Controls.Add(CreateActionButton("↗️ Share", 480));

            card.Controls.Add(profilePic);
            card.Controls.Add(lblUser);
            card.Controls.Add(lblHeadline);
            card.Controls.Add(lblTime);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblContent);
            card.Controls.Add(categoryTag);
            card.Controls.Add(lblEngagement);
            card.Controls.Add(actionsPanel);

            flowFeed.Controls.Add(card);
        }

        private Button CreateActionButton(string text, int x)
        {
            return new Button
            {
                Text = text,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(102, 102, 102),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(150, 36),
                Location = new Point(x, 0),
                BackColor = Color.Transparent,
                FlatAppearance = { BorderSize = 0 }
            };
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private string GetInitials(string name)
        {
            var parts = name.Split(' ');
            if (parts.Length >= 2)
                return $"{parts[0][0]}{parts[1][0]}".ToUpper();
            return name.Length > 0 ? name.Substring(0, Math.Min(2, name.Length)).ToUpper() : "??";
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Post Idea dialog coming soon!");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // implement search logic using IdeaService
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filter feature coming soon!");
        }
    }
}
