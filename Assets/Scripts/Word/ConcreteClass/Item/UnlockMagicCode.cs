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
        description = "一本装饰华丽的魔典，中央有着一个眼睛看来看去，提升3点意志，3点防御。";
        camp = CampEnum.friend;
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "“喂喂，你可得好好拿着！”魔典对" + character.wordName + "说道。";

    }
}
