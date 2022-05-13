using GlazkiSaveNewApp.Models;
using GlazkiSaveNewApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazkiSaveNewApp.Views
{
    public partial class ChangePriorityForm : Form
    {
        public ChangePriorityForm()
        {
            InitializeComponent();
        }

        private void ChangePriorityForm_Load(object sender, EventArgs e)
        {
            int max = 0;
            foreach (AgentCard a in MainForm.selectedAgentCard)
            {
                int priority = Convert.ToInt32(a.priorityLbl.Text);
                if (priority > max)
                {
                    max = priority;
                }
            }
            priorityTxtBox.Text = max.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int valueTxtBox = Convert.ToInt32(priorityTxtBox.Text);
            foreach (AgentCard a in MainForm.selectedAgentCard)
            {
                Agent agent = DatabaseContext.db.Agent.First(x => x.Phone == a.phoneLbl.Text);
                agent.Priority = valueTxtBox;
            }

            try
            {
                DatabaseContext.db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
