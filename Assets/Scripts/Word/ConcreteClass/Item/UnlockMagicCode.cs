using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// δ�����ġ�������ħ�䡷
/// </summary>
class UnlockMagicCode : AbstractItems
{
    public void Awake()
    {
        itemID = 4;
        wordName = "δ�����ġ�������ħ�䡷";
        bookName = BookNameEnum.StudentOfWitch;
        getWay = GetWayEnum.FromStory;
        
    }
}
