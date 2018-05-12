﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.InfernoInfinity_interfaces
{
    public class Knife : IWeapon
    {
        private const int minimalDamage = 3;
        private const int maximalDamage = 4;

        private int minDamage;
        private int maxDamage;
        private int sockets = 2;
        private string rarity;

        public Knife(string rarity)
        {
            this.rarity = rarity;
            this.MinDamage = this.RarityDamageMin();
            this.MaxDamage = this.RarityDamageMax();
        }

        public int MinDamage
        {
            get
            {
                return minDamage;
            }

            private set
            {
                minDamage = value;
            }
        }

        public int MaxDamage
        {
            get
            {
                return maxDamage;
            }
            private set
            {
                maxDamage = value;
            }
        }

        private int RarityDamageMax()
        {
            int damage;

            switch (this.rarity)
            {
                case "Common":
                    damage = maximalDamage * 1;
                    break;
                case "Uncommon":
                    damage = maximalDamage * 2;
                    break;
                case "Rare":
                    damage = maximalDamage * 3;
                    break;
                case "Epic":
                    damage = maximalDamage * 5;
                    break;
                default:
                    throw new ArgumentException("Invalid Rareness!");
            }

            return damage;
        }

        private int RarityDamageMin()
        {
            int damage;

            switch (this.rarity)
            {
                case "Common":
                    damage = minimalDamage * 1;
                    break;
                case "Uncommon":
                    damage = minimalDamage * 2;
                    break;
                case "Rare":
                    damage = minimalDamage * 3;
                    break;
                case "Epic":
                    damage = minimalDamage * 5;
                    break;
                default:
                    throw new ArgumentException("Invalid Rareness!");
            }

            return damage;
        }

        public int Sockets { get; set; }
    }
}
