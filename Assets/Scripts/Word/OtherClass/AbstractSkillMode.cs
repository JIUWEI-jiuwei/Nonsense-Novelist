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
    /// <summary>Ŀ��������ȼ�(�͡���ѡһ��</summary>
    public List<AbstractRole> roleOrder;
    /// <summary>Ŀ���Ը����ȼ�(�͡���ѡһ�������á�</summary>
    public List<AbstractTrait> traitOrder;
    
    /// <summary>����ֵ��Ӱ��������أ�</summary>
    public float extra;
    /// <summary>Ӱ������ֱ�ߡ����Ρ�Բ�Σ�</summary>
    public IAttackRange attackRange ;
    /// <summary>����������������������</summary>
    public int attacktimes=1;

    /// <summary>
    /// �ٴμ���������Ŀ��
    /// </summary>
    /// <param name="character">ʩ����</param>
    /// <returns></returns>
    virtual public GameObject[] CalculateAgain(float attackDistance,GameObject character)
    {
        GameObject[] a=attackRange.AttackRange(attackDistance,character.transform,extra);
        return a;
    }
    /// <summary>
    /// ��Ŀ��ʵ��Ӱ��
    /// </summary>
    /// <param name="value">ֵ</param>
    /// <param name="character">Ŀ�꣨����Ŀ�����飩</param>
    abstract public void UseMode(int value,AbstractCharacter character);    
}
