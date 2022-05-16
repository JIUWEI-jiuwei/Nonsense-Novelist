using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����ɴ֮��
/// </summary>
class QiChongShaDance : AbstractVerbs
{
    public void Awake()
    {
        skillID = 6;
        wordName = "����ɴ֮��";
        bookName = BookNameEnum.Salome;
        banUse.Add(gameObject.AddComponent<Girl>());
        skillMode = gameObject.AddComponent<SpecialMode>();
        skillMode.attackRange = new CircleAttackSelector();
        percentage = 5;// �������Ѿ��ظ�5��SP
        attackDistance = 7;
        skillTime = 0;
        skillEffectsTime = 0;
        cd=maxCD=5;
        comsumeSP = 0;
        prepareTime = 0;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }
    /// <summary>
    /// �������Ѿ��ظ�5��SP
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            AbstractCharacter aimState= aim.GetComponent<AbstractCharacter>();
            skillMode.UseMode(useCharacter,percentage, aimState);
        }
    }
    
    
}