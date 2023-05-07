using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ColorPicker.ViewModels;

public partial class ColorListViewModel : ObservableObject
{
    public ColorViewModel PendingColorViewModel { get; } = new();

    public ObservableCollection<ColorViewModel> ColorViewModels { get; } = new();


    [RelayCommand]
    private void Remove(ColorViewModel colorViewModel)
    {
        if (colorViewModel == null) throw new ArgumentNullException(nameof(colorViewModel));
        ColorViewModels.Remove(colorViewModel);
    }

    [RelayCommand]
    private void AddPendingColorViewModel()
    {
        ColorViewModels.Add(new ColorViewModel
        {
            Red = PendingColorViewModel.Red,
            Green = PendingColorViewModel.Green,
            Blue = PendingColorViewModel.Blue,
            Alpha = PendingColorViewModel.Alpha
        });
    }
}