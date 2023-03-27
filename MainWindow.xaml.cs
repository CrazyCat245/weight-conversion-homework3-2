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
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數
        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = " ";
            txtM.Text = " ";
            txtKM.Text = " ";
            txtIn.Text = " ";
            txtFt.Text = " ";
            txtYard.Text = " ";
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)//毫克
        {
            strInput = txtCM.Text;


            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput * 0.001);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.000001);
            txtIn.Text = string.Format("{0:0.##########}", douOutput * 0.000000001);
            txtFt.Text = string.Format("{0:0.##########}", douOutput * 0.000035274);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.0000022046);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)//公克
        {
            strInput = txtM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 1000);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.001);
            txtIn.Text = string.Format("{0:0.##########}", douOutput * 0.000001);
            txtFt.Text = string.Format("{0:0.##########}", douOutput * 0.0352739619);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.0022046226);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)//公斤
        {
            strInput = txtKM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {

                txtCM.Text = string.Format("{0:0.##########}", douOutput * 1000000);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 1000);
            txtIn.Text = string.Format("{0:0.##########}", douOutput * 0.001);
            txtFt.Text = string.Format("{0:0.##########}", douOutput * 35.27396195);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 2.2046226218);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)//公噸
        {
            strInput = txtIn.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 1000000000);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 1000000);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 1000);
            txtFt.Text = string.Format("{0:0.##########}", douOutput * 35273.96195);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 2204.6226218);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)//盎司
        {
            strInput = txtFt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 28349523125);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 28.349523125);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0283495231);
            txtIn.Text = string.Format("{0:0.##########}", douOutput * 0.0000283495);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.0625);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)//磅
        {
            strInput = txtYard.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {

                txtCM.Text = string.Format("{0:0.##########}", douOutput * 453592.37);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 453.59237);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.45359237);
            txtIn.Text = string.Format("{0:0.##########}", douOutput * 0.0004535924);
            txtFt.Text = string.Format("{0:0.##########}", douOutput * 16);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }
    }
}
