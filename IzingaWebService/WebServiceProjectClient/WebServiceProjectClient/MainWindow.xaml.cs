using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using WebServiceProjectClient.IzingaService;

namespace WebServiceProjectClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogRepository _logs = LogRepository.Instance;

        public MainWindow()
        {
            InstanceContext site = new InstanceContext(new CallbackHandler());
            IzingaService.IzingaServiceClient _service = new IzingaService.IzingaServiceClient(site);
            _service.Subscribe();
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            List<IzingaService.Log> searchedLogs = _logs.Get(ComboBox1.Text, TextBox1.Text, ComboBox2.Text, TextBox2.Text);
            foreach (IzingaService.Log log in searchedLogs)
            {
                ListBox1.Items.Add(log.TidValue + " " + log.IDValue + " " + log.AlarmValue + " " + log.NavnValue + " " + log.AfdelingValue + " " + log.BoligValue + " " + log.AfmeldtValue);
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            List<IzingaService.Log> searchedLogs = _logs.Get(ComboBox1.Text, TextBox1.Text, ComboBox2.Text, TextBox2.Text);
            foreach (IzingaService.Log log in searchedLogs)
            {
                ListBox1.Items.Add(log.TidValue + " " + log.IDValue + " " + log.AlarmValue + " " + log.NavnValue + " " + log.AfdelingValue + " " + log.BoligValue + " " + log.AfmeldtValue);
            }
        }
    }

    public class CallbackHandler : IzingaService.IIzingaServiceCallback
    {
        private LogRepository _logs = LogRepository.Instance;

        public void CallbackPublishResult(IzingaService.Log[] list)
        {
            foreach(IzingaService.Log item in list)
            {
                _logs.Add(item);
            }
        }
    }
}
