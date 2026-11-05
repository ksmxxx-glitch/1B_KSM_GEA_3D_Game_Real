using UnityEngine;
using static UnityEngine.LowLevelPhysics2D.PhysicsLayers;

public class RewardCalc : MonoBehaviour
{

    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.5f;


    [ContextMenu("정산")]

    void Adjustment ()
    {
        Debug.Log("플레이 시간: " + playSeconds / 3600 + ("시간 ") + (playSeconds % 3600) / 60 + ("분 ") + ((playSeconds % 3600) % 60) + ("초"));
        //  Debug.Log("골드 분배: " + );
        //   Debug.Log("경험치: " + );
        //   Debug.Log("레벨: " + );
        Debug.Log("평균 데미지: " + totalDamage / hits + (".") );

    }

}

//    void Adjustment ()
//    {
//      Debug.Log("플레이 시간: " + playSeconds/3600 + ("시간 ") + (playSeconds%3600)/60  + ("분 ") + ((playSeconds%3600)%60) + ("초"));
//      Debug.Log("1인당 " + (gold / members)-(보너스 골드) + ("G, 리더 보너스 ") + (보너스 골드) + ("G"));
//      Debug.Log("경험치: " + (kills*expPerKill)*(배율) + ("(기본: ") + kills*expPerKill + ("Exp)");
//      Debug.Log("Lv " + (최종경험치)/100 + (", 다음 레벨까지") + 100 - ((최종경험치)/100));
//      Debug.Log("평균 데미지: " + totalDamage / hits + (".") + ( 소수점 아래 값) );
//    }


