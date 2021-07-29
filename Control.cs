using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Transform : 오브젝트 형태에 대한 기본 컴포넌트
    void Start()
    {
        // 벡터 : 방향과 그에 대한 크기 값
        // Vector3 vec = new Vector3(5, 0, 0);     // 벡터

        // 오브젝트 변수 transform을 항상 가지고 있음
        // .Translate() : 벡터 값을 현재 위치에 더하는 함수
        // transform.Translate(vec);   // 3차원의 벡터 값

        // int number = 3;     // 스칼라 : 순수 값
    }

    // Vector3 target = new Vector3(8, 1.5f, 0);
    Vector3 target = new Vector3(8, 1.5f, 0);
    
    void Update()
    {
        // 로켓처럼 하늘로 서서히 올라가기
        // Vector3 vec = new Vector3(0, 0.1f, 0);
        // X, Y차원 공간 자유 이동
        // Vector3 vec = new Vector3(
        //     Input.GetAxis("Horizontal"),
        //     Input.GetAxis("Vertical"), 
        //     0);
        // transform.Translate(vec);

        // 1. MoveTowards : 등속 이동
        // 매개 변수는 (현재 위치, 목표위치, 속도)로 구성
        // transform.position =
        //     Vector3.MoveTowards(transform.position,
        //                         target, 1f);

        // 2. SmoothDamp : 부드러운 감속 이동
        Vector3 velo = Vector3.zero;    // 속도
        
        // 마지막 매개변수에 반비례하여 속도 증가
        // ref : 참조 접근 -> 실시간으로 바뀌는 값 적용 가능
        // transform.position = 
        //     Vector3.SmoothDamp(transform.position,
        //                         target, ref velo, 0.1f);
        // 값을 작게 줄수록 빨리 움직임
        
        // 3. Lerp : 선형 보간, SmoothDamp보다 감속시간이 긺
        // 마지막 매개변수에 비례하여 속도 증가(최댓값 1)
        // transform.position = 
        //     Vector3.Lerp(transform.position,
        //                         target, 0.05f);

        // 4. Slerp : 구면 선형 보간, 호를 그리며 이동(포물선 이동)
        transform.position = 
            Vector3.Slerp(transform.position,
                                target, 0.05f);
    }

}
