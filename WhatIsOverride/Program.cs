namespace WhatIsOverride {
    internal class Program {
        static void Main(string[] args) {
            //Parent parent = new Parent();
            //parent.Say();
            //parent.Run(); 
            //parent.Walk(10);

            //Child child = new Child();
            //child.Say();
            //child.Run();
            //child.Walk(10);


            //StoreButton storeButton = new StoreButton();
            //storeButton.OnClickButton();

            //QuestButton questButton = new QuestButton();
            //questButton.OnClickButton();

            Slime slime = new Slime();
            //slime.Name = "kkk";
            Console.WriteLine("[Main] 슬라임 클래스에서 필드를 가져옴 -> {0}", slime.Name);
            

        }
    }
}