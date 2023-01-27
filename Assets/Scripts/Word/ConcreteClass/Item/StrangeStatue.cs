using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class StrangeStatue : AbstractItems
{
    public override void Awake()
    {
        itemID = 21;
        wordName = "���ʯ��";
        bookName = BookNameEnum.CrystalEnergy;
        description = "һ�Ž�ɫ�����ı�ʯ������3�㹥����������ǿ����������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.psy += 2;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
        aim.psy -= 2;
    }
}
