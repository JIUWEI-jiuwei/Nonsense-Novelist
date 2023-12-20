using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形容词：过敏的
/// </summary>
public class GuoMin : AbstractAdjectives,IChongNeng
{
    static public string s_description = "充能，每次弹射<color=#dd7d0e>晕眩</color>0.5s";
    static public string s_wordName = "过敏的";


    private float dizzyAdd;

    public override void Awake()
    {        
        base.Awake();
        adjID = 14;
        wordName = "过敏的";
        bookName = BookNameEnum.FluStudy;
<<<<<<< HEAD
        description = "充能，每次弹射<color=#dd7d0e>晕眩</color>0.5s";
=======
        description = "充能，每次弹射“晕眩”0.5s”";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

        skillMode = gameObject.AddComponent<SelfMode>();

        skillEffectsTime = 0;
        rarity = 1;


        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<ChongNeng>();
    }

    override public string[] DetailLable()
    {
        string[] _s = new string[2];
        _s[0] = "ChongNeng";
        _s[1] = "Dizzy";
        return _s;
    }


    public void ChongNeng(int times)
    {
        dizzyAdd += 0.5f*times;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);

        buffs.Add(aimCharacter.gameObject.AddComponent<Dizzy>());
        buffs[0].maxTime = skillEffectsTime + dizzyAdd;
        
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }
    

    public override void End()
    {
        base.End();
    }

    
}
