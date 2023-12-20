using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:改造
/// </summary>
public class GaiZao : AbstractBuff
{

    // 3层，生命上限+60；
    //5层，生命上限+130，攻击+5，意志减半；
    //7层，生命上限+260，攻击+15，意志最高为0
    int count=0;

    float record=0;
    override protected void Awake()
    {
        base.Awake();
        buffName = "改造";
        description= "3层，生命上限+60；5层，生命上限 + 130，攻击 + 5，意志减半；7层，生命上限 + 260，攻击 + 15，意志最高为0";
        book = BookNameEnum.ElectronicGoal;


        count = GetComponents<GaiZao>().Length;
        if (count >= 7)
        {
            chara.maxHp += 260;
            chara.atk += 15;
            record = chara.san;
            if (record >= 0)
                chara.san = 0;
            
        }
        else if (count >= 5)
        {   
            chara.maxHp += 130;
            chara.atk += 5;
            record = chara.san;
            chara.san = record / 2;
        }
        else if (count >= 3)
        {
            chara.maxHp += 60;
 
        }
        else 
        { }

    }

    private void OnDestroy()
    {
        count = GetComponents<GaiZao>().Length;
        if (count >= 7)
        {
            chara.maxHp -= 260;
            chara.atk -= 15;

            chara.san = record; 

        }
        else if (count >= 5)
        {
            chara.maxHp -= 130;
            chara.atk -= 5;
            chara.san += record / 2;
        }
        else if (count >= 3)
        {
            chara.maxHp -= 60;

        }
        else
        { }
    }

}
