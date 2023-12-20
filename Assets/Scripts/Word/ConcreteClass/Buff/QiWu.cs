using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// buff:起舞
/// </summary>
public class QiWu : AbstractBuff
{
    private float record;
    override protected void Awake()
    {
        base.Awake();
        buffName = "起舞";
        description = "普通攻击攻击所有敌人，伤害降低70%，附带攻击效果";
        book = BookNameEnum.allBooks;

    }


    private void OnDestroy()
    {
    }
}
