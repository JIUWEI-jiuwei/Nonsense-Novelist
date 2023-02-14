using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 冷香丸
/// </summary>
class LengXiangPill : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 2;
        wordName = "冷香丸";
        bookName = BookNameEnum.HongLouMeng;
        description = "一枚制作相当复杂的药丸，提升3点防御。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        rarity = 1;
        nowTime = 0;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision")) 
            wordCollisionShoots.Add(gameObject.AddComponent<XuWu>());
    }
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.def++;
    }

    float nowTime;
    public override void UseVerbs()
    {
        base.UseVerbs();
        nowTime += Time.deltaTime;
        if(nowTime>1)
        {
            nowTime= 0;
            aim.hp += 3;
        }

    }

    public override void End()
    {
        base.End();
        aim.def--;
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "白牡丹花蕊、白荷花花蕊、白芙蓉花蕊、白梅花花蕊......等十年未必都这样巧能做出这冷香丸呢！”" + character.wordName + "说道。";

    }
}
