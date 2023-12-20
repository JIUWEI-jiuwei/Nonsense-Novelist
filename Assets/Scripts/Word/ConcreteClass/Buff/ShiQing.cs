using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:ʫ��
/// </summary>
public class ShiQing : AbstractBuff
{

    override protected void Awake()
    {
        base.Awake();
        buffName = "ʫ��";
        description = "����20%����";
        book = BookNameEnum.HongLouMeng;
        chara.psyMul += 0.2f;

    }


    private void OnDestroy()
    {
        chara.psyMul -= 0.2f;
    }
}
