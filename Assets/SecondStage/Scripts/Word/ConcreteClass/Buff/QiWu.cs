using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QiWu : AbstractBuff
{
    private float record;
    override protected void Awake()
    {
        base.Awake();
        buffName = "ÆðÎè";
        book = BookNameEnum.allBooks;
        record=chara.psy * 0.2f;
        chara.psy += record;
        upup = 1;
    }


    private void OnDestroy()
    {
        chara.psy -= record;
    }
}
