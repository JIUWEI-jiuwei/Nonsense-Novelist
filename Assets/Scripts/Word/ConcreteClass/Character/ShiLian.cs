using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ʧ��
/// </summary>
class ShiLian : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 12;
        wordName = "ʧ��";
        bookName = BookNameEnum.Salome;
        gender = GenderEnum.noGender;
        hp = maxHP = 120;
        atk = 3;
        def = 4;
        psy = 5;
        san = 3;
        mainProperty.Add("����", "�з�dps");
        trait = gameObject.AddComponent<Vicious>();
        roleName = "��������";
        attackInterval = 2.2f;
        attackDistance = 300;
    }
    private void Start()
    {
        attackState = GetComponent<AttackState>();
        Destroy(attackState.attackA);
        attackState.attackA = gameObject.AddComponent<DamageMode>();
    }

    AttackState attackState;
    AbstractCharacter[] aims;
    public override void AttackA()
    {
        base.AttackA();
        //��ͨ������20���ʸ�������ɥ��״̬
        if(Random.Range(1, 101)<=20)
        myState.aim.gameObject.AddComponent<Upset>().maxTime = 5;
    }


    public override string ShowText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string CriticalText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string LowHPText()
    {
        return "";
    }
    public override string DieText()
    {
        return "";
    }
}
