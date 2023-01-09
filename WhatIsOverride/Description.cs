﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOverride {
    internal class Description {
        public void OverrideDesc() {

            /**
             * 매서드 오버라이드 
             * 부모 클래스에 만든 메서드를 자식 클래스에서 다시 새롭게 만들어 
             * 사용하는 것을 메서드 오버라이드라고 한다. 
             * 
             * 매서드 오버라이드: 재정의
             * 클래스 관계를 따지는 상속 개념에서 부모 클래스에 이미 만든 메서드를
             * 동일한 이름으로 자식 클래스에서 다시 정의 (재정의) 해서 
             * 사용한다는 개념이 메서드 오버라이드라고 한다. 
             *  - 메서드 오버라이드는 메서드를 새롭게 정의하는것 
             *  - 오버라이드(Override), 오버라이딩(Overriding)이라는 표현은 동일하다 
             *  - 부모 클래스에 virtual 키워드로 선언해 놓은 메서드는 자식 클래스에서 
             *    override 키워드로 재정의해서 사용 가능함. 
             *    
             * 메서드 오버로드와(메서드 여러번 정의) 오버라이드(상속, 재정의): 
             * 
             * 처음 프로그래밍 할때 쉽게 혼동하는 단어가 바로 오버로드(Overload)와 
             * 오버라이드(Override)이다. 오버로드는 여러번 정의하는 것이고, 오버라이드는
             * 다시 정의 하는 것이다. 
             * 
             * 가상 메서드 
             * 메서드 오버라이드는 다른 표현 방식으로 가상 (Virtual) 메서드라고 한다. 
             * Sealed -> 오버라이드를 못하게 막는다.
             * 
             * 
             */

        }       // OverrideDesc()

        public void PropertyDesc() {

            /**
             * 속성은 필드 값을 읽거나 쓰고 계산하는 방법을 제공하는 클래스 속성을 나타내는 멤버이다. 
             * 아주 간단하게 클래스 속성을 변경하거나 알아보는 기능을 배워보자. 
             * 
             * 속성 
             * 클래스의 멤버 중에서 속성(Property)은 단어 그대로 클래스 속성(특징, 성격, 색상, 크기 등) 
             * 을 나타낸다. 속성은 괄호가 없는 메서드와 비슷하고 개체 필드 중에서 외부에 공개하고자 할때
             * 사용하는 방법이다. 개체의 성질, 특징, 색상, 크기, 모양 등을 속성으로 외부에 공개할 수 있다. 
             * 코드에서는 private 성격이 있는 필드를 public 속성으로 외부에 공개할 때 사용한다. 
             * 
             * 클래스 안에 선언된 필드 내용을 설정(Set) 하거나 참조(Get) 할때 사용하는 코드 블럭을 
             * 속성이라고 한다. 자동차 객체로 비유하자면 빨간 스포츠카, 바퀴 4개 등으로 표현할 수 있다. 
             * 
             * class [클래스 이름] 
             * {
             * public [리턴타입] [속성 이름] {  get; set;  }
             * }
             */


        }       // PropertyDesc()



    }       //class Description

    public class Parent {
        protected int number = 100; 
        public virtual void Say() {
            Console.WriteLine("[부모] 안녕하세요?");
        }
        public virtual void Run() {
            Console.WriteLine("[부모] 달리다.."); 
        }

        public virtual void Walk() {
            Console.WriteLine("[부모] 걷다"); 
        }

        public virtual void Walk(int count) {
            Console.WriteLine("[부모] {0}번 걷다", count);
        }

        public virtual void Walk(string where_) {
            Console.WriteLine("[부모] {0}에서 건다", where_);
        }



    }       // class Parent

    public class Child : Parent {



        public override void Say() {
            Console.WriteLine("[자식] 안녕하세요?"); 
        }
        public override void Run() {
            Console.WriteLine("[자식] 달리다..");
            //base.Run();
            this.number = 10;
            Console.WriteLine("[자식] number: {0}", this.number);
        }

        public override void Walk() {
            Console.WriteLine("[자식] 걷다");
        }

        public override void Walk(int count) {
            Console.WriteLine("[자식] {0}번 걷다", count);
        }

        public override void Walk(String where_) {
            Console.WriteLine("[자식] {0}에서 걷다", where_);
        }



    }       // class Child


    public class Button {
        protected int _index = 0; 

        public virtual void OnClickButton() {

            Console.WriteLine("{0}번 버튼을 눌렀음", this._index);

            // XXXXX 이 버튼을 누르면 퀘스트 창이 열림. XXXXX 

        }       //OnClickButton()

    }       //class Button


    public class StoreButton : Button {

        public override void OnClickButton() {

            this._index = 1;
            
            base.OnClickButton();
            Console.WriteLine("이 버튼을 누르면 상점 창이 열림. {0}", this._index); 

        }

    }

    public class QuestButton : Button {

        public override void OnClickButton() {
            
            base._index = 2;

            base.OnClickButton();
            Console.WriteLine("이 버튼을 누르면 퀘스트 창이 열림. {0}", _index);

        }

    }


}