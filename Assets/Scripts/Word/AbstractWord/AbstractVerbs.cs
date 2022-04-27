using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ���󶯴��ࣨ���ܣ�
/// </summary>
abstract class AbstractVerbs : AbstractWords0 ,ICD
{
    /// <summary>�������</summary>
    public int skillID;


    /// <summary>ʩ������Ч</summary>
    public Animation userAnim;
    /// <summary>��������Ч</summary>
    public Animation aimAnim;
    /// <summary>������Ч</summary>
    public Animation bulletAnim;


    /// <summary>����ʹ����������ƣ�˭����ʹ�ã�</summary>
    public List<AbstractRoleLimit> banUse;
    /// <summary>Ŀ�����ƣ�������˭ʹ�ã�</summary>
    public List<AbstractRoleLimit> banAim;


    /// <summary>�������� </summary>
    public AbstractSkillMode skillMode;
    /// <summary>����ǿ��(����������ȡ���)������� ĳֵn%��percentageдС���� ���˺�</summary>
    public float skillMinStrength, skillMaxStrength,percentage;
    /// <summary>���</summary>
    public float attackDistance;


    /// <summary>���ܳ���ʱ�����ѳ���ʱ������ֳ������� </summary>
    public float skillTime;
    /// <summary>����Ч��(�������Ч��������ʱ�� </summary>
    public float skillEffectsTime;
    /// <summary>��ǰ����������CD����Ϊ����ʱ���ƽA�������������������ͷţ�</summary>
    public float cd;//һ�׶���CD
    /// <summary>������</summary>
    public float maxCD;//һ�׶���CD
    /// <summary>��������</summary>
    public int comsumeSP;
    /// <summary>ʩ��ʱ����ǰҡ����ҡ����ʩ��ʱ������ֳ������������á�</summary>
    public float prepareTime,afterTime;
    /// <summary>�Ƿ������� �����á�</summary>
    public bool allowInterrupt;
    /// <summary>���ܸ��ʣ�ƽAʱ�и����ͷţ������á�</summary>
    public float possibility;

    /// <summary>
    /// ����Ч��(����Ч����
    /// </summary>
    virtual  public void SpecialAbility()
    {

    }

    /// <summary>
    /// �����ڡ���Ŀ�����飩
    /// </summary>
    protected GameObject[] aims;
    /// <summary>
    /// ʹ�ü���
    /// </summary>
    /// <param name="character"></param>
    /// <param name="camp">ʹ������Ӫ</param>
    virtual public void UseVerbs(AbstractCharacter character)
    {
        cd = 0;
        aims=skillMode.CalculateAgain(attackDistance,character.gameObject);
        character.charaAnim.Play(AnimEnum.attack);
        character.sp -= comsumeSP;
    }
    /// <summary>
    /// ��ȴ��UseVerbs��cd����Ϊ0��
    /// </summary>
    /// <returns>�Ƿ���ȴ���</returns>
    virtual public bool CalculateCD()
    {
        if(cd<maxCD)
        {
            cd += Time.deltaTime;
        }
        if (cd >= maxCD)
            return true;
        else 
            return false;
    }
}
