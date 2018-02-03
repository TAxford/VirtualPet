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

        

    }
}
