using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///Nexus-6���ֱ�
/// </summary>
class Nexus_6Arm : AbstractItems
{
    public override void Awake()
    {
        itemID = 12;
        wordName = "Nexus-6���ֱ�";
        bookName = BookNameEnum.ElectronicGoal;
        description = "һ���Ѿ�ͣ����ǿ���е�ۣ�����10�㹥����10%�������ʡ�";
        holdEnum = HoldEnum.handDouble;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 3;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.atk += 7;

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
        aim.atk -= 7;
    }
}
