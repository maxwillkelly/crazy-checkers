using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crazy_Checkers
{
    public partial class FormSettings : Form
    {
        public int ruleSet { get; set; }
        public int gridSize { get; set; }
        public bool sound { get; set; }


        public FormSettings()
        {
            InitializeComponent();
            ruleSet = 0;
            gridSize = 64;
            sound = true;
            // Sets default ruleset
            ruleSetComboBox.SelectedIndex = 0;
        }

        private void gridSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            // Converts slider setting into actual grid size for label
            var gridSizeTrackBar = (TrackBar) sender;
            gridSizeUnitsLabel.Text = Convert.ToString(Math.Pow(gridSizeTrackBar.Value,2));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Restores original values
            ruleSetComboBox.SelectedIndex = ruleSet;
            gridSizeLabel.Text = Convert.ToString(gridSize);
            gridSizeTrackBar.Value = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(gridSize)));
            soundCheckBox.Checked = sound;
            Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Sets new values
            ruleSet = ruleSetComboBox.SelectedIndex;
            gridSize = Convert.ToInt32(gridSizeUnitsLabel.Text);
            sound = soundCheckBox.Checked;
            Hide();
        }
    }
}
