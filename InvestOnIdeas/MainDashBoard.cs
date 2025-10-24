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
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            LoadTimeLine();
        }

        private void LoadTimeLine()
        {
            PanelView.Controls.Clear();

            TimelineFeed oTeamForm = new TimelineFeed
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PanelView.Controls.Add(oTeamForm);
            oTeamForm.Show();
        }

    }
}
