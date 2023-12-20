using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff：颠倒
/// </summary>
public class DianDao : AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "颠倒";
        description = "交换当前的攻击力和精神，结束后恢复";
        book = BookNameEnum.allBooks;
        float record = chara.atk;
        chara.atk = chara.psy;
        chara.psy = record;
        upup = 1;
        isBad = true;
    }


    private void OnDestroy()
    {
        float record = chara.atk;
        chara.atk = chara.psy;
        chara.psy = record;
    }
}
