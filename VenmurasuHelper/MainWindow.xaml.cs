using System;
using System.Collections.Generic;
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
using System.Web;

namespace VenmurasuHelper
{
    using Fizzler.Systems.HtmlAgilityPack;
    using Fizzler.Systems.XmlNodeQuery;
    using HtmlAgilityPack;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, RoutedEventArgs e)
        {
            var web = new HtmlWeb();
            //web.OverrideEncoding = Encoding.Unicode;
            web.AutoDetectEncoding = true;
            var html = web.Load(txtUrl.Text);

            //MessageBox.Show(html.ToString());            
            var doc = html.DocumentNode;
            var sep = new char[] {'–'};
            var title = doc.QuerySelector("h1.post-title").InnerText.Trim();
            title = System.Net.WebUtility.HtmlDecode(title);
            textBlock1.Text = string.Join(":::",title.Split(sep));// doc.QuerySelector("h1.post-title").InnerText;
        }
    }
}
