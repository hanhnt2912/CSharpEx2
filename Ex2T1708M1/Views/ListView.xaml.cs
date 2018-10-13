using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Ex2T1708M1.entity;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ex2T1708M1.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListView : Page
    {
        private ObservableCollection<Song> listSong;

        internal ObservableCollection<Song> ListSong
        {
            get => listSong;
            set => listSong = value;
        }

        public ListView()
        {
            this.ListSong = new ObservableCollection<Song>();
            this.ListSong.Add(new Song() { name = "hello", thumbnail = "" });
            this.ListSong.Add(new Song() { name = "hihi", thumbnail = "" });
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
