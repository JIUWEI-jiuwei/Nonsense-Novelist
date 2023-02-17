using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 厚字典
/// </summary>
class ThickDictionary : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 20;
        wordName = "厚字典";
        bookName = BookNameEnum.CrystalEnergy;
        description = "加2防御";
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
