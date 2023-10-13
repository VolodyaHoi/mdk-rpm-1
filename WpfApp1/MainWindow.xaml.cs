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
using Lib_9;


namespace WpfApp1
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

        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Start(object sender, RoutedEventArgs e)
        {
            int n, result;
            bool isNum = int.TryParse(tb_Input.Text, out n);

            if(isNum)
            {
                Class1 lib = new Class1();

                result = lib.sumOfNumbers(n);

                tb_Output.Text = "Ответ: " + result;
            } else { tb_Input.Text = "Введенное значение не является числом!";  }
        }

        private void text_Clear(object sender, MouseButtonEventArgs e)
        {
            tb_Input.Text = "";
        }
    }
}
