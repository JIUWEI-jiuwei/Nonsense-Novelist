using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaiZao : AbstractBuff
{
    private float recordATK, recordDEF;
    override protected void Awake()
    {
        base.Awake();
        buffName = "¸ÄÔì";
        book = BookNameEnum.ElectronicGoal;
        recordATK = chara.atk * 0.03f;
        recordDEF = chara.def * 0.03f;
        chara.atk += recordATK;
        chara.def+= recordDEF; 
    }

    private void OnDestroy()
    {
        chara.atk -= recordATK;
        chara.def -= recordDEF;
    }

}
