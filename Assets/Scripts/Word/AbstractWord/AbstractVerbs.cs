using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ���󶯴��ࣨ���ܣ�
/// </summary>
abstract class AbstractVerbs : AbstractWords0 
{
    /// <summary>�������</summary>
    public int skillID;

    //ʩ���߼�����Ч���

    //�����߼�����Ч���

    /// <summary>����ʹ����������ƣ�˭����ʹ�ã�</summary>
    public List<AbstractRole> banUse;
    /// <summary>Ŀ�����ƣ�������˭ʹ�ã�</summary>
    public List<AbstractRole> banAim;


    /// <summary>�������� </summary>
    public AbstractSkillMode skillMode;
    /// <summary>���</summary>
    public float attackDistance;
    /// <summary>Ӱ������ֱ�ߡ����Ρ�Բ�Σ�</summary>
    public AbstractAttackRange attackRange;
    /// <summary>����������������������</summary>
    public int attacktimes=1;
    /// <summary>����ǿ��(����������ȡ���)</summary>
    public float skillMinStrength, skillMaxStrength;


    /// <summary>��������</summary>
    public float comsumeSP;
    /// <summary>��ǰ����������CD����Ϊ����ʱ���ƽA�������������������ͷţ�</summary>
    public float nowEnergy;
    /// <summary>������</summary>
    public float maxEnergy;


    /// <summary>���ܳ���ʱ�����ѳ���ʱ������ֳ������� </summary>
    public float skillTime;
    /// <summary>ʩ��ʱ����ǰҡ����ҡ����ʩ��ʱ������ֳ�������</summary>
    public float prepareTime,afterTime;
    /// <summary>�Ƿ������� </summary>
    public bool allowInterrupt;
    /// <summary>���ܸ��ʣ����������и����ͷţ�</summary>
    public float possibility;

    /// <summary>
    /// ����Ч��
    /// </summary>
    abstract public void Ability();

}
