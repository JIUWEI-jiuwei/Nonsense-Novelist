using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///������
/// </summary>
class JiShengChong : AbstractItems
{
    public override void Awake()
    {
        itemID = 15;
        wordName = "������";
        bookName = BookNameEnum.FluStudy;
        description = "����������������Ϊ���겻��������3����������ٹ����ٶȡ�";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.def-=3;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        buffs.Add(gameObject.AddComponent<Ill>());
        buffs[0].maxTime = 5;
    }

    public override void End()
    {
        base.End();
        aim.def+=3;
    }
}
