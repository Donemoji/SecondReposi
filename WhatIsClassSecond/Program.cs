namespace WhatIsClassSecond {
    
    enum StageNumber {
        ONE = 0,
        TWO = 1,
        THREE = 2,
        FOUR = 3
    }
    enum GameProceed {
        START_HUNT = 1,
        GO_INVENTORY = 2, 
        QUIT =3
    }
    
    
    internal class Program {

        
        static void Main(string[] args) {

            //Description description = new Description(123);
            //description.ValueTypeAndReferenceType();
            //description.WhatIdField();

            //TrumpCard trumpCard = new TrumpCard();
            //trumpCard.RollCard();

            //Parent parent = new Parent();
            //parent.Print();

            //Child child = new Child();
            //child.PrintChild();

            //Slime slime= new Slime();
            //slime.MoveAndAttack();

            //Wolf wolf = new Wolf();
            //wolf.MoveAndAttack();


            Player player = new Player("티리엘", 1000, 50, 20);

            Knight knight;
            Boss boss;
            
            Fight fight = new Fight();
            ProceedWhat proceed = new ProceedWhat();

            int currentStage = 0;

            Object whoTheWinner;
            int procedure;



            //잡몹
            while (true) {
                procedure = proceed.WhatToProceed();

                
                if(procedure == (int)GameProceed.START_HUNT) {

                    knight = new Knight("안다리엘", 150, 10, 10);
                    boss = new Boss("디아블로", 200, 20, 10);

                    while (true) {
                        //사냥 시작 
                        if (currentStage == (int)StageNumber.ONE) {


                            whoTheWinner = fight.LetsFight(player, knight);

                            player = (Player)whoTheWinner;

                            if (player.getIsWin()) {
                                player.setIsWin(false);
                                currentStage++;
                                //knight = new Knight("안다리엘", 150, 10, 10);
                                break;

                            } else if ((player.getIsWin() == false) && player.getHp() <= 0) {
                                break;
                            }


                        }



                        if (currentStage == (int)StageNumber.TWO) {

                            whoTheWinner = fight.LetsFight(player, boss);

                            player = (Player)whoTheWinner;

                            if (player.getIsWin()) {
                                player.setIsWin(false);
                                //currentStage++;
                                currentStage = (int)StageNumber.ONE;
                                boss = new Boss("디아블로", 200, 20, 10);
                                break;
                            } else if ((player.getIsWin() == false) && player.getHp() <= 0) {
                                break;
                            }

                        }

                    }       // 게임 while
                    

                } else if(procedure == (int)GameProceed.GO_INVENTORY) {
                    //show inven
                    String[] inven = player.getInventory();
                    Console.Write("인벤토리: ");
                    foreach(String item in inven) {
                        Console.Write("{0} | ", item);
                    }
                    Console.WriteLine();

                } else if(procedure == (int)GameProceed.QUIT) {
                    break;
                } else {
                    //다시 입력 받기

                }

               




            }

            





           






        }       // Main()
    }
}