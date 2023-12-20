using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff:�ж�
/// </summary>
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
        description = "ÿ���ܵ�5�������˺�";
        book = BookNameEnum.allBooks;
        damageMode.attackRange=new SingleSelector();
        isBad = true;
    }


    public override void Update()
    {
        base.Update();
        nowTime += Time.deltaTime;
        if(nowTime>1)
        {
            nowTime= 0;
            damageMode.UseMode(useCharacter!=null?useCharacter:chara, 5* (1 - chara.def / (chara.def + 20)), chara);
        }
    }
}
