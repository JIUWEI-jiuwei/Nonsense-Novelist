using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:诗情
/// </summary>
public class ShiQing : AbstractBuff
{

    override protected void Awake()
    {
        base.Awake();
        buffName = "诗情";
        description = "提升20%精神";
        book = BookNameEnum.HongLouMeng;
        chara.psyMul += 0.2f;

    }


    private void OnDestroy()
    {
        chara.psyMul -= 0.2f;
    }
}
