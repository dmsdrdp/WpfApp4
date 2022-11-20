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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)                    // Кнопка Долларов в рубли
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)                 // Кнопка Евро в рубли
        {
            double rateEur = Convert.ToDouble(rateEuro.Text);
            double sumEur = Convert.ToDouble(sumEuro.Text);
            double resEur = rateEur * sumEur;
            resSumEuro.Text = resEur.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)               // Кнопка гривны в рубли
        {
            double rateGriv = Convert.ToDouble(rateGrivn.Text);
            double sumGriv = Convert.ToDouble(sumGrivn.Text);
            double resGriv = rateGriv * sumGriv;
            resSumGrivn.Text = resGriv.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)            // Кнопка драмы в рубли
        {
            double rateDra = Convert.ToDouble(rateDram.Text);
            double sumDra = Convert.ToDouble(sumDram.Text);
            double resDra = rateDra * sumDra;
            resSumDram.Text = resDra.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)             // Кнопка дюймы в метры
        {
            double rateInch = Convert.ToDouble(rateInches.Text);
            double resInch = rateInch * 0.0254;
            resSumInches.Text = resInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)            // Кнопка футы в метры
        {
            double rateFeet = Convert.ToDouble(rateFeets.Text);
            double resFeet = rateFeet * 0.305;
            resSumFeets.Text = resFeet.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)             // Кнопка мили в метры
        {
            double rateMile = Convert.ToDouble(rateMiles.Text);
            double resMile = rateMile * 1609.344;
            resSumMiles.Text = resMile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)                    // Кнопка версты в метры
        {
            double rateVers = Convert.ToDouble(rateVerst.Text);
            double resVers = rateVers * 1066.8;
            resSumVerst.Text = resVers.ToString();
        }
    }
}
