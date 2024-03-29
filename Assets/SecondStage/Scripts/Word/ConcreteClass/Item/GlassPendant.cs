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
        description = "加2意志";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.san += 2;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.san -= 2;
    }
}
