using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����ʯ
/// </summary>
class TigerStone: AbstractItems
{
    public override void Awake()
    {
        itemID = 10;
        wordName = "����ʯ";
        bookName = BookNameEnum.CrystalEnergy;
        description = "һ�Ž�ɫ�����ı�ʯ������3�㹥����������ǿ����������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 2;
        wordCollisionShoots.Add(gameObject.AddComponent<JiHuo>());

    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.atk += 5;

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
        aim.atk -= 5;
    }
}
