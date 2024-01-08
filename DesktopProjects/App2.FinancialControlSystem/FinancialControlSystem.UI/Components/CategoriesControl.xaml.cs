using FinancialControlSystem.Logic.Storages;
using System.Windows;
using System.Windows.Controls;

namespace FinancialControlSystem.UI.Components
{
    public partial class CategoriesControl : UserControl
    {
        public CategoriesControl()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            GridAddButton.Visibility = Visibility.Visible;
        }

        private void ButtonCansel_Click(object sender, RoutedEventArgs e)
        {
            GridAddButton.Visibility = Visibility.Hidden;
        }

        public void LoadAllCategories()
        {
            FinanceStorage Categories = new ();
            //ListBoxCategories.Items.
        }
    }
}
