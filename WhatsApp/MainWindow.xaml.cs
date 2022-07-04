using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WhatsApp;

public class Message
{
    public string? Text { get; set; }
    public DateTime? Date { get; set; }
}


public partial class MainWindow : Window
{
    public List<Message> Messages { get; set; }
    public MainWindow()
    {
        InitializeComponent();

        Messages = new List<Message>();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Messages.Add(new Message { Text = tbox.Text, Date = DateTime.Now });

        foreach (var message in Messages)
        {
            listview.Items.Add(message.Text);
            listview.Items.Add(message.Date);
            listview.FontSize = 24;
            listview.Foreground = Brushes.White;
        }

        tbox.Text = string.Empty;
        Messages.Clear();
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {

        Menu menu = new Menu();
        menu.VerticalAlignment = VerticalAlignment.Bottom;
        menu.FlowDirection = FlowDirection.RightToLeft;

        menu.Items.Add("View Contact");
        menu.Items.Add("Search");
        menu.Items.Add("Mute");
        menu.Items.Add("Wallpaper");
        menu.Items.Add("More");

        grid.Children.Add(menu);

    }

}
