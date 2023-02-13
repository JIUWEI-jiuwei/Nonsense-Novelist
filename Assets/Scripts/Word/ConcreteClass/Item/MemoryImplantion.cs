using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ֲ��ļ���
/// </summary>
class MemoryImplantion : AbstractItems
{
    public override void Awake()
    {
        itemID = 13;
        wordName = "��ֲ��ļ���";
        bookName = BookNameEnum.ElectronicGoal;
        description = "һ���Ѿ�ͣ����ǿ���е�ۣ�����10�㹥����10%�������ʡ�";
        holdEnum = HoldEnum.handDouble;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.psy-= chara.psy * 0.15f;
        chara.san-= chara.san * 0.15f;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
    }
}
