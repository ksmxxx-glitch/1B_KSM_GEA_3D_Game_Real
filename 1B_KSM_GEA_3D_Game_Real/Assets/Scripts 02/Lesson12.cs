using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    [ContextMenu("흩어진 값")]
    void SeparateVariables()
    {
        string[] names = { "슬라임", "고블린" };
        int[] hps = { 30, 50 };
        int[] attacks = { 5, 8 };

        hps[1] -= 20;
        Debug.Log(names[1] + " " + hps[1] + " " + attacks[1]);
    }

}
