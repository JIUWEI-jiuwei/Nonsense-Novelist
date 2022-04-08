using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �����ɫ��
/// </summary>
abstract class AbstractCharacter : AbstractWords0
{
    /// <summary>���</summary>
    public int characterID;
    /// <summary>�Ա�</summary>
    public GenderEnum gender;
    /// <summary>������ţ����������ļ�����</summary>
    public int appearance;


    /// <summary>ʱ���������ı���</summary>
    public string epoch;
    /// <summary>�����������ı���</summary>
    public string area;
    /// <summary>���ﱩ��Ĭ��̨�ʣ���������ʱ��˵��̨�ʣ�</summary>
    public string criticalSpeak;
    /// <summary>��������Ĭ��̨�ʣ�����ʱ��˵��̨�ʣ�</summary>
    public string deadSpeak;


    /// <summary>��Ӫ</summary>
    public CampEnum camp;
    /// <summary>���</summary>
    public AbstractRole role;
    //�������ݵ����Ϳ��Բ������䣬��ͬ�������ս��ʱ��ʵ����˵�λ�Ĺ�����Ȩ����Ӱ�죬���С�㣬�ܵ��������⣬���������˺��ϵͣ��յ���ͥ������˺��ϸ�
    /// <summary>�Ը񡾲��á�</summary>
    public AbstractTrait trait;
    /// <summary>�Դ�����</summary>
    public List<AbstractVerbs> skill;
    /// <summary>Ѫ��</summary>
    public int hp = 0;
    /// <summary>��Ѫ��</summary>
    public int maxHP = 0;
    /// <summary>����</summary>
    public int sp = 0;
    /// <summary>������</summary>
    public int maxSP = 0;
    /// <summary>������(�˺�=������-������*0.6)</summary>
    public int atk = 0;
    /// <summary>������</summary>
    public int def = 0;
    /// <summary>������</summary>psychic force
    public int psy = 0;
    /// <summary>��־��</summary>
    public int san = 0;
    /// <summary>��������</summary>
    public float criticalChance = 0;
    /// <summary>��������</summary>
    public float multipleCriticalStrike = 0;
    /// <summary>�����ٶ�(�춨�����Ĵ����Լ�ÿ���ι������ʱ��)</summary>
    public int attackSpeed = 0;
    /// <summary>�����ٶ�(���ڼ��ٸ��������м��ܵ�CD��������Ҫ���ֵ)</summary>
    public int skillSpeed = 0;
    /// <summary>���ܼ���(��ȫ���ӹ����ĸ���)</summary>
    public float dodgeChance = 0;
    /// <summary>����ֵ</summary>
    public int luckyValue = 0;
}
