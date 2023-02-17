using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XinShenJiDang : AbstractAdjectives
{
    /// <summary>���ܴ��� </summary>
    public int chongNeng;
    /// <summary>�Ƿ�ʼ���� </summary>
    public bool beginCN;
    /// <summary>���ܳ���ʱ�� </summary>
    public float chongNengTime=10;
    public override void Awake()
    {
        adjID = 10;
        wordName = "���񼤵���";
        bookName = BookNameEnum.Salome;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 2;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0]=gameObject.AddComponent<ChongNeng>();
    }
    protected override void Update()
    {
        //���ܳ���ʱ��
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

        //����Ч��
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
