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
    public partial class MainForm : Form
    {
        public List<Agent> agents = new List<Agent>(DatabaseContext.db.Agent);
        public static List<AgentCard> selectedAgentCard = new List<AgentCard>();
        public MainForm()
        {
            InitializeComponent();
            GenerateAgentCardList(agents);
        }

        private void GenerateAgentCardList(List<Agent> agents)
        {
            foreach (var a in agents)
            {
                AgentCard card = new AgentCard();
                card.GenerateDataToAgentCard(a);
                flowLayoutPanel1.Controls.Add(card);

                card.Click += new System.EventHandler(this.Card_Click);
                card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;
            selectedAgentCard.Add(card);
            AddEditForm editForm = new AddEditForm();
           DialogResult dialogResult = editForm.ShowDialog();
            SortListView();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;
            
            if (card.BackColor == Color.White)
            {
                card.BackColor = Color.FromArgb(177, 117, 238);
                selectedAgentCard.Add(card);
            }
            else
            {
                card.BackColor = Color.White;
                selectedAgentCard.Remove(card);
            }
            if (selectedAgentCard.Count > 1)
            {
                changePriorityBtn.Visible = true;
            }
            else
            {
                changePriorityBtn.Visible = false;
            }
        }

        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Agent.ToList();
            // Filter
            if (filterComboBox.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.AgentType.Title == filterComboBox.SelectedItem
                    .ToString())
                    .ToList();
            }

            // Search
            if (searchTextBox.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.Title.ToLower()
                    .Contains(searchTextBox.Text
                    .ToLower()) || x.Phone
                    .Contains(searchTextBox.Text) || x.Email.ToLower()
                    .Contains(searchTextBox.Text.ToLower())).ToList();
            }

            // Sort
            if (sortComboBox.Text == "Наименование")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Title).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Title).ToList();
                }
            }
            if (sortComboBox.Text == "Приоритет")
            {
                if (!descCheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Priority).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Priority).ToList();
                }
            }
            flowLayoutPanel1.Controls.Clear();
            GenerateAgentCardList(listUpdate);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "Введите для поиска")
            {
                flowLayoutPanel1.Controls.Clear();
                SortListView();
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void descCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.AgentType.Select(type => type.Title).ToList();
            allType.Insert(0, "Все типы");
            filterComboBox.DataSource = allType;
            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
        }

        private void changePriorityBtn_Click(object sender, EventArgs e)
        {
            ChangePriorityForm changePriorityForm = new ChangePriorityForm();
            DialogResult dialogResult = changePriorityForm.ShowDialog();
            SortListView();
        }
    }
}
