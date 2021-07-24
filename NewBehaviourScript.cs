using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehaviour : Unity 게임 오브젝트 클래스
public class NewBehaviourScript : MonoBehaviour
{
    // 전역변수
    string title = "전설의";
    string playerName = "채뚱";
    int level = 5;
    float strength = 15.5f;
    int exp = 1300;
    bool isFullLevel = false;
    int health = 30;
    int mana = 25;
    void Start()
    {
        Debug.Log("Hello UNITY!");

        // 1. 변수
        // int, float, string, bool 자료형
        // int level = 5;                 // 정수형 데이터
        // float strength = 15.5f;        // 숫자형 데이터
        // string playerName = "채뚱";     // 문자형 데이터
        // bool isFullLevel = false;      // 논리형 데이터

        // 프로그래밍 언어의 흐름 : 선언 > 초기화 > 호출
        // Debug.Log("용사의 이름은?");
        // Debug.Log(playerName);
        // Debug.Log("용사의 레벨은?");
        // Debug.Log(level);
        // Debug.Log("용사의 힘은?");
        // Debug.Log(strength);
        // Debug.Log("용사는 만렙인가?");
        // Debug.Log(isFullLevel);

        // 2. 그룹형 변수
        // 배열 : 가장 기본적인 고정형 그룹변수
        string[] monsters = {"슬라임", "사막뱀", "악마"};

        // Debug.Log("맵에 존재하는 몬스터");
        // Debug.Log(mosters[0]);
        // Debug.Log(mosters[1]);
        // Debug.Log(mosters[2]);

        int[] monsterLevel = new int[3];
        monsterLevel[0] = 2;
        monsterLevel[1] = 7;
        monsterLevel[2] = 13;

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        // Debug.Log(monsterLevel[0]);
        // Debug.Log(monsterLevel[1]);
        // Debug.Log(monsterLevel[2]);

        // 리스트 : 기능이 추가된 가변형 그룹형 변수
        List<string> items = new List<string>();    // 자료형 정해줘야 함
        items.Add("생명물약30");
        items.Add("마나물약30");

        // Debug.Log("가지고 있는 아이템");
        // Debug.Log(items[0]);
        // Debug.Log(items[1]);

        // items.RemoveAt(0);       // 가변형이므로 값 지우기 가능
    
        // 3. 연산자
        // int exp = 1300;

        exp = 1273 + 309;
        exp = exp - 19;
        level = exp / 200;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 328 - (exp % 200);    // % : 나머지 출력
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        // string title = "전설의";
        Debug.Log("용사의 이름은 ~~~~~~~? ");
        Debug.Log(title + " " + playerName);

        // 비교 연산자(==, >, <, >=, <=)
        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까???? " + isFullLevel);
    
        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        // 논리 연산자
        // int health = 30;    // 지역변수
        // int mana = 25;
        // bool isBadCondition = health <= 50 && mana <= 20;   // && : and
        bool isBadCondition = health <= 50 || mana <= 20;   // || : or

        // 삼항 연산자 
        // ? A:B : true일 때 A, false일 때 B 출력
        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

        // 4. 키워드
        // int float string bool new List : 변수명으로 사용 X

        // 5. 조건문
        if (condition == "나쁨") {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요!!!");
        }
        else {
            Debug.Log("플레이어 상태가 좋습니다~~!!");
        }

        if (isBadCondition && items[0] == "생명물약30") {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }

        else if (isBadCondition && items[0] == "마나물약30") {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }

        // switch, case : 변수값에 따라 로직 실행
        // switch (변수) {
        //     case 값1:
        //         break;
        //     case 값2:
        //         break;
        //     case 값3:
        //         break;
        // }

        switch (monsters[1]) {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터 출현!");
                break;
            default:    // 모든 case를 통과한 후 실행
                Debug.Log("??? 새로운 몬스터 출현!!!");
                break;
        }

        // 6. 반복문
        // while 문
        while (health > 0) {
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다." + health);
            else
                Debug.Log("사망하였습니다...");
            
            if (health == 10) {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        // for 문
        // for (연산될 변수 ; 조건 ; 연산) {
        //     로직
        // }
        for (int count = 0 ; count < 10 ; count++) {
            health++;
            Debug.Log("붕대로 치료 중..." + health);
        }

        // 그룹형 변수의 길이 : .Length(배열), .Count(리스트)
        for (int index = 0; index < monsters.Length; index++) {
            Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }

        // foreach : for의 그룹형변수 탐색 특화(위와 같은 결과)
        foreach (string monster in monsters) {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }

        // 7. 함수(method)
        // health = Healing(health);   // 매개변수
        Healing();

        for (int index = 0; index < monsters.Length; index++) {
            Debug.Log("용사는 " + monsters[index] + "에게 " + Battle(monsterLevel[index]));
        }

        // 8. 클래스
        // Character player = new Character();     // 클래스를 하나의 변수(player)로 담아줌
        // 인스턴스 : 정의된 클래스를 변수 초기화로 실체화
        // 상속 : Player 클래스가 Character 클래스를 상속받음
        Player player = new Player();
        // Character 클래스는 부모 클래스, Player 클래스는 자식 클래스가 된 것.

        player.id = 0;
        player.name = "채뚱";
        player.title = "똑똑한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name +  "의 레벨은 " + player.level + "입니다.");

        Debug.Log(player.move());
    }

    
    // 함수가 반환하는 값의 자료형을 맨 앞에 써줌
    int Healing(int currentHealth)     // 인자로 받는 자료형 int       
    {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다." + currentHealth);
        return currentHealth;          // 함수 값 반환
    }

    // void : 반환 데이터가 없는 함수 타입
    void Healing()
    {
        health += 10;
        Debug.Log("힐을 받았습니다." + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다 !!";
        else
            result = "졌습니다 .. ";
        
        return result;
    }

}
