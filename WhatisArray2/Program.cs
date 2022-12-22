using System;
using System.Diagnostics;

namespace WhatisArray2 {
    internal class Program {
        static void Main(string[] args) {

            //int number = 1_0822; 
            //Console.WriteLine("64로 Mod 연산: {0}", number%64);


            /** 
             * 다차원 배열 
             * 2차원 배열, 3차원 배열처럼 차원이 2개 이상인 배열을 
             * 다차원 배열이라고 한다. 
             * C#에서 배열을 선언할때는 콤마를 기준으로 차원을 구분한다. 
             */

            //1차원 배열
            //int[] oneArr = new int[2] { 1 , 2 };

            ////2차원 배열
            //int[,] twoArr = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            ////3차원 배열 
            //int[,,] threeArr = new int[2, 2, 2]
            //{
            //    { { 1, 2 }, { 3, 4 } } ,
            //    { { 1, 2 }, { 3, 4 } }
            //};

            ////3행 3열짜리 배열에서 행과 열이 같으면 1, 다르면 0을 출력 
            //twoArr = new int[3, 3];



            ////더 적게 도는게 가장 위에 쌓여야 한다.
            //for (int y = 0; y < 3; y++) {
            //    for (int x = 0; x < 3; x++) {
            //        if (x == y) {
            //            twoArr[y, x] = 1;

            //        } else {
            //            twoArr[y, x] = 0;
            //        }
            //    }
            //}
            ////getUpperBound 배열에서 지정된 차원의 마지막 요소의 "인덱스"를 가져옵니다.
            //Console.WriteLine(twoArr.GetUpperBound(0));
            //Console.WriteLine(twoArr.GetUpperBound(1));

            ////getLength 배열의 "길이"를 리턴한다. 
            //Console.WriteLine(twoArr.GetLength(0));
            //Console.WriteLine(twoArr.GetLength(1));




            //for (int y = 0; y <= twoArr.GetUpperBound(0); y++) {

            //    for (int x = 0; x <= twoArr.GetUpperBound(1); x++) {

            //        Console.Write("{0} ", twoArr[y, x]);

            //    }

            //    Console.WriteLine();

            //}

            /**
             * 가변 배열 
             * 차원이 2개 이상인 배열은 다차원 배열이고, 배열 길이가 
             * 가변 길이인 배열은 가변 배열이라고 한다. 
             * 18.6 챕터
             */

            //int[][] zagArr = new int[2][];
            //zagArr[0] = new int[2] { 1, 2 };
            //zagArr[1] = new int[] { 3, 4, 5 };

            //for(int y = 0; y<2; y++) {
            //    for(int x =0; x< zagArr[y].Length; x++) {
            //        Console.Write("{0} ", zagArr[y][x]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] intArr;           //int 형 데이터 타입의 intArr라는 배열을 선언
            //intArr = new int[3];    //int형 데이터 타입의 변수 3개를 메모리에 할당 

            //intArr[0] = 1;          // intArr 0번쨰 인덱스에 1이라는 정수값 대입
            //intArr[1] = 2;          // intArr 1번쨰 인덱스에 1이라는 정수값 대입
            //intArr[2] = 3;          // intArr 2번쨰 인덱스에 1이라는 정수값 대입

            //// 배열 직접 출력해보자 
            //for (int i=0; i<3; i++) {
            //    Console.WriteLine("{0}번째 인덱스의 값 -> {1}",i,intArr[i]);
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////intArr 배열에서 int형 데이터 타입의 값을 하나씩 뽑아서 index에 저장 할것이다. 
            //foreach(int idx in intArr) {

            //    Console.WriteLine("intArray 배열에서 뽑아온 값 -> {0}", idx);

            //}   //loop: intArr배열의 길이 만큼 도는 루프

            //int[] testScore = new int[3];
            //String temp = "";

            //for(int idx =0; idx<3; idx++) {
            //    Console.Write("{0} 번째 학생의 점수를 입력하시오: ", idx+1);

            //    temp = Console.ReadLine();
            //    int.TryParse(temp, out testScore[idx]);

            //    byte[] convertByte = Encoding.ASCII.GetBytes(temp);

            //    Console.WriteLine("!!!!" + convertByte[0]);
            //    Console.WriteLine("!!!!" + testScore[idx]);

            //    if (!(48 <= convertByte[0] && convertByte[0]<= 57)) {
            //        Console.WriteLine("다시 입력하시오..");
            //        idx--;
            //        continue;
            //    }


            //    if (!(testScore[idx] >= 0 && testScore[idx] <= 100)) {
            //        Console.WriteLine("다시 입력하시오..");
            //        idx--;

            //    }



            //}

            //float sum = testScore[0] + testScore[1] + testScore[2];

            //float avg = sum / 3.0f;

            //Console.WriteLine("총점: {0}, 평균: {1}", sum, avg);




            //LAB1. 
            Random rnd = new Random();
            int biggest = 0;

            int[] rndNumContainer = new int[100];


            for (int idx = 0; idx < 100; idx++) {


                rndNumContainer[idx] = rnd.Next(0, 101);


                if (biggest < rndNumContainer[idx]) {
                    biggest = rndNumContainer[idx];
                }

                Console.WriteLine("계산한 최대값: {0}", biggest);
                Console.WriteLine("난수: {0}", rndNumContainer[idx]);
                Console.WriteLine("=============================");

            }

            Console.WriteLine("최종 최대값: {0}", biggest);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine();


            //LAB 2. 버블, 합병 분할 정렬

            int[] appleCnt = new int[100];



            for (int idx = 0; idx < 100; idx++) {
                appleCnt[idx] = rnd.Next(0, 300);

                for (int idx2 = 0; idx2 < appleCnt.Length; idx2++) {
                    if (idx == idx2) {
                        //do noting
                    } else {
                        if (appleCnt[idx] == appleCnt[idx2]) {
                            idx--;
                            break;
                        }
                    }



                }
            }

            int[] appleCntMergeSort = new int[100];
            appleCnt.CopyTo(appleCntMergeSort, 0);



            Console.Write("버블 정렬 되기전 난수: ");
            for (int idx = 0; idx < appleCnt.Length; ++idx) {
                Console.Write(appleCnt[idx] + ",  ");
            }


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int idx = 0; idx < appleCnt.Length - 1; idx++) {

                for (int idx2 = idx + 1; idx2 < appleCnt.Length; idx2++) {

                    if (appleCnt[idx] > appleCnt[idx2]) {

                        int temp = appleCnt[idx];
                        appleCnt[idx] = appleCnt[idx2];
                        appleCnt[idx2] = temp;


                    }

                }
            }
            stopwatch.Stop();



            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=============================");
            Console.WriteLine("=============================");


            Console.Write("버블 정렬 된 난수: ");
            for (int idx = 0; idx < appleCnt.Length; ++idx) {
                Console.Write(appleCnt[idx] + ",  ");
            }
            Console.WriteLine();
            Console.WriteLine("time: " + stopwatch.ElapsedTicks + "ms");


            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine();


            //LAB2. 머지 소트 
            //int[] appleCntMergeSort = appleCnt;

            //appleCntMergeSort;
            Console.Write("M & S 정렬 되기전 난수: ");
            for (int idx = 0; idx < appleCntMergeSort.Length; ++idx) {
                Console.Write(appleCntMergeSort[idx] + ",  ");
            }
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("=============================");

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            int[] resultArr = SortArr(appleCntMergeSort, 0, appleCntMergeSort.Length - 1);
            stopwatch1.Stop();


            Console.Write("M & S 정렬 된 난수: ");
            for (int idx = 0; idx < resultArr.Length; ++idx) {
                Console.Write(resultArr[idx] + ",  ");
            }
            Console.WriteLine();
            Console.WriteLine("time: " + stopwatch1.ElapsedTicks + "ms");


            Console.WriteLine();
            Console.WriteLine();




        } //main



        public static int[] SortArr(int[] arr, int start, int end) {

            if (start < end) {
                int middle = (end + start) / 2;

                SortArr(arr, start, middle);
                SortArr(arr, middle + 1, end);

                MergeArr(arr, start, middle, end);

            }


            return arr;
        }

        public static void MergeArr(int[] arr, int left, int middle, int right) {
            int startArrayLength = middle - left + 1;
            int endArrayLength = right - middle;

            int[] startTempArray = new int[startArrayLength];
            int[] endTempArray = new int[endArrayLength];



            for (int idx = 0; idx < startArrayLength; ++idx)
                startTempArray[idx] = arr[left + idx];

            for (int idx2 = 0; idx2 < endArrayLength; ++idx2)
                endTempArray[idx2] = arr[middle + 1 + idx2];


            int i, j;

            i = 0;
            j = 0;

            int k = left;

            while (i < startArrayLength && j < endArrayLength) {

                if (startTempArray[i] <= endTempArray[j]) {

                    arr[k++] = startTempArray[i++];

                } else {

                    arr[k++] = endTempArray[j++];

                }

            }

            while (i < startArrayLength) {

                arr[k++] = startTempArray[i++];

            }

            while (j < endArrayLength) {

                arr[k++] = endTempArray[j++];

            }

        }






    }

}