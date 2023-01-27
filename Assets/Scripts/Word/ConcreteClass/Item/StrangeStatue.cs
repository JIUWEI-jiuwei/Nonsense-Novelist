using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class StrangeStatue : AbstractItems
{
    public override void Awake()
    {
        itemID = 21;
        wordName = "奇怪石像";
        bookName = BookNameEnum.CrystalEnergy;
        description = "一颗金色华丽的宝石，提升3点攻击，少量增强暴击倍数。";
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
