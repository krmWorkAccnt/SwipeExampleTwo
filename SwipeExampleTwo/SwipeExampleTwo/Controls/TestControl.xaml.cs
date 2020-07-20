using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeExampleTwo.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestControl : ContentView
    {
        public TestControl()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty ViewModelProperty = BindableProperty.Create(nameof(ViewModel), typeof(TestViewModel), typeof(TestControl));

        public TestViewModel ViewModel
        {
            get => (TestViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }
    }
}