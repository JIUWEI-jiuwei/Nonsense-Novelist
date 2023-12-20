using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:花瓣
/// </summary>
public class HuaBan: AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "花瓣";
        description = "提升1精神";
        book = BookNameEnum.allBooks;
        chara.psy += 1;
    }


    private void OnDestroy()
    {
        chara.psy -= 1;
    }
}
