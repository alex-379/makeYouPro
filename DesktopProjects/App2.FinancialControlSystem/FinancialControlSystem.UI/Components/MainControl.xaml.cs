using System.Windows;
using System.Windows.Controls;

namespace FinancialControlSystem.UI.Components
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }
        private void ButtonAccounts_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.TabAccounts.IsSelected = true;
        }

        private void ButtonCredits_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.TabCredits.IsSelected = true;
        }

        private void ButtonLoans_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.TabLoans.IsSelected = true;
        }

        private void ButtonIncomes_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.TabIncomes.IsSelected = true;
        }

        private void ButtonExpenses_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.TabExpenses.IsSelected = true;
        }

        private void ButtonIncomesPlan_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.TabIncomesPlan.IsSelected = true;
        }

        private void ButtonExpensesPlan_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.TabExpensesPlan.IsSelected = true;
        }

        private void ButtonCategories_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.TabCategories.IsSelected = true;
        }

        private void ButtonReporting_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.TabReporting.IsSelected = true;
        }
    }
}
