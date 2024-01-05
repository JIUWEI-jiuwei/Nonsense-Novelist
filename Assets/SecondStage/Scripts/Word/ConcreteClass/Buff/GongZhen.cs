using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GongZhen : AbstractBuff
{
    /// <summary>共振角色数量</summary>
    static int num;
    /// <summary>上次增益记录</summary>
    private int record;
    override protected void Awake()
    {
        base.Awake();
        buffName = "共振";
        book = BookNameEnum.CrystalEnergy;

        if (this.GetComponents<GongZhen>().Length == 1)
        {
            num++;
        }
        GongZhen[] all = CharacterManager.father.GetComponentsInChildren<GongZhen>();
        foreach (GongZhen gz in all)
        {
            gz.NumChanged();
        }
    }

    public void NumChanged()
    {
        chara.atk += num - record;
        chara.def += num - record;
        chara.psy += num - record;
        chara.san += num - record;
        record = num;
    }


    private void OnDestroy()
    {
        chara.atk -= record;
        chara.def -= record;
        chara.psy -= record;
        chara.san -= record;
        
        if(this.GetComponents<GongZhen>().Length==1)//表示就剩自己
        {
            num--;
        }
        GongZhen[] all = CharacterManager.father.GetComponentsInChildren<GongZhen>();
        foreach (GongZhen gz in all)
        {
            if(gz!=this)
            gz.NumChanged();
        }
    }
}
