using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 服药
/// </summary>
class BenJieShiDui : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 3;
        wordName = "本杰士堆";
        bookName = BookNameEnum.ZooManual;
        description = "使队友获得亢奋";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        rarity = 2;

        nowTime = 0;
        skillMode = new CureMode();
    }
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
    }

    float nowTime;
    AbstractSkillMode skillMode;
    AbstractCharacter[] friends;
    public override void UseVerbs()
    {
        base.UseVerbs();
        nowTime += Time.deltaTime;
        if(nowTime>10)
        {
            nowTime= 0;
            friends = skillMode.CalculateAgain(999, aim);

            buffs.Add(friends[Random.Range(0,friends.Length)].gameObject.AddComponent<KangFen>());
            buffs[0].maxTime = 10;
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
