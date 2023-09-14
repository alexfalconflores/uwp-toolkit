# Converters
### StringToVisibilityConverter
Check if a string is null or empty and return a Visibility value. if the string is null or empty, return Collapsed, otherwise return Visible.

````xaml
...
 <ToolTipService.ToolTip>
    <ToolTip Content = "{x:Bind ButtonToolTip, Mode=OneWay}" Visibility="{x:Bind ButtonToolTip, Converter={StaticResource StringToVisibilityConverter}, Mode=OneWay}" />
 </ToolTipService.ToolTip>
`````