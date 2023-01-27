using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��Ʒ���Լ�����ÿ�������£�
/// </summary>
abstract class AbstractItems : AbstractWords0
{
    /// <summary>��Ʒ���</summary>
    public int itemID;
    /// <summary>��Ʒ��Ӧս������</summary>
    public GameObject obj;
    /// <summary>���з�ʽ</summary>
    public HoldEnum holdEnum;
    /// <summary>��Ʒ���ʣ���Ӧ��Ч���� </summary>
    public MaterialVoiceEnum VoiceEnum;

    protected AbstractCharacter aim;
    /// <summary>����Ч���洢����</summary>
    protected List<AbstractBuff> buffs = new List<AbstractBuff>();

    virtual public void Awake()
    {
        aim = GetComponent<AbstractCharacter>();
    }

    /// <summary>
    /// ��ʼ�ͷ�
    /// </summary>
    /// <param name="chara">������</param>
    virtual public void UseItems(AbstractCharacter chara)
    {
        
    }

    /// <summary>
    /// �൱��Update
    /// </summary>
    /// <param name="chara"></param>
    virtual public void UseVerbs()
    {

    }

    private void Update()
    {
        if(aim!=null)
        {
            UseVerbs();
        }
    }

    /// <summary>
    /// �൱��OnDestroy()
    /// </summary>
    virtual public void End()
    {

    }

    private void OnDestroy()
    {
        foreach (AbstractBuff buff in buffs)
        {
            Destroy(buff);
        }
        if (aim != null)
        {
            End();
        }
    }

}
