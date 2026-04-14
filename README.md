# Xamarin.Forms Expandable ListView
This example shows creating expandable listview (aka Accordion) using syncfusion SfListView.

## Sample

```xaml
<sflistview:SfListView x:Name="listView" AutoFitMode="DynamicHeight" SelectionMode ="None" IsScrollBarVisible="False" ItemSpacing="0">
    <sflistview:SfListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <ViewCell.View>
                    <Grid Padding="2" Margin="1" BackgroundColor="#F0F0F0" >
                        <Frame x:Name="frame" CornerRadius="2" Padding="1" Margin="1" OutlineColor="White">
                            <Grid VerticalOptions="FillAndExpand" BackgroundColor="White" HorizontalOptions="FillAndExpand">
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="Auto" />
                                </Grid.RowDefinitions>
                                <Grid x:Name="grid" RowSpacing="0" Padding="0,4,0,0">
                                    <Grid.GestureRecognizers>
                                        <TapGestureRecognizer Command="{Binding Path=BindingContext.TapGestureCommand, Source={x:Reference listView}}" CommandParameter="{Binding .}"/>
                                    </Grid.GestureRecognizers>
                                    <Grid.RowDefinitions>
                                        <RowDefinition Height="60" />
                                    </Grid.RowDefinitions>
                                    <code>
                                    . . .
                                    . . .
                                    <code>
                                </Grid>
                                <Grid IsVisible="{Binding IsVisible, Mode=TwoWay}" ColumnSpacing="0" RowSpacing="0" Grid.Row="1" BackgroundColor="White" HorizontalOptions="FillAndExpand" Padding="5" VerticalOptions="FillAndExpand">
                                    <Grid.RowDefinitions>
                                        <RowDefinition Height="1" />
                                        <RowDefinition Height="40" />
                                        <RowDefinition Height="40" />
                                        <RowDefinition Height="40" />
                                        <RowDefinition Height="40" />
                                        <RowDefinition Height="40" />
                                    </Grid.RowDefinitions>
                                    <Grid.ColumnDefinitions >
                                        <ColumnDefinition Width="50" />
                                        <ColumnDefinition Width="*" />
                                    </Grid.ColumnDefinitions>
                                    <code>
                                    . . .
                                    . . .
                                    <code>
                                </Grid>
                            </Grid>
                        </Frame>
                    </Grid>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </sflistview:SfListView.ItemTemplate>
</sflistview:SfListView>
```

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
