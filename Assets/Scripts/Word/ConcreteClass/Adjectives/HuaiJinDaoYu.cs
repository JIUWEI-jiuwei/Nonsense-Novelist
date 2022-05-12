using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 活死人汤剂
/// </summary>
class HuaiJinDaoYu : AbstractAdjectives
{
    public void Awake()
    {
        adjID = 2;
        wordName = "怀金悼玉";
        description = "饮下活死人汤剂能让其能够在死后重新获得一次生命，代价是灵魂变得干枯。";
        chooseWay = ChooseWayEnum.canChoose;
        skillMode = gameObject.AddComponent<SpecialMode>();
        useAtFirst = false;
    }

    /// <summary>
    /// 复活
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
