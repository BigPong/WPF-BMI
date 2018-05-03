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

namespace _0419WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //按下計算按鈕，輸出BMI結果
            double height = double.Parse(HeightBox.Text)/100;
            double weight = double.Parse(WeightBox.Text);
            
            double BMI = Math.Round(weight / Math.Pow(height,2),2);
            result.Text = BMI.ToString();

            // 根據結果改變顏色
            if (BMI < 18.5)
            {
                result.Foreground = Brushes.Red;                
            }

            else if (18.5 <= BMI & BMI < 24)
            {
                result.Foreground = Brushes.Green;               
            }

            else if (BMI > 24)
            {
                result.Foreground = Brushes.Goldenrod;                
            }
                              
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // 將身高數值歸零
            HeightBar.Value = 0;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 讀取Slider的值       
            HeightBox.Text = HeightBar.Value.ToString();
            WeightBox.Text = WeightBar.Value.ToString();

            // 計算BMI結果並輸出
            double height = double.Parse(HeightBox.Text) / 100;
            double weight = double.Parse(WeightBox.Text);

            double BMI = Math.Round(weight / Math.Pow(height, 2), 2);
            result.Text = BMI.ToString();

            // 根據結果改變顏色
            if (BMI < 18.5)
            {
                result.Foreground = Brushes.Red;
                resultText.Foreground = Brushes.Red;
                resultText.Text = "過輕";
            }

            else if (18.5 <= BMI & BMI < 24)
            {
                result.Foreground = Brushes.Green;
                resultText.Foreground = Brushes.Green;
                resultText.Text = "適中";
            }
                
            else if (BMI > 24)
            {
                result.Foreground = Brushes.Goldenrod;
                resultText.Foreground = Brushes.Goldenrod;
                resultText.Text = "過重";
            }               

        }

        private void ButtonClear2_Click(object sender, RoutedEventArgs e)
        {
            // 將體重數值歸零
            WeightBar.Value = 0;
        }
    }
}
