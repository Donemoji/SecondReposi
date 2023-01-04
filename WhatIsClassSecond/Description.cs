using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WhatIsClassSecond {
    internal class Description {

        private String stringField = "이것은 어디에서 접근이 가능할까?";

        public Description() {
            Console.WriteLine("이것이 바로 숨어있는 생성자이다.");

        }

        public Description(int number) {
            Console.WriteLine("number -> {0}을 받는 생성자 이것이 바로 숨어있는 생성자이다.", number);

        }

        public void ValueTypeAndReferenceType() {

            /**
             * 값 형식과 참조 형식 
             * 클래스나 구조체 같은 데이터 형식을 말할때 값 형식 (Value Type) 
             * 과 참조 형식 (Reference Type)으로 구분 짓기도 한다.
             * 
             * 값 형식 
             * 개체에 값 자체를 담고있는 구조이다. 지금까지 다룬 int, double 등은 
             * 내부적으로 구조체로 된 전형적인 값 형식의 데이터 구조이다. 
             * 
             * 참조형식 
             * 개체가 값을 담고 있는 또 다른 개체를 포인터로 바라보는 구조이다. 
             * 여러값이 동일한 개체를 가리킬 수 있다. 
             */

            /**
             * 박싱과 언박싱
             * 프로그래밍을 하다보면 데이터의 형식 변환이 필요하다. 이러한 변환 과정에서 
             * 값형식의 데이터를 참조 형식의 데이터로 변경하는 것을 박싱(Boxing)이라고 한다. 
             * 반대로 참조형식의 데이터를 값 형식의 데이터로 변경하는 것을 언박싱이라고 한다.
             * 
             * 박싱
             * 박싱이란 말 그대로 박스에 포장을 하는 것이다. C#에서 박싱은 값 형식의 데이터를 참조 
             * 형식의 데이터로 의미 하는 작업을 의미한다. 예를 들어 다음 코드 처럼 정수 형식의
             * 데이터를 오브젝트 형식의 데이터에 담는 형태를 박싱이라고 한다. 
             * 
            //박싱
            //int number = 1234;
            //Object objectValue = number;
            //Console.WriteLine("{0}", objectValue);
              
             * 
             * 좀 더 어렵게 말하면 스택 메모리 영역에 저장된 값 형식의 데이터를 힙 메모리 영역에
             * 저장하는 단계를 거치기 때문에 시간과 공간이 소비되는 비용이 발생한다. 
             * 
             * 언박싱 
             * 다음 코드는 Object 변수에 저장된 1234를 실제 정수 형식의 데이터로 변환하는 
             * 모습을 보여 준다. 
             * 참조 형식의 데이터를 값 형식의 데이터로 변환하는 과정이 포장을 푸는 것과 비슷해 보여서 
             * 언박싱이라고 한다. 언박싱을 캐스트(Cast) 또는 캐스팅(Casting)으로 표현 한다. 
             * 
            //언박싱
            //Object objectValue = 1234;
            //int number = (int)objectValue;
            //Console.WriteLine("{0}", number); 
              
             * 
             * object형 변수에 들어 있는 데이터 중에서 숫자 형식의 데이터는 바로 int 형 변수에 
             * 대입할 수 없다. object형 변수 값을 int형 변수에 대입하려면 형식 변환을 해야한다. 
             * 형식 변환은 캐스팅이나 Convert 클래스와 같은 변환 API를 사용하면 된다. 
             * 즉 (int) 또는 Convert.ToInt32() 같은 형식 변환 관련 기능을 명시적으로 지정해 
             * 주어야 한다. 
             * 
             * 
             */

            Object objectValue;
            char charValue = 'a';
            int intValue = 97;
            char charValue2; 

            objectValue = charValue;
            charValue2 = (char)objectValue;

            Console.WriteLine("{0}", charValue2);

            Console.WriteLine("ValueTypeAndReferenceType -> {0}", stringField);



        }       //ValueTypeAndReferenceType()

        public void WhatIdField() {

            /*
             * 
             * 필드는 클래스의 부품 역할을 하는 클래스의 내부 상태 값을 저장해 놓는 그릇을 의미한다. 
             * 예를 들어 필드는 자동차 클래스에 선언된 변수로 자동차 부품에 해당한다고 할 수 있다. 
             * 
             * 필드
             * 클래스 내에서 선언된 변수 또는 배열 등을 C# 에서는 필드라고 한다. 필드는 일반적으로
             * 클래스의 부품 역할을 하며, 대부분 private 액세스 한정자 (Access Modifier)가 붙고 
             * 클래스 내에서 데이터를 담는 그릇 역할을 한다. 이러한 필드는 개체 상태를 보관한다. 
             * 필드는 선언한후 초기화 하지 않아도 자동으로 초기화 한다. 예를 들어 int형 필드는
             * 0으로, String형 필드는 String.Empty, 즉 공백으로 초기화 된다. 
             * 
             * 지역 변수와 전역 변수
             * C#에서 변수를 선언할때는 Main() 메서드와 같은 메서드 내에서 선언하거나 메서드 밖에서 
             * 즉 메서드와 동등한 레벨에서 변수를 선언할 수 있다. 메서드 내에서 선언된 변수 또는 배열을 
             * 지역 변수(Local variable)라고 하며, 메서드 밖에서 선언된 변수를 전역 변수(Global Variable)
             * 라고 한다. 다만 C#에서는 전역 변수 라는 용어를 사용하지 않고 메서드와 동일하게 엑세스 
             * 한정자를 붙여 필드 라고 한다. 
             * 
             * 지역 변수 
             * 변수는 Main() 메서드가 종료 되면 자동으로 소멸 된다. 변수가 살아 있는 영역은 Main() 메서드의
             * 중괄호 시작({)과 끝 사이(})이다. 특정 지역을 범위로 하기에 변수를 일반적으로 지역변수라고
             * 표현한다. 
             * 
             * 전역 변수 
             * Main() 메서드가 아닌 클래스 내에 선언된 변수를 필드라고 한다. C#에서 필드는 변수와 마찬가지로
             * 주로 소문자 또는 (_)언더스코어로 시작한다. 이러한 필드는 메서드 내에 선언된 지역 변수와 달리 
             * 전역 변수라고도 한다. 
             * 
             * 
             */

            Console.WriteLine("WhatIdField -> {0}", stringField);


        }       //WhatIdField()



        public void WhatIsConstructor() {
            /**
             * C#에서 생성자는 클래스에서 맨 먼저 호출되는 메서드로, 클래스 기본값 등을 
             * 설정한다. 
             * 자동차 클래스를 예로 들면, 자동차의 시동 걸기에 해당하는 것이 바로 생성자이다. 
             * 
             * 생성자
             * 클래스의 구성요소 중에는 생성자(Constructor)라는 메서드가 숨어 있다. 
             * 단어 그대로 개체를 생성하면서 무엇인가를 하고자 할떄 사용되는 메서드 이다. 일반적으로
             * 생성자는 개체를 초기화(주로 클래스 내 필드를 초기화)하는 데에 사용된다. 생성자는 생성자 메서드
             * 라고도 한다. 이러한 생성자는 독특한 규칙이 있는데, 바로 생성자 이름이 클래스 이름과
             * 동일하다는 것이다. 클래스 내에서 클래스 이름과 동일한 이름을 갖는 메서드는 모두 생성자이다. 
             * 
             * 생성자는 매개 변수가 없는 기본(Default) 생성자가 있고, 매개 변수를 원하는 만큼
             * 정의해서 사용할 수도 있다. 이때 리턴값은 가지지 않는다. 또 생성자도 static 생성자(정적 생성자)
             * public 생성자(인스턴스 생성자)로 구분된다. 일반적으로 public 키워드를 사용하는 인스턴스 
             * 생성자를 많이 사용한다. 
             */
            

        }       //WhatIsConstructor()


        public void WhatISDestructor() {

            /**
             * 
             * 소멸자는 생성자와 반대 개념으로 클래스에서 인스턴스화 된 개체가 메모리상에서 
             * 없어질때 실행되는 메서드이다. 자동차 클래스를 예로 들면 자동차 주차 대행, 시동끄기
             * 등으로 볼 수 있다. 
             * 
             * 종료자 
             * 종료자(Finalizer)라고도 하는 소멸자는 닷넷의 가비지 컬렉터에서 클래스의 인스턴스를
             * 사용한후 최종 정리할때 실행되는 클래스에서 가장 늦게 호출하는 메서드이다. 
             * C#에서는 닷넷 가비지 컬렉터가 개체를 소멸할때 메모리를 해제하는 등 역할을 대신해주기
             * 때문에 이 책에서는 소멸자에 직접 접근할 일이 없다. 
             * 
             *  - 자동차 시동을 끄는 것에 비유할수 있다, 운전수가 주차하고 시동을 끄는 것이 아니라
             *    주차 요원(가비지 컬렉터)이 대신 주차하고 시동을 끄는것과 의미가 비슷하다. 
             *  - 소멸자는 클래스 이름과 동일한 메서드로 앞에 물결 기호인 ~(필드)를 붙여서 만든다. 
             *  - 소멸자도 특별한 형태의 메서드 이다. 소멸자 또한 ㅏ소멸자 메서드 라고도 한다. 생성자와
             *    달리 매개 변수를 받을 수 없다. 
             *  - 소멸자는 오버로딩을 지원하지 않으며 직접 호출할 수도 없다. 
             * 
             */

        }

        public void WhatIsInheritance() {
            /**
             * 클래스 간에는 부모와 자식 관계를 설정할 수 있다. 이러한 내용을 
             * 개체 관계 프로그래밍(Object Relationship programming)이라고 한다. 
             * 상속은 부모 클래스에 정의된 기능을 다시 사용하거나 확장 또는 수정하여 
             * 자식 클래스로 만드는 것이다. 
             * 특정 클래스에서 만든 기능을 다른 클래스에 상속으로 물려주면 장점이 많이 있다. 
             *
             * 클래스 상속하기 
             * 객체 지향 프로그래밍의 장점 중 하나는 이미 만든 클래스를 재사용 하는 것이다.
             * 이 재사용의 핵심 개념이 바로 상속이다. 부모 재산을 자식에게 상속하듯이 부모 클래스의 
             * 모든 멤버를 자식 클래스(파생 클래스)가 재사용하도록 허가하는 기능이다. 
             * 여러 클래스 간의 관계를 설정할때 수평 관계가 아닌 부모와 자식간 관계 처럼 계층적인
             * 관계를 표현할때 사용하는 개념을 상속이라고 한다. 클래스의 상속은 
             * 단일 상속 (single inheritance)와 다중 상속 (mutiple inheritance)으로 
             * 구분할 수 있다. 단, C# 클래스 상속은 단일 상속만 지원한다. 다중 상속은
             * 나중에 배울 인터페이스로 지원 받을수 있다. 
             * 
             * 클래스 상속 구문
             * C#에서는 다음과 같이 클래스 이름 뒤에 콜론(:) 기호와 부모가 되는 클래스 이름을 붙인다. 
             * 
             * public class [기본 클래스 이름] 
             * {
             *      // 기본 클래스 멤버를 정의
             * }
             * 
             * public class [파생 클래스 이름] : [기본 클래스 이름] 
             * {
             *      // 기본 클래스의 멤버를 포함한 자식 클래스의 멤버를 정의
             * }
             * 
             *  - System.Object 클래스: System.Object 클래스는 모든 클래스의 부모 클래스이다. 
             *    닷넷에서 가장 높은 계층에 속하는 시조(조상) 클래스 라고 할 수 있다. 새롭게 만드는 C#의
             *    모든 클래스는 자동으로 Object 클래스에서 상속받기 때문에 Object 클래스를 상속하는 코드는
             *    생략 가능하다. 
             *    
             *  - 기본(Base) 클래스: 다른 클래스의 부모 클래스가 되는 클래스를 기본 클래스라고 한다. 
             *    기본 클래스를 다른말로 Base 클래스, super 클래스, 부모 클래스 라고도 한다.
             *    
             *  - 파생(Derived) 클래스: 다른 클래스의 자식 클래스가 되는 클래스를 파생 클래스 라고 한다. 
             *    파생 클래스는 다른 클래스에서 멤버를 물려받은 것으로, Derived 클래스, sub 클래스, 
             *    자식 클래스로 표현한다.
             * 
             * 부모 클래스와 자식 클래스 
             * 프로그래밍에서 상속을 표형할때 상속을 주는 클래스를 부모 클래스라고 하며, 상속을 받는 클래스를
             * 자식 클래스라고 한다. 콜론(:) 기호로 상속 관계를 지정하면 부모 클래스의 public 멤버들을 
             * 자식 클래스에서 그대로 물려 받아 사용할 수 있다. public, protected로 선언된 멤버들도 자식
             * 클래스에서 사용 가능하다 (private로 선언된 멤버는 상속이 안된다)
             */
              
        }


    }       //class Description

    class Parent {
        public String stringVal = "stringVal -> 부모 클래스의 멤버 변수";
        protected int intVal = 1234;
        private float floatVal = 3.14f;
        public void Print() {
            Console.WriteLine("부모 클래스의 멤버 호출"); 
        }
    }       //class Parent

    class Child : Parent {
        public void PrintChild() {
            
            Console.WriteLine("자식 클래스의 멤버 호출");
            Console.WriteLine("부모 클래스의 멤버 변수 호출: {0} , {1}", base.stringVal, base.intVal);


        }
    }       //class Child


    //class Monster {

    //    protected String name;
    //    protected int hp;
    //    protected int damage;
    //    protected int defence;

    //    protected void Move(String name) {
    //        Console.WriteLine("{0}(이)가 움직인다..", name);
    //    }

    //    protected void Attack(String name, int damage) {
    //        Console.WriteLine("{0}(이)가 {1}의 공격력으로 공격했다.", name, damage);
    //    }

    //    public void MoveAndAttack() {
    //        this.Move(this.name);
    //        this.Attack(this.name, this.damage);
    //    }



    //}       //class Monster

    //class Slime : Monster {

    //    public Slime() {
    //        this.name = "슬라임";
    //        this.hp = 100;
    //        this.damage = 2;
    //        this.defence = 1; 
    //    }

    //    //public void MoveAndAttack() {
    //    //    this.Move(this.name);
    //    //    this.Attack(this.name, this.damage);
    //    //}

    //}       //class Slime

    //class Wolf : Monster {
    //    public Wolf() {
    //        this.name = "늑대"; 
    //        this.hp = 200;
    //        this.damage = 3;
    //        this.defence = 1;

    //    }
    //    //public void MoveAndAttack() {
    //    //    this.Move(this.name);
    //    //    this.Attack(this.name, this.damage);
    //    //}


    //}       //class Wolf

    class HyperSuperClass {
        protected String name; 
        protected int hp;
        protected int attack;
        protected int defence;
        protected CalculateHP calculateHP;
        protected Boolean isWin;

        public HyperSuperClass() {
            calculateHP = new CalculateHP();
        }

        protected void Move() { 
            Console.WriteLine("{0} MOVE!", this.name);
        }

        public int Attack() {
            Console.WriteLine("{0} ATTACK!", this.name);
            
            return attack;
        }

        protected int Defence() {
            Console.WriteLine("{0} Defence!", this.name);
            return defence;
        }
        protected void showStatus() {
            Console.WriteLine("ATTACK: {0}", this.attack);
            Console.WriteLine("HP: {0}", this.hp);
        }

        public int getHp() {
            return this.hp;
        }

        public void setHp(int changedHp) {
            this.hp = changedHp;
        }

        public String getName() {
            return this.name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public Boolean getIsWin() {
            return this.isWin;
        }

        public void setIsWin(Boolean isWin) {
            this.isWin = isWin;
        }

        public Boolean IsWin {
            get { return this.isWin; }
            set { this.isWin = value; }
        }


    }

    class Boss : HyperSuperClass {
        String jordanRing;

        public Boss(String name, int hp, int attack, int defence) {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defence = defence;
            this.jordanRing = "JordanRing";
        }

        public int BossAttack() {
            Console.WriteLine("{0} BossAttack!", this.name);
            return attack * 2;
        }

        public String BossDead() {
            Console.WriteLine("{0}(이)가 {1}을 드랍했습니다.", this.name, this.jordanRing);
            return jordanRing;
        }

        


    }

    class Knight : HyperSuperClass {
        String helmet;
        public Knight(String name, int hp, int attack, int defence) {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defence = defence;
            this.helmet = "Helmet";
        }

        public void Charge() {
            Console.WriteLine("{0} CHARGE!", this.name);
        }

        public String KnightDead() {
            Console.WriteLine("{0}(이)가 {1}을 드랍했습니다.", this.name, this.helmet);
            return helmet;
        }



    }


    

    class Bandit : HyperSuperClass {
        public Bandit(String name, int hp, int attack, int defence) {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defence = defence;
        }
        public void Steal() {
            Console.WriteLine("{0} Steal!", this.name);
        }

    }

    class Player : HyperSuperClass {

        String[] inventory; 
        public Player(String name, int hp, int attack, int defence) {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defence = defence;
            inventory= new String[10];  
        }

        public int PlayerSuperAttack() {
            Console.WriteLine("{0} PlayerSuperAttack!", this.name);
            return attack * 3;
        }

        public String[] getInventory() {
            return this.inventory;
        }

        public void setInventory(String item) {

            
            for(int idx = 0; idx < inventory.Length; idx++) {
                if (inventory[idx] == null) {
                    inventory[idx] = item;
                    break;
                }
            }


        }




    }

    class ProceedWhat {

        public int WhatToProceed() {
            Console.WriteLine("1. 게임진행, 2. 인벤토리, 3. 게임 나가기");
            Console.Write("선택하시오: ");
            int num = 0; 
            int.TryParse(Console.ReadLine(), out num);



            if(num > 0 && num < 4) {
                return num;
            } else {
                Console.WriteLine("다시 입력하시오!!!");
                return num;
            }



        }



    }

    class CalculateHP {
        public Player Calculate(Player player, int bossDmg) {
            player.setHp(player.getHp() - bossDmg);
            Console.WriteLine("Boss Dmg : {0}", bossDmg);
            Console.WriteLine("Player Hp : {0}", player.getHp());


            return player;
        }

        public Boss Calculate(Boss boss, int playerDmg) {
            boss.setHp(boss.getHp() - playerDmg);
            Console.WriteLine("Player Dmg : {0}", playerDmg);
            Console.WriteLine("Boss Hp : {0}", boss.getHp());
            return boss;
        }

        public Knight Calculate(Knight knight, int playerDmg) {
            knight.setHp(knight.getHp() - playerDmg);
            Console.WriteLine("Player Dmg : {0}", playerDmg);
            Console.WriteLine("Boss Hp : {0}", knight.getHp());
            return knight;
        }

        public Player CollectItem(Player player, String item) {

            player.setInventory(item);
            return player;
        }

    }

   


   
    

    class Fight {
        private CalculateHP calculate;

        public Object LetsFight(Player player, Knight knight) {

            int dmgKnight = knight.Attack();
            calculate = new CalculateHP();
            player = calculate.Calculate(player, dmgKnight);
            Thread.Sleep(1000);
            Console.WriteLine();

            int dmgPlayer = player.Attack();
            knight = calculate.Calculate(knight, dmgPlayer);
            Thread.Sleep(1000);
            Console.WriteLine();


            if (knight.getHp() <= 0) {
                Console.WriteLine("플레이어 {0} 승리!", player.getName());
                String dropItem = knight.KnightDead();
                player = calculate.CollectItem(player, dropItem);
                Console.WriteLine();
                Console.WriteLine("획득한 아이템: {0}", dropItem);

                Console.Write("내 인벤토리: ");
                foreach (String items in player.getInventory()) {
                    Console.Write("{0} | ", items);
                }
                Console.WriteLine();
                Console.WriteLine();
                player.setIsWin(true);
                return (Object)player;
                
            } else if (player.getHp() <= 0) {
                player.setIsWin(false);
                Console.WriteLine("플레이어 패배");
                return (Object)player;
            } else {
                return (Object)player;
            }

        }



        public Object LetsFight(Player player, Boss boss) {

            int dmgBoss = boss.Attack();
            calculate = new CalculateHP();
            player = calculate.Calculate(player, dmgBoss);
            Thread.Sleep(1000);
            Console.WriteLine();

            int dmgPlayer = player.Attack();
            boss = calculate.Calculate(boss, dmgPlayer);
            Thread.Sleep(1000);
            Console.WriteLine();


            if (boss.getHp() <= 0) {
                Console.WriteLine("플레이어 {0} 승리!", player.getName());
                String dropItem = boss.BossDead();
                player = calculate.CollectItem(player, dropItem);
                Console.WriteLine();
                Console.WriteLine("획득한 아이템: {0}", dropItem);

                Console.Write("내 인벤토리: ");
                foreach (String items in player.getInventory()) {
                    Console.Write("{0} | ", items);
                }
                Console.WriteLine();
                Console.WriteLine();
                player.setIsWin(true);
                return (Object)player;

            } else if (player.getHp() <= 0) {
                player.setIsWin(false);
                Console.WriteLine("플레이어 패배");
                return (Object)player;
            } else {
                return (Object)player;
            }

        }








    }




}
