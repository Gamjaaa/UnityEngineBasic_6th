using System;

namespace ClassObjectInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            // new 키워드 : 동적할당 키워드
            Human human = new Human();
            // L-value : Human 클래스 타입의 참조 지역변수
            // R-value : Human 객체 생성 후 반환된 객체
            
            // .연산자 (멤버 접근연산자)
            human.SayAge();
            human.SayName();

            // Class:
            // 객체 타입

            // Object :
            // 객체 : Class 타입으로 메모리 공간을 확보한 것

            // Instance :
            //객체 (데이터가 할당된 경우)

            // Instance 는 Object에 포함된다

        }
    }

    class Human // 다중선택 alt shift 아래 화살표
    {
        // 접근 제한자
        // public : 다른 객체가 접근가능
        // protected : 상속받은 자식 객체만 접근가능
        // private : 다른객체 접근 불가능
        // internal : 동일 어셈블리 내에서 다른 객체가 접근 가능
        // 캡슐화 : 멤버들에 보호처리 / 연산처리 등을 추가해주기위한 과정
        private int age = 2;
        private float height = 20.0f;
        private double weight = 20.0;
        private bool isResting = true;
        private char gender = 'W';
        private string name = "아무개";

        // C#에는 두가지 접근 형식이 있음
        // 값 타입, 참조 타입
        // 값타입 : 할당된 메모리에 데이터를 직접쓰고 읽는 형태
        // 참조타입 : 할당된 메모리의 주소를 통해서 간접적으로 데이터를 쓰고 읽는 형태

        // 생성자
        // 해당 클래스타입의 객체를 힙영역에다가 할당한 다음 해당 영역의 참조를 반환하는 함수
        public Human()
        {

        }

        // 소멸자
        // 힙영역에 할당되었던 객체를 메모리에서 해제하기 위해 호출하는 함수
        ~Human()
        {

        }

        public void SayAge()
        {
            Console.WriteLine(age);
        }

        public void SayHeight()
        {
            Console.WriteLine(height);
        }

        public void SayName()
        {
            Console.WriteLine(name);

        }
    }


}
