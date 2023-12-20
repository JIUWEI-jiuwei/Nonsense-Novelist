
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaiYi : AbstractBuff
{
    float orgAtk;
    override protected void Awake()
    {
        base.Awake();
        buffName = "猜疑";
        book = BookNameEnum.allBooks;

        //伤害效果降低50%
        orgAtk = chara.atk;
        chara.atk = orgAtk*0.5f;

        upup = 1;
        maxTime = 5f;

        
        //随机目标开关打开；结束效果时再关闭此开关
        chara.SetAimRandom(true);
        AbstractCharacter _ac=chara.myState.GetANewAim(true);
        chara.myState.SetUnchangeAim(_ac);
        print(chara.wordName + "现在的目标是" + chara.myState.aim.wordName);
  
    }
    override public void Update()
    {
        base.Update();
        print(chara.wordName + "Update()现在的目标是" + chara.myState.aim.wordName);
        //攻击随机角色B，持续5秒，伤害结果降低50 %
        //被攻击者B随机攻击角色C（角色可以反复获得，即C也可以是A），效果一致，依据此循环，直到boss死亡


    }

    private void OnDestroy()
    {
        //对目标传导此buff

        //随机目标开关关闭；结束效果时再关闭此开关
        chara.SetAimRandom(false);
        //攻击恢复原装
        chara.atk = orgAtk;
    }
}

