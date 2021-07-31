using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MashRenderer mesh;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<>();
        mat = mash.material;    
    }

    // OnCollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수
    // Collision : 충돌 정보 클래스
    // Color :기본 색상 클래스, Color32 : 255색상 클래스
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);
        
    }
    // OnCollisionExit : 물리적 충돌하고 있을 때 호출되는 함수
    // private void OnCollisionStay(Collision collision) {
        
    // }
    // // OnCollisionExit : 물리적 충돌 끝났을 때 호출되는 함수
    // private void OnCollisionExit(Collision collision) {
        
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}
