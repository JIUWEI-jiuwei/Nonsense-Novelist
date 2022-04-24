using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 偷香窃玉
/// </summary>
class TaiXuHuanJing : AbstractAdjectives
{
    public void Awake()
    {
        adjID = 3;
        wordName = "太虚幻境";
        description = "进入太虚幻境";
        chooseWay = ChooseWayEnum.allChoose;
        skillMode = new PlatformMode();
        attackDistance = 999;
        skillEffectsTime = 10;
        useAtFirst = true;
    }
    /// <summary>
    /// 抽到时，全场进入太虚幻境，普通攻击以精神力与意志力进行计算
    /// </summary>
    override public void SpecialAbility()
    {

    }

    override public void UseVerbs(GameObject character)
    {
        base.UseVerbs(character);
        foreach (GameObject aim in aims)
        {
            
        }
            SpecialAbility();
    }
}
