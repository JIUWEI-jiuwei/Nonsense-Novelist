using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：益智喂食器
/// </summary>
class YiZhiWeiShiQi : AbstractItems
{

    static public string s_description = "获得<color=#dd7d0e>益智喂食器</color>，被破坏后名词消失";
    static public string s_wordName = "益智喂食器";
    public override void Awake()
    {
        base.Awake();
        itemID =5;
        wordName = "益智喂食器";
        bookName = BookNameEnum.ZooManual;
<<<<<<< HEAD
        description = "获得<color=#dd7d0e>益智喂食器</color>，被破坏后名词消失";//随从
=======
        description = "获得益智喂食器，被破坏后名词消失";//随从
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        VoiceEnum = MaterialVoiceEnum.materialNull;
        rarity = 2;

        nowTime = 0;
        skillMode = new CureMode();
    }

    override public string[] DetailLable()
    {
        string[] _s = new string[1];
        _s[0] = "CS_YiZhiWeiShiQi";
        return _s;
    }
    float nowTime;
    AbstractSkillMode skillMode;
    AbstractCharacter[] friends;
    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        friends= skillMode.CalculateAgain(999, chara);
        foreach (AbstractCharacter friend in friends)
        {
            friend.psy++;
        }
    }

    public override void UseVerb()
    {
        base.UseVerb();
        //获得随从


        //nowTime += Time.deltaTime;
        //if (nowTime > 1)
        //{
        //    nowTime = 0;

        //    friends = skillMode.CalculateAgain(999, aim);
        //    friends[0].CreateFloatWord(
        //    skillMode.UseMode(aim, 3, friends[0])
        //    ,FloatWordColor.heal,true);
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
