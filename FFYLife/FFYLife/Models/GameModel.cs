﻿using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FFYLife.Models
{
    public class GameModel :IGameModel
    {
        const int NumBlocks = 5;

        //public int HeroHP { get; set; }
        //public int Cash { get; set; }
        //public int MonsterHP { get; set; }
        //public int Damage { get; set; }
        public double BlockNumber { get; set; }
        public int HPPrice { get; set; }
        public int DmgPrice { get; set; }

        public string Name { get; set; }

        public List<Chest> Chests { get; set; }

        public OneHero Hero { get; set; }
        public List<OneMonster> Monsters {get ; set; }
        
        public List<OneBlock> Blocks { get; set; }

        public Chest Chest { get; set; }
        public int ChestNum { get; set; }

        public double WindowHeight { get; set; }
        public double WindowWidth { get; set; }

        public double GameDisplayHeight { get; set; }
        public double GameDisplayWidth { get; set; }

        public double UIHeight { get; set; }
        public double UIWidth { get; set; }

        public GameModel(double w, double h , string Name )
        {
            GameDisplayHeight = h;
            GameDisplayWidth = w;

            this.Name = Name;
            
            for (int i = 0; i < NumBlocks; i++)
            {
                Blocks.Add(new OneBlock(w / NumBlocks, h / 4));
            }

            Hero = new OneHero(w/5,h/2);

            Monsters.Add(new OneMonster(w / 3, h / 2, 1 ));
            Monsters.Add(new OneMonster(w / 1, h / 2, 1));




        }

        public GameModel()
        {

        }

        public GameModel(double w, double h, string Name, int HeroHp, int DMG, int Armor, int Cash, int blockNumber, int DmgPrice, int HpPrice, int monster1Lvl, int monster1CX, int monster1CY, int monster2Lvl, int monster2CX, int monster2CY) //For the reload without the chest
        {
            GameDisplayHeight = h;
            GameDisplayWidth = w;

            this.Name = Name;

            for (int i = 0; i < NumBlocks; i++)
            {
                Blocks.Add(new OneBlock(w / NumBlocks, h / 4));
            }

            Hero = new OneHero(w / 5, h / 2, HeroHp, DMG, Armor, Cash);

            this.BlockNumber = blockNumber;
            this.DmgPrice = DmgPrice;
            this.HPPrice = HpPrice;


            Monsters.Add(new OneMonster(monster1CX, monster1CY, monster1Lvl));
            Monsters.Add(new OneMonster(monster2CX, monster2CY, monster2Lvl));

        }

        public GameModel(double w, double h, string Name, int HeroHp, int DMG, int Armor, int Cash, int blockNumber, int DmgPrice, int HpPrice, int monster1Lvl, int monster1CX, int monster1CY, int monster2Lvl, int monster2CX, int monster2CY, int chestCX, int chestCy, int chestNum) //For the reload with the chest
        {
            GameDisplayHeight = h;
            GameDisplayWidth = w;

            this.Name = Name;

            for (int i = 0; i < NumBlocks; i++)
            {
                Blocks.Add(new OneBlock(w / NumBlocks, h / 4));
            }

            Hero = new OneHero(w / 5, h / 2, HeroHp, DMG, Armor, Cash);

            Chest c = Chests[chestNum];
            c.CX = chestCX;
            c.CY = chestCy;



            this.BlockNumber = blockNumber;
            this.DmgPrice = DmgPrice;
            this.HPPrice = HpPrice;

            Monsters.Add(new OneMonster(monster1CX, monster1CY, monster1Lvl));
            Monsters.Add(new OneMonster(monster2CX, monster2CY, monster2Lvl));

        }

}
}