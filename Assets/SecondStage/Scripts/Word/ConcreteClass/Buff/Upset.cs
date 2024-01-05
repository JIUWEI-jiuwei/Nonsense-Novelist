using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upset : AbstractBuff
{
    AttackState state;
    override protected void Awake()
    {
        base.Awake();
        buffName = "��ɥ";
        book = BookNameEnum.allBooks;
        upup = 1;
        state=GetComponent<AttackState>();
    }

    public override void Update()
    {
        base.Update();
        state.attackAtime = 0;//�޷�ƽA
    }

}


