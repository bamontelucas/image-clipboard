using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace image_clipboard
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                System.Console.WriteLine("Informe a imagem por parâmetro!");
                System.Console.ReadKey(true);
            } else
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(args[0]);
                System.Windows.Forms.Clipboard.SetImage(img);
            }
        }
    }
}
