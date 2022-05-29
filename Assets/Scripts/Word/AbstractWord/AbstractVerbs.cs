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
    public List<AbstractRoleLimit> banUse=new List<AbstractRoleLimit>();
    /// <summary>Ŀ�����ƣ�������˭ʹ�ã�</summary>
    public List<AbstractRoleLimit> banAim=new List<AbstractRoleLimit>();


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
    /// <summary>�Ƿ�����ʹ�øü��� </summary>
    public bool isUsing;
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
    /// <summary>Ŀ������ </summary>
    protected GameObject[] aims;

    public virtual void Awake()
    {
        wordSort =WordSortEnum.verb;
    }
    /// <summary>
    /// ����Ч��(����Ч����
    /// </summary>
    virtual public void SpecialAbility(AbstractCharacter useCharacter)
    {

    }
    /// <summary>
    /// ʹ�ü���
    /// </summary>
    /// <param name="camp">ʹ������Ӫ</param>
    virtual public void UseVerbs(AbstractCharacter useCharacter)
    {
        isUsing = true;
        cd = 0;
        aims=skillMode.CalculateAgain(attackDistance,useCharacter.gameObject);
        useCharacter.charaAnim.Play(AnimEnum.attack);
        useCharacter.sp -= comsumeSP;
    }

    virtual public void FixedUpdate()
    {
        if (cd < maxCD)
        {
            cd += Time.deltaTime;
        }
        if(isUsing && !userAnim.isPlaying )//��������Ч��Ϊʹ�����
        {
            isUsing=false;
        }
    }

    /// <summary>
    /// ��ȴ��UseVerbs��cd����Ϊ0��
    /// </summary>
    /// <returns>�Ƿ���ȴ���</returns>
    virtual public bool CalculateCD()
    {

        if (cd >= maxCD)
        {
            cd = maxCD;
            return true;
        }
        else
            return false;
    }
}
