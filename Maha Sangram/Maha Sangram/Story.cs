using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maha_Sangram
{
    class Story
    {
        public string Scene { get; set; }

        public void PrintWithDelay(int delayInSeconds)
        {
           

            string[] paragraphs = GetParagraphs();

            foreach (string paragraph in paragraphs)
            {
                Console.WriteLine(paragraph);
                Thread.Sleep(delayInSeconds * 1000); // Convert seonds to milliseconds
            }
        }

        private string[] GetParagraphs()
        {
            return new string[]
            {
               "As the tension thickens between Arjuna and Ravana, their gazes lock in a silent exchange of unspoken challenges.\n",
                "Arjuna, his voice steady yet charged with determination, breaks the silence.\n \"Ravana, dark lord of the rakshasas, your reign of terror ends here. The forces of righteousness shall prevail.\"\n",
                "Ravana's laughter echoes across the battlefield like rolling thunder, tinged with the sinister edge of impending conflict.\n \"Arjuna, noble prince of men, you dare challenge me? Your bravery is commendable, but it shall not save you from the darkness that awaits.\"\n",
                 "With a flicker of defiance in his eyes, Arjuna responds, his words ringing out with the clarity of a clarion call.\n \"I fear not the darkness, for I carry the light of righteousness within me. Let us settle this once and for all, Ravana. Today, the fate of our worlds shall be decided.\"\n",
            };
        }
    }
}
