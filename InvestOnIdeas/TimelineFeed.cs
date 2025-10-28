using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using InvestOnIdeas.Services;
using InvestOnIdeas.Models;

namespace InvestOnIdeas
{
    public partial class TimelineFeed : Form
    {
        private readonly IdeaService _ideaService;
        private List<IdeaModel> _allIdeas = new();

        // Modern color palette
        private readonly Color _primaryColor = Color.FromArgb(59, 130, 246);    // Blue-500
        private readonly Color _primaryDark = Color.FromArgb(37, 99, 235);     // Blue-600
        private readonly Color _primaryLight = Color.FromArgb(239, 246, 255);  // Blue-50
        private readonly Color _backgroundColor = Color.FromArgb(249, 250, 251); // Gray-50
        private readonly Color _cardColor = Color.White;
        private readonly Color _textPrimary = Color.FromArgb(17, 24, 39);      // Gray-900
        private readonly Color _textSecondary = Color.FromArgb(107, 114, 128); // Gray-500
        private readonly Color _textLight = Color.FromArgb(156, 163, 175);     // Gray-400
        private readonly Color _borderColor = Color.FromArgb(229, 231, 235);   // Gray-200
        private readonly Color _successColor = Color.FromArgb(16, 185, 129);   // Green-500

        public TimelineFeed()
        {
            InitializeComponent();
            _ideaService = new IdeaService();
            this.Load += TimelineFeed_Load;
            ApplyModernStyling();
        }

        private void ApplyModernStyling()
        {
            // Set background colors
            this.BackColor = _backgroundColor;
            flowFeed.BackColor = _backgroundColor;
            panelHeader.BackColor = _cardColor;

            // Add subtle shadow to header
            panelHeader.Paint += (s, e) =>
            {
                using (var pen = new Pen(_borderColor, 1))
                {
                    e.Graphics.DrawLine(pen, 0, panelHeader.Height - 1, panelHeader.Width, panelHeader.Height - 1);
                }
            };
        }

        private async void TimelineFeed_Load(object sender, EventArgs e)
        {
            await LoadFeedAsync();
        }

        private async Task LoadFeedAsync()
        {
            flowFeed.Controls.Clear();
            _allIdeas = await _ideaService.GetAllIdeasAsync();
            DisplayIdeas(_allIdeas);
        }

        private void DisplayIdeas(IEnumerable<IdeaModel> ideas)
        {
            flowFeed.Controls.Clear();

            foreach (var idea in ideas)
            {
                AddFeedCard(
                    username: $"User {idea.CreatedBy}",
                    headline: "Innovator",
                    title: idea.Title,
                    content: idea.Description,
                    category: idea.Category,
                    time: DateTime.Now.ToString("MMM dd, yyyy · h:mm tt"),
                    likes: new Random().Next(10, 80),
                    comments: new Random().Next(2, 20)
                );
            }

            if (!ideas.Any())
            {
                Label lblNoResults = new Label
                {
                    Text = "No matching ideas found. Try adjusting your search terms.",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = _textSecondary,
                    AutoSize = true,
                    Margin = new Padding(40, 60, 40, 40),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                flowFeed.Controls.Add(lblNoResults);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(query))
            {
                DisplayIdeas(_allIdeas);
                return;
            }

            var filtered = _allIdeas.Where(i =>
                (i.Title?.ToLower().Contains(query) ?? false) ||
                (i.Description?.ToLower().Contains(query) ?? false) ||
                (i.Category?.ToLower().Contains(query) ?? false)
            ).ToList();

            DisplayIdeas(filtered);
        }

        private void AddFeedCard(string username, string headline, string title, string content,
            string category, string time, int likes, int comments)
        {
            Panel card = new Panel
            {
                Width = 800, // Reduced width for better readability
                Height = 320, // Slightly increased height for better spacing
                Margin = new Padding(0, 0, 0, 24),
                BackColor = _cardColor,
                Padding = new Padding(24),
                Cursor = Cursors.Hand
            };

            // Add card shadow and rounded corners
            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw shadow
                using (var shadowPath = GetRoundedRect(new Rectangle(2, 2, card.Width - 4, card.Height - 4), 12))
                using (var shadowBrush = new SolidBrush(Color.FromArgb(10, 0, 0, 0)))
                {
                    e.Graphics.FillPath(shadowBrush, shadowPath);
                }

                // Draw card
                using (var path = GetRoundedRect(new Rectangle(0, 0, card.Width - 2, card.Height - 2), 12))
                using (var brush = new SolidBrush(_cardColor))
                {
                    e.Graphics.FillPath(brush, path);
                    using (var pen = new Pen(_borderColor, 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };

            // Profile section with better layout
            Panel profileContainer = new Panel
            {
                Location = new Point(24, 24),
                Size = new Size(card.Width - 48, 48),
                BackColor = Color.Transparent
            };

            // Profile picture
            Panel profilePic = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(48, 48),
                BackColor = Color.Transparent
            };

            profilePic.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var brush = new SolidBrush(_primaryColor))
                    e.Graphics.FillEllipse(brush, 0, 0, 48, 48);

                string initials = GetInitials(username);
                using (var font = new Font("Segoe UI", 14F, FontStyle.Bold))
                using (var fmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    e.Graphics.DrawString(initials, font, Brushes.White, new RectangleF(0, 0, 48, 48), fmt);
            };

            // User info section
            Label lblUser = new Label
            {
                Text = username,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = _textPrimary,
                Location = new Point(60, 0),
                AutoSize = true
            };

            Label lblHeadline = new Label
            {
                Text = headline,
                Font = new Font("Segoe UI", 10F),
                ForeColor = _textSecondary,
                Location = new Point(60, 22),
                AutoSize = true
            };

            Label lblTime = new Label
            {
                Text = time,
                Font = new Font("Segoe UI", 9F),
                ForeColor = _textLight,
                Location = new Point(profileContainer.Width - 120, 0),
                AutoSize = true,
                TextAlign = ContentAlignment.TopRight
            };

            // Content section
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = _textPrimary,
                Location = new Point(24, 90),
                Size = new Size(card.Width - 72, 30),
                AutoEllipsis = true
            };

            Label lblContent = new Label
            {
                Text = content,
                Font = new Font("Segoe UI", 11F),
                ForeColor = _textSecondary,
                Location = new Point(24, 130),
                Size = new Size(card.Width - 72, 48),
                MaximumSize = new Size(card.Width - 72, 0),
                AutoSize = true
            };

            // Category tag
            Panel categoryTag = new Panel
            {
                Location = new Point(24, 190),
                Size = new Size(Math.Min(category.Length * 8 + 24, 200), 28),
                BackColor = _primaryLight
            };

            categoryTag.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = GetRoundedRect(categoryTag.ClientRectangle, 14))
                {
                    categoryTag.Region = new Region(path);
                    using (var brush = new SolidBrush(_primaryLight))
                        e.Graphics.FillPath(brush, path);
                }
            };

            Label lblCategory = new Label
            {
                Text = category,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = _primaryColor,
                Location = new Point(12, 6),
                AutoSize = true
            };
            categoryTag.Controls.Add(lblCategory);

            // Engagement stats
            Label lblEngagement = new Label
            {
                Text = $"{likes} likes · {comments} comments",
                Font = new Font("Segoe UI", 10F),
                ForeColor = _textLight,
                Location = new Point(24, 230),
                AutoSize = true
            };

            // Action buttons
            Panel actionsPanel = new Panel
            {
                Location = new Point(24, 260),
                Size = new Size(card.Width - 96, 36)
            };

            actionsPanel.Controls.Add(CreateActionButton("👍 Like", 0, likes > 30 ? _primaryColor : _textSecondary));
            actionsPanel.Controls.Add(CreateActionButton("💬 Comment", 120, _textSecondary));
            actionsPanel.Controls.Add(CreateActionButton("🤝 Collaborate", 240, _textSecondary));
            actionsPanel.Controls.Add(CreateActionButton("↗️ Share", 380, _textSecondary));

            // Add controls to profile container
            profileContainer.Controls.Add(profilePic);
            profileContainer.Controls.Add(lblUser);
            profileContainer.Controls.Add(lblHeadline);
            profileContainer.Controls.Add(lblTime);

            // Add all to card
            card.Controls.Add(profileContainer);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblContent);
            card.Controls.Add(categoryTag);
            card.Controls.Add(lblEngagement);
            card.Controls.Add(actionsPanel);

            flowFeed.Controls.Add(card);
        }

        private Button CreateActionButton(string text, int x, Color color)
        {
            var button = new Button
            {
                Text = text,
                Font = new Font("Segoe UI", 9F),
                ForeColor = color,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(110, 32),
                Location = new Point(x, 0),
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand
            };

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);

            return button;
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
            MessageBox.Show("Post Idea dialog coming soon!", "Create Post",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filter feature coming soon!", "Filter Ideas",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            btnReload.Enabled = false;
            btnReload.Text = "Refreshing...";

            await LoadFeedAsync();  // Reuse existing method to reload from IdeaService

            btnReload.Enabled = true;
            btnReload.Text = "Reload 🔄";
        }

    }
}