using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DataGridCrash
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DataGrid.ItemsSource = new ObservableCollection<DataGridItem>();

            KeyUp += OnKeyUp;
        }
        
        private void OnKeyUp( object sender, KeyEventArgs e )
        {
            // Pressing F1 is meant to show an overlay and disable the current content
            if( e.Key == Key.F1 )
                DataGrid.IsEnabled = false;
        }
        
        class DataGridItem
        {
            public string Text { get; set; } 
        }
    }
}