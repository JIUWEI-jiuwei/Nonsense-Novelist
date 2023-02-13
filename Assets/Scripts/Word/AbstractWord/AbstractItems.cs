using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 物品（自己处理每秒做的事）
/// </summary>
abstract class AbstractItems : AbstractWords0
{
    /// <summary>物品序号</summary>
    public int itemID;
    /// <summary>物品对应战场形象</summary>
    public GameObject obj;
    /// <summary>持有方式</summary>
    public HoldEnum holdEnum;
    /// <summary>物品材质，对应音效种类 </summary>
    public MaterialVoiceEnum VoiceEnum;
    /// <summary>弹射机制 </summary>
    public List<WordCollisionShoot> wordCollisionShoots = new List<WordCollisionShoot>();

    protected AbstractCharacter aim;
    /// <summary>特殊效果存储引用</summary>
    protected List<AbstractBuff> buffs = new List<AbstractBuff>();

    virtual public void Awake()
    {
        aim = GetComponent<AbstractCharacter>();
        wordKind = WordKindEnum.noun;
    }

    /// <summary>
    /// 初始释放
    /// </summary>
    /// <param name="chara">持有者</param>
    virtual public void UseItems(AbstractCharacter chara)
    {
        
    }

    /// <summary>
    /// 相当于Update
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
    /// 相当于OnDestroy()
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
