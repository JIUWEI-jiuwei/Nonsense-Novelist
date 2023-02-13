using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ֵ�
/// </summary>
class ThickDictionary : AbstractItems
{
    public override void Awake()
    {
        itemID = 20;
        wordName = "���ֵ�";
        bookName = BookNameEnum.CrystalEnergy;
        description = "һ�Ž�ɫ�����ı�ʯ������3�㹥����������ǿ����������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.def += 2;

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
        aim.def -= 2;
    }
}
