using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft
{
    internal class Program
    {
        public static int message;
        static void Main(string[] args)
        {
            
            while(true)
            {
                Thread th = new Thread(() =>
                {

                    message++;
                    MessageBox.Show("russian hacked your computer!", "new message from putin (" + message + ")", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    


                });
                th.Start();
                Thread.Sleep(1000);
            }
            




        }
        
        
    }
}
