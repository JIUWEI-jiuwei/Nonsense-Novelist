 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������Ʒ��
/// </summary>
abstract class AbstractItems : AbstractWords0
{
    /// <summary>��Ʒ���</summary>
    public int itemID;
    /// <summary>��Ʒ��Ӧս������</summary>
    public GameObject obj;
    /// <summary>��ƷĿ����Ӫ(��ĳЩ��Ʒ���ܸ��з�)�����á�</summary>
    public CampEnum camp;
    /// <summary>��ƷĿ��������ƣ�˭����ʹ�ã� </summary>
    public List<AbstractRoleLimit> banUse;
    /// <summary>���з�ʽ</summary>
    public HoldEnum holdEnum;
    /// <summary>��Ʒ���ʣ���Ӧ��Ч���� </summary>
    public MaterialVoiceEnum VoiceEnum;
    /// <summary>��Ʒ�ṩ�ļ���</summary>
    public AbstractVerbs withSkill;
    /// <summary>��Ʒ�ṩ��״̬</summary>
    public AbstractAdjectives withAdj;
    /// <summary>��Ʒÿ��ʹ��ʱ�ṩ�ľ���ֵ�����á�</summary>
    public int provideExp;
    /// <summary>��Ʒ�ȼ������á�</summary>
    public int level;
    //�������ԣ��ɳ����ԣ�
}
