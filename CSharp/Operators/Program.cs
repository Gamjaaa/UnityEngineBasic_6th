using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 5;
            int c = 0;

            // 산술 연산
            // 더하기, 빼기, 나누기, 곱하기, 나머지
            //==================================================================

            // 더하기
            c = a + b;
            Console.WriteLine(c);

            // 빼기
            c = a - b;
            Console.WriteLine(c);

            // 나누기 - 정수연산시 나머지 버림
            c = a / b;
            Console.WriteLine(c);

            // 곱하기
            c = a * b;
            Console.WriteLine(c);

            // 나머지 - 실수 연산시 정수연산과 동일함
            c = a % b;
            Console.WriteLine(c);

            // 증감 연산
            // 증가, 감소 연산자
            //==================================================================

            // 증가
            ++c; // 전위연산 // c = c + 1;
            c++; // 후위연산

            c = 0;
            Console.WriteLine(++c); // result : 1
            Console.WriteLine(c++); // result : 0

            // 감소
            --c; // c = c - 1;
            c--;

            // 관계 연산
            // 같음, 다름, 크기 비교 연산
            //==================================================================

            // 같음
            Console.WriteLine(a == b);

            // 다름
            Console.WriteLine(a != b);

            // 크다
            Console.WriteLine(a > b);

            // 작다
            Console.WriteLine(a < b);

            // 크거나 같다
            Console.WriteLine(a >= b);

            // 작거나 같다
            Console.WriteLine(a <= b);

            // 대입 연산
            // (더해서, 빼서, 나누어서, 곱해서, 나머지구해서) 대입
            //==================================================================

            c = 20;
            Console.WriteLine($"C value = {c}");
            c += b;
            Console.WriteLine(c);
            c -= b;
            Console.WriteLine(c);
            c /= b;
            Console.WriteLine(c);
            c *= b;
            Console.WriteLine(c);
            c %= b;
            Console.WriteLine(c);

            // 논리 연산
            // 논리형의 피연산자들을 대상으로 연산수행
            // or, and, xor, not
            //==================================================================

            bool A = true;
            bool B = false;

            // or
            // A 와 B 둘중 하나라도 true 이면 true 반환, 나머지경우 false 반환
            Console.WriteLine(A | B);

            // and
            // A 와 B 둘 다 true 이면 true 반환 ,나머지경우 false 반환
            Console.WriteLine(A & B);

            // xor
            // A 와 B 둘중 하나만 true 일때 true 반환, 나머지경우 false 반환
            Console.WriteLine(A ^ B);

            // not
            // 피연산자 값을 반전
            Console.WriteLine(!A);
        }
    }
}