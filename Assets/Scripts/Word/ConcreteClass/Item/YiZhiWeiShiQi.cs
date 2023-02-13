using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 益智喂食器
/// </summary>
class YiZhiWeiShiQi : AbstractItems
{
    public override void Awake()
    {
        itemID = 4;
        wordName = "益智喂食器";
        bookName = BookNameEnum.ZooManual;
        description = "一枚制作相当复杂的药丸，提升3点防御。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        rarity = 2;

        nowTime = 0;
        skillMode = new CureMode();
    }

    float nowTime;
    AbstractSkillMode skillMode;
    AbstractCharacter[] friends;
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        friends= skillMode.CalculateAgain(999, aim);
        foreach (AbstractCharacter friend in friends)
        {
            friend.psy++;
        }
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        nowTime += Time.deltaTime;
        if (nowTime > 1)
        {
            nowTime = 0;
            friends = skillMode.CalculateAgain(999, aim);
            friends[0].hp += 3;
        }
    }

    public override void End()
    {
        base.End();
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "白牡丹花蕊、白荷花花蕊、白芙蓉花蕊、白梅花花蕊......等十年未必都这样巧能做出这冷香丸呢！”" + character.wordName + "说道。";

    }
}
