using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff����ɥ
/// </summary>
public class Upset : AbstractBuff
{
    AttackState state;
    override protected void Awake()
    {
        base.Awake();
        buffName = "��ɥ";
        description = "ֹͣ��ͨ����";
        book = BookNameEnum.allBooks;
        isBad = true;
        state=GetComponent<AttackState>();
    }

    public override void Update()
    {
        base.Update();
        state.attackAtime = 0;//�޷�ƽA
    }

}


