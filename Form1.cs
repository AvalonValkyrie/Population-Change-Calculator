using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baldwin_ASG5_Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculatePopulation_Click(object sender, EventArgs e)
        {
            listBoxApproxPopulation.Items.Clear();
            listBoxApproxPopulation.Items.Add("Population Start: " + textBoxStartingOrganismNumber.Text.ToString() + "     Daily Increase: " + textBoxAvgDailyPercentIncrease.Text.ToString() + "%     Number of Days: " + textBoxNumberOfDays.Text.ToString());
            listBoxApproxPopulation.Items.Add("");
            listBoxApproxPopulation.Items.Add("Day\tApproximate Population");
            
            int loopCount = 2;
            int daysToMultiply = 0;
            if (int.TryParse(textBoxNumberOfDays.Text, out daysToMultiply) == true) {
                double startingPopulationNumber = 0.0;
                if (double.TryParse(textBoxStartingOrganismNumber.Text, out startingPopulationNumber) == true)
                {
                    double population = startingPopulationNumber;
                    double AvgPercentIncrease = 0.0;
                    if (double.TryParse(textBoxAvgDailyPercentIncrease.Text, out AvgPercentIncrease) == true)
                    {
                        listBoxApproxPopulation.Items.Add("1\t" + startingPopulationNumber);
                        while (loopCount < (daysToMultiply + 1))
                        {
                            population = population + (population * (AvgPercentIncrease / 100.0));
                            listBoxApproxPopulation.Items.Add(loopCount + "\t" + population);
                            loopCount = loopCount + 1;
                        }
                    }
                    else
                    {
                        listBoxApproxPopulation.Items.Add("We have encountered an error while checking the average daily % increase\nPlease check your answers and try again...");
                    }
                }
                else
                {
                    listBoxApproxPopulation.Items.Add("We have encountered an error while checking the starting organisms\nPlease check your answers and try again...");
                }
                
            }
            else
            {
                listBoxApproxPopulation.Items.Add("We have encountered an error while checking the number of days to multiply\nPlease check your answers and try again..."); 
            }
        }
    }
}
