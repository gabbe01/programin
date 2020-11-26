using System;

namespace character_dialogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string warrior = "gabriel";
            string mage = "elsa";
            string dialog = "The party stared down the stone stairs into darkness. \"We should've brought some torches with us,\" remarked WARRIOR. MAGE turned around and replied, \"Worry not dear WARRIOR, let me shine some light for you,\" as she cast a Continual light spell.";
            string output = dialog.Replace("WARRIOR",warrior).Replace("MAGE", mage);
            Console.WriteLine(output);

            string addressBook = "Gamla vägen 12, 362 51 Vackelsang. Dackegatan 15, 362 51 Vackelsang.";
            string fixedAddressBook = addressBook.Replace("Vackelsang","Väckelsång");
            Console.WriteLine(fixedAddressBook);

        }   
    }
}
