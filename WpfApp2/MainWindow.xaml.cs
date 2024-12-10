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

namespace Самомстоятельная
{
    public partial class MainWindow : Window
    {
        public static int oshibki = 0;
        public MainWindow()
        {
            MessageBox.Show("Это супер тест!!!!");
            InitializeComponent();
        }
        private void proverit(object sender, RoutedEventArgs e)
        {
            if (text.Text == "Человек спит, какой вывод вы можете сделать? (Zzzzzzz)")
            {
                if (radio3.IsChecked == true)
                {
                    text.Text = "Как называется маленькая синяя баночка в фортнайте?";
                    radio1.Content = "Миник";
                    radio2.Content = "Gay-пати";
                    radio3.Content = "Синило";
                    radio4.Content = "Чага";
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
            else if (text.Text == "Как называется маленькая синяя баночка в фортнайте?")
            {
                if (radio1.IsChecked == true)
                {
                    text.Text = "Ты любишь мальчиков?";
                    radio1.Content = "Да";
                    radio2.Content = "Конечно";
                    radio3.Content = "Это база";
                    radio4.Content = "Люблю";
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
            else if (text.Text == "Ты любишь мальчиков?")
            {
                MessageBox.Show("Я так и знал");
                text.Text = "Играешь в доту?";
                radio1.Content = "Да";
                radio2.Content = "Каждый день";
                radio3.Content = "Обожаю";
                radio4.Content = "Нет";
            }
            else if (text.Text == "Играешь в доту?")
            {
                if (radio4.IsChecked == true)
                {
                    text.Text = "Кто ты?";
                    radio1.Visibility = Visibility.Collapsed;
                    radio2.Visibility = Visibility.Collapsed;
                    radio3.Visibility = Visibility.Collapsed;
                    radio4.Visibility = Visibility.Collapsed;

                    check1.Content = "Гомосапиенс";
                    check2.Content = "Чел";
                    check3.Content = "Ну человек";
                    check4.Content = "Гейшит импактер";

                    check1.Visibility = Visibility.Visible;
                    check2.Visibility = Visibility.Visible;
                    check3.Visibility = Visibility.Visible;
                    check4.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
            else if (text.Text == "Кто ты?")
            {
                if (check1.IsChecked == true && check2.IsChecked == true && check3.IsChecked == true && check4.IsChecked == true)
                {
                    MessageBox.Show("Хорош");
                    text.Text = "Чи или не чи?";
                    check3.Visibility = Visibility.Collapsed;
                    check4.Visibility = Visibility.Collapsed;
                    check1.Content = "Чи";
                    check2.Content = "Не чи";

                    check1.IsChecked = false;
                    check2.IsChecked = false;
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
            else if (text.Text == "Чи или не чи?")
            {
                if (check1.IsChecked == true && check2.IsChecked == false)
                {
                    text.Text = "Сигма языки какие?";

                    check1.Content = "Питон";
                    check2.Content = "С++";
                    check3.Content = "С#";
                    check4.Content = "Брейн Фак";

                    check3.Visibility = Visibility.Visible;
                    check4.Visibility = Visibility.Visible;

                    check1.IsChecked = false;
                    check2.IsChecked = false;
                    check3.IsChecked = false;
                    check4.IsChecked = false;
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
            else if (text.Text == "Сигма языки какие?")
            {
                if (check2.IsChecked == true && check3.IsChecked == true && check1.IsChecked == false && check4.IsChecked == false)
                {
                    MessageBox.Show("Ну, молодец, хоть это знаешь");
                    text.Text = "Мама или Папа?";

                    check1.Content = "Мама";
                    check2.Content = "Папа";
                    check3.Content = "300$";

                    check4.Visibility = Visibility.Collapsed;

                    check1.IsChecked = false;
                    check2.IsChecked = false;
                    check3.IsChecked = false;
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
            else if (text.Text == "Мама или Папа?")
            {
                if (check1.IsChecked == true && check2.IsChecked == true && check3.IsChecked == false)
                {
                    MessageBox.Show("Правильный выбор");
                    MessageBox.Show("Это конец!!!!");
                    MessageBox.Show($"Всего ошибок --> {oshibki}");
                    Close();
                }
                else if (check3.IsChecked == true)
                {
                    MessageBox.Show("-rep");
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
        }
    }
}




