using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class DuXian : AbstractItems
{
    public override void Awake()
    {
        itemID = 18;
        wordName = "����";
        bookName = BookNameEnum.CrystalEnergy;
        description = "һ�Ž�ɫ�����ı�ʯ������3�㹥����������ǿ����������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        buffs.Add(gameObject.AddComponent<FuShi>());
        buffs[0].maxTime = 12;
    }

    public override void End()
    {
        base.End();
    }
}
