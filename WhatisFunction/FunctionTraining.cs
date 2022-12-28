using System;

namespace WhatisFunction {
    internal class FunctionTraining {
        public static void Main() {


            SayHello(3);
            Console.WriteLine("최대 값은 : {0}", Maximum(10, 8, 3));
            Console.WriteLine("직각 삼각형 빗변의 길이는 : {0:F4}", Hypot(1.2, 2.8));
            Console.WriteLine("직각 삼각형 빗변의 길이는 : {0}", Math.Round(Hypot(1.2, 2.8), 2));

            Prime();
            TelephoneNumber();


            Console.Write("문자를 입력하시오.. ");
            ReverseString(Console.ReadLine());



        }

        public static void ReverseString(String stringValue) {

            char[] temp = new char[stringValue.Length];
            int idx = 0;
            

            foreach (char character in stringValue) {
                temp[idx] = character;
                idx++;
            }

            for(int idx1 = temp.GetUpperBound(0); idx1 >= 0; idx1--) {
                Console.Write(temp[idx1]);
            }
            
            

            







        }
        public static void TelephoneNumber() {

            while (true) {

                Console.Write("전화 번호를 입력하시오: ");
                String phoneNumStr = Console.ReadLine();
                phoneNumStr = phoneNumStr.Replace("(", "");
                phoneNumStr = phoneNumStr.Replace(")", "");
                Console.WriteLine(phoneNumStr);

                if (phoneNumStr == "quit") {
                    break;
                }

            }

        }


        public static void SayHello(int num1) {

            for (int i = 0; i < num1; i++) {

                Console.WriteLine("SayHello!");

            }

        }


        public static int Maximum(int num1, int num2, int num3) {

            int[] bundle = new int[3] { num1, num2, num3 };

            for (int i = 0; i < bundle.Length; i++) {

                for (int k = 0; k < bundle.Length; k++) {

                    if (bundle[i] > bundle[k]) {
                        int temp = bundle[i];
                        bundle[i] = bundle[k];
                        bundle[k] = temp;

                    }

                }

            }

            return bundle[0];

        }


        public static double Hypot(double num1, double num2) {

            double resultofPow = (num1 * num1) + (num2 * num2);

            return Math.Sqrt(resultofPow);

        }

        public static void Prime() {

            Console.Write("2 ~ 100사이의 숫자 중에서 소수는 : ");

            for (int i = 2; i < 100 + 1; i++) {
                Boolean isPrime = checkPrime(i);
                
                if (isPrime) {
                    Console.Write(" {0} ", i);
                }
            }

            Console.WriteLine();

        }

        public static Boolean checkPrime(int num) {

            Boolean isPrime = true;

            for (int i = 2; i < num; i++) {

                if (num % i == 0) {
                    isPrime = false;
                }

            }

            return isPrime;

        }


    }
}
