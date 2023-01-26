using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ݴ�
/// </summary>
abstract class AbstractAdjectives : AbstractWords0
{
    /// <summary>�������</summary>
    public int adjID;
    /// <summary>Ŀ����Ч</summary>
    public Animation anim;
    /// <summary>���÷�Χ���ͣ�����ʵ����UI�ű��жϴ��ֶΣ�</summary>
    public ChooseWayEnum chooseWay;
    /// <summary>Ŀ�����ƣ�������˭ʹ�ã�</summary>
    public List<AbstractRoleLimit> banAim=new List<AbstractRoleLimit>();
    /// <summary>�������� </summary>
    public AbstractSkillMode skillMode;
    /// <summary>����ǿ��(����������ȡ���)������� ĳֵn%��percentageдС���� ���˺�</summary>
    public float skillMinStrength, skillMaxStrength, percentage;
    /// <summary>���</summary>
    public int attackDistance;
    /// <summary>���ܳ���ʱ�����ѳ���ʱ������ֳ������� </summary>
    public float skillTime;
    /// <summary>����Ч��(�������Ч��������ʱ�� </summary>
    public float skillEffectsTime;
    /// <summary>�Ƿ�鵽ʱ�ͷ�</summary>
    public bool useAtFirst;

    public virtual void Awake()
    {
    }
    /// <summary>
    /// ����Ч��(����Ч����
    /// </summary>
    abstract public void SpecialAbility(AbstractCharacter aimCharacter);

    /// <summary>
    /// �����ڡ���Ŀ�����飩
    /// </summary>
    protected AbstractCharacter[] aims;
    /// <summary>
    /// ʹ�ü���
    /// </summary>
    /// <param name="aimCharacter">Ŀ��</param>
    virtual public void UseVerbs(AbstractCharacter aimCharacter)
    {
        AbstractBook.afterFightText += UseText();
    }
}
