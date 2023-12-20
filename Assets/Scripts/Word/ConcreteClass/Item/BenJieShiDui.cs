using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：本杰士堆
/// </summary>
class BenJieShiDui : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 4;
        wordName = "本杰士堆";
        bookName = BookNameEnum.ZooManual;
        description = "获得本杰士堆，被破坏后名词消失";//随从
        rarity = 2;

        VoiceEnum = MaterialVoiceEnum.materialNull;
   

        nowTime = 0;
        skillMode = new CureMode();
    }


    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);

        //为角色增加一个随从
        chara.AddServant(gameObject.AddComponent<CS_BenJieShiDui>());
    }

    float nowTime;
    AbstractSkillMode skillMode;
    AbstractCharacter[] friends;
    public override void UseVerb()
    {
        base.UseVerb();
        //获得随从




        //nowTime += Time.deltaTime;
        //if (nowTime > 10)
        //{
        //    nowTime = 0;
        //    friends = skillMode.CalculateAgain(999, aim);

        //    buffs.Add(friends[Random.Range(0, friends.Length)].gameObject.AddComponent<KangFen>());
        //    buffs[0].maxTime = 10;
        //}
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
