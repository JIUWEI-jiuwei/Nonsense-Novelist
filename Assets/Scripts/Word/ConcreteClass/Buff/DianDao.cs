using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DianDao : AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "µßµ¹";
        book = BookNameEnum.allBooks;
        float record = chara.atk;
        chara.atk = chara.psy;
        chara.psy = record;
        upup = 1;
    }


    private void OnDestroy()
    {
        float record = chara.atk;
        chara.atk = chara.psy;
        chara.psy = record;
    }
}
