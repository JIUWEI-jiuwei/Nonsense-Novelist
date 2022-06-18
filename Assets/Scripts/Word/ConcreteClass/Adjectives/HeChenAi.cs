using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 核尘埃
/// </summary>
class HeChenAi : AbstractAdjectives
{
    private AbstractCharacter aimState;//如果挂在角色身上时，获取的抽象角色
    public override void Awake()
    {
        base.Awake();
        adjID = 5;
        wordName = "核尘埃";
        bookName = BookNameEnum.ElectronicGoal;
        chooseWay = ChooseWayEnum.canChoose;
        skillMode=gameObject.AddComponent<PlatformMode>();
        attackDistance = 999;
        percentage = 0;
        skillEffectsTime = 10;
        useAtFirst = true;
        description = "在发生核爆炸的地方,空气中的尘埃沾染上放射性元素,这些尘埃就被称为核尘埃，对于吸入的任何生物都将产生致命的危害。";
        aimState = this.GetComponent<AbstractCharacter>();//2.获取目标（挂在目标上时）
    }


    private float now = 0;//计时
    private int seconds = 0;//每秒
    /// <summary>
    /// 意志力-3
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        if (!aimCharacter.buffs.ContainsKey(14) || aimCharacter.buffs[14] < 1)
        {
            aimCharacter.AddBuff(14);

            //1.给目标添加此脚本：该脚本在Start获取抽象角色类,并在Update等待触发效果
            aimCharacter.gameObject.AddComponent<HeChenAi>();
        }
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
    }

    private void FixedUpdate()
    {
        if (aimState != null)//3.时间到结束销毁自己
        {
            if(now>seconds)//每秒5点伤害
            {
                aimState.hp -= 5;
                seconds++;
            }
            
            if (now < skillEffectsTime)
            {
                now += Time.deltaTime;
            }
            else if (now >= skillEffectsTime)
            {
                aimState.san += 3;
                aimState.RemoveBuff(14);
                Destroy(this);
            }
        }
    }

    public override string UseText()
    {

        return "一阵从北方而来的气流将核泄露禁区的放射性尘埃带了过来，顿时这片区域陷入了核污染中。";

    }
}
