using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:����
/// </summary>
public class HuaBan: AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "����";
        description = "����1����";
        book = BookNameEnum.allBooks;
        chara.psy += 1;
    }


    private void OnDestroy()
    {
        chara.psy -= 1;
    }
}
