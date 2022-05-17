using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ˤ
/// </summary>
class FallBadly : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 4;
        wordName = "ˤ";
        bookName = BookNameEnum.HongLouMeng;
        description = "������������ˤ��Է�";
        nickname.Add("��");
        nickname.Add("˦");
        nickname.Add("Ͷ��");
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange =new CircleAttackSelector();//
        percentage = 1.5f;
        attackDistance = 6;
        skillTime = 0;
        skillEffectsTime = 1.5f;
        cd=0;
        maxCD=6;
        comsumeSP = 0;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }

    private AbstractCharacter aimState;//Ŀ��ĳ����ɫ��
    /// <summary>
    /// ���150%���������˺�
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            aimState = aim.GetComponent<AbstractCharacter>();
           skillMode.UseMode(useCharacter, useCharacter.atk * percentage *(1-aimState.def/(aimState.def+20)), aimState);
        }
        SpecialAbility(useCharacter);
    }
    /// <summary>
    /// ��ѣ1.5��
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach(GameObject aim in aims)
        {
            AbstractCharacter a = aim.GetComponent<AbstractCharacter>();
            a.dizzyTime = skillEffectsTime;
            a.AddBuff(5);
        }
    }
    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return  character.wordName + "���Ҽ��������˳�ȥ��";

    }
}
