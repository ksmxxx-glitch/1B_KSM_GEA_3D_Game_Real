using UnityEngine;

public class Battle : MonoBehaviour
{
    public int heroHp = 100;
    public int heroAttack = 30;
    public int heroDefense = 10;
    public int monsterHp = 80;
    public int monsterAttack = 25;
    public int monsterDefense = 5;
    void Attack(int turn, Fighter attacker, Fighter target)
    {
        // 5. 작성
    }

    [ContextMenu("전투")]
    void StartBattle()
    {
        // 6. 작성
    }
}

