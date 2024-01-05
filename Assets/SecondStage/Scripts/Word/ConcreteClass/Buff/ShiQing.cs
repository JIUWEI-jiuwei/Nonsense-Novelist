using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiQing : AbstractBuff
{
    private float record;
    override protected void Awake()
    {
        base.Awake();
        buffName = "Ê«Çé";
        book = BookNameEnum.HongLouMeng;
        record=chara.psy * 0.2f;
        chara.psy += record;
        upup = 1;
    }


    private void OnDestroy()
    {
        chara.psy -= record;
    }
}
