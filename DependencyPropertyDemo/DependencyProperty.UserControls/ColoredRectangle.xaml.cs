using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyPropertyDemo
{
    /// <summary>
    /// Interaction logic for ColoredRectangle.xaml
    /// </summary>
    public partial class ColoredRectangle : UserControl
    {
        public ColoredRectangle()
        {
            InitializeComponent();

            var redPropertyDescriptor = DependencyPropertyDescriptor.FromProperty(ColoredRectangle.RedProperty,typeof(ColoredRectangle));
            redPropertyDescriptor.AddValueChanged(this, (sender, args) => OnColorChange());

            var greenPropertyDescriptor = DependencyPropertyDescriptor.FromProperty(ColoredRectangle.GreenProperty, typeof(ColoredRectangle));
            greenPropertyDescriptor.AddValueChanged(this, (sender, args) => OnColorChange());

            var bluePropertyDescriptor = DependencyPropertyDescriptor.FromProperty(ColoredRectangle.BlueProperty, typeof(ColoredRectangle));
            bluePropertyDescriptor.AddValueChanged(this, (sender, args) => OnColorChange());
        }

        private void OnColorChange()
        {
            Color color = Color.FromRgb(Red, Green, Blue);
            Rectangle.Fill = new SolidColorBrush(color);
        }

        public static readonly DependencyProperty RedProperty = DependencyProperty.Register(
            "Red", typeof(byte), typeof(ColoredRectangle), new PropertyMetadata(default(byte)));



        public byte Red
        {
            get { return (byte) GetValue(RedProperty); }
            set { SetValue(RedProperty, value); }
        }

        public static readonly DependencyProperty GreenProperty = DependencyProperty.Register(
            "Green", typeof(byte), typeof(ColoredRectangle), new PropertyMetadata(default(byte)));

        public byte Green
        {
            get { return (byte) GetValue(GreenProperty); }
            set { SetValue(GreenProperty, value); }
        }

        public static readonly DependencyProperty BlueProperty = DependencyProperty.Register(
            "Blue", typeof(byte), typeof(ColoredRectangle), new PropertyMetadata(default(byte)));

        public byte Blue
        {
            get { return (byte) GetValue(BlueProperty); }
            set { SetValue(BlueProperty, value); }
        }
    }
}
