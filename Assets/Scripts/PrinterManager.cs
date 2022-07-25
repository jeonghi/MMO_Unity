using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManager : MonoBehaviour
{
    // 1. 델리게이트(대리자)의 형태(시그니처)를 정의한다. 시그니처란 반환 타입과 매개변수를 말한다.
    // PrintDelegate 는 "반환 타입이 void 이고 매개변수로 하나의 string 값을 가지는 함수를 담는다"라고 정의 되었다.
    // 여기서는 단순히 델리게이트의 하나의 특정 형태를 PrintDelegate 라고 이름을 붙여 정의했다라고 생각하면 된다.
    public delegate void PrintDelegate(string s);
    
    void Start()
    {
        // 2. 대리자도 하나의 클래스이므로 참조변수를 사용해야한다.
        // 앞서 정의된 델리게이트 자체는 특정한 형태의 타입을 가진 클래스이기 때문에 바로 함수를 담을 수는 없다.
        // 그래서 대리자의 참조 변수를 선언하고 그 변수에 함수를 넣어야한다.
        // int = 5 (x) , int x = 5 (o)
        PrintDelegate PrintAll = PrintMessage1;
        
        // 4. 연산자를 통해 함수를 추가, 삭제할 수 있다.
        // 대리자는 마치 체인처럼 함수들을 연결할 수 있다.
        // += 추가
        // -= 삭제
        // = 새로 할당 ( 이전에 담았던 함수가 사라지고 할당되니 주의해서 사용할 것. )
        PrintAll += PrintMessage2;
        
        // 5. 대리자를 실행하기 전 null 검사를 해야한다.
        // 어떤 함수도 할당되지 않은 상태에서 대리자를 실행시키게 되면 NullReferenceException 이 생기기 때문에 반드시 null 검사가 필요하다.
        if (PrintAll != null)
        {
            PrintAll("출력 실시");
        }
    }
    // 3. 대리자의 형태와 할당될 함수의 형태가 같아야한다.
    // 앞서 정의한 대리자의 시그니처는 하나의 타입과도 같기 때문에 담으려는 함수가 이와 다른 형태를 가지고 있으면 할당 되지 않는다.
    // 앞서 정의한 PringDelegate 대리자의 시그니처는 (string) -> (void) 이다.
    void PrintMessage1(string s)
    {
        Debug.Log("Message 1 is " + s);
    }

    void PrintMessage2(string s)
    {
        Debug.Log("Message 2 is " + s);
    }
}
