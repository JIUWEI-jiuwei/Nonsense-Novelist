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
        attackRange = new CircleAttackSelector();
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {

    }
    /// <summary>
    /// ȫѡ�����999��
    /// </summary>
    /// <param name="attackDistance"></param>
    /// <returns></returns>
    override public GameObject[] CalculateAgain(float attackDistance, GameObject character)
    {
        GameObject[] a = base.CalculateAgain(attackDistance, character);
        return a;
    }
}
