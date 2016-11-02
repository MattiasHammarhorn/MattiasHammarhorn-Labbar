using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure
{
    class QuestManager
    {
        public static bool isQuestStarted { get; set; }
        public static bool isLadderTaken { get; set; }

        public static void QuestMonologue()
        {
            if (isQuestStarted == false)
            {
                Console.WriteLine("You find yourself in a small English village somewhere in the East Midlands.\nIt's thursday, the weather is cloudy and not alot of people are out.\nYou should probably talk to some of the villagers.");
            }

            else if (isQuestStarted == true)
            {
                Console.WriteLine("You take the ladder.");
            }

            Console.ReadKey(true);
        }

        public static void QuestEnd()
        {
            {
                Console.WriteLine("\nYou take help Eric and Mss.Fairfax to get Mr.Nibbles down and is rewarded by staying at their house\n and eating dinner with them. The next morning, you pack up and leave the pair after having\n said goodbye. The journey continues...");
                Console.WriteLine("\nGame is over. Thank you for playing! (You should probably just close\nthe program because there is nothing more to do...)");
            }
        }
    }
}
