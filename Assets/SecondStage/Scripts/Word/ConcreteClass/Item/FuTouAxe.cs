using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 钝斧头
/// </summary>
class FuTouAxe : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 19;
        wordName = "钝斧头";
        bookName = BookNameEnum.CrystalEnergy;
        description = "加2攻击";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.atk += 2;

    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.atk -= 2;
    }
}
