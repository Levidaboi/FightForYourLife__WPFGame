﻿using GameModel.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Linq;



namespace StorageRepository
{
    public class StorageRepo : IStorageRepository
    {
        public List<Chest> ChestList { get; set; }

        public StorageRepo()
        {
            
        }


        public /*static*/ void SaveHighScore(GameModel.Models.IGameModel gm)
        {
            if (File.Exists("highscores.txt"))
            {
                StreamWriter sw = File.AppendText("highscores.txt");
                sw.WriteLine(gm.Name + ";" + gm.BlockNumber);
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter("highscores.txt");
                sw.WriteLine(gm.Name + ";" + gm.BlockNumber);
                sw.Close();
            }
        }


        public static string[] LoadHighScores()
        {
            if (File.Exists("highscores.txt"))
            {
                return File.ReadAllLines("highscores.txt");
            }

            return null;
        }

        public static string[] SavedGamesList()
        {
            if (!Directory.Exists("Saves/"))
            {
                Directory.CreateDirectory("Saves");
            }


            return Directory.GetFiles("Saves");
        }


        public void SaveGame(IGameModel gameModel)
        {
            if (!Directory.Exists("Saves/"))
            {
                Directory.CreateDirectory("Saves");
            }

            XDocument saveGameXDoc = new XDocument(new XElement("Save"));
            saveGameXDoc.Root.Add(new XElement("Name", gameModel.Name));
            saveGameXDoc.Root.Add(new XElement("HeroHP", gameModel.Hero.Hp));
            saveGameXDoc.Root.Add(new XElement("Armor", gameModel.Hero.Armor));
            saveGameXDoc.Root.Add(new XElement("ArmorPrice", gameModel.ArmorPrice));
            saveGameXDoc.Root.Add(new XElement("BlockNumber", gameModel.BlockNumber));
            saveGameXDoc.Root.Add(new XElement("Cash", gameModel.Hero.Cash));
            saveGameXDoc.Root.Add(new XElement("Damage", gameModel.Hero.AttackDMG));
            saveGameXDoc.Root.Add(new XElement("AttackSpeed", gameModel.Hero.AttackSpeed));
            saveGameXDoc.Root.Add(new XElement("DmgPrice", gameModel.DmgPrice));
            saveGameXDoc.Root.Add(new XElement("HPPrice", gameModel.HPPrice));
            saveGameXDoc.Root.Add(new XElement("h", gameModel.GameDisplayHeight));
            saveGameXDoc.Root.Add(new XElement("w", gameModel.GameDisplayWidth));
            saveGameXDoc.Root.Add(new XElement("Monster1LVL", gameModel.Monsters[0].MonsterLVL));
            saveGameXDoc.Root.Add(new XElement("Monster1CX", gameModel.Monsters[0].CX));
            saveGameXDoc.Root.Add(new XElement("Monster1CY", gameModel.Monsters[0].CY));
            saveGameXDoc.Root.Add(new XElement("Monster2LVL", gameModel.Monsters[1].MonsterLVL));
            saveGameXDoc.Root.Add(new XElement("Monster2CX", gameModel.Monsters[1].CX));
            saveGameXDoc.Root.Add(new XElement("Monster2CY", gameModel.Monsters[1].CY));

            if (gameModel.Chest != null)
            {
                saveGameXDoc.Root.Add(new XElement("ChestCX", gameModel.Chest.CX));
                saveGameXDoc.Root.Add(new XElement("ChestCY", gameModel.Chest.CY));
                saveGameXDoc.Root.Add(new XElement("ChestNum", gameModel.ChestNum));

            }
            else
            {
                saveGameXDoc.Root.Add(new XElement("ChestCX", -1));
                saveGameXDoc.Root.Add(new XElement("ChestCY", -1));
                saveGameXDoc.Root.Add(new XElement("ChestNum", -1));

            }

            saveGameXDoc.Save("Saves/"+ gameModel.Name  + DateTime.Now.ToString("yyyy.MM.dd_HH.mm") + ".xml");

        }


        public GameModel.Models.GameModel LoadGame(string savefile)
        {

            savefile = savefile.Substring(6);
            savefile = "Saves\\" + savefile;
            XDocument save = XDocument.Load(savefile);

            int s = int.Parse(save.Root.Element("ChestCX").Value);





                if (int.Parse(save.Root.Element("ChestCX").Value) == -1)
                {
                GameModel.Models.GameModel  gm = new GameModel.Models.GameModel(int.Parse(save.Root.Element("w").Value), int.Parse(save.Root.Element("h").Value), save.Root.Element("Name").Value, int.Parse(save.Root.Element("HeroHP").Value), int.Parse(save.Root.Element("Damage").Value), int.Parse(save.Root.Element("AttackSpeed").Value),
                   int.Parse(save.Root.Element("Armor").Value), int.Parse(save.Root.Element("ArmorPrice").Value), int.Parse(save.Root.Element("Cash").Value), int.Parse(save.Root.Element("BlockNumber").Value), int.Parse(save.Root.Element("DmgPrice").Value), int.Parse(save.Root.Element("HPPrice").Value),
                   int.Parse(save.Root.Element("Monster1LVL").Value), int.Parse(save.Root.Element("Monster1CX").Value), int.Parse(save.Root.Element("Monster1CY").Value), int.Parse(save.Root.Element("Monster2LVL").Value), int.Parse(save.Root.Element("Monster2CX").Value),
                   int.Parse(save.Root.Element("Monster2CY").Value)) ;
                   return gm;
            
                }
                else
                {
                GameModel.Models.GameModel gm = new GameModel.Models.GameModel(int.Parse(save.Root.Element("w").Value), int.Parse(save.Root.Element("h").Value), save.Root.Element("Name").Value, int.Parse(save.Root.Element("HeroHP").Value), int.Parse(save.Root.Element("Damage").Value), int.Parse(save.Root.Element("AttackSpeed").Value),
                      int.Parse(save.Root.Element("Armor").Value), int.Parse(save.Root.Element("ArmorPrice").Value), int.Parse(save.Root.Element("Cash").Value), int.Parse(save.Root.Element("BlockNumber").Value), int.Parse(save.Root.Element("DmgPrice").Value), int.Parse(save.Root.Element("HPPrice").Value),
                           int.Parse(save.Root.Element("Monster1LVL").Value), int.Parse(save.Root.Element("Monster1CX").Value), int.Parse(save.Root.Element("Monster1CY").Value), int.Parse(save.Root.Element("Monster2LVL").Value), int.Parse(save.Root.Element("Monster2CX").Value),
                        int.Parse(save.Root.Element("Monster2CY").Value), int.Parse(save.Root.Element("ChestCX").Value), int.Parse(save.Root.Element("ChestCY").Value), int.Parse(save.Root.Element("ChestNum").Value));

                   return gm;

                }



        }

    }
}
