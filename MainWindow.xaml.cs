using System.Windows;
using Hotel.Views;

namespace Hotel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EsciClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClientiClick(object sender, RoutedEventArgs e)
        {
            AddOrSelectTab("Clienti", new ClienteView());
        }

        private void CamereClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funzionalità Camere non ancora implementata");
        }

        private void PrenotazioniClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funzionalità Prenotazioni non ancora implementata");
        }

        private void ComandeClick(object sender, RoutedEventArgs e)
        {
            AddOrSelectTab("Comande", new ComandaView());
        }

        private void PagamentiClick(object sender, RoutedEventArgs e)
        {
            AddOrSelectTab("Pagamenti", new PagamentoView());
        }

        private void ListiniClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funzionalità Listini non ancora implementata");
        }

        private void AgenzieClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funzionalità Agenzie non ancora implementata");
        }

        private void AllotmentClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funzionalità Allotment non ancora implementata");
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hotel Management System v1.0\nCreated with C# WPF MVVM");
        }

        private void AddOrSelectTab(string header, FrameworkElement content)
        {
            // Check if tab already exists
            foreach (TabItem tab in MainTabControl.Items)
            {
                if (tab.Header.ToString() == header)
                {
                    MainTabControl.SelectedItem = tab;
                    return;
                }
            }

            // Create new tab
            var tabItem = new TabItem
            {
                Header = header,
                Content = content
            };
            MainTabControl.Items.Add(tabItem);
            MainTabControl.SelectedItem = tabItem;
        }
    }
}
