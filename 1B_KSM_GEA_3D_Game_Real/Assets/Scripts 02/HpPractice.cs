using UnityEngine;

public class HpPractice : MonoBehaviour
{

    public int currentHp;
    public int MaxHp;

    [ContextMenu("체력")]
    void PrintHp()
    {
        int h = currentHp * 100 / MaxHp;
        Debug.Log("HP " + h + "%");

    }

}
