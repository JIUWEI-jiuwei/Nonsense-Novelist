using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ҩ
/// </summary>
class FuYao : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 5;
        wordName = "��ҩ";
        bookName = BookNameEnum.HongLouMeng;
        description = "ѧ���ҩ���ָ�20���������������Ч����";
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 0;
        needCD = 6;
        description = "";
    }
    /// <summary>
    /// ����Ѫ
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        useCharacter.teXiao.PlayTeXiao("LengXiangWan");
        base.UseVerbs(useCharacter);
        foreach (AbstractCharacter aim in aims)
        {
            aim.hp = aim.maxHP;
        }
        SpecialAbility(useCharacter);
    }
    /// <summary>
    /// ������и���״̬
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        useCharacter.dizzyTime = 0;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "����һ��������ɮ��ѧ��һ�ɷ���������2���������ɷ�����Ϊ�����衣";

    }
}
