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

    //ʩ���߼�����Ч���

    //�����߼�����Ч���

    /// <summary>����ʹ����������ƣ�˭����ʹ�ã�</summary>
    public List<AbstractRole> banUse;
    /// <summary>Ŀ�����ƣ�������˭ʹ�ã�</summary>
    public List<AbstractRole> banAim;

    /// <summary>���</summary>
    public float attackDistance;
    /// <summary>�������� </summary>
    public AbstractSkillMode skillMode;
    /// <summary>����ǿ��(����������ȡ���)���������� ĳֵ ��n%�˺�</summary>
    public float skillMinStrength, skillMaxStrength,additional;


    /// <summary>��������</summary>
    public int comsumeSP;
    /// <summary>��ǰ����������CD����Ϊ����ʱ���ƽA�������������������ͷţ�</summary>
    public float cd;//һ�׶���CD
    /// <summary>������</summary>
    public float maxCD;//һ�׶���CD


    /// <summary>���ܳ���ʱ�����ѳ���ʱ������ֳ������� </summary>
    public float skillTime;
    /// <summary>����Ч������ʱ�� </summary>
    public float skillEffectsTime;
    /// <summary>ʩ��ʱ����ǰҡ����ҡ����ʩ��ʱ������ֳ������������á�</summary>
    public float prepareTime,afterTime;
    /// <summary>�Ƿ������� �����á�</summary>
    public bool allowInterrupt;
    /// <summary>���ܸ��ʣ�ƽAʱ�и����ͷţ������á�</summary>
    public float possibility;

    /// <summary>�Ƿ�Ϊ����</summary>
    public bool isFirst;
    /// <summary>����CD�Ƿ���ȴ���</summary>
    public bool b_CdCooled;

    /// <summary>
    /// ����Ч��(����Ч����
    /// </summary>
    abstract public void Ability();

    /// <summary>
    /// ʹ�ü���
    /// </summary>
    /// <param name="character"></param>
    virtual public void UseVerbs(GameObject character)
    {
        Ability();
        cd = 0;
        skillMode.CaculateAgain(attackDistance,character.transform);

        AbstractCharacter  characterStatus=character.GetComponent<AbstractCharacter>();
        characterStatus.sp -= comsumeSP;

    }
    /// <summary>
    /// ����CD��ȴ
    /// </summary>
    /// <param name="cd"></param>
    /// <param name="maxCD"></param>
    /// <param name="b_CDCooled"></param>
    virtual public void CDTime(float cd,float maxCD,bool isFirst,bool b_CDCooled)//ֻ�п���ҡ����ʱ��isFirst=true������ʱ��Ϊfalse
    {
        //����
        if (isFirst) b_CDCooled = true;

        //����
        else
        {
            b_CDCooled = false;
            cd += Time.deltaTime;

            //CD�Ѻ�
            if (cd == maxCD)
            {
                b_CDCooled = true;

            }
        }
    }
}
