using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuShi: AbstractBuff
{

    override protected void Awake()
    {
        base.Awake();
        buffName = "¸¯Ê´";
        book = BookNameEnum.PHXTwist;
        chara.def -= 2;
    }

    private void OnDestroy()
    {
        chara.def += 2;
    }

}
