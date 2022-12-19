using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace GameProgram
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //Console.Write("현재 가지고 있는 돈 : ");
            //String money = Console.ReadLine();

            //int moneyInt = default;
            //int.TryParse(money, out moneyInt);
            //const int PRICE_CANDY = 300;
            
            //int candyAmount = moneyInt / PRICE_CANDY;
            //int leftmoney = moneyInt % PRICE_CANDY;

            //Console.WriteLine("최대로 살 수 있는 캔디의 개수 : {0}", candyAmount);
            //Console.WriteLine("캔디 구입 후 남은 돈 : {0}", leftmoney);

            ////(화씨온도 - 32) ÷ 1.8 = 섭씨온도

            //Console.Write("화씨 온도 입력: ");
            //String fTemp = Console.ReadLine();
            //// 문자열 제대로 들어 왔나 
            //float fTempFl = default;
            //float.TryParse(fTemp, out fTempFl);
            ////변환이 제대로 됐는지
            //float cTempFl = (fTempFl - 32.0f) / 1.8f;
            ////공식 계산이 제대로 됐는지 
            //Console.WriteLine("화씨 온도 {0}은 섭씨온도 {1}입니다.", fTempFl, cTempFl);
            

            //Random randomNum = new Random();
            //int randomNumInt1 = randomNum.Next(1, 7);
            //int randomNumInt2 = randomNum.Next(1, 6 + 1);
            //int sumRandomNum = randomNumInt1 + randomNumInt2;
            //Console.WriteLine("첫번째 주사위: {0}", randomNumInt1);
            //Console.WriteLine("두번째 주사위: {0}", randomNumInt2);
            //Console.WriteLine("두 주사위 찹: {0}", sumRandomNum);

            ///**
            // * 제어문 소개 
            // * 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차구조(순차문), 선택구조(조건문)
            // * 반복구조(반복문)가 있다. 
            // * 
            // * 순차문
            // * 프로그램은 기본적으로 Main() 메서드 시작 지점부터 끝 지점까지 코드가 나열되면 순서대로
            // * 실행 후 종료한다. 
            // * 
            // * 제어문 
            // * 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할깨 사용하는 구문으로 
            // * 조건문과 반복문으로 구분한다. 
            // * 
            // * 조건문(선택문) 
            // * 조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조이다. 분기문 또는 비교 판단문이라고
            // * 하기도 한다. 
            // * 
            // * 반복문
            // * 특정 명령문을 지정된 수만큼 반복해서 실행할때나 조건식이 참일 동안 반복 시킬떄 사용한다. 
            // */

            ///**
            // * if/else 
            // * 프로그램 흐름을 여러가지 갈래로 가지치기 할 수 있는데 이떄 if를 사용한다. 
            // * if는 조건을 비교해서 판단하는 구문으로 if, else if, else 세가지 키워드가 있다. 
            // */


            //int numberX, numberY;
            //Console.Write("x 값을 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberX);
            //Console.Write("y 값을 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberY);


            //if (numberY < numberX) {
            //    Console.WriteLine("x가 y보다 큽니다. ");
            //} else {
            //    Console.WriteLine("y가 x보다 큽니다. ");
            //}

            //Console.WriteLine("의미 없는 출력문");

            ///**
            // * 컵의 사이즈를 받아서 100ml 미만은 small, 100ml 이상 200ml 미만은 emdium, 200 이상은 large라고
            // * 출력하는 if else문을 작성 
            // * 
            // */

            //Console.Write("컵의 사이즈를 입력하시오: ");
            //int cupSize; 
            //int.TryParse(Console.ReadLine(), out cupSize);


            

            //if (0 < cupSize && cupSize < 100) {
            //    Console.WriteLine("small");
            //} else if(100 <= cupSize && cupSize < 200) {
            //    Console.WriteLine("medium");
            //} else if(cupSize>=200){
            //    Console.WriteLine("large");
            //} else {
            //    Console.WriteLine("잘못 입력 했습니다. ");
            //}

            
            String secretCode = "g";
            byte[] convertByte = Encoding.ASCII.GetBytes(secretCode);
            int convertByteInt;
            int.TryParse(convertByte[0].ToString(), out convertByteInt);


            while (true) {
                Console.Write("코드를 입력하시오: ");
                String answer = Console.ReadLine();
                
                byte[] convertByteAns = Encoding.ASCII.GetBytes(answer);
                int ansByteInt;
                int.TryParse(convertByteAns[0].ToString(), out ansByteInt);

                

                if (convertByteInt < ansByteInt) {
                    Console.WriteLine("뒤에 있음");
                } else if (convertByteInt > ansByteInt) {
                    Console.WriteLine("앞에 있음");
                } else {
                    Console.WriteLine("정답 비밀 코드는 {0}입니다.", secretCode);
                    break;

                }

            }

            //while (true) {
            //    try {
            //        Console.Write("3개의 정수를 입력하시오: ");
            //        String threeInt2 = Console.ReadLine();

            //        string[] threeIntwords2 = threeInt2.Split(" ");

            //        int num11, num22, num33;

            //        int.TryParse(threeIntwords2[0], out num11);
            //        int.TryParse(threeIntwords2[1], out num22);
            //        int.TryParse(threeIntwords2[2], out num33);

            //    } catch (IndexOutOfRangeException e) {
            //        Console.Write("야 다시해");
            //        break;
            //    }
            //}
            

            
            String threeInt = Console.ReadLine();

            string[] threeIntwords = threeInt.Split(" ");

            int num1, num2, num3;

            int.TryParse(threeIntwords[0], out num1);
            int.TryParse(threeIntwords[1], out num2);
            int.TryParse(threeIntwords[2], out num3);

            if(num1 >= num2 && num1 >= num3) {
                Console.WriteLine("첫번쨰가 큽니다");
            } else if(num2 >= num1 && num2 >= num3){
                Console.WriteLine("두번쨰가 큽니다");
            } else if(num3 >= num1 && num3 >= num2) {
                Console.WriteLine("세번쨰가 큽니다");
            }




        }

    }
}
