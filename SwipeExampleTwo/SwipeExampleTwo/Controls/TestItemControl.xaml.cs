using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeExampleTwo.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestItemControl : ContentView
    {
        public TestItemControl()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty TestItemProperty = BindableProperty.Create(nameof(TestItem), typeof(object), typeof(TestItemControl));
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(TestItemControl));
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(TestItemControl));


        public object TestItem
        {
            get => ((object)GetValue(TestItemProperty));
            set => SetValue(TestItemProperty, value);
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }
    }
}