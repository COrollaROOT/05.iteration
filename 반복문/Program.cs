namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for 반복문 몇회 반복하자
            //       // for (초기화;(int i = 0;) 조건식;(i < 10;)얼마만큼 증감연산(i++)얼마 증가)
            //       for (int i = 0; i < 10; i++) // int 정수형 프로그램에선 0부터 쓰는게 룰
            //                                    // +1만 해주는 연산자 = ++ (증감 연산자)
            // ++i +가 앞에 있으면 먼저 더하고 바꾼다.
            // i++ +가 뒤에 있으면 먼저 바꾸고 더한다.
            //
            //         for (int i = 0; i < 10; i++)
            //       {
            //           // 반복할 내용
            //           Console.WriteLine("똑같은 작업");
            //       }
            //
            // 카운트 다운 (빼기)
            //  for (int i = 5; i > 0; i--) 
            //  {
            //      Console.WriteLine("카운트 다운 {0}", i);
            //  }
            //

            // for 반복문에 조건 넣기
            // 369게임 특정 수에서 특정 행동하게 하기
            //   Console.WriteLine("369 369 369 369");
            //   for (int i = 0; i < 10; i++) 
            //   {
            //       if (i == 3 || i == 6 || i == 9) // ||는 또는 ==은 같을때 (i % 3 == 0)처럼 응용 가능
            //       {
            //           Console.WriteLine("짝!");
            //       }
            //
            //       else // 3,6,9도 아닐경우
            //       {
            //           Console.WriteLine(i); // i 숫자 출력
            //       }
            // }

            //    Console.WriteLine("홀짝~");
            //    for (int i = 1; i < 10; i++)
            //    {
            //        if (i % 2 == 0) // 짝
            //        {
            //            Console.WriteLine("{0} : 짝", i);
            //        }
            //        else // 홀
            //        {
            //             Console.WriteLine("{0} : 홀", i);
            //        }
            //
            //    }
            //
            //  for문의 for문 사용 하여 구구단 만들기
            //    Console.WriteLine("구구단");
            //    for (int dan = 2; dan <= 9; dan++)
            //    {
            //        Console.WriteLine("{0}단", dan);
            //        for (int number = 1; number <= 9; number++)
            //        {
            //            Console.WriteLine("{0} * {1} = {2}", dan, number, dan * number);
            //        }
            //        Console.WriteLine();
            //    }



            //    // 반복의 반복문
            //    for (int group = 1; group <= 10; group++) // {0}반 반복
            //    
            //    {
            //        for (int student = 1; student <= 10; student++) //{1}번째 학생 반복
            //        {
            //            Console.WriteLine("{0}반의 {1}번째 학생", group, student); // 반복 결과값
            //        }
            //    }

            // while 반복문 (될때까지 한다)
            //동전 교환기 (코인이 남아 있을때 까지 꺼낸다)
            //   int coin = 500; // 
            //   while (coin > 0) // 이거 되면 계속
            //   {
            //       Console.WriteLine("100원 동전을 꺼냅니다."); // 메세지 출력
            //       coin -= 100; // 반복할때마다 -
            //   }
            //




            // hp가 0일때까지 살아있는다 예시



            //do while 반복문 (한번은 해보고 체크 아니면 다시, 맞으면 돌아간다)
            // 무조건 한번은 실행한다
            //    int choice;
            //    do
            //    {
            //        Console.Write("1에서 9 사이의 수를 입력하세요 : "); // 메세지 출력
            //        string input = Console.ReadLine(); // 작성자가 입력한 메세지 
            //        int.TryParse(input, out choice );  // 
            //
            //    } while ((1 <= choice && choice <= 9) == false);

            // 반복문 while 키워드 [break] [continue]


            // break 제어문
            //   while (true)
            //   {
            //
            //       Console.WriteLine("1");
            //       Console.WriteLine("2");
            //       Console.WriteLine("3");
            //       Console.WriteLine("4");
            //       Console.WriteLine("5");
            //
            //       break;
            //
            //       Console.WriteLine("6");
            //       Console.WriteLine("7");
            //       Console.WriteLine("8");
            //       Console.WriteLine("9");
            //       Console.WriteLine("10");
            //
            //
            //   }
            //   Console.WriteLine("프로그램 종료");


         //      int potionPos = 12;
         //   for (int i = 1; i < 1000; i++)
         //   {
         //       Console.WriteLine("{0}번째칸에서 포션이 있는지 확인 합니다.", i);
         //       if (i == potionPos)
         //       {
         //           Console.WriteLine("포션을 찾았습니다.");
         //           Console.WriteLine("포션을 사용합니다.");
         //           break;
         //       }
         //   }
         //
         int num = 35;
         for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num}을 나눌 수 있는 가장 작은 수는 {i} 입니다.");
                    break;
                }
            }
         


                //  while (true)
                //  {
                //      Console.WriteLine("1.공격한다. 2. 방어한다. 3. 도망친다.");
                //      Console.Write("행동을 선택하세요 : ");
                //      string input = Console.ReadLine();
                //
                //      if (input == "1")
                //      {
                //          Console.WriteLine("플레이어가 공격합니다.");
                //      }
                //      else if (input == "2")
                //      {
                //          Console.WriteLine("플레이어가 방어합니다.");
                //      }
                //      else if (input == "3")
                //      {
                //          Console.WriteLine("플레이어가 도망칩니다.");
                //          break;
                //      }
                //      else
                //      {
                //          Console.WriteLine("잘못 입력 하셨습니다.");
                //      }
                //      Console.WriteLine();
                //  }

                //  while (true)
                //    {
                // 
                //        Console.WriteLine("1");
                //        Console.WriteLine("2");
                //        Console.WriteLine("3");
                //        Console.WriteLine("4");
                //        Console.WriteLine("5");
                // 
                //        continue;
                // 
                //        Console.WriteLine("6");
                //        Console.WriteLine("7");
                //        Console.WriteLine("8");
                //        Console.WriteLine("9");
                //        Console.WriteLine("10");
                // 
                // 
                //    }
                //    Console.WriteLine("프로그램 종료");

                //홀수는 아군 짝수는 적군
                // continue 제어문
                //    for (int i = 1; i <= 8; i++)
                //    {
                //        if (i % 2 == 1)
                //            continue;
                //
                //        Console.WriteLine("{0}번 플레이어를 공격합니다", i);
                //    }




            }
        }
}





﻿namespace _04._Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************
             * 반복문 (Iteration)
             *
             * 블록을 반복적으로 실행하는 문장
             ****************************************************************/

            /****************************************************************
             * while 반복문
             *
             * 조건식의 true, false에 따라 블록을 반복하는 반복문
             ****************************************************************/

            int coin = 400;
            while (coin > 0)
            {
                Console.WriteLine("100원 동전을 꺼냅니다.");
                coin -= 100;
            }



            /****************************************************************
             * do while 반복문
             *
             * 블록을 한번 실행 후 조건식의 true, false에 따라 블록을 반복하는 반복문
             ****************************************************************/

            int input;
            do
            {
                Console.Write("1 에서 9 사이의 수를 입력하세요 : ");
                string text = Console.ReadLine();
                int.TryParse(text, out input);
            } while (input < 1 || 9 < input);



            /****************************************************************
             * for 반복문
             *
             * 초기화, 조건식, 증감연산 으로 구성된 반복문
             ****************************************************************/

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"for 반복문 반복횟수 : {i}");
            }



            /****************************************************************
             * foreach 반복문
             * 
             * 반복가능한 데이터집합의 처음부터 끝까지 반복
             ****************************************************************/

            int[] intArray = { 1, 3, 5, 7, 9, 8, 6, 4, 2, 0 };
            foreach (int element in intArray)
            {
                Console.WriteLine($"foreach 반복문의 현재 요소 : {element}");
            }



            /****************************************************************
             * 제어문
             *
             * 프로그램의 순차적인 실행 중 다른 문으로 제어를 전송
             ****************************************************************/

            /****************************************************************
             * break 제어문
             *
             * 가장 가까운 반복문을 종료
             ****************************************************************/

            int num = 35;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num}을 나눌 수 있는 가장 작은 수는 {i} 입니다.");
                    break;
                }
            }



            /****************************************************************
             * continue 제어문
             *
             * 가장 가까운 반복문의 새 반복을 시작
             ****************************************************************/

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                if (i % 3 == 0)
                    continue;

                Console.WriteLine($"{i}은 2의 배수와 3의 배수가 아닙니다.");
            }
        }
    }
}
