// 게임 오브젝트에 들어가는 몇 가지 중요한 데이터들 변수로 만들고,
// 캐릭터가 행동할 수 있는 일들을 함수로 만들기
public class Character {

    public int id;      // public : 외부 클래스에 공개로 설정하는 접근자
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "대화를 걸었습니다.";
    }

    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        level += 1;
    }
}
