using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour {
    // 코드 흐름 : 선언 < 초기화 < 호출 순으로 작성

    RigidBody rigid;

    void Start () {
        // 1. 컴포넌트 가져오기
        // GetComponent<T> : 자신의 T 타입 컴포넌트를 가져옴
        rigid = GetComponent<RigidBody>();
        
        // 2. 속도 올리기(velocity : 현재 이동 속도)
        rigid.velocity = Vector3.right;
    }

    void Update () {
        
    }
}