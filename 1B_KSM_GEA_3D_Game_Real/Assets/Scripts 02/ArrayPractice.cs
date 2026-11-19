using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    public int[] golds = { 300, 1200, 50, 800 };

    [ContextMenu("배열 실습")]
    void ShowGolds()
    {
        int total = 0;
        for (int i = 0; i < golds.Length; i++)
        {
            Debug.Log(i + "번: " + golds[i]);
            total += golds[i];
        }
        Debug.Log("합계 " + total);
    }


}


//     {
//        int[] scores = { 300, 1200, 50, 800 };
//        int sum = 0;
//        for (int i = 0; i < scores.Length; i++)
//        {
//            sum += scores[i];
//        }
//        Debug.Log("합계 " + sum);
//    }