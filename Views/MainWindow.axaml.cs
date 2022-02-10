using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using NBAScore.Models;
using NBAScore.ViewModels;
using System;
using Avalonia.Interactivity;

namespace NBAScore.Views
{
    public partial class MainWindow : Window
    {
        public MainWindowViewModel? TheViewModel { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();

           //DataGrid controller
            var dg = this.FindControl<DataGrid>("scoreDataGrid");
            dg.IsReadOnly = true;

            //CalendarDatePicker controller
            var dp = this.FindControl<CalendarDatePicker>("DatePicker");
            dp.DisplayDateEnd = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            dp.DisplayDateStart = new DateTime(1979, 10, 12);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private int teamId;
        private string? endDate;
        private string? startDate;

        //Detect changes on ComboBox
        public void TeamSelected(object sender, SelectionChangedEventArgs args)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            teamId = senderComboBox.SelectedIndex + 1;

        }

        //Detect changes on CalendarDatePicker
        public void DateSelected(object sender, SelectionChangedEventArgs args)
        {
            CalendarDatePicker senderDatePicker = (CalendarDatePicker)sender;
            endDate = senderDatePicker.SelectedDate.Value.Date.ToString("yyyy/MM/dd");
            startDate = senderDatePicker.SelectedDate.Value.Date.AddDays(-14).ToString("yyyy/MM/dd");
        }

        //Detect changes on Button (clicked)
        public async void ButtonClicked(object sender, RoutedEventArgs args)
        {
            try
            {
                var games = await Games.GetGamesAsync(startDate, endDate, teamId);
                TheViewModel.Games = games.games;
            }
            //Prevents program from crashing if connection ruined
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e}");
            }

        }

        
    }
}
