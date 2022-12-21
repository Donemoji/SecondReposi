//system 이라는 어셈블리에서 이것 저것 여러 기능을 가져와서 사용한다.
using System;
using System.Runtime.InteropServices;

//내 프로그램 이름이다. 내가 정했다.
namespace WhatisArray {
    //클래스 라는 것인데, C# 에서는 모든 요소들이 클래스 안에 있어야 한다. 
    internal class Program {
        //무조건 한개는 있어야 한다. -> C# 콘솔을 사용할때
        static void Main(string[] args) {


            ////3의 배수를 제외한 수 
            //int sumOfNum = 0; 
            ////int variable_ = 100;



            //for (int variable_ = 1; variable_ <= 100; variable_++) {

            //    bool isRealMultipleofThree = (variable_ % 3 == 0);
            //    Console.WriteLine("{0} -> isRealMultipleofThree: {1}",
            //        variable_, isRealMultipleofThree);

            //    //1 ~ 100 숫자 중에서 3의 배수를 제외한 수의 합 구하기
            //    if (isRealMultipleofThree == false) {

            //        //3의 배수가 아닌건 다 여기로 온다. 
            //        sumOfNum += variable_;
            //        Console.WriteLine("잘 더해지고 있나? : {0}", sumOfNum);

            //    } else {


            //    }


            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("=========================");
            //Console.WriteLine("sumOfNumber : {0}", sumOfNum);
            //Console.WriteLine("=========================");




            //string personalGender = "여자";
            //if (personalGender.Equals("남자")) {
            //    // 조건문 a가 참이면 여기로 온다. 
            //    // 조건문 a가 여기서부터 읽기 시작한다. 
            //    Console.WriteLine("남자구나");
            //    // 조건문 a가 여기서 끝난다.
            //}else if(personalGender == "여자") {
            //    // 조건문 b가 참이면 여기로 온다. 
            //    // 조건문 b가 여기서부터 읽기 시작한다. 
            //    Console.WriteLine("여자구나");
            //    // 조건문 b가 여기서 끝난다.
            //} else {
            //    //저 조건문이 거짓이면 여기로 온다
            //}

            ////조건문을 실행했으면 이제 다시 여기서 부터 프로그램 시작
            //for(int index =1; index <= 50; index++) {
            //    Console.WriteLine();
            //}

            //// 프로그램 사용자로부터 양의 정수를 하나 입력 받아서
            //// 그 수만큼 'hello world!'를 출력하는 프로그램 작성 
            //int someNum = 100;
            //bool isPositiveInteger = ( 0 < someNum ); 

            ///**
            // * 프로그램 사용자로부터 계속해서 정수를 입력받는다 
            // * 그리고 그 값은 계속해서 더해 나간다. 이러한 작업은
            // * 프로그램 사용자가 0을 입력할때까지 계속되어야 하며
            // * 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료 
            // */ 

            //bool isNumZero = ( someNum== 0 );


            //// 프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단 출력 
            //// 역순으로 출력하는 프로그램 작성
            //int userInputNum = 3; 
            //for(int index = 9; index >= 1; index--) {
            //    Console.WriteLine("{0} * {1} = {2}", 
            //        userInputNum, index, userInputNum * index);
            //}


            ////컴퓨터 시크릿 코드 추적, 앞에 있는지 뒤에 있는지 리턴
            //char secretCode = 'y';
            //char userInputAlphabet = '#';

            //Boolean isSmaillAlphabet =
            //    ('a' <= userInputAlphabet && userInputAlphabet <= 'z');

            //Boolean isAlphabetFore = (userInputAlphabet <= secretCode); 
            //Boolean isAlphabetBack = (userInputAlphabet >= secretCode);


            //if(isSmaillAlphabet) {

            //} else {
            //    Console.WriteLine("{0} {1}",
            //        "[System] 당신의 입력은 처리할 수 없습니다.",
            //        "알파벳 소문자 만을 입력해주세요");
            //}

            //if (isAlphabetFore) {
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다.");

            //} else {

            //}

            //if(isAlphabetBack) {
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 뒤에 있습니다.");
            //}

            // 1~100 숫자 중에서 3의 배수이면서 4의 배수인 정수 합 구하기 
            //int sumNum = 0;
            //int multiNum = 100;
            //bool isMultipleofThree = (multiNum % 3 == 0); 
            //bool isMultipleofFour = (multiNum % 4 == 0);

            //bool isTrue = isMultipleofThree && isMultipleofFour;

            //if (isTrue) {
            //    sumNum += multiNum; 
            //}


            //.gitignore git에 ignore안에 있는 파일을 안올린다.

            // 별을 100번 찍는법 
            //String star = "**********";
            //Console.WriteLine("{0} {1} {2} {3} {4}", 
            //    star, star, star, star, star);
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    star, star, star, star, star);

            //for(int index = 1; index <=100; index++) {
            //    Console.Write("{0} ", "*");
            //}



            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //for (int index = 1; index <= 10; index++) {

            //    for(int index2 = 1; index2 <= 10; index2++) {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();

            //}


            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //int hundredCnt = 0;

            //for (int index = 1; index <= 10; index++) {

            //    for (int index2 = 1; index2 <= 10; index2++) {

            //        for(int index3 = 1; index3 <= 10; index3++) {
            //            hundredCnt++;
            //            if(100 < hundredCnt) {
            //                break;
            //            } else {

            //            }
            //            Console.Write("* ");

            //            //여기서 10번마다 한줄을 찍어 줄것임 
            //            if(hundredCnt%10 == 0) {
            //                Console.WriteLine();
            //            }


            //        }//1oop1이 0번 도는 동안 2번 루프가 100번 돌고 그 동안 10번 돈다 

            //    }//loop1이 1번 도는 동안 10번 돈다

            //}//loop1 10번 돈다.

            //int rowInputNum = 0;
            //int.TryParse(Console.ReadLine(), out rowInputNum);

            //for(int index = 1; index <=rowInputNum; index++) {
            //    for(int index2 = 1; index2 <=index; index2++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("정수 입력: ");
            //int rowInputNum2 = 0;
            //int.TryParse(Console.ReadLine(), out rowInputNum2);



            //for (int i = 0; i < 3; i++) {
            //    for (int a = i; a < 3-1; a++) {
            //        Console.Write("@");
            //    }
            //    for(int j = 0; j <= (i*2); j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 3-1; i > 0; i--) {
            //    for (int a = i; a < 3; a++) {
            //        Console.Write("^");
            //    }
            //    for (int b = 0; b <= (i-1)*2; b++) {
            //        Console.Write("*");

            //    }

            //    Console.WriteLine();

            //}

            //int userinputRow = 0;
            //Console.Write("다이아몬드를 만들자.. 다이아몬드 줄 수를 입력하시오 : ");
            //int.TryParse(Console.ReadLine(), out userinputRow);

            //if(userinputRow % 2 ==0) {
            //    // 짝수
            //    // 입력한 수 보다 한줄 감소한 다이아몬드 출력 
            //    Console.WriteLine("대칭이 안맞습니다. 입력한 {0} 줄 보다 한줄 감소한 {1} 줄 다이아몬드 출력", 
            //        userinputRow, userinputRow -1);
                
            //    int rowUp, rowDown;
            //    rowUp = userinputRow / 2;
            //    rowDown = (userinputRow / 2)-1;


            //    //홀수

            //    for (int idx1 = 0; idx1 < rowUp; idx1++) {
            //        for (int idx2 = idx1; idx2 < rowUp; idx2++) {
            //            Console.Write(" ");
            //        }
            //        for (int idx3 = 0; idx3 < (idx1 * 2) + 1; idx3++) {
            //            Console.Write("*");

            //        }
            //        Console.WriteLine();
            //    }


            //    //짝수
            //    //4,2,
            //    for (int idx1 = rowDown; idx1 > 0; idx1--) {
            //        for (int idx2 = idx1; idx2 < rowDown + 2  ; idx2++) {
            //            Console.Write(" ");
            //        }
            //        for (int idx3 = 0; idx3 < (idx1*2)-1 ; idx3++) {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();
            //    }



            //} else {
            //    // 홀수
            //    int rowUp, rowDown;
            //    rowUp = (userinputRow / 2) + 1;
            //    rowDown = userinputRow / 2;

            //    for (int idx1 = 0; idx1 < rowUp; idx1++) {
            //        for (int idx2 = idx1; idx2 < rowUp; idx2++) {
            //            Console.Write(" ");
            //        }
            //        for (int idx3 = 0; idx3 < (idx1 * 2) + 1; idx3++) {
            //            Console.Write("*");

            //        }
            //        Console.WriteLine();
            //    }


            //    //홀수
            //    //3,2,1
            //    for (int idx1 = rowDown; idx1 > 0; idx1--) {
            //        for (int idx2 = idx1; idx2 < rowDown + 2; idx2++) {
            //            Console.Write(" ");
            //        }
            //        for (int idx3 = 0; idx3 < (idx1 * 2) - 1; idx3++) {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();
            //    }




            //}




            //for (int index = 0; index < 5; index++) {
            //    for (int index2 = index; index2 <= 5; index2++) {
            //        Console.Write("/");
            //    }
            //    for (int index3 = 0; index3 <= (index * 2); index3++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int index = 4; index > 0; index--) {
            //    for (int index2 = index; index2 <= 6; index2++) {
            //        Console.Write("%");
            //    }
            //    for (int index3 = 0; index3 <= ((index - 1) * 2); index3++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            Random random = new Random();

            int answerHund, answerTen, answerOne;
            int answer = 0; 

            while (true) {
                answer = random.Next(0, 1000);
                
                answerHund = answer / 100;
                answerTen = (answer / 10) % 10;
                answerOne = (answer % 10);
                bool isEqual = answerHund.Equals(answerTen) || answerHund.Equals(answerOne) || answerTen.Equals(answerOne);

                if (isEqual) {

                } else {
                    break;
                }
            }
            
            Console.WriteLine("숫자 야구 입니다. 세자리 숫자를 맞춰보자");

            int inputAnswer = 0;
            int inputHund, inputTen, inputOne;

            int strikeCnt = 0;
            int ballCnt = 0;
            int outCnt = 0;

            Console.WriteLine("컴퓨터 설정 숫자: {0}", answer);


            for (int idx = 0; idx < 9; idx++) {

                Console.Write("{0}회 숫자 입력: ", idx+1);
                
                int.TryParse(Console.ReadLine(), out inputAnswer);
                inputHund = inputAnswer / 100;
                inputTen = (inputAnswer / 10) % 10;
                inputOne = (inputAnswer % 10);



                //100자리
                if (answerHund == inputHund) {
                    //스트라이크
                    strikeCnt++;
                } else if(answerTen == inputHund) {
                    //볼
                    ballCnt++;
                } else if(answerOne == inputHund) {
                    //볼
                    ballCnt++;
                } else {
                    //숫자가 없다 
                    outCnt++;
                }

                //10자리
                if (answerTen == inputTen) {
                    //스트라이크
                    strikeCnt++;
                } else if (answerHund == inputTen) {
                    //볼
                    ballCnt++;
                } else if (answerOne == inputTen) {
                    //볼
                    ballCnt++;
                } else {
                    //숫자가 없다
                    outCnt++;
                }

                //1자리
                if (answerOne == inputOne) {
                    //스트라이크
                    strikeCnt++;
                } else if (answerTen == inputOne) {
                    //볼
                    ballCnt++;
                } else if (answerHund == inputOne) {
                    //볼
                    ballCnt++;
                } else {
                    //숫자가 없다
                    outCnt++;
                }


                if(outCnt == 3) {
                    Console.WriteLine("아웃 입니다.");
                    if (idx == 8) {
                        Console.WriteLine("게임오버.... 정답은 {0} 입니다.", answer); ;
                    }
                } else if (strikeCnt == 3) {
                    Console.WriteLine("3S 입니다. 플레이어 승리!");
                    break;
                }else {
                    Console.WriteLine("{0}S {1}B 입니다.", strikeCnt, ballCnt);
                    if(idx == 8) {
                        Console.WriteLine("게임오버.... 정답은 {0} 입니다.", answer); ;
                    }
                }
                

                outCnt = 0;
                ballCnt = 0;
                strikeCnt = 0;


            }



            //프로그램 끝
        }
    }
}