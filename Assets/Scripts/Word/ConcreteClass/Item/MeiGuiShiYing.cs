using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// õ��ʯӢ
/// </summary>
class MeiGuiShiYing : AbstractItems
{
    public override void Awake()
    {
        itemID = 11;
        wordName = "õ��ʯӢ";
        bookName = BookNameEnum.CrystalEnergy;
        description = "һ�Ž�ɫ�����ı�ʯ������3�㹥����������ǿ����������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 2;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.def += 6;

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        buffs.Add(gameObject.AddComponent<GongZhen>());
        buffs[0].maxTime = Mathf.Infinity;
    }

    public override void End()
    {
        base.End();
        aim.def -= 6;
    }
}
