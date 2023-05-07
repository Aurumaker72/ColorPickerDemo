using System.Windows;
using ColorPicker.ViewModels;

namespace ColorPicker.Views.WPF;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        ColorListViewModel.ColorViewModels.Add(new ColorViewModel
        {
            Red = 1f,
            Green = 0f,
            Blue = 1f
        });
    }

    public ColorListViewModel ColorListViewModel { get; } = new();
}