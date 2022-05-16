using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 刻板行为
/// </summary>
class KeBanXingWei : AbstractAdjectives
{
    private AbstractCharacter aimState;//如果挂在角色身上时，获取的抽象角色
    public void Awake()
    {
        adjID = 4;
        wordName = "刻板行为";
        bookName = BookNameEnum.ZooManual;
        chooseWay = ChooseWayEnum.canChoose;
        skillMode=gameObject.AddComponent<SpecialMode>();
        percentage = 10;
        skillEffectsTime = 7;
        useAtFirst = false;

        aimState = this.GetComponent<AbstractCharacter>();//2.获取目标（挂在目标上时）
    }


    private float now = 0;//计时
    /// <summary>
    /// 意志力-3
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        if (aimCharacter.buffs[2] < 5)//最高叠5层
        {
            aimCharacter.san -= 3;
        
            aimCharacter.AddBuff(2);

            //1.给目标添加此脚本：该脚本在Start获取抽象角色类,并在Update等待触发效果
            aimCharacter.gameObject.AddComponent<KeBanXingWei>();
        }
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
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
                aimState.san += 3;
                aimState.RemoveBuff(2);
                Destroy(this);
            }
        }
    }
}
