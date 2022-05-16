using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ͬƵ����
/// </summary>
class TongPinGongZhen: AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 9;
        wordName = "ͬƵ����";
        bookName = BookNameEnum.CrystalEnergy;
        banUse.Add(gameObject.AddComponent<Girl>());
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new CircleAttackSelector();
        percentage = 0;
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 1.5f;
        cd=maxCD=5;
        comsumeSP = 10;
        prepareTime = 1;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }

    private AbstractCharacter aimState;//Ŀ��ĳ����ɫ��
    /// <summary>
    /// �������Ѿ��ظ�5��SP
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            aimState = aim.GetComponent<AbstractCharacter>();
        }
        SpecialAbility(useCharacter);
    }

    /// <summary>
    /// �����е�����ѣ1.5��
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach (GameObject aim in aims)
        {
            AbstractCharacter a = aim.GetComponent<AbstractCharacter>();
            a.dizzyTime = skillEffectsTime;
            a.AddBuff(5);
        }
    }

}
