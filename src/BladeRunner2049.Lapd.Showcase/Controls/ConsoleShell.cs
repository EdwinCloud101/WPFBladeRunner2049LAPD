using System.Windows;
using System.Windows.Controls;

namespace BladeRunner2049.Lapd.Showcase.Controls;

public class ConsoleShell : ContentControl
{
    public static readonly DependencyProperty MastheadTitleProperty = DependencyProperty.Register(
        nameof(MastheadTitle), typeof(string), typeof(ConsoleShell), new PropertyMetadata("CONTROL INDEX"));

    public static readonly DependencyProperty SectionNumberProperty = DependencyProperty.Register(
        nameof(SectionNumber), typeof(string), typeof(ConsoleShell), new PropertyMetadata(""));

    public static readonly DependencyProperty SectionTitleProperty = DependencyProperty.Register(
        nameof(SectionTitle), typeof(string), typeof(ConsoleShell), new PropertyMetadata(""));

    public static readonly DependencyProperty JpLabelProperty = DependencyProperty.Register(
        nameof(JpLabel), typeof(string), typeof(ConsoleShell), new PropertyMetadata(""));

    public string MastheadTitle
    {
        get => (string)GetValue(MastheadTitleProperty);
        set => SetValue(MastheadTitleProperty, value);
    }

    public string SectionNumber
    {
        get => (string)GetValue(SectionNumberProperty);
        set => SetValue(SectionNumberProperty, value);
    }

    public string SectionTitle
    {
        get => (string)GetValue(SectionTitleProperty);
        set => SetValue(SectionTitleProperty, value);
    }

    public string JpLabel
    {
        get => (string)GetValue(JpLabelProperty);
        set => SetValue(JpLabelProperty, value);
    }
}
