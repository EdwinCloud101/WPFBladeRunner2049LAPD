# Blade Runner 2049 : LAPD Style for WPF

A .NET 10 WPF port of the [blade-runner-2049-lapd-style](https://github.com/EdwinCloud101/blade-runner-2049-lapd-style) HTML/CSS kit. Same LAPD console aesthetic: phosphor teal glow, chromatic aberration, scanlines, film grain and edge halation.

![Visual Studio designer](https://raw.githubusercontent.com/EdwinCloud101/WPFBladeRunner2049LAPD/master/docs/screenshots/visual-studio-designer.png)

## Projects

- `BladeRunner2049.Lapd.Styles` - style-only library: design tokens, atmosphere brushes and 21 control styles, all keyed `Lapd.*`. Fonts (Orbitron, Share Tech Mono) embedded.
- `BladeRunner2049.Lapd.Showcase` - demo app with one window per control, all sharing the `ConsoleShell` chrome.

## Run

```
dotnet run --project src/BladeRunner2049.Lapd.Showcase
```

Pass a window name to open a single control, for example:

```
dotnet run --project src/BladeRunner2049.Lapd.Showcase -- Tree
```

Names: TextArea, TextBox, CheckBox, Radio, ComboBox, Tabs, DataGrid, Slider, ImageDisplay, ImageUpload, ButtonText, ButtonIcon, Toggle, Progress, Spinner, Badge, Tooltip, Tree, ColorPicker, MultiSelect, AutoComplete.

## Use the styles

Merge the aggregator dictionary and pick styles by key:

```xml
<ResourceDictionary Source="pack://application:,,,/BladeRunner2049.Lapd.Styles;component/Themes/BladeRunner2049Lapd.xaml" />
```

```xml
<Button Style="{StaticResource Lapd.Button}" Content="TRANSMIT" />
```

## Credits

Typefaces: [Orbitron](https://fonts.google.com/specimen/Orbitron) and [Share Tech Mono](https://fonts.google.com/specimen/Share+Tech+Mono) (OFL).

Independent, non-commercial fan homage to the visual design of Blade Runner 2049. Not affiliated with any rights holder.

## License

Public domain ([Unlicense](LICENSE)). Do whatever you want with it, no attribution needed. The fonts keep their own OFL license.
