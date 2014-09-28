using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppArryBigtask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resetButton.Visible = false;
        }

        private string inputName;
        private void addButton_Click(object sender, EventArgs e)
        {
            inputName =  addNameTextBox.Text;
            string[] nameArry = new string[10];
            for (int i = 0; i < 10; i++)
            {
                nameArry[i] = inputName;
                foreach (var item in nameArry)
                {
                    MessageBox.Show(item.ToString());
                }
            }

            
        }

        
    }
}
