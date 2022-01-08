using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HW8WPF
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedUICommand ColorRed { get; set; }
        public static RoutedUICommand BoldStyle { get; set; }
        public static RoutedUICommand ItalicStyle { get; set; }
        public static RoutedUICommand BaseLine { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommands), inputs);
            ColorRed = new RoutedUICommand();
            BoldStyle = new RoutedUICommand();
            ItalicStyle = new RoutedUICommand();
            BaseLine = new RoutedUICommand();
        }
    }
}
