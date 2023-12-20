using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形容词：神游环境的
/// </summary>
public class ShenYouHuanJing : AbstractAdjectives
{
    static public string s_description = " <sprite name=\"atk\">和 <sprite name=\"psy\">交换10s";
    static public string s_wordName = "神游幻境的";
    public override void Awake()
    {
        adjID = 2;
        wordName = "神游幻境的";
        bookName = BookNameEnum.HongLouMeng;
<<<<<<< HEAD
        description = " <sprite name=\"atk\">和 <sprite name=\"psy\">交换10s";
=======
        description = "攻击精神交换10s";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 1;
        
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
        {
            wordCollisionShoots[0] = gameObject.AddComponent<XuWu_YunSu>();
        }
    }

    override public string[] DetailLable()
    {
        string[] _s = new string[1];
        _s[0] = "XuWu_YunSu";
        return _s;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);

        buffs.Add(aimCharacter.gameObject.AddComponent<DianDao>());
        buffs[0].maxTime = skillEffectsTime;
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        
    }
    
}
