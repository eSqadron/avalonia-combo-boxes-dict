using CommunityToolkit.Mvvm.ComponentModel;
using ListOfComboBoxesApp.Model;
using System;

namespace ListOfComboBoxesApp.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private KeyValues _boundKeyValues = new KeyValues();

    public void GetValues()
    {
        foreach (var item in BoundKeyValues)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }        
    }

    public void FillValues()
    {
        BoundKeyValues = new KeyValues()
        {
            { EKeys.Value1, "Value 1" },
            { EKeys.Value2, "Value 2" },
            { EKeys.Value3, "Value 3" },
            { EKeys.Value4, "Value 4" }
        };
    }
}
