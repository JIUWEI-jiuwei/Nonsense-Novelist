using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:ʫ��
/// </summary>
public class ShiQing : AbstractBuff
{
<<<<<<< HEAD
    static public string s_description = "����20%< sprite name=\"psy\">";
    static public string s_wordName = "ʫ��";

=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

    override protected void Awake()
    {
        base.Awake();
        buffName = "ʫ��";
<<<<<<< HEAD
        description = "����20%< sprite name=\"psy\">";
=======
        description = "����20%����";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        book = BookNameEnum.HongLouMeng;
        chara.psyMul += 0.2f;

    }


    private void OnDestroy()
    {
        chara.psyMul -= 0.2f;
    }
}
