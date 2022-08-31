using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
class PlatformMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 6;
        skillModeName = "����ħ��";
        attackRange = new SingleSelector();
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {

    }
    /// <summary>
    /// ȫѡ�����999��
    /// </summary>
    /// <param name="attackDistance"></param>
    /// <returns></returns>
    override public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation, NeedCampEnum.all);
        return a;
    }
}
