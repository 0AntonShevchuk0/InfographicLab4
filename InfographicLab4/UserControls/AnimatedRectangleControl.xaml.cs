using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InfographicLab4
{
    public partial class AnimatedRectangleControl : UserControl
    {
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(AnimatedRectangleControl));

        public string NameText
        {
            get { return (string)GetValue(NameTextProperty); }
            set { SetValue(NameTextProperty, value); }
        }

        public static readonly DependencyProperty NameTextProperty =
            DependencyProperty.Register("NameText", typeof(string), typeof(AnimatedRectangleControl), new PropertyMetadata(""));

        public Brush TextColor
        {
            get { return (Brush)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly DependencyProperty TextColorProperty =
            DependencyProperty.Register("TextColor", typeof(Brush), typeof(AnimatedRectangleControl), new PropertyMetadata(new SolidColorBrush() { Color = Color.FromArgb(255, 0, 0, 0) }));

        public int RectangleStartWidth
        {
            get { return (int)GetValue(RectangleStartWidthProperty); }
            set { SetValue(RectangleStartWidthProperty, value); }
        }

        public static readonly DependencyProperty RectangleStartWidthProperty =
            DependencyProperty.Register("RectangleStartWidth", typeof(int), typeof(AnimatedRectangleControl), new PropertyMetadata(0));

        public int RectangleEndWidth
        {
            get { return (int)GetValue(RectangleEndWidthProperty); }
            set { SetValue(RectangleEndWidthProperty, value); }
        }

        public static readonly DependencyProperty RectangleEndWidthProperty =
            DependencyProperty.Register("RectangleEndWidth", typeof(int), typeof(AnimatedRectangleControl), new PropertyMetadata(0));

        public Brush RectangleColor
        {
            get { return (Brush)GetValue(RectangleColorProperty); }
            set { SetValue(RectangleColorProperty, value); }
        }

        public static readonly DependencyProperty RectangleColorProperty =
            DependencyProperty.Register("RectangleColor", typeof(Brush), typeof(AnimatedRectangleControl), new PropertyMetadata(new SolidColorBrush() { Color = Color.FromArgb(255, 0, 0, 0) }));

        public AnimatedRectangleControl()
        {
            InitializeComponent();
        }
    }
}
