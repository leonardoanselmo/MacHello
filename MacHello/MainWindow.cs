using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    int i = 0;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    private void clicarBotao(object send, EventArgs args)
    {
        lblViewNome.Text = "Meu nome é: "+edtNome.Text;
    }
}
