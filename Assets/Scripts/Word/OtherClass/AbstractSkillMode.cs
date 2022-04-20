using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 技能类型
/// </summary>
abstract class AbstractSkillMode : MonoBehaviour
{
    /// <summary>技能类型序号</summary>
    public int skillModeID;
    /// <summary>技能类型名称</summary>
    public string skillModeName;
    /// <summary>目标身份优先级(和↓二选一）</summary>
    private List<AbstractRole> roleOrder;
    /// <summary>目标性格优先级(和↑二选一）【不用】</summary>
    private List<AbstractTrait> traitOrder;
    
    /// <summary>额外值（影响区域相关）</summary>
    public float extra;
    /// <summary>影响区域（直线、扇形、圆形）</summary>
    public IAttackRange attackRange ;
    /// <summary>攻击次数（比如三连击）</summary>
    public int attacktimes=1;

    /// <summary>
    /// 再次计算锁定的目标
    /// </summary>
    /// <param name="character">施法者</param>
    /// <returns></returns>
    virtual public GameObject[] CalculateAgain(float attackDistance,GameObject character)
    {
        GameObject[] a=attackRange.AttackRange(attackDistance,character.transform,extra);


        return a;
    }
    abstract public void UseMode(int value,AbstractCharacter character);    
}
