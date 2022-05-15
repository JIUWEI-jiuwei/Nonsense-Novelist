using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 未解锁的《密特拉魔典》
/// </summary>
class UnlockMagicCode : AbstractItems
{
    public void Awake()
    {
        itemID = 4;
        wordName = "未解锁的《密特拉魔典》";
        bookName = BookNameEnum.StudentOfWitch;
        getWay = GetWayEnum.FromStory;
        withSkill=gameObject.AddComponent<FireBall>();
    }
}
