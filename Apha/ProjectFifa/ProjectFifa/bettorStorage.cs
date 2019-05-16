using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFifa
{
    class bettorStorage
    {
        public const string LOCATION = "./gokkers/";
        public List<bettor> bettors { get; set; }

        /*public betStorage()
        {
            this.bets = this.Load();
        }*/
        public void save()
        {
            if (!Directory.Exists(LOCATION))
            {
                Directory.CreateDirectory(LOCATION);
            }

            foreach (string filename in Directory.EnumerateFiles(LOCATION))
            {
                File.Delete(filename);
            }
            foreach (bettor bettorsave in this.bettors)
            {
                string fileContent = "";

                fileContent += bettorsave.name;

                fileContent += "\n" + bettorsave.balance;

                //fileContent += "\n" + bettorsave.mybets;

                string safeTitle = RemoveInvalidFileNameChars(bettorsave.name);

                File.WriteAllText(LOCATION + safeTitle, fileContent);
            }
        }

        public List<bettor> Load()  //Bron: Docent tim: File: UsingObjects// :) Natuurlijk aan gepast naar mijn wensen
        {
            List<bettor> result = new List<bettor>();

            if (!Directory.Exists(LOCATION))
            {

                return result;
            }
            foreach (string fileName in Directory.EnumerateFiles(LOCATION))
            {
                string fileContent = File.ReadAllText(fileName);

                bettor loadedBettor = new bettor();

                string[] contentLines = fileContent.Split('\n');

                loadedBettor.name = contentLines[0];

                loadedBettor.balance = contentLines[1];

                result.Add(loadedBettor);
            }
            return result;
        }

        private string RemoveInvalidFileNameChars(string title)
        {
            string fileName = title;

            // Bron: https://stackoverflow.com/questions/333175/is-there-a-way-of-making-strings-file-path-safe-in-c
            foreach (var invalidChar in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(invalidChar, '-');
            }

            return fileName;
        }
        // niet vergeten.
        public void addBettor(bettor newbettor)
        {
            this.bettors.Add(newbettor);
        }
    }
}
