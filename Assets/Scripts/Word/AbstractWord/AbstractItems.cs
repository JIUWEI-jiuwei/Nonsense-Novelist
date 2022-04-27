 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 抽象物品类
/// </summary>
abstract class AbstractItems : AbstractWords0
{
    /// <summary>物品序号</summary>
    public int itemID;
    /// <summary>物品对应战场形象</summary>
    public GameObject obj;
    /// <summary>物品目标阵营(如某些物品不能给敌方)【不用】</summary>
    public CampEnum camp;
    /// <summary>物品目标身份限制（谁不能使用） </summary>
    public List<AbstractRoleLimit> banUse;
    /// <summary>持有方式</summary>
    public HoldEnum holdEnum;
    /// <summary>物品材质，对应音效种类 </summary>
    public MaterialVoiceEnum VoiceEnum;
    /// <summary>物品提供的技能</summary>
    public AbstractVerbs withSkill;
    /// <summary>物品提供的状态</summary>
    public AbstractAdjectives withAdj;
    /// <summary>物品每次使用时提供的经验值【不用】</summary>
    public int provideExp;
    /// <summary>物品等级【不用】</summary>
    public int level;
    //基础属性，成长属性？

    virtual public void UseItem(AbstractCharacter character)
    {
        withSkill.UseVerbs(character); 
    }
}
