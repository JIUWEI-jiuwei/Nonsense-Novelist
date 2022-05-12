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
    /// <summary>��ȡ��ʽ</summary>
    public GetWayEnum getWay;
    /// <summary>��Ʒ��Ӧս������</summary>
    public GameObject obj;
    /// <summary>��ƷĿ����Ӫ(��ĳЩ��Ʒ���ܸ��з�)�����á�</summary>
    public CampEnum camp;
    /// <summary>��ƷĿ��������ƣ�˭����ʹ�ã� </summary>
    public List<AbstractRoleLimit> banUse=new List<AbstractRoleLimit>();
    /// <summary>���з�ʽ</summary>
    public HoldEnum holdEnum;
    /// <summary>��Ʒ���ʣ���Ӧ��Ч���� </summary>
    public MaterialVoiceEnum VoiceEnum;
    /// <summary>��Ʒ�ṩ�ļ���</summary>
    public AbstractVerbs withSkill;
    /// <summary>��Ʒ�ṩ��״̬</summary>
    public AbstractAdjectives withAdj;

    /// <summary>�ṩ�Ĺ�����</summary>
    public float atk = 0;
    /// <summary>�ṩ�ķ�����</summary>
    public float def = 0;
    /// <summary>�ṩ�ľ�����</summary>psychic force
    public float psy = 0;
    /// <summary>�ṩ����־��</summary>
    public float san = 0;

    /// <summary>
    /// ʹ����Ʒ
    /// </summary>
    virtual public void UseItem(AbstractCharacter useCharacter)
    {
        withSkill.UseVerbs(useCharacter);
        //��Ʒ�ṩ������
        useCharacter.atk += atk;
        useCharacter.def += def;
        useCharacter.psy += psy;
        useCharacter.san += san;
    }

    virtual public void LoseItem(AbstractCharacter useCharacter)
    {
        //ʧȥ��Ʒ�ṩ������
        useCharacter.atk -= atk;
        useCharacter.def -= def;
        useCharacter.psy -= psy;
        useCharacter.san -= san;
    }
}
