using System.Collections;

namespace AdventureStory {
    internal class Program {
        static void Main(string[] args) {
            

            //플레이어 스탯
            int luckStat = 10;
            int strStat = 10;
            int dexStat = 8;
            int healthStat = 5;
            int playerLifeCnt = 5;

            //플레이어 특정 선택지 확률 (luck)에 따라 가변적 
            float luckSucPercentage = (float)luckStat * 3.5f;


            //몬스터 스탯
            int oppoStrStat = 1;
            int oppoDexStat = 1;
            int oppoHealthStat = 1;

            //전투 관련 

            //플레이어와 몬스터 체력
            int playerHp = healthStat * 100;
            int oppoHp = oppoHealthStat * 100;

            //플레이어와 몬스터의 회피 확률 dex에 따라 가변적 (1.5도 dex에 따른 범위 지정해서 random 해야함)
            float avoidDamagePercent = (float)dexStat * 1.5f;
            float oppoAvoidDamagePercent = (float)oppoDexStat * 1.5f;

            //플레이어와 몬스터의 회피 체크
            float isPlayerAvoid;
            float isOppoAvoid;

            //공격 부분, str에 따라 가변적 (3.0도 str에 따른 범위 지정해서 random 해야함) 
            float attackDamage = (float)strStat * 3.0f;
            float oppoAttackDamage = (float)oppoStrStat * 3.0f;

            //다음으로 넘어갈건지
            Boolean isNext = false;

            //switch문 동작키
            int optionChoice = 0;

            //옵션에 따른 동작 코드
            bool isOption1LuckSuc = false;
            bool isOption2Suc = false;
            bool isOption3Suc = false;
            bool isOption4Suc = false;

            //싸울건지 말건지 코드
            bool isFight = false;


            ArrayList inventoryList = new ArrayList();
            ArrayList itemList = new ArrayList();

            Random rndPercent = new Random();

            int isValidKey = 0;



            Console.WriteLine("=======================");
            Console.WriteLine("=======================");
            Console.WriteLine("=====모험가 이야기=====");
            Console.WriteLine("=======================");
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            String tapToStart = default;
            Console.Write("     Tap to Start");
            tapToStart = Console.ReadLine();
            Console.WriteLine("FFFFFFFFFF" + tapToStart);
            if (tapToStart.Equals(default)) {

            } else {


                Console.Clear();
                

            }



            Console.WriteLine("블라 블라 어쩌고 저쩌고 어쩔래?");
            Console.WriteLine("1, 칼을 챙긴다..");
            Console.WriteLine("성공 확률 {0}%", luckSucPercentage);
            Console.WriteLine("2, 명복을 빈다..");
            Console.WriteLine("3, 싸울 준비를 한다..");
            



            
            int.TryParse(Console.ReadLine(), out optionChoice);
            


            
            switch (optionChoice) {

                case 1:

                    //luck에 따른 확률 계산
                    int temp = rndPercent.Next(0, 100);

                    if (temp < luckSucPercentage) {
                        //성공
                        isOption1LuckSuc = true;
                    } else {
                        //실패
                        isOption1LuckSuc = false;
                    }


                    if (isOption1LuckSuc) {
                        //성공했을시 이벤트 발생후 스위치 종료
                        Console.WriteLine("무한의 대검을 획득했다!");
                        Console.WriteLine("힘 스탯이 {0}에서 {1}로 증가했다.", strStat, strStat + 1);
                        
                        inventoryList.Add("무한의 대검");
                        
                        ArrayList tempItem = new ArrayList();
                        tempItem.Add("무한의 대검");
                        tempItem.Add("str");
                        tempItem.Add(1);
                        itemList.Add(tempItem);

                        isNext= true;

                        break;


                    } else {
                        //실패했을시 이벤트 발생후 스위치 종료

                        Console.WriteLine("부러진 검이다 부시자!");
                        isNext = true;
                        break;

                    }


                case 2:
                    isNext = true;
                    Console.WriteLine("주 하나님 블라 블라 명복을 빕니다..");
                    break;


                case 3:
                    Console.WriteLine("당신은 ~~~ 덤벼들었다!");
                    Console.WriteLine("1. 전투 시작..");
                    Console.WriteLine("2. 도망 간다..");

                    int choice3_1 = 0;
                    int.TryParse(Console.ReadLine(), out choice3_1);

                    switch (choice3_1) {
                        case 1:
                            isFight = true;
                            Console.Clear();
                            Console.WriteLine("================전투 시작================");
                            break;
                        case 2:
                            Console.WriteLine("도망가자..");
                            isFight = false;
                            isNext = true;
                            break;

                    }

                    break;

            }




            while (isFight) {
                

                if (oppoHp <= 0 || playerHp <= 0) {
                    break;

                } else {
                    //fight
                    //회피 계산
                    
                    isOppoAvoid = rndPercent.Next((int)0, 100);

                    if (playerHp <= 0) {
                        //플레이어 죽으면 반복문 탈출
                        Console.WriteLine("플레이어 패배!");
                        if (playerLifeCnt<=0) {
                            isNext = false;
                            Console.WriteLine("게임 오버..");
                        } else {
                            isNext = true;
                            playerLifeCnt--;

                        }
                        
                        break;
                    } else {
                        //플레이어 공격

                        if (oppoAvoidDamagePercent >= isOppoAvoid) {
                            //적 회피
                            Console.WriteLine("적 회피했다.. ");
                            Console.WriteLine("플레이어 체력: {0}  ", playerHp);
                            Console.WriteLine("몬스터 체력: {0}  ", oppoHp);
                        } else {
                            //데미지 들어간다
                            Console.WriteLine("몬스터에게 {0}의 데미지가 들어갔다!! ", (int)attackDamage);

                            oppoHp -= (int)attackDamage;

                            if (oppoHp <= 0) {
                                oppoHp = 0;
                                Console.WriteLine("플레이어 체력: {0}  ", playerHp);
                                Console.WriteLine("몬스터 체력: {0}  ", oppoHp);
                                isNext = true;

                            } else {
                                Console.WriteLine("플레이어 체력: {0}  ", playerHp);
                                Console.WriteLine("몬스터 체력: {0}  ", oppoHp);



                            }


                        }
                    }

                    //회피 계산
                    isPlayerAvoid = rndPercent.Next((int)0, 100);


                    if (oppoHp <= 0) {
                        //적이 죽으면 반복문 탈출
                        Console.WriteLine("플레이어 승리!");

                        break;

                    } else {
                        //몬스터 공격

                        if (isPlayerAvoid <= avoidDamagePercent) {
                            //플레이어 회피
                            Console.WriteLine("플레이어 회피했다.. ");
                            Console.WriteLine("플레이어 체력: {0}  ", playerHp);
                            Console.WriteLine("몬스터 체력: {0}  ", oppoHp);
                        } else {
                            //플레이어에게 데미지 들어간다.
                            Console.WriteLine("플레이어에게 {0}의 데미지가 들어갔다!! ", (int)oppoAttackDamage);

                            playerHp -= (int)oppoAttackDamage;

                            if (playerHp <= 0) {
                                playerHp = 0;
                                Console.WriteLine("플레이어 체력: {0}  ", playerHp);
                                Console.WriteLine("몬스터 체력: {0}  ", oppoHp);
                                isNext = true;

                            } else {
                                Console.WriteLine("플레이어 체력: {0}  ", playerHp);
                                Console.WriteLine("몬스터 체력: {0}  ", oppoHp);

                            }
                        }
                    }



                    Console.ReadLine();


                }




            }
            
            //스테이지 2
            if (isNext) {
                String temp = Console.ReadLine();
                Console.WriteLine("enter 찍어보자.."+temp);
                if(temp.Equals(default)) {

                } else {
                    Console.Clear();
                    Console.WriteLine("스테이지 투");

                }
            }



        }



    }
}