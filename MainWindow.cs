using System;
using System.Linq;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace csharp_ide
{
    class MainWindow : Window
    {
        [UI] private Label _label1 = null;


        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetRawOwnedObject("MainWindow"))
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            this.KeyPressEvent  +=  Window_KeyPressEvent;
        }

        private async void Window_KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.Args.Any(x => (x as Gdk.EventKey).Key == Gdk.Key.F5))
            {
                Console.WriteLine("Building app...");
                await new AppBuilder().BuildAsync().ConfigureAwait(false);
            }
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

    }
}
