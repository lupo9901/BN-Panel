using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;

namespace BoxComm
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();

            SolidColorBrush blueForeground = new SolidColorBrush(Color.FromArgb(255, 0, 86, 145));

            SolidColorBrush darkGrayBackground = new SolidColorBrush(Color.FromArgb(255, 40, 40, 40));
             
            gauge1.From = 0;
            gauge1.To = 25;
            gauge1.Foreground = blueForeground;
            gauge1.GaugeBackground = darkGrayBackground;
            gauge1.FontSize = 30;
            


        }

        public void updateAngle(string delegatedValue)
        {
            gauge1.Value = Convert.ToDouble(delegatedValue);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            elementHost1.Width = this.Width ;

         


        }
    }
}
