using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReLife : AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "¸´»î";
        book = BookNameEnum.EgyptMyth;
        chara.reLifes ++;
        upup = 1;
    }

    private void OnDestroy()
    {
        chara.reLifes --;
    }
}
