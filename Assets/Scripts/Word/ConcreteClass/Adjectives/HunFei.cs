using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///婚飞
/// </summary>
class HunFei : AbstractAdjectives
{
    private AbstractCharacter aimState;//如果挂在角色身上时，获取的抽象角色
    public override void Awake()
    {
        base.Awake();
        adjID = 9;
        wordName = "婚飞";
        bookName = BookNameEnum.PHXTwist;
        chooseWay = ChooseWayEnum.canChoose;
        skillMode=gameObject.AddComponent<UpATKMode>();
        percentage = 0;
        skillEffectsTime = 10;
        useAtFirst = true;
        description = "提升目标30%精神力的攻击，持续10秒";
        aimState = this.GetComponent<AbstractCharacter>();//2.获取目标（挂在目标上时）
    }

    private float now = 0;//计时
    private float record;//记录提升的攻击力
    /// <summary>
    /// 提升30%精神力的攻击力,持续10秒
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        record = aimCharacter.psy * 0.3f;
        skillMode.UseMode(null,record,aimCharacter);
        aimCharacter.AddBuff(1);

        //1.给目标添加此脚本：该脚本在Start获取抽象角色类,并在Update等待触发效果
        aimCharacter.gameObject.AddComponent<HunFei>().record=record;
    }

    private void FixedUpdate()
    {
        if(aimState!=null)
        {
            if (now < skillEffectsTime)
            {
                now += Time.deltaTime;
            }
            else if (now >= skillEffectsTime)
            {
                aimState.atk-=record;
                aimState.RemoveBuff(1);
            }
        }
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "一阵淅淅沥沥的春雨毫无征兆地降下了，在结束后的半小时内，大群的白蚁雄性成虫飞出巢穴进行婚飞" + character.wordName + "也加入了这场盛会中。";

    }
}
