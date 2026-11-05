
using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName = "Name";
    public int level = 1;
    public float attack = 10f;
    public bool isBoss = true;

    [ContextMenu("스탯 보기")]
    void ShowStat()
    {
        Debug.Log("플레이어 이름: " + playerName);
        Debug.Log("레벨: " + level);
        Debug.Log("공격력: " + attack);
        Debug.Log("보스 여부: " + isBoss);

    }
    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);
        gold = gold + 1;
        Debug.Log(gold);
        byte red = 255;
        red++;
        Debug.Log(red);
    }

    [ContextMenu("예측 3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합: " + a + b);
        Debug.Log("합: " + (a + b));
        Debug.Log(a + b + "점");
        Debug.Log("HP " + 7 / 2);
    }

}
