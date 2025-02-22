using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using ListOfComboBoxesApp.Model;
using System;
using System.Linq;

namespace ListOfComboBoxesApp.Views;

public partial class SpecialComboBoxes : UserControl
{
    public SpecialComboBoxes()
    {
        InitializeComponent();

        // TODO: - Bind Container/ContainerProperty to the children of SpecialComboBxesStackPanel so that the values can be set and read from Bound observable properties

    }

    public static readonly StyledProperty<KeyValues> ContainerProperty = AvaloniaProperty.Register<SpecialComboBoxes, KeyValues>(
            nameof(Container),
            defaultValue: new KeyValues(),
            defaultBindingMode: BindingMode.TwoWay);

    public KeyValues Container
    {
        get => GetValue(ContainerProperty);
        set => SetValue(ContainerProperty, value);
    }

    public void AddNewComboBox(object sender, RoutedEventArgs e)
    {
        StackPanel stackPanel = new StackPanel();

        (ComboBox KeyComboBox, TextBox ValueTextBox) = createLine();

        stackPanel.Children.Add(KeyComboBox);
        stackPanel.Children.Add(ValueTextBox);
        stackPanel.Orientation = Avalonia.Layout.Orientation.Horizontal;

        SpecialComboBxesStackPanel.Children.Add(stackPanel);
    }

    private (ComboBox, TextBox) createLine()
    {
        ComboBox keyComboBox = new ComboBox();
        keyComboBox.ItemsSource = Enum.GetValues(typeof(EKeys)).Cast<EKeys>();

        keyComboBox.SelectionChanged += (sender, e) =>
        {
            // TODO - something here?
        };

        TextBox valueTextBox = new TextBox();

        valueTextBox.TextChanged += (sender, e) =>
        {
            // TODO - something here?
        };

        return (keyComboBox, valueTextBox);
    }

}