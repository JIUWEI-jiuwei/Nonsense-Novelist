using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:花瓣
/// </summary>
public class HuaBan: AbstractBuff
{   
    static public string s_description = "提升1<sprite name=\"psy\">";
    static public string s_wordName = "花瓣";
    override protected void Awake()
    {
        base.Awake();
        buffName = "花瓣";
<<<<<<< HEAD
        description = "提升1<sprite name=\"psy\">";

=======
        description = "提升1精神";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        book = BookNameEnum.allBooks;
        chara.psy += 1;
    }


    private void OnDestroy()
    {
        chara.psy -= 1;
    }
}
