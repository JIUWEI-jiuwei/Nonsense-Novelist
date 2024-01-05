using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toxic : AbstractBuff
{
    /// <summary>�ⲿ��ֵʹ����</summary>
    public AbstractCharacter useCharacter;
    float nowTime;
    DamageMode damageMode;
    override protected void Awake()
    {
        base.Awake();
        buffName = "�ж�";
        book = BookNameEnum.allBooks;
        damageMode.attackRange=new SingleSelector();
        upup = 1;
    }


    public override void Update()
    {
        base.Update();
        nowTime += Time.deltaTime;
        if(nowTime>1)
        {
            nowTime= 0;
            damageMode.UseMode(useCharacter!=null?useCharacter:chara, 10 * (1 - chara.san / (chara.san + 20)), chara);
        }
    }
}
