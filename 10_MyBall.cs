using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour {
    // 코드 흐름 : 선언 < 초기화 < 호출 순으로 작성

    Rigidbody rigid;

    void Start () {
        // 1. 컴포넌트 가져오기
        // GetComponent<T> : 자신의 T 타입 컴포넌트를 가져옴
        rigid = GetComponent<Rigidbody>();
        
        // 2. 속도 올리기(velocity : 현재 이동 속도)
        // rigid.velocity = Vector3.right;     // 굴러가는 방향 오른쪽으로
        // rigid.velocity = new Vector3(2, 4, 3);  // 굴러가는 방향 지정

        // 3. 힘으로 밀기
        // rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);      // 힘을 주는 방식(가속, 무게 등)
        // Mass값이 클수록 움직이는데 더 많은 힘이 필요.
    }

    // RigidBody 관련 코드는 FixedUpdate에 작성!!
    void FixedUpdate () {
        // rigid.velocity = new Vector3(2, 4, -1);  // Update 안에 쓰면 속도 계속 유지
    
        // 캐릭터 점프
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // 화살표 키보드를 눌러 공 자연스럽게 굴리기
        Vector3 vec = new Vector3(h, 0, v);
        rigid.AddForce(vec, ForceMode.Impulse);

        // 회전력
        // AddTorque(Vec) : Vec 방향을 축으로 회전력이 생김
        rigid.AddTorque(Vector3.back);
        // Vec을 축으로 삼으므로 이동방향 주의!
    }

    // 콜라이더가 계속 충돌하고 있을 때 호출.
    private void OnTriggerStay(Collider other) {
        if (other.name == "Cube")                                   // 큐브라는 이름의 물체에 들어가면
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);      // 위로 날아감
    }

    // 실제 물리적인 충돌로 발생하는 이벤트
    // void OnCollisionEnter(Collision collision) { }
    // void OnCollisionStay(Collision collision) { }
    // void OnCollisionExit(Collision collision) { }

    // 콜라이더 충돌로 발생하는 이벤트
    // void OnTriggerEnter(Collider other) { }
    // void OnTriggerStay(Collider other) { }
    // void OnTriggerExit(Collider other) { }

    public void Jump() {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}