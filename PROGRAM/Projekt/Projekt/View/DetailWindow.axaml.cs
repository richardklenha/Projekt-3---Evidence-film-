using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Projekt
{
    public partial class DetailWindow : Window
    {
        public DetailWindow()
        {
            InitializeComponent();
            BtnZavrit.Click += (sender, e) => this.Close();
        }
    }
}