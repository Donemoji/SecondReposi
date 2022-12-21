using System;


namespace Switch {
    internal class Program {
        //static void Main(string[] args) {


        //    /**
        //     * 선택문인 switch 문은 값에 따라 다양한 제어를 처리 할 수 있다. 
        //     * 조건을 처리할 내용이 많은 경우 유용하다. 
        //     * switch, case, default 키워드를 사용하여 조건을 처리한다. 
        //     */


        //    //Console.Write("정수 1,2,3 중에 하나를 입력하시오: ");
        //    //int switchNum = 0;
        //    //int.TryParse(Console.ReadLine(), out switchNum);

        //    //switch (switchNum) {
        //    //    case 1:
        //    //        Console.WriteLine("1을 입력했습니다.");
        //    //        break;
        //    //    case 2:
        //    //        Console.WriteLine("2을 입력했습니다.");
        //    //        break;
        //    //    case 3:
        //    //        Console.WriteLine("3을 입력했습니다.");
        //    //        break;
        //    //    default:
        //    //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
        //    //        break;

        //    //}

        //    //switch (switchNum) {
        //    //    case 1:
        //    //        Console.WriteLine("1을 입력했습니다.");
        //    //        goto case 3;
        //    //    case 2:
        //    //    case 3:
        //    //        Console.WriteLine("3을 입력했습니다.");
        //    //        break;
        //    //    default:
        //    //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
        //    //        break;

        //    //}


        //    //Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
        //    //Console.Write("1, C\t");
        //    //Console.Write("2, C++\t");
        //    //Console.Write("3, C#\t");
        //    //Console.Write("4, Java\t");

        //    //int choice = default;
        //    //int.TryParse(Console.ReadLine(), out choice);

        //    //switch (choice) {
        //    //    case 1:
        //    //        Console.WriteLine("C 선택");
        //    //        break;
        //    //    case 2:
        //    //        Console.WriteLine("C++ 선택");
        //    //        break;
        //    //    case 3:
        //    //        Console.WriteLine("C# 선택");
        //    //        break;
        //    //    case 4:
        //    //        Console.WriteLine("Java 선택");
        //    //        break;

        //    //    default:
        //    //        Console.WriteLine("처리 하지 않은 예외 입력 입니다.");
        //    //        break;
        //    //}


        //    //Console.WriteLine("오늘의 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ....)");
        //    //String weather = Console.ReadLine();

        //    //switch (weather) {

        //    //    case "맑음":
        //    //        Console.WriteLine("오늘의 날씨는 맑다.");
        //    //        break;
        //    //    case "흐림":
        //    //        Console.WriteLine("오늘의 날씨는 흐리다.");
        //    //        break;
        //    //    case "비":
        //    //        Console.WriteLine("오늘의 날씨는 비가 온다.");
        //    //        break;
        //    //    default:
        //    //        Console.WriteLine("혹시 눈이 오나요?");
        //    //        break;
        //    //}

        //    // while 문은 조건식이 참일 동안 문장을 반복 실행한다.


        //    //while 문은 반복문인데 5번 실행할 예정
        //    //int loopCount = 0;
        //    //while (loopCount < 5) {
        //    //    Console.WriteLine("반복문이 {0}번 돌았네요.", loopCount+1);
        //    //    loopCount++;
        //    //}


        //    ////10 ~ 1 카운트 후 발사 출력하는 프로그램 작성 
        //    //loopCount = 10;
        //    //while (loopCount>0) {
        //    //    Console.WriteLine("{0}", loopCount);
        //    //    --loopCount;
        //    //}

        //    //Console.WriteLine("발사");

        //    //int userGugudan = 0;
        //    //Console.Write("구구단 중에서 출력하고 싶은 단 입력: ");
        //    //int.TryParse(Console.ReadLine(), out userGugudan);

        //    //const int GUGU_LOOP_COUT = 9;
        //    //int guguLoopIdx = 1; 

        //    //while (guguLoopIdx < 10) {
        //    //    Console.WriteLine("{0} * {1} = {2}", userGugudan, guguLoopIdx, userGugudan* guguLoopIdx);
        //    //    guguLoopIdx++;
        //    //}

        //    //int helloCnt = default;
        //    //while (true) {
        //    //    Console.Write("양의 정수를 입력하시오: ");
        //    //    int.TryParse(Console.ReadLine(), out helloCnt);

        //    //    if (helloCnt < 0) {
        //    //        Console.WriteLine("다시 양의 정수를 입력하시오 ");
        //    //        helloCnt = default;
        //    //    } else {

        //    //        while (helloCnt > 0) {
        //    //            Console.WriteLine("HELLO WORLD");
        //    //            --helloCnt;
        //    //        }
        //    //        break;

        //    //    }

        //    //}




        //    //int loopIdx = default;
        //    //int threeCnt = default;


        //    //while (true) {
        //    //    Console.Write("양의 정수를 입력하시오 : ");
        //    //    int.TryParse(Console.ReadLine(), out threeCnt);

        //    //    if (threeCnt < 0) {
        //    //        Console.WriteLine("다시 양의 정수를 입력하시오");

        //    //    } else {
        //    //        while (loopIdx <= threeCnt) {
        //    //            Console.Write("{0}, ", loopIdx * 3);
        //    //            ++loopIdx;

        //    //        }
        //    //        break;
        //    //    }


        //    //}







        //    //Console.WriteLine();

        //    //int plusNum = default;
        //    //int plusResult = default; 

        //    //while (true) {
        //    //    Console.Write("정수를 입력 하시오: ");
        //    //    int.TryParse(Console.ReadLine(), out plusNum);


        //    //    if(plusNum == 0) {
        //    //        Console.WriteLine(plusResult); 
        //    //        break;
        //    //    } else {
        //    //        plusResult += plusNum;
        //    //    }

        //    //}



        //    //int usergugudan = default;
        //    //int guguloopidx = 9;

        //    //Console.Write("구구단 단 입력: ");

        //    //int.TryParse(Console.ReadLine(), out usergugudan);


        //    //while (guguloopidx > 0) {
        //    //    Console.WriteLine("{0} * {1} = {2}", usergugudan, guguloopidx, usergugudan * guguloopidx);
        //    //    --guguloopidx;
        //    //}



        //    //int inputAvgCnt = default;
        //    //int loopCnt = default;
        //    //float tempNum = default;
        //    //float sumAvg = default;

        //    //Console.Write("정수를 입력 하시오 평균 구해드립니다: ");
        //    //int.TryParse(Console.ReadLine(), out inputAvgCnt);
        //    //loopCnt = inputAvgCnt;

        //    //while (loopCnt > 0) {

        //    //    float.TryParse(Console.ReadLine(), out tempNum);

        //    //    sumAvg += tempNum;
        //    //    --loopCnt;



        //    //}

        //    //Console.WriteLine("평균 값: {0}", sumAvg / inputAvgCnt);

        //    //const float FLOAT_VALUE = 0.1f;
        //    //int loopCnt = 10;
        //    //float sumOfFloatValue = 0.0f; 


        //    //while (0 < loopCnt) {
        //    //    sumOfFloatValue += FLOAT_VALUE;
        //    //    --loopCnt;

        //    //}
        //    //Console.WriteLine("무슨 값이 나오냐? {0}", sumOfFloatValue);



        //    //float num1, num2 = default;

        //    //Console.Write("첫번째 실수를 입력하시오: ");
        //    //float.TryParse(Console.ReadLine(), out num1);

        //    //Console.Write("두번째 실수를 입력하시오: ");
        //    //float.TryParse(Console.ReadLine(), out num2);

        //    //if(num1 == num2) {
        //    //    Console.WriteLine("두 값은 같습니다.");
        //    //} else {
        //    //    Console.WriteLine("두 값은 다릅니다.");

        //    //}

        //    //Console.WriteLine(0.000001f + 0.000001f);



        //    /**
        //     * for 문은 일정한 횟수만큼 반복할때 유용하다. 
        //     * 초기식을 실행한 후에 조건식이 참인 동안, 문장을 반복한다. 한번 반복이 
        //     * 끝날때마다 증감식이 실행된다. 
        //     */

        //    //int sumNum = 0;
        //    ////                   5번          7번
        //    ////      1번          2번          4번
        //    //for(int index = 1; index <= 10; index++) {

        //    //    //3번, 6번
        //    //    sumNum += index;
        //    //}
        //    //Console.WriteLine("1부터 10까지의 정수의 합 = {0}", sumNum);


        //    //int sumNum = default;

        //    //for(int loop = 1; loop<=100; ++loop) {

        //    //    if(loop%3==0) {
        //    //        //do nothing
        //    //        continue;
        //    //    } else {
        //    //        sumNum += loop;
        //    //    }

        //    //}

        //    //Console.WriteLine("3의 배수를 제외한 합 : {0}", sumNum);


        //    /**
        //     * 
        //     * break 문 
        //     * break문은 반복 루프를 벗어나기 위해서 사용한다. 
        //     * break 문이 실행되면 반복 루프는 즉시 중단되고 
        //     * 반복 루프 다음에 있는 문장이 실행된다. 
        //     * 
        //     * continue 문
        //     * continue 문은 현재 수행하고 있는 반복 과정의 나머지를
        //     * 건너 뛰고 다음 반복 과정을 강제적으로 시작하게 만든다. 
        //     * 반복 루프에서 continue 문을 만나게 되면 continue 문 
        //     * 다음에 있는 후속 코드들은 실행 되지 않고 건너뛰게 된다.
        //     * 
        //     */

        //    //for(int idx = 1; idx<= 10; idx++) {
        //    //    if(idx == 4) {
        //    //        break;
        //    //    }
        //    //    Console.WriteLine("현재 인덱스: {0}", idx);
        //    //}


        //    //char[] inputString = Console.ReadLine().ToCharArray();


        //    //LAB 1
        //    String temp = "";
        //    int jaCnt = 0;
        //    int moCnt =  0;
        //    Boolean checkMo = temp.Equals("a")  || temp.Equals("e") || temp.Equals("i") || temp.Equals("o") || temp.Equals("u") || temp.Equals("A") || temp.Equals("E") || temp.Equals("O") || temp.Equals("U") || temp.Equals("I");




        //    while (true) {

        //        Console.Write("영문자를 입력하시오: ");
        //        temp = Console.ReadLine();

        //        if (temp == "#") {
        //            break;
        //        } else if (temp.Equals("a") || temp.Equals("e") || temp.Equals("i") || temp.Equals("o") || temp.Equals("u") || temp.Equals("A") || temp.Equals("E") || temp.Equals("O") || temp.Equals("U") || temp.Equals("I")) {
        //            moCnt += 1;
        //            temp = "";
        //        } else {
        //            jaCnt += 1;
        //            temp = "";
        //        }


        //    }

        //    Console.WriteLine("모음: {0}", moCnt);
        //    Console.WriteLine("자음: {0}", jaCnt);




        //    Random rndNum = new Random();
        //    int tempNum = 0;
        //    int start = 0;
        //    int end = 100;
        //    int middle = 0;
        //    int targetNum = 0;

        //    int scoreNum = default;
        //    int.TryParse(Console.ReadLine(), out scoreNum);





        //    for (int index = 0; index >= 0; index++) {


        //        middle = (start + end) / 2;
        //        if (index == 6 && middle == 99) {
        //            Console.WriteLine("정답입니다.", 100);
        //            break;
        //        }
        //        targetNum = middle;


        //        //rndNum.Next(targetNum / 2, targetNum

        //        //50 , 50보다 타겟이 크면 75, 87, 93, 적으면 25


        //        if (targetNum < scoreNum) {
        //            start = middle;
        //            Console.WriteLine("{0}보다 정한 숫자 {1} (이)가 더 큽니다.", targetNum, scoreNum);
        //        } else if (targetNum > scoreNum) {
        //            end = middle;
        //            Console.WriteLine("{0}보다 정한 숫자 {1} (이)가 더 작습니다.", targetNum, scoreNum);
        //        } else {
        //            Console.WriteLine("{0} 정답입니다.", targetNum);
        //            break;
        //        }

        //    }

        //    int num1, num2;
        //    num1 = rndNum.Next(-1, 100);
        //    num2 = rndNum.Next(-1, 100);

        //    double answer2 = 0;            
        //    double myAnswer2 = 0;


        //    Console.Write("곱셈? 덧셈? 뺄셈? 나눗셈? ");
        //    String whatFom = Console.ReadLine();



        //    while (true) {

        //        if(whatFom == "곱셈") {
        //            answer2 = num1 * num2;
        //            Console.Write("곱셈 해보자: {0} * {1} = ", num1, num2);
        //            double.TryParse(Console.ReadLine(), out myAnswer2);
        //            if(myAnswer2 == answer2) {
        //                Console.WriteLine("정답입니다.");
        //                break;
        //            } else {
        //                Console.WriteLine("오답입니다. 정답은 {0}입니다.", answer2);
        //                continue;
        //            }

        //        } else if(whatFom == "덧셈") {

        //            answer2 = num1 + num2;
        //            Console.Write("덧셈 해보자: {0} + {1} = ", num1, num2);
        //            double.TryParse(Console.ReadLine(), out myAnswer2);
        //            if (myAnswer2 == answer2) {
        //                Console.WriteLine("정답입니다.");
        //                break;
        //            } else {
        //                Console.WriteLine("오답입니다. 정답은 {0}입니다.", answer2);
        //                continue;
        //            }

        //        } else if(whatFom == "나눗셈") {



        //            Console.Write("나눗셈 해보자(둘째 자리 까지): {0} / {1} = ", num1, num2);


        //            answer2 = (double)num1 / (double)num2;
        //            answer2 = Math.Round(answer2, 2);

        //            double.TryParse(Console.ReadLine(), out myAnswer2);

        //            if (myAnswer2 == answer2) {
        //                Console.WriteLine("정답입니다.");
        //                break;
        //            } else {
        //                Console.WriteLine("오답입니다. 정답은 {0}입니다.", answer2);
        //                continue;
        //            }  
        //        } else {

        //            answer2 = num1 - num2;
        //            Console.Write("뺄셈 해보자: {0} - {1} = ", num1, num2);
        //            double.TryParse(Console.ReadLine(), out myAnswer2);
        //            if (myAnswer2 == answer2) {
        //                Console.WriteLine("정답입니다.");
        //                break;
        //            } else {
        //                Console.WriteLine("오답입니다. 정답은 {0}입니다.", answer2);
        //                continue;
        //            }

        //        }
        //    }

        /**
             * foreach문은 배열이나 컬렉션같은 값을 여러개 담고 있는 데이터 구조에서
             * 각각의 데이터가 들어 있는 만큼 반복하는 반복문이다. 데이터 개수나 반복 조건을 
             * 처리할 필요가 없다. 
             */
        //string stringText = "Hello world?";

        //int loopCnt = 0; 



        //foreach (char oneChar in stringText) {
        //    Console.Write("{0} ", oneChar);
        //    loopCnt++;
        //    //loop stringText의 길이 만큼 도는 루프
        //}
        //Console.WriteLine("loopCnt: {0}, stringTextLen: {1}", loopCnt, stringText.Length);


        //int tempNum = 0;
        //for(int index = 1; index < 101; index++) {
        //    if((index % 3 ==0) && (index % 4 == 0)) {
        //        tempNum += index;
        //    }
        //}

        //Console.WriteLine("3의 배수이면서 4의 배수인 정수의 합: {0}", tempNum);


        //int numberA, numberB, garbageNum;



        //while (true) {

        //    Console.Write("정수 1 을 입력하시오: ");
        //    int.TryParse(Console.ReadLine(), out numberA);

        //    Console.Write("정수 2 을 입력하시오: ");
        //    int.TryParse(Console.ReadLine(), out numberB);

        //    if (numberA >= numberB ) {

        //    } else {
        //        garbageNum = numberA;
        //        numberA = numberB;
        //        numberB = garbageNum;
        //    }


        //    if(numberA - numberB < 0) {
        //        Console.WriteLine("두수의 차가 0보다 작습니다. 다시 입력 하시오");
        //        continue;
        //    } else {
        //        Console.WriteLine("두수의 차는 {0}입니다.", numberA- numberB);
        //        break;
        //    }
        //}

        //int guguNum = 1;

        //for(int indxNum = 1; indxNum<10; indxNum++) {
        //    if((indxNum % 2) != 0) {
        //        ++guguNum;
        //        continue;
        //    } else {
        //        for(int indxGugu = 0; indxGugu<indxNum; indxGugu++) {
        //            Console.WriteLine("{0} * {1} = {2}", indxNum, indxGugu+1, indxNum * (indxGugu+1));

        //        }

        //    }
        //}

        //int numA, numB;

        //for(int indxNum2 =0; indxNum2<100; indxNum2++) {

        //    numA = indxNum2 / 10;
        //    numB = indxNum2 % 10;

        //    if((numA*10 + numB*1) + (numB * 10 + numA * 1) == 99) {
        //        Console.WriteLine("A: {0}, Z: {1}",numA,numB);

        //    } 

        //}










        //}
    }
}