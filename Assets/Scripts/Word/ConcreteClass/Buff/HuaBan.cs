using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:����
/// </summary>
public class HuaBan: AbstractBuff
{   
    static public string s_description = "����1<sprite name=\"psy\">";
    static public string s_wordName = "����";
    override protected void Awake()
    {
        base.Awake();
        buffName = "����";
<<<<<<< HEAD
        description = "����1<sprite name=\"psy\">";

=======
        description = "����1����";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        book = BookNameEnum.allBooks;
        chara.psy += 1;
    }


    private void OnDestroy()
    {
        chara.psy -= 1;
    }
}
