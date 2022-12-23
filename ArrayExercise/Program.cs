
namespace ArrayExercise {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("첫번째 문자열을 입력하시오: "); 
            String firstString = Console.ReadLine();
            Console.Write("두번째 문자열을 입력하시오: "); 
            String secondString = Console.ReadLine();
            

            if(firstString == secondString) {
                Console.WriteLine("같다");

            } else {
                Console.WriteLine("다르다");
            }




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            String[] drinkName = new string[] { "콜라", "물", "스프라이트", "주스", "커피" };
            
            int inputIdx=0;

            


            Console.Write("1. 콜라\t2. 물\t3. 스프라이트\t4. 주스\t5. 커피: ");
            int.TryParse(Console.ReadLine(), out inputIdx);


            

            switch (inputIdx) {


                case 1:
                    Console.WriteLine("{0} 이(가) 뽑혔습니다.", drinkName[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} 이(가) 뽑혔습니다.", drinkName[1]);
                    break;
                case 3:
                    Console.WriteLine("{0} 이(가) 뽑혔습니다.", drinkName[2]);
                    break;
                case 4:
                    Console.WriteLine("{0} 이(가) 뽑혔습니다.", drinkName[3]);
                    break;
                case 5:
                    Console.WriteLine("{0} 이(가) 뽑혔습니다.", drinkName[4]);
                    break;

                default:
                    Console.WriteLine("index out of range");
                    break;


            }

            




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int[] days = new int[] {
                31,29,31,30,31,30,31,31,30,31,30,31
            }; 


            for(int idx = 0; idx< days.Length; idx++) {
                Console.WriteLine("{0}월은 {1}일까지 입니다.", idx+1, days[idx]);
            }

            



        }
    }
}