using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 恶性肿瘤
/// </summary>
class EXingZhongLiu : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 16;
        wordName = "恶性肿瘤";
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
