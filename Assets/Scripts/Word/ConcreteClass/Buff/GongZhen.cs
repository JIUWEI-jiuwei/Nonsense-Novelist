using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// buff：共振
/// </summary>
public class GongZhen : AbstractBuff
{
<<<<<<< HEAD

    static public string s_description = "场上每有4个“共振”，四维+1，<sprite name=\"hp\">+30";
    static public string s_wordName = "共振";
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    int count=0;
    /// <summary>共振角色数量</summary>
    static int num;
    /// <summary>上次增益记录</summary>
    private int record;
    override protected void Awake()
    {
        base.Awake();
        buffName = "共振";
        book = BookNameEnum.CrystalEnergy;
        description = "场上每有4个“共振”，四维+1，生命上限+30";

        count = GetComponents<GongZhen>().Length;
        num = Mathf.FloorToInt(count / 4);
        record = num;
        chara.maxHp += 30 * num;
        chara.def += 1 * num;
        chara.san += 1 * num;
        chara.psy += 1 * num;
        chara.atk += 1 * num;
        //if (this.GetComponents<GongZhen>().Length == 1)
        //{
        //    num++;
        //}
        //GongZhen[] all = CharacterManager.father.GetComponentsInChildren<GongZhen>();
        //foreach (GongZhen gz in all)
        //{
        //    gz.NumChanged();
        //}
    }

    //public void NumChanged()
    //{
    //    chara.atk += num - record;
    //    chara.def += num - record;
    //    chara.psy += num - record;
    //    chara.san += num - record;
    //    record = num;
    //}


    private void OnDestroy()
    {
        //chara.atk -= record;
        //chara.def -= record;
        //chara.psy -= record;
        //chara.san -= record;
        chara.maxHp -= 30 * num;
        chara.def -= 1 * num;
        chara.san -= 1 * num;
        chara.psy -= 1 * num;
        chara.atk -= 1 * num;

        //if(this.GetComponents<GongZhen>().Length==1)//表示就剩自己
        //{
        //    num--;
        //}
        //GongZhen[] all = CharacterManager.father.GetComponentsInChildren<GongZhen>();
        //foreach (GongZhen gz in all)
        //{
        //    if(gz!=this)
        //    gz.NumChanged();
        //}
    }
}
