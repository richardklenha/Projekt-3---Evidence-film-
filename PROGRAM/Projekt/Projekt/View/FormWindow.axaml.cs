using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Projekt
{
    public partial class FormWindow : Window
    {
        public FormWindow()
        {
            InitializeComponent();
            
            var btnUlozit = this.FindControl<Button>("BtnUlozit");
            if (btnUlozit != null)
            {
                btnUlozit.Click += (sender, e) => this.Close();
            }
        }
    }
}