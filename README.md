# Universal-Windows-Plateform-calculator-UMP 
 `Date: 11-30-21`
 
**This is a basic calculator build in Universal Windows plateform application under the framwork of ASP.Net**

*if you want this project you just neend to clone it*

### how to clone a project 

1. Click on the `Code ▼` button (Green Colored ) and copy the HTTPS link 
2. Go to your any local directory(folder) where you want to clone it
3. open the command promnt from that directory
4. type the command " git clone [paste the copied link] " and press enter 
5. once your project is downloaded you can now open in your visual studio. 
6. that's it Enjoy🙂

## Calculator UI

<img src="https://raw.githubusercontent.com/imUmer/Universal-Windows-Plateform-calculator-UMP/root/assets/1.png"></img>
<img src="https://raw.githubusercontent.com/imUmer/Universal-Windows-Plateform-calculator-UMP/root/assets/2.png"></img>
<img src="https://raw.githubusercontent.com/imUmer/Universal-Windows-Plateform-calculator-UMP/root/assets/3.png"></img>


## MainPage.xaml

```
<Page
    x:Class="Calculator_11_30_21.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:Calculator_11_30_21"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    BorderBrush="Beige"
    BorderThickness="0"
    Background="{ThemeResource ApplicationPageBackgroundThemeBrush}" Width="326" Height="509">

    <Grid Margin="1" BorderBrush="CornflowerBlue" BorderThickness="1">
        <Grid.RowDefinitions>
            <RowDefinition Height = "Auto" />
            <RowDefinition Height = "Auto" />
            <RowDefinition Height = "Auto" />
            <RowDefinition Height = "Auto" />
            <RowDefinition Height = "Auto" />
            <RowDefinition Height = "Auto" />
            <RowDefinition Height = "Auto" />
        </Grid.RowDefinitions>

        <Grid.ColumnDefinitions>
            <ColumnDefinition Width = "Auto" />
            <ColumnDefinition Width = "Auto" />
            <ColumnDefinition Width = "Auto" />
            <ColumnDefinition Width = "Auto" />
        </Grid.ColumnDefinitions>
        <!--<TextBox x:Name="showOutput" FontSize="20"  Width="auto" Height="34"  Grid.Column = "1" Margin = "1"--> 
         <!--PlaceholderText="Type here..." Text = "{Binding Name, Mode = TwoWay}"/>-->


        <StackPanel Grid.Row = "1" Grid.Column = "1" Padding="2" Margin="0" Orientation="Vertical">
            <TextBox  BorderBrush="SaddleBrown" BorderThickness="0" x:Name="numberInput" FontSize="20"  Width="Auto" Height="64"   
         PlaceholderText="Type here..." />
            <TextBlock Text="0"  TextAlignment="Right" x:Name="result" FontSize="20"  Width="Auto" Height="34"   Margin = "0" 
           Foreground="CornflowerBlue"/>
        </StackPanel>
        
        <StackPanel HorizontalAlignment="Center" Grid.Row = "2" Grid.Column = "1" Padding="0" Margin="0" Orientation="Horizontal">
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "b1" 
             Content="1" Click="b1_Click"/>
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "b2" 
            Content="2" Click="b2_Click"/>

            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "b3" 
              Content="3" Click="b3_Click"/>

            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "bp" 
              Content="+"  Foreground="YellowGreen" Click="bp_Click"/>
        </StackPanel>

        <StackPanel HorizontalAlignment="Center" Grid.Row = "3" Grid.Column = "1" Padding="0" Margin="0"  Orientation="Horizontal">
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "b4" 
              Content="4" Click="b4_Click"/>
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "b5" 
            Content="5" Click="b5_Click"/>

            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "b6" 
             Content="6" Click="b6_Click"/>

            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "bs" 
            Content="-" Foreground="YellowGreen" Click="bs_Click"/>
        </StackPanel>

        <StackPanel HorizontalAlignment="Center" Grid.Row = "4" Grid.Column = "1" Padding="0" Margin="0"  Orientation="Horizontal">
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "b7" 
             Content="7" Click="b7_Click"/>
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "b8" 
             Content="8" Click="b8_Click"/>
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "b9" 
              Content="9" Click="b9_Click"/>
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "bml" 
             Content="x" Foreground="YellowGreen" Click="bml_Click"/>
        </StackPanel>

        <StackPanel HorizontalAlignment="Center" Grid.Row = "5" Grid.Column = "1" Padding="0" Margin="0"  Orientation="Horizontal">
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "bdot" 
             Content="." Click="bdot_Click" />
            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "bee" 
             Content="0" Click="bee_Click"/>


            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "be" 
              Content="=" Click="be_Click"/>

            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "bd" 
            Content="/" Foreground="YellowGreen" Click="bd_Click"/>
        </StackPanel>

        <StackPanel HorizontalAlignment="Center" Grid.Row = "6" Grid.Column = "1" Padding="0" Margin="0"  Orientation="Horizontal">


            <Button BorderBrush="Black" FontSize="34" Width="80" Height="80" Name = "bf" 
              Content=" " />


            <Button BorderBrush="Black" FontSize="24" Width="80" Height="80" Name = "bClear" 
             Content="C" Foreground="PaleVioletRed" Click="bClear_Click"/>

            <Button BorderBrush="Black" FontSize="24" Width="80" Height="80" Name = "bac" 
             Content="AC" Foreground="Red" Click="bac_Click" />
            <Button BorderBrush="Black" FontSize="24" Width="80" Height="80" Name = "bf2" 
            Content=" " Foreground="YellowGreen"/>
        </StackPanel>

    </Grid>
</Page>

```

## MainPage.xaml.cs

```
namespace Calculator_11_30_21
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int f = 0;
        char opt = ' ';
        double firstNumber = 0;
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void bp_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0) firstNumber = Convert.ToDouble(numberInput.Text);
            else firstNumber = Convert.ToDouble(result.Text);
            f = 1;
            opt = '+';
            numberInput.Text = "";
            numberInput.Focus(FocusState.Programmatic);
        }

        private void bs_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0) firstNumber = Convert.ToDouble(numberInput.Text);
            else firstNumber = Convert.ToDouble(result.Text);
            f = 1; 
            opt = '-';
            numberInput.Text = "";
            numberInput.Focus(FocusState.Programmatic);
        }

        private void bml_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0) firstNumber = Convert.ToDouble(numberInput.Text);
            else firstNumber = Convert.ToDouble(result.Text);
            f = 1;
            opt = '*';
            numberInput.Text = "";
            numberInput.Focus(FocusState.Programmatic);
        }

        private void bd_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0) firstNumber = Convert.ToDouble(numberInput.Text);
            else firstNumber = Convert.ToDouble(result.Text);
            f = 1;
            opt = '/';
            numberInput.Text = "";
            numberInput.Focus(FocusState.Programmatic);
        }

        private void bClear_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text = "";
        }

        private void bac_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            numberInput.Text = "";
            result.Text = "0";
            f = 0;
        }

        private void bdot_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += bdot.Content;
        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b1.Content; 
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b2.Content;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b3.Content;

        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b4.Content;

        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b5.Content;

        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b6.Content;

        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b7.Content;

        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b8.Content;

        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += b9.Content;

        }

        private void bee_Click(object sender, RoutedEventArgs e)
        {
            numberInput.Text += bee.Content;

        }

        private void be_Click(object sender, RoutedEventArgs e)
        {
            double secondNumber = 0, answer = 0;

            secondNumber = Convert.ToDouble(numberInput.Text);

            switch (opt)
            {
                case '+':
                    answer = (firstNumber + secondNumber);
                    result.Text = Convert.ToString(answer);
                    firstNumber = answer;
                    break;
                case '-':
                    answer = (firstNumber - secondNumber);
                    result.Text = Convert.ToString(answer);
                    firstNumber = answer;
                    break;
                case '*':
                    answer = (firstNumber * secondNumber);
                    result.Text = Convert.ToString(answer);
                    firstNumber = answer;
                    break;
                case '/':
                    answer = (firstNumber / secondNumber);
                    result.Text = Convert.ToString(answer);
                    firstNumber = answer;
                    break;
                default:
                    break;
            }
            numberInput.Text = "";

        }

       
    }
}
```
