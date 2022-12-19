using System;

namespace GameProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string stringBinary = Convert.ToString(10, 2);
            Console.WriteLine(stringBinary);
            int intBinary = Convert.ToInt32("0111", 10);
            Console.WriteLine(intBinary);
            
            /**
             * 연산자
             * 데이터로 연산 작업을 수행할 때는 연산자(operator)를 사용한다. 연산자는 기능에 따라 
             * 대입, 산술, 관계 논리, 증감, 조건, 비트, 시프트 연산자 등으로 나누며, 
             * 이용 형태에 따라 항 1개로 연산을 하는 단항 연산자와 항 2개로 연산을 하는 이항 연산자, 
             * 항 3개로 연산을 하는 삼항 연산자로 나눈다. 
             * 
             * 단항 연산자
             * 단항 연산자는 연산자와 피 연산자 하나로 식을 처리한다. 
             * ex) [연산자] [피 연산자] 
             * + 연산자: 특정 정수형 변수 값을 그대로 출력한다. 
             * - 연산자: 특정 정수형 변수 값을 음수로 변경하여 출력한다. 음수값이 들어 있다면 양수로 변환한다
             * 
             * 이항 연산자
             * 이항 연산자는 연산자와 피연산자 2개로 식을 처리한다. 
             * ex) [피 연산자1] [연산자] [피연산자2] 
             * 
             * 삼항 연산자 
             * 삼항 연산자는 식 1개의 항과 그 결과에 따른 피연산자 각 1개씩 총 2개 항으로 식을 처리한다. 
             * ex) (식) ? 피연산자1 : 피연산자2
             * 
             * 식과 문 
             * 값 하나 또는 연산을 진행하는 구문의 계산식을 식(expression) 또는 표현식 이라고 한다. 
             * 표현식을 사용하여 명령 하나를 진행하는 구문을 문 또는 문장이라고 한다. 
             * 
             */

            //단항 연산자 
            const int PLUS_FIVE = +5;
            const int MINUS_FIVE = -5;

            //이항 연산자 
            const int PLUS_TEN = 5 + 5;

            //삼항 연산자 
            String compareTen = (PLUS_FIVE > 10) ? "{0}은 10보다 크다" : "{0}은 10보다 크지 않다";
            Console.WriteLine(compareTen, PLUS_FIVE);

            //변환 연산자 
            //() 기호를 사용하여 특성 값을 원하는 데이터 형식으로 변환할 수 있다. 
            const int PI_INT = (int)3.141592;
            const float PI_FLOAT = (float)3.141592;

            /**
             * 산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자 
             * 
             * 산술 연산자
             * 더하기, 빼기, 곱하기, 나누기, 나머지
             * 수학적 연산을 하는데 사용한다. 보통 정수 형식과 실수 형식의 연산에 사용한다. 
             * ex) +,-,*,/,%%%%%%%
             * 
             * 문자열 연결 연산자 
             * 산술 연산자 중 하나인 + 연산자는 피 연산자의 데이터 타입에 따라 산술 연산 또는 문자열 
             * 연결 연산을 수행한다. 
             * 
             * +연산자: 두항이 숫자일때는 산술(+) 연산 가능, 문자열 일떄는 문자열 연결 가능. 
             *
             * 연산자 오버로딩
             *
             */


            string addMsg = "string " + "plus " + "string"; 
            Console.WriteLine(addMsg);

            /**
             * 
             * 할당연산자 
             * 할당 연산자는 변수에 데이터를 대입 하는데 사용한다. 할당 연산자를 대입 연산자 라고도 한다. 
             * =기호는 같다는 의미가 아니라 오른쪽에 있는 값 또는 식의 결과를 왼쪽 변수에 할당하라고 지시 하는 것이다. 
             * 
             * ex) =, +=, -=, *=, /=, %= 
             * 
             * 증간 연산자 
             * 뱐수 값을 1증가 시키거나 1 감소 시키는 연산자 이다. 증감 연산자가 변수 앞에 위치 하느냐 뒤에 위치 하느냐에 
             * 따라 연산 처리 우선 순위가 결정된다. 
             * 
             * ++ 증가 연산자: 변수 값에 1을 더한다. 
             * -- 감소 연산자: 변수 값에 1을 뺀다 
             * 
             * 증감 연산자가 앞에 부붙으면 전위 증감 연산자 라고 하며, 변수 뒤에 붙으면 후위 증감 연산자 라고 한다. 
             * 
             * 전위 증감 연산자: 정수형 변수 앞에 연산자가 위치하여 변수 값을 미리 증감한 후 나머지 연산 수행 
             * 
             * 후위 증감 연산자: 정수형 변수 뒤에 연산자가 위치 하여 연산식(대입)을 먼저 실행한 후 나중에 
             * 변수 값을 증감 한다. 
             * 
             */

            int num = 0;
            num++; 
            Console.WriteLine(num);

            /**
             * 관계형 연산자 
             * 관계형 연산자 또는 비교 연산자는 두 항이 큰지 작은지 또는 같은지 등을 비교 하는데 사용한다. 
             * 관계형 연산자의 결과값은 논리 데이터 형식인 참 또는 거짓으로 출력된다. 
             * ex) <, <=, >, >=, ==, != 
             * 
             * 논리 연산자 
             * 논리 연산자 (Logical operator)는 논리곱(and), 논리합 (or), 논리 부정(not)의 조건식에 대한
             * 논리 연산을 수행한다. 연산의 결과 값은 참 또는 거짓의 bool 형식으로 리턴되어 boolean 연산자 라고도 한다. 
             * 
             * ex) &&, ||, !,
             * 
             * 비트 연산자 
             * 비트 연산자는 정수형 데이터의 값을 이진수 비트 단위로 연산을 수행할 때 사용한다. 
             * ex) &, |, ^, ~, 
             * 
             * 시프트 연산자 
             * 시프트 연산자는 정수 데이터가 담겨있는 메모리의 비트를 왼쪽 또는 오른쪽으로 지정한 
             * 비트만큼 이동시킨다. 
             * ex) <<, >>
             * 
             * 조건 연산자 
             * 조건 연산자는 조건에 따라서 참일때와 거짓일떄 결과를 다르게 반환하며, 
             * (조건식) ? (식 1 또는 값1) : (식2 또는 값2) 형태의 연산자 이다. 
             * if~else 문의 축약형 이기도 하다. 
             * 
             * 
             * 
             */
            


            Boolean isBigger = false;
            isBigger = (5 == 10) || (5<10);
            Console.WriteLine(isBigger);

            isBigger = !isBigger; 
            Console.WriteLine(isBigger);

            int bitNum = 10;
            int bitResult = 0;
            bitResult = bitNum & 0b0100; 
            Console.WriteLine("bitNum가 0010 상태를 가니고 있나요?-> {0}",bitResult);

            int bitNum2 = 10;
            int bitResult2 = 0;
            bitResult2 = bitNum2<<1;
            Console.WriteLine(bitResult2);

            // 나열 (콤마) 연산자 
            // 콤마를 구분자로 하여 한 문장에 변수 여러 개는 선언할 때 사용한다.
            int intNumber1, intNumber2, intNumber3;

            /**
             * sizeof 연산자 
             * sizeof 연산자는 단항 연산자로 데이터 형식 자체의 크기를 구하는데 사용한다. 
             * sizeof([데이터 타입]) 형태로 사용하며, 운영 체제와 CPU 아키텍쳐의 종류에 따라 결과 값이 다르게 
             * 나올 수 있다. 
             */
            Console.WriteLine("int의 메모리 크기는 {0} 바이트 입니다.", sizeof(int));


            /** 
             * 연산자 우선순위 
             * 연산자 여러개를 함께 사용할 때는 연산자 우선순위에 따라 계산 된다. 
             * 연산자 우선순위를 잘 모를때는 일단 괄호() 연산자 부터 잘 사용하도록 연습하는게 좋다 
             */


            Console.Write("주어: ");
            String sub = Console.ReadLine();
            Console.Write("동사: ");
            String verb = Console.ReadLine();
            Console.Write("목적어: ");
            String adj = Console.ReadLine();


            Console.WriteLine("{0} {1} a {2}", sub,verb,adj);

            Console.Write("나이: "); 
            String age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);
            ageInt += 10;
            Console.WriteLine("10년 후에는 {0}살이 됩니다.", ageInt);


            Console.Write("높이: ");
            String heightStr = Console.ReadLine();
            double height = Convert.ToDouble(heightStr);
            Console.Write("밑변: ");
            String bottomStr = Console.ReadLine();
            double bottom = Convert.ToDouble(bottomStr);
            
            double.TryParse(bottomStr, out height);
            
            

            double powofHeight = height * height;
            double powofbottom = bottom * bottom;
            double powofResult = powofHeight+ powofbottom;

            Console.WriteLine("빗변 길이는: {0}", Math.Sqrt(powofResult));


            Console.Write("길이: ");
            string lengthBox = Console.ReadLine();
            Console.Write("너비: ");
            string widthBox = Console.ReadLine();
            Console.Write("높이: ");
            String heightBox = Console.ReadLine();


            double lengthBoxDou = default;
            double.TryParse(lengthBox, out lengthBoxDou);

            double widthBoxDou = default;
            double.TryParse(widthBox, out widthBoxDou);

            double heightBoxDou = default;
            double.TryParse(heightBox, out heightBoxDou);

            Console.WriteLine("상자의 부피 : {0}, 상자의 표면적: {1}", lengthBoxDou*widthBoxDou*heightBoxDou, lengthBoxDou*heightBoxDou*6);


            Console.Write("평: "); 
            String pyung = Console.ReadLine();
            float pyungFl = default;
            float.TryParse(pyung, out pyungFl);

            float pyungMeter = pyungFl * 3.3058f;
            Console.WriteLine("평방미터: {0}", pyungMeter);

            Console.Write("시: ");
            string hour = Console.ReadLine();
            Console.Write("분: ");
            string min = Console.ReadLine();
            Console.Write("초: ");
            String sec = Console.ReadLine();

            int hourInt, minInt, secInt = default;
            int.TryParse(hour, out hourInt);
            int.TryParse(min, out minInt);
            int.TryParse(sec, out secInt);

            Console.WriteLine("전체 초: {0}", hourInt * 60 * 60 + minInt * 60 + secInt);


            String template = "퀴즈\t#{0}\t성적 : ";


            Console.Write(template, 1);
            String quizOne = Console.ReadLine();
            Console.Write(template, 2);
            String quizTwo = Console.ReadLine();
            Console.Write(template, 3);
            String quizThree = Console.ReadLine();
            Console.Write("중간고사  \t성적 : ");
            String mid = Console.ReadLine();
            Console.Write("기말고사 \t성적 : " );
            String finalScore = Console.ReadLine();

            

            double quizOneDou, quizTwoDou, quizThreeDou, midDou, finalScoreDou = default;
            double.TryParse(quizOne, out quizOneDou);
            double.TryParse(quizTwo, out quizTwoDou);
            double.TryParse(quizThree, out quizThreeDou);
            double.TryParse(mid, out midDou);
            double.TryParse(finalScore, out finalScoreDou);

            

            double totalScore = quizOneDou + quizTwoDou + quizThreeDou + midDou + finalScoreDou;
            Console.WriteLine("==================================");
            Console.WriteLine("성적 총합 : {0}", totalScore);
            Console.WriteLine("==================================");




             






        }
    }
}