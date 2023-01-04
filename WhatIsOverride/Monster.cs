using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOverride {
    internal class Monster {




        protected String name;
        protected int hp;
        protected int damage;
        protected int defence;

        protected void Move(String name) {
            Console.WriteLine("{0}(이)가 움직인다..", name);
        }

        protected void Attack(String name, int damage) {
            Console.WriteLine("{0}(이)가 {1}의 공격력으로 공격했다.", name, damage);
        }

        public void MoveAndAttack() {
            this.Move(this.name);
            this.Attack(this.name, this.damage);
        }

    }       //class Monster 


    class Slime : Monster {

        public String Name {

            get { return this.name; }
            private set { this.name = value; } 
        
        }





        public Slime() {
            this.name = "슬라임";
            this.hp = 100;
            this.damage = 2;
            this.defence = 1;
        }

        

    }       //class Slime


    class Wolf : Monster {
        public Wolf() {
            this.name = "늑대";
            this.hp = 200;
            this.damage = 3;
            this.defence = 1;
        }

        public String Name {
            get { return this.name; }
            set { this.name = value; }
        }
        


        //public void MoveAndAttack() {
        //    this.Move(this.name);
        //    this.Attack(this.name, this.damage);
        //}


    }       //class Wolf



}
