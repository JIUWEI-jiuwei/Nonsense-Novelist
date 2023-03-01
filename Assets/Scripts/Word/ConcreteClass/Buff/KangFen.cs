using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangFen : AbstractBuff
{
    public float nowTime = 0;
    override protected void Awake()
    {
        base.Awake();
        buffName = "亢奋";
        book = BookNameEnum.ZooManual;
        chara.atk += 5;
    }

    override public void Update()
    {
        base.Update();
        nowTime += Time.deltaTime;
        if (nowTime > 1)//每秒5%恢复
        {
            nowTime= 0; 
            chara.CreateFloatWord(0.05f * chara.maxHp, FloatWordColor.heal, false);
            chara.hp += 0.05f * chara.maxHp;
        }
    }

    private void OnDestroy()
    {
        chara.atk -= 5;
    }
}
