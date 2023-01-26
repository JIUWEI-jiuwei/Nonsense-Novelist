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
    override public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation,NeedCampEnum.friend);
        CollectionHelper.OrderBy(a, p => p.hp);

        return a;
    }
}
