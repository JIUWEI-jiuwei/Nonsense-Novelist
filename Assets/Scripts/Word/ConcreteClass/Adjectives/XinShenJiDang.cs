using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XinShenJiDang : AbstractAdjectives
{
    /// <summary>充能次数 </summary>
    public int chongNeng;
    /// <summary>是否开始充能 </summary>
    public bool beginCN;
    /// <summary>充能持续时间 </summary>
    public float chongNengTime=10;
    public override void Awake()
    {
        adjID = 10;
        wordName = "心神激荡的";
        bookName = BookNameEnum.Salome;
        description = "获得精神，攻击精神交换（颠倒）";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 2;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0]=gameObject.AddComponent<ChongNeng>();
    }
    protected override void Update()
    {
        //充能持续时间
        if (beginCN)
        {
            chongNengTime -= Time.deltaTime;
            if (chongNengTime < 0)
            {
                aim.psy -= 5 * chongNeng;
            }
        }
        base.Update();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<DianDao>());
        buffs[0].maxTime = skillEffectsTime;

        //充能效果
        beginCN = true;
        aimCharacter.psy += 5 * chongNeng;
        if (chongNeng > 0)
        {
            if (nowTime < chongNengTime)
                nowTime = chongNengTime;
        }
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }



    public override void End()
    {
        base.End();
    }

}
