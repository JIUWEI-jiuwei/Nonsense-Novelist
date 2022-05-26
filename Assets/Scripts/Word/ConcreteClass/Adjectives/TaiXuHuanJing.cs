using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 太虚幻境
/// </summary>
class TaiXuHuanJing : AbstractAdjectives
{
    private AbstractCharacter aimState;//如果挂在角色身上时，获取的抽象角色
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.adj;
        adjID = 3;
        wordName = "太虚幻境";
        bookName = BookNameEnum.HongLouMeng;
        description = "进入太虚幻境";
        chooseWay = ChooseWayEnum.allChoose;
        skillMode = gameObject.AddComponent<PlatformMode>();
        attackDistance = 999;
        skillEffectsTime = 10;
        useAtFirst = true;

        aimState = this.GetComponent<AbstractCharacter>();//2.获取目标（挂在目标上时）
    }

    private float now = 0;//计时
    private float swap;//用于交换的中间变量
    /// <summary>
    /// 抽到时，全场进入太虚幻境，普通攻击以精神力与意志力进行计算
    /// </summary>
    override public void SpecialAbility(AbstractCharacter aimCharacter)
    {
        if (!aimCharacter.buffs.ContainsKey(8) || aimCharacter.buffs[8] < 1)//最高叠1层
        {
            aimCharacter.AddBuff(8);
            swap = aimCharacter.atk;
            aimCharacter.atk = aimCharacter.psy;
            aimCharacter.psy = swap;

            swap = aimCharacter.def;
            aimCharacter.def = aimCharacter.san;
            aimCharacter.san = swap;

            //1.给目标添加此脚本：该脚本在Start获取抽象角色类,并在Update等待触发效果
            aimCharacter.gameObject.AddComponent<TaiXuHuanJing>();
        }
    }

    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        aims=skillMode.CalculateAgain(attackDistance, aimCharacter.gameObject);
        foreach (GameObject aim in aims)
        {
            SpecialAbility(aim.GetComponent<AbstractCharacter>());
        }

    }

    private void FixedUpdate()
    {
        if (aimState != null)//3.时间到结束销毁自己
        {
            if (now < skillEffectsTime)
            {
                now += Time.deltaTime;
            }
            else if (now >= skillEffectsTime)
            {
                swap = aimState.atk;
                aimState.atk = aimState.psy;
                aimState.psy = swap;

                swap = aimState.def;
                aimState.def = aimState.san;
                aimState.san = swap;
                aimState.RemoveBuff(8);
            }
        }
    }
}
