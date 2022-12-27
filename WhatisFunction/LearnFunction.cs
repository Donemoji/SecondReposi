using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatisFunction {
    internal class LearnFunction {


        static int number1 = 1; 
        static int number2 = 3;


        public static void Main() {


            //int value = 100; 


            //Console.WriteLine(value);
            //value = Hi(); 
            //Console.WriteLine(value);

            //Hi("Hi I'm WJ Lee");

            //showMessage("매개변수");
            //showMessage("파라미터를 넘겨준다.");


            //String returnValue = GetString();
            //Console.WriteLine(returnValue);


            //int r = SquareFunction(14);
            //Console.WriteLine(r);

            //int plusValue = getPlus(1,2);
            //Console.WriteLine(plusValue);

            //int[] valueBundle = getValue(-1, 2);
            //Console.WriteLine("큰 값: {0}\n작은 값:{1}\nnum1 절댓값:{2}\nnum2 절댓값:{3}",
            //    valueBundle[0], 
            //    valueBundle[1], 
            //    valueBundle[2], 
            //    valueBundle[3]);


            //Multi();
            //Multi("반갑습니다.");
            //Multi("또 만나요.", 3);


            //Console.WriteLine("Factorial: {0}", Factorial(4));

            int number1_ = 10; 
            int number2_ = 30;

            Swap(number1, number2);

            Console.WriteLine("Main의 number 값은?: {0}, {1}", number1, number2);


        }       //Main()



        static void Swap(int intValue1, int intValue2) {

            Console.WriteLine("바뀌기 전의 값: {0}, {1}", intValue1, intValue2);

            int temp; 
            temp = intValue1;
            intValue1 = intValue2; 
            intValue2 = temp;

            Console.WriteLine("바뀐 후의 값: {0}, {1}", intValue1, intValue2);


        }


        static int[] getValue(int num1, int num2) {
            
            int greaterNum, smallerNum, absoluteNum1, absoluteNum2;

            

            if (num1 > num2) {
                greaterNum = num1;
                smallerNum = num2;
            } else {
                greaterNum = num2;
                smallerNum = num1;
            }
            


            if (num1 > 0) {
                absoluteNum1 = num1;
            } else {
                absoluteNum1 = num1 * -1;
            }

            if (num2 > 0) {
                absoluteNum2 = num2;
            } else {
                absoluteNum2 = num2 * -1;
            }


            return new int[4] {greaterNum, smallerNum, absoluteNum1, absoluteNum2};


        }

        static int getPlus(int num1, int num2) {
            return num1 + num2;
        }


        // Hi world 출력하는 사용자 정의 함수
        static void show() {

            /**
             * 함수 (Function) 또는 메서드 (Method)는 
             * 재사용을 목적으로 만든 특정 작업을 수행하는 코드 블록이다. 
             * 
             * 함수를 부르는 다양한 명칭 
             * 함수 (Function)
             * 메서드 (Method)
             * 프로시저 (Procedure)
             * 서브 루틴 (Sub Routine) 
             * 서브 모듈 (Sub Module) 
             * 
             * 프로그래밍을 하다 보면 같은 유형의 코드를 반복할때가 많다. 
             * 이 코드들을 매번 입력하면 불편하고 입력하다가 실수도 할 수 있다.
             * 이때 '함수'를 사용한다. 
             * 
             * 프로그래밍 언어에서 함수는 어떤 동박 및 행위를 표현한다. 
             * 함수의 사용 목적은 코드 재사용에 있다. 
             * 한번 만들어놓은 함수는 프로그램에서 한 번 이상 사용할 수 있다. 
             * 지금까지 사용한 Main() 메서드는 C#의 시작 지점을 나타내는 
             * 특수한 목적의 함수로 볼 수 있다. 
             * 또, Console 클래스의 WriteLine 메서드도 함수로 볼 수 있다. 
             * 
             * - 함수란 어떤 값을 받아서 그 값을 가지고 가공을 거쳐 
             * 어떤 결과 값을 반환시켜 주는 코드 이다. 
             * - 함수는 프로그램 코드 내에서 톡정한 기능을 처리하는 
             * 독립적인 하나의 단위 또는 모듈을 가리킨다.
             * 
             * 입력 -> 처리 -> 출력 
             * 
             * 함수의 종류 (내장 함수와 사용자 정의 함수) 
             * 함수에는 내장 함수와 사용자 정의 함수가 있다. 
             * 내장 함수는 C#이 자주 사용하는 기능을 미리 만들어서
             * 제공하는 함수로 특정 클래스의 함수로 표현된다. 
             * 내장 함수도 그 용도에 따라 문자열 관련 함수, 날짜 및 시간 관련 함수, 
             * 수학 관련 함수, 형식 변환 관련 함수, 등으로 나눌 수 있다. 
             * 이러한 내장 함수를 API(Application Programming Interface)로 표현한다. 
             * 
             * 사용자 정의 함수는 내장 함수와 달리 프로그래머가 필요할 때마다 새롭게 기능을 
             * 추가 하여 사용하는 함수이다.
             * 
             * 함수 정의하고 사용하기 
             * 함수 정의(Define)는 함수를 만드는 작업이다. 함수 호출(Call)은 함수를 사용하는
             * 작업이다. 
             * 함수 생성 및 호출은 반드시 소괄호가 들어간다. 
             * 함수를 정의하는 형태는 지금까지 사용한 Main() 메서드와 유사하다. 
             * 다음 코드는 함수를 만드는 가장 기본적인 형태를 보여준다. 
             * 
             * static void [함수이름](){
             *     함수 내용
             * }
             * 
             * 만든 함수를 호출하는 형태는 다음 세가지가 있다. 
             * [함수이름](); 
             * [함수이름](매개변수); 
             * 변수(결과값) = [함수이름](매개변수);
             * 
             */

            Console.WriteLine("Hi World"!);
            
            /**
             * 
             * 이 함수는 가장 간단한 형태의 함수로, 매개변수(Parameter)도 없고
             * 반환값(Return Value)도 없는 형태이다. 
             * 
             */ 

        }

        static int Hi() {

            /**
             * 함수를 만들고 반복해서 사용하기 
             * 함수를 만드는 목적 중 하나는 반복 사용에 있다. 
             * 함수를 만들고 여러번 호출해서 사용하는 방법을 알아보자. 
             */

            Console.WriteLine("안녕하세요!");

            return 0;
        }

        

        static int Hi(String text) {

            Console.WriteLine(text);
            
            return 0;
        }

        static int ParameterAndReturn() {
            
            /**
             * 함수를 만들어 놓고 기능이 동일한 함수만 사용하지는 않는다. 
             * 호출할때마다 조금씩 다른 기능을 적용할때는 함수의 매개변수를
             * 달리하여 호출 할수 있다. 
             * 매개변수 (인자, 파라미터)는 함수에 어떤 정보를 넘겨주는 데이터를 나타낸다. 
             * 이러한 매개변수는 콤마를 기준으로 여러개 설정할 수 있으며, 문자열의 숫자 등 모든 데이터 
             * 형식을 사용 할 수 있다. 
             * 
             * 매개변수(인자, 파라미터)가 없는 함수: 매개 변수도 없고 리턴도 없는
             * 함수 형태는 가장 단순한 형태의 함수이다. 
             * 앞에서 사용한 함수 중에서 모든 변수에 있는 값을 문자열로 변환시키는
             * ToString() 메서드 처럼 빈 괄호만 있는 함수 형식을 나타낸다. 
             * 
             * 매개변수가 있는 함수: 특정 함수에 인자 값을 1개 이상 전달 하는 방식이다. 
             * 정수형, 실수형, 문자형, 문자열형, 개체ㅔ형 등 여러가지 데이터 형식을 인자 값으로
             * 전달할 수 있다.
             * 
             * 반환값이 있는 함수(결과값이 있는 함수, 리턴이 있는 함수): 함수의 처리 결과를 함수를 호출한
             * 쪽으로 반환할때는 return 키워드를 사용하여 데이터를 돌려 줄 수 있다. 
             * 
             * 매개변수가 가변(여러개)적인 함수: C#에서는 클래스 하나에 매개변수의 형식과 
             * 개수를 달리하여 이름이 동일한 함수를 여러개 만들수 있다. 이를 가리켜 함수 중복 
             * 또는 함수 오버로드(overload)라고 한다. 
             * 
             */

            return 0;

        }



        static void showMessage(String msg) {
            Console.WriteLine(msg);
        }

        static String GetString() {
            return "반환값, Return Value";
        }

        static int SquareFunction(int x) {
            int r = x * x; 
            return r;
        }

        static void FunctionOverloading() {
            /** 
             * 함수 오버로드: 다중 정의 
             * 클래스 하나에 매개변수를 달리해서 이름이 동일한 함수 여러개를 
             * 정의할 수 있는데. 이를 함수 오버로드라고 한다.. 
             * 우리말로는 여러번 정의 한다는 의미 이다. 
             */ 
            
        }


        //숫자를 받아서 출력하는 함수 
        /**
         * @param num int type number for print
         */
        static void GetNumber(int num) {
            Console.WriteLine("Int32: {0}", num);
            Console.WriteLine("4바이트 정수: {0}", num);
        }

        /**
         * @param num long type number for print
         */
        static void GetNumber(long num) {
            Console.WriteLine("Int64: {0}", num);
            Console.WriteLine("8바이트 정수: {0}", num);
        }

        static void Multi() {
            Console.WriteLine("안녕하세요..");

        }
        
        static void Multi(String msg) {
            Console.WriteLine(msg);
        }

        static void Multi(String msg, int count) {
            for(int idx = 0; idx < count; idx++) {
                Console.WriteLine("{0}", msg);
            }
        }

        static void RecursiveFunction() {
            /**
             * 재귀 함수 
             * 함수에서 함수 자신을 호출하는 것을 재귀(Recursion) 또는
             * 재귀 함수 라고 한다. 
             */
        }

        static int Factorial(int num) {

            //탈출 조건
            if(num == 0 || num == 1) {
                return 1;
            }
            Console.WriteLine("n의 값은 {0}", num);
            return num * Factorial(num - 1); // 여기서 재귀 호출 

        }
        
        static void FunctionScope() {
            
            /**
             * 함수 범위: 전역변수와 지역변수
             * 클래스와 같은 레벨에서 선언된 변수를 전역변수(global variable) 또는 필드 라고 하며 
             * 함수 레벨에서 선언된 변수를 지역 변수(local variable)라고 한다. 
             * 이때 동일한 이름으로 변수를 전역 변수와 함수 내의 지역 변수로 
             * 선언 할 수 있다. 
             * 함수내에서는 함수 범위에 있는 지역 변수를 사용하고, 함수 범위 내에 선언된 
             * 변수가 없으면 전역 변수 내에 선언된 변수를 사용한다. 
             * 단, C# 에서는 전역 변수가 아닌 필드라는 단어를 주로 사용하며, 전역 변수는 
             * 언더 스코어(_) 또는 m_ 접두사를 붙이는 경향이 있다. 
             */ 
             
        }

        static void ArrowFunction() {
            
            /**
             * 화살표 함수 
             * 화살표 모양의 연산자인 화살표 연산자 (=>)를 사용하여
             * 메서드 코드를 줄일 수 있다. 
             * 이를 화살표 함수 라고 한다. 
             * 프로그래밍에서 화살표 함수 또는 화살표 메서드는 
             * 람다식 (Lamda Expression)의 또다른 이름이다.
             * 화살표 함수를 사용하면 함수를 줄여서 표현할 수 있다. 
             * 함수 고유의 표현을 줄여서 사용하면 처음에는 어색할 수 있다. 
             * 하지만 이 방식에 익숙해지면 차후에는 코드의 간결함을 유지할 수 있다. 
             */ 

        }

        



    }       // class
}