using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// »³½ðµ¿Óñ
/// </summary>
class HuaiJinDaoYu : AbstractAdjectives
{
    public void Awake()
    {
        adjID = 2;
        wordName = "»³½ðµ¿Óñ";
        description = "¸»¹ó×ªË²¼´ÊÅ£¬»³Äîµ±³õµÄÈÙ»ª¸»¹ó";
        nickname.Add("¸»¹ó¸¡ÔÆ");
        chooseWay = ChooseWayEnum.canChoose;
        skillMode = gameObject.AddComponent<SpendCodeMode>();
        percentage = 0.05f;
        useAtFirst = false;
    }

    /// <summary>
    /// ¸´»î
    /// </summary>
    override public void SpecialAbility()
    {

    }

    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        SpecialAbility();
    }


}
