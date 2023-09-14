# Converters
### EnumToGridLengthConverter
Convert an enum to a GridLength

```xaml
//Size is an enum
<RowDefinition Height="{x:Bind Size, Converter={StaticResource EnumToGridLengthConverter}, Mode=OneWay}" />
```