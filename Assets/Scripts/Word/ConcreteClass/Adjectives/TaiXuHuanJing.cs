using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 太虚幻境
/// </summary>
class TaiXuHuanJing : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.adj;
        adjID = 3;
        wordName = "太虚幻境";
        description = "进入太虚幻境";
        chooseWay = ChooseWayEnum.allChoose;
        skillMode = gameObject.AddComponent<PlatformMode>();
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

    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        foreach (GameObject aim in aims)
        {
            
        }
            SpecialAbility();
    }
}
