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
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {

    }
    /// <summary>
    /// ȫѡ�����999��
    /// </summary>
    /// <param name="attackDistance">�����0����</param>
    /// <returns></returns>
    override public GameObject[] CalculateAgain(float attackDistance, GameObject character)
    {
        GameObject[] a = attackRange.AttackRange(999, character.transform, extra);
        return a;
    }
}
