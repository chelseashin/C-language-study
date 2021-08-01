using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    // Input : 게임 내 입력을 관리하는 클래스
    void Update()
    {
        // anyKeyDown : 아무 입력을 최초로 받을 때 true
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
    
        // anyKey : 아무 입력을 받으면 true
        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        // 각 입력함수 3가지로 구분 : 누를 때, 누르고 있을 때, 뗄 때
        // GetKey : 키보드 버튼 입력을 받으면 true
        if (Input.GetKeyDown(KeyCode.Return))   // 엔터 키 
            Debug.Log("아이템을 구입했습니다.");

        if (Input.GetKeyDown(KeyCode.LeftArrow))   // 왼쪽 화살표 키 
            Debug.Log("왼쪽으로 이동 중...");
        
        if (Input.GetKeyUp(KeyCode.RightArrow))   // 왼쪽 화살표 키 
            Debug.Log("오른쪽으로 이동 중...");

        // GetMouse : 마우스 버튼 입력 받으면 true
        // 0 : 마우스 왼쪽 버튼, 1: 오른쪽 버튼
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사 준비");

        // 누르고 있는 상태
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중....");

        // 마우스 뗄 때 상태
        if (Input.GetMouseButtonUp(0))
            Debug.Log("미사일 발사!!");

        // GetButton : Input 버튼 입력을 받으면 true
        // 문자열은 지정된 키보드 버튼 이름으로 설정!
        // if (Input.GetButtonDown("Jump"))     
        //     Debug.Log("점프 준비!");
        
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중....");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!!!");

        // Button 새로 추가, 변경 가능
        if (Input.GetButtonDown("SuperPower"))
            Debug.Log("필살기 시전!!!!");

        // 횡 이동
        if (Input.GetButton("Horizontal")) {
            // GetAxis : 수평, 수직 버튼 입력받으면 float
            Debug.Log("횡 이동 중......" + Input.GetAxis("Horizontal"));

        }

        if (Input.GetButton("Vertical")) {
            // GetAxis : 수평, 수직 버튼 입력받으면 float
            Debug.Log("종 이동 중......" + Input.GetAxis("Vertical"));

        }
            
    }
}
