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
using Xceed.Wpf.Toolkit;
using InaportClientBJTI.ViewModel;
using InaportClientBJTI.Helper;

namespace InaportClientBJTI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EntryRPKRO : Window
    {

        public EntryRPKRO()
        {
            InitializeComponent();
            ModelRPKRO_DB modelRPKRO = new ModelRPKRO_DB();
            List<ViewModelItemRPKRO> listItem = modelRPKRO.getRPKRO();
            dg_draft.ItemsSource = listItem;
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
