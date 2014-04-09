using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test_fonts
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Loaded += new RoutedEventHandler(this.MainWindow_Loaded);
        }

        private ObservableCollection<FontFamily> GetFontList()
        {
            var fontList = new ObservableCollection<FontFamily>();
            var fonts = Fonts.SystemFontFamilies;
            foreach (var Font in fonts)
            {
                fontList.Add(Font);
            }
            return fontList;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.ddlFontName.ItemsSource = this.GetFontList(); 
        }
    }
}