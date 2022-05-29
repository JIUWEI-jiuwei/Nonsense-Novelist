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
        camp = CampEnum.friend;
    }
    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "��ιι����ɵúú����ţ���ħ���" + character.wordName + "˵����";

    }
}
