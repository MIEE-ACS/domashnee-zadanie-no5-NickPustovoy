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

namespace DZ5_IVT_21B_Nick_P._Var2
{
    /// Задание: 
    /// 1) Добавить поле для города (Кнопка)
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Address address = new Address("Москва", "Зеленоград", "Площадь Шокина", 1, 124498);
            Address address2 = new Address("Украина", "Киевская область", "Киев", "Владимирская", 60, 01033);
            Address address3 = new Address("Москва", "Зеленоград", 713, 124498);
            AddressList.Items.Add(address);
            AddressList.Items.Add(address2);
            AddressList.Items.Add(address3);

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Address ad = new Address(Area.Text, City.Text, int.Parse(Building.Text), int.Parse(PostalCode.Text));
                AddressList.Items.Add(ad);
            }
            catch (FormatException ead)
            {
                MessageBox.Show("Проверьте правильность заполнения Номера Дома или Почтового Индекса");
            }
            catch (Exception ead)
            {
                MessageBox.Show(ead.Message);
            }
            Country.Text = "";
            Area.Text = "";
            City.Text = "";
            Street.Text = "";
            Building.Text = "";
            PostalCode.Text = "";
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            List<Address> addresses = new List<Address>();
            foreach (var adr in AddressList.Items)
            {
                if ((adr as Address).Country == "Россия")
                {
                    addresses.Add(adr as Address);
                }
            }
            AddressList.Items.Clear();
            foreach (var adr in addresses)
            {
                AddressList.Items.Add(adr);
            }
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Country.Items.Add("Россия");
            Country.Items.Add("Украина");
            Country.Items.Add("Казахстан");
            Country.Items.Add("Беларусь");
        }

        private void Srt_Click(object sender, RoutedEventArgs e)
        {
            
            Address p;
            List<Address> addresses = new List<Address>();
            foreach(var obj in AddressList.Items)
            {
                addresses.Add(obj as Address);
            }
            AddressList.Items.Clear();
            for (int j = 0; j < addresses.Count - 1; j++)
            {
                for (int i = 0; i < addresses.Count - 1; i++)
                {
                    if(addresses[i].Country.CompareTo(addresses[i + 1].Country) > 0)
                    {
                        p = addresses[i];
                        addresses[i] = addresses[i + 1];
                        addresses[i + 1] = p;
                    }
                }
            }
            foreach (var obj in addresses)
            {
                AddressList.Items.Add(obj as Address);
            }
        }

        private void Nfilt_Click(object sender, RoutedEventArgs e)
        {
            Address p;
            List<Address> addresses = new List<Address>();
            foreach (var obj in AddressList.Items)
            {
                if((obj as Address).City == Ctname.Text)
                {
                    addresses.Add(obj as Address);
                }               
            }
            AddressList.Items.Clear();
            foreach (var obj in addresses)
            {
                AddressList.Items.Add(obj as Address);
            }
        }
    }
}
