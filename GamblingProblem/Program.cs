using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamblingProblem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 window = new Form1();
            Application.Run(window);

            Deck d = new Deck();
            HumanPlayer h = new HumanPlayer();
            Card c;
            int i;
            for(i = 0; i < 5; i++)
            {
                c = d.getCard();
                h.hand.addCard(c);
                Console.Write("Opening image " + c.getCardPath() + "\n");
                window.handCard1.ImageLocation = c.getCardPath();
            }
        }
    }
}
