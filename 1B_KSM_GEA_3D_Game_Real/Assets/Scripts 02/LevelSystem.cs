using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;          // 몬스터 한 마리의 경험치
    public int killCount = 3;               // 잡은 마릿수

    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
  //      int level = 1; int exp = 0;

        
    }
//    Debug.Log(level + " " + exp);
}



//  규칙 1
// 몬스터를 killCount 마리 잡음. 한 마리 잡을 때마다 exp 에 expPerKill 을 더함

// 규칙 2
// 레벨업에 필요한 경험치 = 지금 레벨 × 10000. exp 가 그 이상이면 그만큼 빼고 레벨을 1 올린 뒤 레벨업! Lv 2 (1마리째) 출력. 괄호 안은 몇 마리째를 잡았을 때인지

// 규칙 3
// 한 마리를 잡았을 때 레벨이 두 번 이상 오를 수도 있음

// 마지막 출력
// 전부 잡은 뒤 한 줄: 최종 Lv 5, 경험치 5000 / 50000   (50000은 지금 레벨의 필요 경험치)


//     [ContextMenu("레벨업")]
//      void LevelUp()
//      {
//         int level = 1;
//         int exp = 45000;
//         while (exp >= level * 10000)
//            {
//                exp -= level * 10000;
//                level++;
//             }
//           Debug.Log(level + " " + exp);
//      }

