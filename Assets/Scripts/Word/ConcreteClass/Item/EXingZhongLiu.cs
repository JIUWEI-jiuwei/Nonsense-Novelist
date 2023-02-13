using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ¶ñÐÔÖ×Áö
/// </summary>
class EXingZhongLiu : AbstractItems
{
    public override void Awake()
    {
        itemID = 16;
        wordName = "¶ñÐÔÖ×Áö";
        bookName = BookNameEnum.FluStudy;
        description = " ";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 1;
        wordCollisionShoots.Add(gameObject.AddComponent<ChongNeng>());
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
    }
}
