using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff：颠倒
/// </summary>
public class DianDao : AbstractBuff
{
    static public string s_description = "交换当前的<sprite name=\"atk\">和<sprite name=\"psy\">，结束后恢复";
    static public string s_wordName = "颠倒";

    override protected void Awake()
    {
        base.Awake();
        buffName = "颠倒";
<<<<<<< HEAD
        description = "交换当前的<sprite name=\"atk\">和<sprite name=\"psy\">，结束后恢复";
=======
        description = "交换当前的攻击力和精神，结束后恢复";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
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
