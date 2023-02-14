using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ݴ�
/// </summary>
abstract public class AbstractAdjectives : AbstractWords0
{
    /// <summary>�������</summary>
    public int adjID;
    /// <summary>Ŀ����Ч</summary>
    public Animation anim;
    /// <summary>�������� </summary>
    public AbstractSkillMode skillMode;
    /// <summary>���(���ã�</summary>
    public int attackDistance=100;
    /// <summary>����Ч��(�������Ч��������ʱ�� </summary>
    public float skillEffectsTime;
    /// <summary>������� </summary>
    public List<WordCollisionShoot> wordCollisionShoots=new List<WordCollisionShoot>();

    public AbstractCharacter aim;
    /// <summary>����Ч���洢����</summary>
    protected List<AbstractBuff> buffs=new List<AbstractBuff>();

    public virtual void Awake()
    {
        wordKind = WordKindEnum.adj;
        nowTime = skillEffectsTime;
        aim=GetComponent<AbstractCharacter>();
    }
    /// <summary>
    /// ����Ч��(����Ч����
    /// </summary>
    abstract public void BasicAbility(AbstractCharacter aimCharacter);

    /// <summary>
    /// ʹ�ü���
    /// </summary>
    /// <param name="aimCharacter">Ŀ��</param>
    virtual public void UseAdj(AbstractCharacter aimCharacter)
    {
        AbstractBook.afterFightText += UseText();
    }
    /// <summary>����ʱ</summary>
    protected float nowTime;
    virtual protected void Update()
    {
        nowTime-=Time.deltaTime;
        if (nowTime < 0)
            Destroy(this);
    }
    virtual public void End()
    {

    }

    private void OnDestroy()
    {
        foreach (AbstractBuff buff in buffs)
        {
            Destroy(buff);
        }
        if (aim!=null)
        {
            End();
        }
    }

}
