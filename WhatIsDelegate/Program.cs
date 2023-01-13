namespace WhatIsDelegate {
    internal class Program {
        static void Main(string[] args) {
            Delegate desc = new Delegate(); 
            //desc.Hi();
            desc.DelegateDesc();

            desc.Test("aaa", Abcd, PrintUserInfo, Zxcv);
            
        }


        static void Abcd() {
            Console.WriteLine("abcd");
        }

        static public void PrintUserInfo() {
            Console.WriteLine("qwer");
        }

        static public int Zxcv(int x) {
            return x + 100;
        }

    }
}