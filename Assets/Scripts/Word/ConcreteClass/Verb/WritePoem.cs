using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ʫ
/// </summary>
class WritePoem : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 1;
        wordName = "��ʫ";
        bookName = BookNameEnum.HongLouMeng;
        nickname.Add("��ʫ");
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = 7;
        rarity = 1;
        needCD=4;
    }


    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<ShiQing>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "����ߵ��������𺳣����ɵ�ʫ�Դ󷢣��̳�����ʫ�衰��ɽ��������ɽ���ۺ��������ں�����ӽ֮�䣬��������֮������";

    }
}
