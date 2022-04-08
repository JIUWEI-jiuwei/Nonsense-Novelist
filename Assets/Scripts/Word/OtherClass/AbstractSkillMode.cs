using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��������
/// </summary>
public class AbstractSkillMode : MonoBehaviour
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

    /// <summary>���</summary>
    public float attackDistance;
    /// <summary>Ӱ������ֱ�ߡ����Ρ�Բ�Σ�</summary>
    public AbstractAttackRange attackRange;
    /// <summary>����������������������</summary>
    public int attacktimes=1;
    
}
