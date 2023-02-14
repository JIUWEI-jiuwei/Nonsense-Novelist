using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 玻璃挂坠
/// </summary>
class GlassPendant : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 22;
        wordName = "玻璃挂坠";
        bookName = BookNameEnum.CrystalEnergy;
        description = "一颗金色华丽的宝石，提升3点攻击，少量增强暴击倍数。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.san += 2;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
        aim.san -= 2;
    }
}
