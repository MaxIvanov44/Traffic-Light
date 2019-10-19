using Logic;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using static Logic.ChangeColor;


namespace traffic_light
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer2 = new DispatcherTimer();
        static int count = 0;
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                //int h = DateTime.Now.Hour;
                //int m = DateTime.Now.Minute;
                //int s = DateTime.Now.Second;

                timer.Tick += ChangeColor.ChangeLight;
                timer.Tick += Change;
                timer.Tick += NOW;

                timer2.Tick += NOW;
                timer2.Tick += ChangeLight2;
                timer2.Tick += Change;

                ChangeColor.C = MyEnum.Yellow;

                timer.Start();

                void NOW(object sender, object e)
                {
                    count++;
                }
                void Change(object sender, object e)
                {
                    if (count > 10)
                    {
                        timer2.Start();
                        switch (ChangeColor.C2)
                        {
                            case MyEnum2.Black:
                                timer2.Interval = new TimeSpan(0, 0, 0, 1);
                                RedL.Fill = Brushes.Black;
                                YellowL.Fill = Brushes.Black;
                                GreenL.Fill = Brushes.Black;
                                break;
                            case MyEnum2.Yellow:
                                timer2.Interval = new TimeSpan(0, 0, 0, 1);
                                RedL.Fill = Brushes.Black;
                                YellowL.Fill = Brushes.Yellow;
                                GreenL.Fill = Brushes.Black;
                                break;
                        }
                    }
                    else
                    {
                        switch (ChangeColor.C)
                        {
                            case MyEnum.Red:
                                timer.Interval = new TimeSpan(0, 0, 0, 3);
                                RedL.Fill = Brushes.Red;
                                YellowL.Fill = Brushes.Black;
                                GreenL.Fill = Brushes.Black;
                                break;
                            case MyEnum.RedAndYellow:
                                timer.Interval = new TimeSpan(0, 0, 0, 1);
                                RedL.Fill = Brushes.Red;
                                YellowL.Fill = Brushes.Yellow;
                                GreenL.Fill = Brushes.Black;
                                break;
                            case MyEnum.Green:
                                timer.Interval = new TimeSpan(0, 0, 0, 3);
                                RedL.Fill = Brushes.Black;
                                YellowL.Fill = Brushes.Black;
                                GreenL.Fill = Brushes.Green;
                                break;
                            case MyEnum.Yellow:
                                timer.Interval = new TimeSpan(0, 0, 0, 1);
                                RedL.Fill = Brushes.Black;
                                YellowL.Fill = Brushes.Yellow;
                                GreenL.Fill = Brushes.Black;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}