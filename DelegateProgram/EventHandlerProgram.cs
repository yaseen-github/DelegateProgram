using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProgram
{
    internal class EventHandlerProgram
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.click += Button_Click;
            button.InvokeClick();

            Console.ReadLine();

        }
        static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked");
        }
    }

    public class Button
    {
        public event EventHandler click;

        public void InvokeClick()
        {
            click?.Invoke(this, EventArgs.Empty);
        }
    }
}
