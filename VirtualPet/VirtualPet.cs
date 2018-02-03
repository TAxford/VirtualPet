using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //Fields of Twinkletoe the puppy

        private bool isHungry;
        private bool isTried;
        private bool isBored;
        private bool isDirty;


        //Properties of Twinkletoe the puppy

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

        public bool IsTired
        {
            get { return this.isTried; }
            set { this.isTried = value; }
        }


        public bool IsDirty
        {
            get { return this.isDirty; }
            set { this.isDirty = value; }
        }

        //Constructor for Twinkletoe the puppy

        public VirtualPet(bool isHungry, bool isBored, bool isTired, bool isDirty)
        {
            this.isHungry = isHungry;
            this.isBored = isBored;
            this.isTried = isTried;
            this.isDirty = isDirty;

        }

        //Methods for Twinkletoe the puppy

        public string Hungry()
        {
            if (isHungry == false)
            {
                isHungry = true;
                return "I am hungry ";
            }
            else
            {
                return "I am full ";
            }
        }

        public string Bored()
        {
            if (isBored == false)
            {
                isBored = true;
                return "I want to play ";
            }
            else
            {
                return "My play meter is full";
            }
        }

        public string Tired()
        {
            if (isTried == false)
            {
                isTried = true;
                return "I want to go to bed ";
            }
            else
            {
                return "I have so much energy ";
            }
        }

        public string Dirty()
        {
            if (isDirty == false)
            {
                isDirty = true;
                return "I need a bath please";
            }
            else
            {
                return "I am sparkly clean";
            }
        }
    }
}
