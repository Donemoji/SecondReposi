using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsDelegate {

    public delegate void delegateFunction1();
    public delegate int delegateFunction2(int x);



    internal class Delegate {


        // void 리턴타입과, 매개변수를 받지 않는 함수를 저장할 수 있는 
        // 데이터 타입을 선언한것임. 
        delegate void SayDelegate();


        delegate int ReturnInteger(int x);

        //delegate void delegateFunction1();
        //delegate int delegateFunction2(int x);

        //delegateFunction1 delegateFunction1;
        //delegateFunction1 delegateFunction2;

        //delegateFunction2 delegateFunction3;



        public void Test(String msg, delegateFunction1 a, delegateFunction1 _printUserInfo, delegateFunction2 c) {
            //delegateFunction1 = a; 
            //delegateFunction2 = _printUserInfo;
            //delegateFunction3 = c;

            a();
            a.Invoke(); 


            //delegateFunction1();
            //delegateFunction2();
            //int k = delegateFunction3(100);
            //Console.WriteLine(k);




        }

        public void DelegateDesc() {
            
            /**
             * 
             * 대리자 (delegate)는 매개변수 목록 및 반환 형식이 있는 메서드 
             * 참조(포인터)를 나타내는 형식이다. 영어 단어 delegate는 
             * '위임하다' 또는 '대신하다'의 의미가 있다. 
             * 
             * 대리자(위임 / 델리게이트) 
             * 대리자는 delegate 키워드를 사용하여 만든다. 대리자는 함수 자체를 데이터
             * 하나로 보고 의미 그대로 다른 메서드를 대신 실행하는 기능이다. 
             * 한번에 하나 이상을 대신해서 호출할 수 있는 개념이다. 
             * 
             *  - 자동차 개체를 예로 들면 대리운전 처럼 대리자가 집까지 좌회전(),
             *    우회전(), 직진() 등 동작을 대신해서 할수있게 하는 개념과 비슷하다. 
             *  - 메서드의 매개변수로 대리자를 넘길수 있다. 대리자를 사용하여 
             *    함수의 매개변수로 함수 자체를 전달할 수 있다. 
             *  - 메서드의 매개변수로 또 다른 메서드 호출을 넘기는 기능이다. 
             *  - 대리자는 동일한 메서드 시그니쳐를 갖는 메서드 참조를 담을 수 있는 
             *    그릇 역할을 한다. 
             *  - 대리자는 람다(Lamda)와 개념이 같다고 보아도 된다. 
             *  - 대리자를 사용하면 함수를 모아 놓았다 나중에 실행하거나 실행을
             *    취소할 수 있다. 
             *  - 대리자는 내부적으로 MulticastDelegate 클래스에서 기능을 상속한다. 
             *  - 대리자는 이벤트(Event)를 만들어 내는 중간 단계의 키워드로 존재한다. 
             *  
             */


            SayDelegate sayDelegate = Hi;

            sayDelegate.Invoke();



            ReturnInteger returnInteger = aaaa;

            int returned = returnInteger.Invoke(10);

            Console.WriteLine(returned);


        }       // DelegateDesc()

        public void Hi() {
            Console.WriteLine("안녕하세요?");
        }

        public int aaaa(int z) {
            int c = 10;
            return c + z;
        }


    }
}
