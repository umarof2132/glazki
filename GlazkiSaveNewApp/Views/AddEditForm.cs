using GlazkiSaveNewApp.Models;
using GlazkiSaveNewApp.Utils;
using GlazkiSaveNewApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazkiSaveNewApp
{
    public partial class AddEditForm : Form
    {
        Agent currentAgent = new Agent();
        public AddEditForm()
        {
            InitializeComponent();
        }







        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
          agentTypeBindingSource.DataSource =  DatabaseContext.db.AgentType.ToList();
            foreach (AgentCard agent in MainForm.selectedAgentCard)
            {
                currentAgent = DatabaseContext.db.Agent.First( x => x.Phone == agent.phoneLbl.Text);
                agentBindingSource.DataSource = currentAgent;
                changePictureBx.ImageLocation = currentAgent.Logo;
                //var allType = DatabaseContext.db.AgentType.Select(type => type.Title).ToList();
               // titleComboBox1.DataSource = allType;
               //agentTypeBindingSource.DataSource = allType;
            }




        }

        private void agentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
