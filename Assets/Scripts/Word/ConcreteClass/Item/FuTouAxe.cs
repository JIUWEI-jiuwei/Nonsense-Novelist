using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �۸�ͷ
/// </summary>
class FuTouAxe : AbstractItems
{
    public override void Awake()
    {
        itemID = 19;
        wordName = "�۸�ͷ";
        bookName = BookNameEnum.CrystalEnergy;
        description = "һ�Ž�ɫ�����ı�ʯ������3�㹥����������ǿ����������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.atk += 2;

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
        aim.atk -= 2;
    }
}
