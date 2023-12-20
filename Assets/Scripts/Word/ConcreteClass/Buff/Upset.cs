using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff£º¾ÚÉ¥
/// </summary>
public class Upset : AbstractBuff
{
    AttackState state;
    override protected void Awake()
    {
        base.Awake();
        buffName = "¾ÚÉ¥";
        description = "Í£Ö¹ÆÕÍ¨¹¥»÷";
        book = BookNameEnum.allBooks;
        isBad = true;
        state=GetComponent<AttackState>();
    }

    public override void Update()
    {
        base.Update();
        state.attackAtime = 0;//ÎÞ·¨Æ½A
    }

}


