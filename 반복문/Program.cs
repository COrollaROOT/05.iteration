namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
     //       // for (초기화;(int i = 0;) 조건식;(i < 10;) 증감연산(i++))
     //       for (int i = 0; i < 10; i++) // int 정수형 프로그램에선 0부터 쓰는게 룰
     //                                    // +1만 해주는 연산자 = ++ (증감 연산자)
                                           // ++i +가 앞에 있으면 먼저 더하고 바꾼다.
                                           // i++ +가 뒤에 있으면 먼저 바꾸고 더한다.
     //
     //
     //       {
     //           // 반복할 내용
     //           Console.WriteLine("똑같은 작업");
     //       }


            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("카운트 다운 {0}", i);
            }


        }
    }
}
