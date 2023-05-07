using CommunityToolkit.Mvvm.ComponentModel;

namespace ColorPicker.ViewModels;

public partial class ColorViewModel : ObservableObject
{
    [ObservableProperty] [NotifyPropertyChangedFor(nameof(Hexadecimal))]
    private float _alpha = 1f;

    [ObservableProperty] [NotifyPropertyChangedFor(nameof(Hexadecimal))]
    private float _blue;

    [ObservableProperty] [NotifyPropertyChangedFor(nameof(Hexadecimal))]
    private float _green;

    [ObservableProperty] [NotifyPropertyChangedFor(nameof(Hexadecimal))]
    private float _red;

    public string Hexadecimal =>
        $"#{(byte)(Red * 255):X}{(byte)(Green * 255):X}{(byte)(Blue * 255):X}{(byte)(Alpha * 255):X}";
}