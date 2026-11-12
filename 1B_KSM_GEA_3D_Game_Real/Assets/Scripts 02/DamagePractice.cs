using UnityEngine;

public class DamagePractice : MonoBehaviour

{

    //attack, defense (public int), isCritical, targetIsBoss (bool)

    public int attack = 12;
    public int defense = 5;
    public bool isCritical = true;
    public bool targetIsBoss = true;


    [ContextMenu("데미지")]
    void Calc()
    {
        int Damage = attack - defense;
        int FinalDamage = Damage < 1 ? 1 : Damage;

        //  damage = Mathf.Max(damage, 1);
        //  damage = damage < 1 ? 1 : damage;


        if (isCritical)
        {
            Damage = Damage * 2;
        }

        if (targetIsBoss)
        {
            Damage = Damage / 2;
        }
        Debug.Log(Damage);

    }


}
