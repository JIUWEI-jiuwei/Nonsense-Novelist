using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangFen : AbstractBuff
{
    public float nowTime = 0;
    override protected void Awake()
    {
        base.Awake();
        buffName = "ø∫∑‹";
        book = BookNameEnum.ZooManual;
        chara.atk += 5;
    }

    private void Update()
    {
        nowTime += Time.deltaTime;
        if (nowTime > 1)//√ø√Î5%ª÷∏¥
        {
            chara.hp += 0.05f * chara.maxHP;
        }
    }

    private void OnDestroy()
    {
        chara.atk -= 5;
    }
}
