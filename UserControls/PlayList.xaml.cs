using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicPlayer.UserControls
{
    /// <summary>
    /// Interaction logic for PlayList.xaml
    /// </summary>
    public partial class PlayList : UserControl
    {
        public PlayList()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }

        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(PlayList));
        public string Desc
        {
            get { return (string)GetValue(DescProperty); }
            set { SetValue(DescProperty, value); }

        }
        public static readonly DependencyProperty DescProperty = DependencyProperty.Register("Desc", typeof(string), typeof(PlayList));
        public ImageSource AlbumImage
        {
            get { return (ImageSource)GetValue(AlbumImageProperty); }
            set { SetValue(AlbumImageProperty, value); }

        }
        public static readonly DependencyProperty AlbumImageProperty = DependencyProperty.Register("AlbumImage", typeof(ImageSource), typeof(PopularSong));
        //public bool IsActive
        //{
        //    get { return (bool)GetValue(IsActiveProperty); }
        //    set { SetValue(IsActiveProperty, value); }

        //}
        //public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(PopularSong));

    }
}
