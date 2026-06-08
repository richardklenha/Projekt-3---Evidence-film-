using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Projekt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BtnOtevritFormular.Click += OtevriFormularOkno;
            BtnOtevritDetail.Click += OtevriDetailOkno;
        }

        private void OtevriFormularOkno(object sender, RoutedEventArgs e)
        {
            FormWindow oknoFormulare = new FormWindow();
            oknoFormulare.ShowDialog(this); 
        }

        private void OtevriDetailOkno(object sender, RoutedEventArgs e)
        {
            DetailWindow oknoDetailu = new DetailWindow();
            oknoDetailu.ShowDialog(this);
        }
    }
}