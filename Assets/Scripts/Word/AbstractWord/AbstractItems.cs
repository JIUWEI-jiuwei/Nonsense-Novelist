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
    /// <summary>获取方式</summary>
    public GetWayEnum getWay;
    /// <summary>物品对应战场形象</summary>
    public GameObject obj;
    /// <summary>物品目标阵营(如某些物品不能给敌方)【不用】</summary>
    public CampEnum camp;
    /// <summary>物品目标身份限制（谁不能使用） </summary>
    public List<AbstractRoleLimit> banUse=new List<AbstractRoleLimit>();
    /// <summary>持有方式</summary>
    public HoldEnum holdEnum;
    /// <summary>物品材质，对应音效种类 </summary>
    public MaterialVoiceEnum VoiceEnum;
    /// <summary>物品提供的技能</summary>
    public AbstractVerbs withSkill;
    /// <summary>物品提供的状态</summary>
    public AbstractAdjectives withAdj;

    /// <summary>提供的攻击力</summary>
    public float atk = 0;
    /// <summary>提供的防御力</summary>
    public float def = 0;
    /// <summary>提供的精神力</summary>psychic force
    public float psy = 0;
    /// <summary>提供的意志力</summary>
    public float san = 0;

    /// <summary>
    /// 使用物品
    /// </summary>
    virtual public void UseItem(AbstractCharacter useCharacter)
    {
        withSkill.UseVerbs(useCharacter);
        //物品提供的属性
        useCharacter.atk += atk;
        useCharacter.def += def;
        useCharacter.psy += psy;
        useCharacter.san += san;
    }

    virtual public void LoseItem(AbstractCharacter useCharacter)
    {
        //失去物品提供的属性
        useCharacter.atk -= atk;
        useCharacter.def -= def;
        useCharacter.psy -= psy;
        useCharacter.san -= san;
    }
}
