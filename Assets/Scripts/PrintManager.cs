using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintManager : MonoBehaviour
{

    #region Singleton
    private static PrintManager instance;
    public static PrintManager Instance { get { return instance; } }
    #endregion
    
    void Awake()
    {
        instance = this;
    }

    public delegate void PrintDelegate(string s);
    // 이벤트 클래스는 알림을 통해 구독자가 추가한 함수를 간접적으로 실행시킬 수 있는 권한은 가지고 있지만
    // 실제로 함수를 실행하는 것은 해당 함수를 가진 구독자 클래스 라는 것을 헷갈리면 안된다.
    // 이벤트는 특정 상황의 발생을 알려주는 트리거의 역할일 뿐이다.
    public event PrintDelegate PrintAllEvent;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //스페이스바를 누르면 이벤트 발생
        {
            if (PrintAllEvent != null)
                PrintAllEvent("print out!"); //이벤트 발생

            //혹은 이렇게 써도 동일함
            //PrintAllEvent?.Invoke("print out!");
        }

    }
}
