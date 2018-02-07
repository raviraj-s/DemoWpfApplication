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
using System.Net.Http;
using System.Net.Http.Headers;

namespace DemoWpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
                  
        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    BindEmployeeList();
        //}

        //private void BindEmployeeList()
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("https://localhost:4567/");
        //    //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
        //    client.DefaultRequestHeaders.Accept.Add(
        //       new MediaTypeWithQualityHeaderValue("application/json"));

        //    HttpResponseMessage response = client.GetAsync("CareServices/GeneralService.asmx?op=GetNearestOrganisation").Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var employees = response.Content.ReadAsAsync<IEnumerable<OrganisationDetails>>().Result;
        //        grdEmployee.ItemsSource = employees;

        //    }
        //    else
        //    {
        //        MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
        //    }
        //}

        //private void btnDelete_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void btnSearch_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
