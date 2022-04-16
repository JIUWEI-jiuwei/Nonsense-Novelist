using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��������
/// </summary>
abstract class AbstractSkillMode : MonoBehaviour
{
    /// <summary>�����������</summary>
    public int skillModeID;
    /// <summary>������������</summary>
    public string skillModeName;
    /// <summary>Ŀ����Ӫ���ȼ�</summary>
    private List<CampEnum> campOrder;
    /// <summary>Ŀ��������ȼ�(�͡���ѡһ��</summary>
    private List<AbstractRole> roleOrder;
    /// <summary>Ŀ���Ը����ȼ�(�͡���ѡһ�������á�</summary>
    private List<AbstractTrait> traitOrder;

    /// <summary>�Ƿ�����ѡ���Ѫ��</summary>
    private bool chooseMinHp;

    
    /// <summary>����ֵ��Ӱ��������أ�</summary>
    public float extra;
    /// <summary>Ӱ������ֱ�ߡ����Ρ�Բ�Σ�</summary>
    public IAttackRange attackRange ;
    /// <summary>����������������������</summary>
    public int attacktimes=1;


    /// <summary>
    /// �ٴμ���������Ŀ��
    /// </summary>
    /// <param name="character">ʹ����λ��</param>
    /// <returns></returns>
    virtual public GameObject[] CaculateAgain(float attackDistance,Transform ownTrans)
    {
        GameObject[] a=attackRange.AttackRange(attackDistance,ownTrans,extra);


        return a;
    }
    abstract public void UseMode(int value,AbstractCharacter character);    
}
