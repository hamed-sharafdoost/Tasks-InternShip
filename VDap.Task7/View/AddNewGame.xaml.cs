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
using VDap.Task7.DataProvider;
using VDap.Task7.ViewModel;

namespace VDap.Task7.View
{
    /// <summary>
    /// Interaction logic for AddNewGame.xaml
    /// </summary>
    public partial class AddNewGame : UserControl
    {
        private GameViewModel viewModel;
        public AddNewGame()
        {
            InitializeComponent();
            viewModel = GameViewModel.GetInstance();
            DataContext = viewModel;
        }
    }
}
