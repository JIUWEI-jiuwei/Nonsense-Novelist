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
        description = "ѧ��ˤ�����150%���������˺�����ѣ1.5�롣";
        nickname.Add("��");
        nickname.Add("˦");
        nickname.Add("Ͷ��");
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new SingleSelector();
        attackDistance = 6;
        skillTime = 0;
        skillEffectsTime = 1.5f;
        cd=0;
        maxCD=6;
        prepareTime = 0.5f;
        afterTime = 0;
    }

    /// <summary>
    /// ���150%���������˺�
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (AbstractCharacter aim in aims)
        {
           skillMode.UseMode(useCharacter, useCharacter.atk  *(1-aim.def/(aim.def+20)), aim);
        }
        SpecialAbility(useCharacter);
    }
    /// <summary>
    /// ��ѣ1.5��
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach(AbstractCharacter aim in aims)
        {
            aim.dizzyTime = skillEffectsTime;
            aim.AddBuff(5);
        }
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return  character.wordName + "���Ҽ��������˳�ȥ��";

    }
}
