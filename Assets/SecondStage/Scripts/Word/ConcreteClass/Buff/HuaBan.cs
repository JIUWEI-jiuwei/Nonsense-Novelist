using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuaBan: AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "»¨°ê";
        book = BookNameEnum.allBooks;
        chara.psy += 2;
    }


    private void OnDestroy()
    {
        chara.psy -= 2;
    }
}
