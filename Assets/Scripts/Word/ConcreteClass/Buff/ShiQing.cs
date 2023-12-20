using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:诗情
/// </summary>
public class ShiQing : AbstractBuff
{
<<<<<<< HEAD
    static public string s_description = "提升20%< sprite name=\"psy\">";
    static public string s_wordName = "诗情";

=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

    override protected void Awake()
    {
        base.Awake();
        buffName = "诗情";
<<<<<<< HEAD
        description = "提升20%< sprite name=\"psy\">";
=======
        description = "提升20%精神";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        book = BookNameEnum.HongLouMeng;
        chara.psyMul += 0.2f;

    }


    private void OnDestroy()
    {
        chara.psyMul -= 0.2f;
    }
}
