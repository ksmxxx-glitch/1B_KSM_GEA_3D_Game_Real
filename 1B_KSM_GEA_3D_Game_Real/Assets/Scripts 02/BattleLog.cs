using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int total = 0;
        List<int> criticals = new List<int>();

        foreach (int damage in damages)
        {
            total += damage;

            if (damage >= criticalLine)
            {
                criticals.Add(damage);
            }
        }

        Debug.Log("총 데미지 " + total);
        Debug.Log("치명타 " + criticals.Count + " 회");

        foreach (int critical in criticals)
        {
            Debug.Log("치명타 " + critical);
        }
    }
}


//할 일 1
//foreach 로 damages 를 돌며 총 데미지를 구함
//할 일 2
//criticalLine 이상인 데미지는 치명타. List<int> criticals 에 추가
//할 일 3
//총 데미지, 치명타 횟수 (List 의 칸 수), 치명타를 한 줄씩 출력
//조건
//Inspector 에서 두 필드의 값을 바꿔도 코드 수정 없이 동작


//과제 확인: 테스트 Set과 제출
// 1]  1200, 3500, 800, 12000, 3500, 950  (기본값) || 3000
// 2] 3000 || 3000
// 3] 999999, 250000, 999999, 500000 || 300000
// 4] 0 칸(Size 를 0 으로) || 3000

//다음 수업 전까지 개인 저장소 GEA_2026 에 커밋, Push. 구글 클래스룸에 저장소 링크 + 커밋 해시. Set 1 과 Set 3 의 Console 캡처 첨부