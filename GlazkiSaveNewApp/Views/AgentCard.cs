using GlazkiSaveNewApp.Models;
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
    public partial class AgentCard : UserControl
    {
        public AgentCard()
        {
            InitializeComponent();
        }

        public void GenerateDataToAgentCard(Agent agent)
        {
            pictureBox1.ImageLocation = agent.Logo;
            typeNameLbl.Text = agent.AgentType.Title + " | " + agent.Title;
            int qty = 0;
            int yearQty = 0;
            decimal sum = 0;
            foreach (ProductSale p in agent.ProductSale)
            {
                qty = p.ProductCount;
                yearQty += qty;
                sum += qty * p.Product.MinCostForAgent;
            }

            qtySalesLbl.Text = yearQty + " продаж за год";
            phoneLbl.Text = agent.Phone;
            priorityLbl.Text = agent.Priority.ToString();

            if (sum < 10000)
            {
                percentLbl.Text = "0%";
            }
            else if (sum >= 10000 && sum <= 50000)
            {
                percentLbl.Text = "5%";
            }
            else if (sum > 50000 && sum <= 150000)
            {
                percentLbl.Text = "10%";
            }
            else if (sum > 150000 && sum <= 500000)
            {
                percentLbl.Text = "20%";
            }
            else
            {
                percentLbl.Text = "25%";
            }

            if (percentLbl.Text == "10%")
            {
                typeNameLbl.BackColor = Color.LightGreen;
            }
        }
    }
}
