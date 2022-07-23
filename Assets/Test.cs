using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour // 모노행동 ?? 이라는 특이하는 클래스 상속함
{
    // Start is called before the first frame update
    void Start() // 맨 처음에 딱 한번 실행됨
    {
        
    }

    // Update is called once per frame
    void Update() // 프레임마다 실행
    {
        transform.Rotate(new Vector3(1.0f,1.0f,1.0f));
    }
}

