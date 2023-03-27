using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace weight_conversion
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)//毫克
        {
            double douCM; 
            douCM = Convert.ToDouble(txtCM.Text); 

            txtM.Text = string.Format("{0:0.##########}", douCM * 0.001);
            txtKM.Text = string.Format("{0:0.##########}", douCM * 0.000001);
            txtIn.Text = string.Format("{0:0.##########}", douCM *0.000000001);
            txtFt.Text = string.Format("{0:0.##########}", douCM * 0.000035274);
            txtYard.Text = string.Format("{0:0.##########}", douCM * 0.0000022046);
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)//公克
        {
            double douM;
            douM = Convert.ToDouble(txtM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douM * 1000);
            txtKM.Text = string.Format("{0:0.##########}", douM * 0.001);
            txtIn.Text = string.Format("{0:0.##########}", douM * 0.000001);
            txtFt.Text = string.Format("{0:0.##########}", douM * 0.0352739619);
            txtYard.Text = string.Format("{0:0.##########}", douM * 0.0022046226);
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)//公斤
        {
            double douKM;
            douKM = Convert.ToDouble(txtKM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douKM * 1000000);
            txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
            txtIn.Text = string.Format("{0:0.##########}", douKM * 0.001);
            txtFt.Text = string.Format("{0:0.##########}", douKM * 35.27396195);
            txtYard.Text = string.Format("{0:0.##########}", douKM * 2.2046226218);
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)//公噸
        {
            double douIn;
            douIn = Convert.ToDouble(txtIn.Text);

            txtCM.Text = string.Format("{0:0.##########}", douIn * 1000000000);
            txtM.Text = string.Format("{0:0.##########}", douIn * 1000000);
            txtKM.Text = string.Format("{0:0.##########}", douIn * 1000);
            txtFt.Text = string.Format("{0:0.##########}", douIn * 35273.96195);
            txtYard.Text = string.Format("{0:0.##########}", douIn * 2204.6226218);
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)//盎司
        {
            double douFt;
            douFt = Convert.ToDouble(txtFt.Text);

            txtCM.Text = string.Format("{0:0.##########}", douFt * 28349523125);
            txtM.Text = string.Format("{0:0.##########}", douFt * 28.349523125);
            txtKM.Text = string.Format("{0:0.##########}", douFt * 0.0283495231);
            txtIn.Text = string.Format("{0:0.##########}", douFt * 0.0000283495);
            txtYard.Text = string.Format("{0:0.##########}", douFt * 0.0625);
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)//磅
        {
            double douYard;
            douYard = Convert.ToDouble(txtYard.Text);

            txtCM.Text = string.Format("{0:0.##########}", douYard * 453592.37);
            txtM.Text = string.Format("{0:0.##########}", douYard * 453.59237);
            txtKM.Text = string.Format("{0:0.##########}", douYard * 0.45359237);
            txtIn.Text = string.Format("{0:0.##########}", douYard * 0.0004535924);
            txtFt.Text = string.Format("{0:0.##########}", douYard * 16);
        }
    }
}
