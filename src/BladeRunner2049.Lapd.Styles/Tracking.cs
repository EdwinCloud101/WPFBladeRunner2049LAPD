using System.Windows;
using System.Windows.Controls;

namespace BladeRunner2049.Lapd.Styles;

public static class Tracking
{
    public static readonly DependencyProperty TextProperty = DependencyProperty.RegisterAttached(
        "Text", typeof(string), typeof(Tracking), new PropertyMetadata(null, OnChanged));

    public static readonly DependencyProperty SpacesProperty = DependencyProperty.RegisterAttached(
        "Spaces", typeof(int), typeof(Tracking), new PropertyMetadata(2, OnChanged));

    public static string? GetText(DependencyObject obj) => (string?)obj.GetValue(TextProperty);
    public static void SetText(DependencyObject obj, string? value) => obj.SetValue(TextProperty, value);

    public static int GetSpaces(DependencyObject obj) => (int)obj.GetValue(SpacesProperty);
    public static void SetSpaces(DependencyObject obj, int value) => obj.SetValue(SpacesProperty, value);

    private static void OnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not TextBlock tb)
            return;

        var text = GetText(tb);
        if (string.IsNullOrEmpty(text))
        {
            tb.Text = text;
            return;
        }

        var gap = new string(' ', GetSpaces(tb));
        tb.Text = string.Join(gap, text.ToCharArray());
    }
}
