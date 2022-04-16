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
    /// <summary>目标阵营优先级</summary>
    private List<CampEnum> campOrder;
    /// <summary>目标身份优先级(和↓二选一）</summary>
    private List<AbstractRole> roleOrder;
    /// <summary>目标性格优先级(和↑二选一）【不用】</summary>
    private List<AbstractTrait> traitOrder;

    /// <summary>是否优先选择低血量</summary>
    private bool chooseMinHp;

    
    /// <summary>额外值（影响区域相关）</summary>
    public float extra;
    /// <summary>影响区域（直线、扇形、圆形）</summary>
    public IAttackRange attackRange ;
    /// <summary>攻击次数（比如三连击）</summary>
    public int attacktimes=1;


    /// <summary>
    /// 再次计算锁定的目标
    /// </summary>
    /// <param name="character">使用者位置</param>
    /// <returns></returns>
    virtual public GameObject[] CaculateAgain(float attackDistance,Transform ownTrans)
    {
        GameObject[] a=attackRange.AttackRange(attackDistance,ownTrans,extra);


        return a;
    }
    abstract public void UseMode(int value,AbstractCharacter character);    
}
