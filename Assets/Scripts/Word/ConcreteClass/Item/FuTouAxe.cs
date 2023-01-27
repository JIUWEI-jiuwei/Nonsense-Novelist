using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class FuTouAxe : AbstractItems
{
    public override void Awake()
    {
        itemID = 19;
        wordName = "钝斧头";
        bookName = BookNameEnum.CrystalEnergy;
        description = "一颗金色华丽的宝石，提升3点攻击，少量增强暴击倍数。";
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
