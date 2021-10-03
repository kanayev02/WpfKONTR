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

        private void slav_Checked(object sender, RoutedEventArgs e)
        {
            month.Visibility = Visibility.Visible;
            selectMonth.Visibility = Visibility.Visible;
            month.IsEnabled = true;
            dateorgod.Text = "Введите день рождения";
        }

        private void yapons_Checked(object sender, RoutedEventArgs e)
        {
            month.Visibility = Visibility.Collapsed;
            selectMonth.Visibility = Visibility.Collapsed;
            dateorgod.Text = "Введите год рождения";
        }
        private void Button_Click(object sender, RoutedEventArgs e)  // событие для кнопки рассчета площади
        {


            try
            {

                double Datehappy = Convert.ToDouble(DateOfhappy.Text);
                //if (slav.IsEnabled == true)
                {
                    if (Datehappy > 1995 && Datehappy < 2008)
                    {
                        if (Datehappy == 1996)
                        {
                            resualt.Text = "Крыса";
                        }
                        if (Datehappy == 1997)
                        {
                            resualt.Text = "Бык";
                        }
                        if (Datehappy == 1998)
                        {
                            resualt.Text = "Тигр";
                        }
                        if (Datehappy == 1999)
                        {
                            resualt.Text = "Кролик";
                        }
                        if (Datehappy == 2000)
                        {
                            resualt.Text = "Дракон";
                        }
                        if (Datehappy == 2001)
                        {
                            resualt.Text = "Змея";
                        }
                        if (Datehappy == 2002)
                        {
                            resualt.Text = "Лошадь";
                        }
                        if (Datehappy == 2003)
                        {
                            resualt.Text = "Овца";
                        }
                        if (Datehappy == 2004)
                        {
                            resualt.Text = "Обезьяна";
                        }
                        if (Datehappy == 2005)
                        {
                            resualt.Text = "Петух";
                        }
                        if (Datehappy == 2006)
                        {
                            resualt.Text = "Собака";
                        }
                        if (Datehappy == 2007)
                        {
                            resualt.Text = "кабан";
                        }
                    }
                    else
                    {
                        MessageBox.Show("повториете");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ошибка" + ex.Message);
            }

            try
            {

                dateorgod = Convert.ToString(dateorgod.Text);   

                if (dateorgod.Text != "" && (day > 0 && day < 32))
                {
                    resualt.Text;
                }
                else                                     //я тут очень запутался 
                {
                    MessageBox.Show("повторите ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка" + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("ошибка" + ex.Message);
            }


             void result(string month, byte day)
            {
                if ((month == "Декабрь" || month == "Январь") && (day > 23 && day < 31))
                {
                    resualt.Text = "Мороз (Морозко, Трескун, Студенец)";
                }
                if ((month == "Январь" || month == "Февраль") && (day > 29 && day < 32))
                {
                    resualt.Text = "Велес";
                }
                if (month == "Март")
                {
                    resualt.Text = "Макошь";
                }
                if (month == "Апрель")
                {
                    resualt.Text = "Жива";
                }
                if (month == "Май" && (day > 0 && day < 15))
                {
                    resualt.Text = "Ярила (Ярило)";
                }
                if ((month == "Май" || month == "Июнь") && (day > 1 && day < 16))
                {
                    resualt.Text = "Леля";
                }
                if (month == "Июнь" && (day > 1 && day < 13))
                {
                    resualt.Text = "Кострома";
                }
                if ((month == "Июнь" || month == "Июль") && (day > 5 && day < 14))
                {
                    resualt.Text = "Додола";
                }
                if (month == "Июнь" && day == 24)
                {
                    resualt.Text = "Иван Купалаф";
                }
                if (month == "Июль" && (day > 6 && day < 32))
                {
                    resualt.Text = "Лада";
                }
                if (month == "Август" && (day > 0 && day < 29))
                {
                    resualt.Text = "Перун";
                }
                if ((month == "Август" || month == "Сентябрь") && (day > 12 && day < 30))
                {
                    resualt.Text = "Сева";
                }
                if (month == "Сентябрь" && (day > 13 && day < 28))
                {
                    resualt.Text = "Рожаница";
                }
                if ((month == "Сентябрь" || month == "Октябрь") && (day > 14 && day < 29))
                {
                    resualt.Text = "Сварожичи";
                }
                if ((month == "Октябрь" || month == "Ноябрь") && (day > 7 && day < 17))
                {
                    resualt.Text = "Морена";
                }
                if (month == "Ноябрь" && (day > 8 && day < 29))
                {
                    resualt.Text = "Зима";
                }
                if ((month == "Ноябрь" || month == "Декабрь") && (day > 22 && day < 30))
                {
                    resualt.Text = "Карачуни";
                }
            }
        }
    }
}
