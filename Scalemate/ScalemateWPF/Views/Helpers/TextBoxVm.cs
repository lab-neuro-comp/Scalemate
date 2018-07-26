using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ScalemateWPF.Views.Helpers
{
    class TextBoxVm : DependencyObject
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextBoxVm), new UIPropertyMetadata("default text",
            (d, e) =>
            {
                var vm = (TextBoxVm)d;
                var val = (string)e.NewValue;
            }));

        public string TitleText
        {
            get { return (string)GetValue(TitleTextProperty); }
            set { SetValue(TitleTextProperty, value); }
        }
        public static readonly DependencyProperty TitleTextProperty =
            DependencyProperty.Register("TitleText", typeof(string), typeof(TextBoxVm), new UIPropertyMetadata("default title"));
    }
}
