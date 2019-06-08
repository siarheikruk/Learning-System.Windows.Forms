using Microsoft.VisualBasic;
using System.Windows.Forms;

class InputDialogDemo
{
    static void Main ()
    {
        string name;

        name = Interaction.InputBox(
            "What is your name?",
            "Say Hi!...");

        string txt = "It's pleasure, " + name + "!";

        MessageBox.Show(txt, "we are done.");
    }
}