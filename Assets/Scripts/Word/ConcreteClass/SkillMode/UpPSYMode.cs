using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����������
/// </summary>
class UpPSYMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 2;
        skillModeName = "״̬����";
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
        aimCharacter.psy += value;

    }
    /// <summary>
    /// �ٴμ���������Ŀ��
    /// </summary>
    /// <param name="character">ʩ����</param>
    /// <returns></returns>
    override public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation, NeedCampEnum.friend);
        CollectionHelper.OrderByDescending(a, p => p.allValue);
        return a;
    }
}
