using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��Ѫ
/// </summary>
class CureMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 3;
        skillModeName = "��Ѫ";
    }
    public override void UseMode(AbstractCharacter useCharacter,float value, AbstractCharacter aimCharacter)
    {
        if (value > 0)
        {
            aimCharacter.hp += (int)value;
        }
    }
    /// <summary>
    /// �ٴμ���������Ŀ��(��Ѫ���ѷ���
    /// </summary>
    /// <param name="character">ʩ����</param>
    /// <returns></returns>
    override public GameObject[] CalculateAgain(float attackDistance, GameObject character)
    {
        CampEnum camp = character.GetComponent<AbstractCharacter>().camp;
        GameObject[] a = base.CalculateAgain(attackDistance, character);
        if (a != null)
        {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == camp);
        }
        CollectionHelper.OrderBy<GameObject, float>(a, p => p.GetComponent<AbstractCharacter>().hp);

        return a;
    }
}
