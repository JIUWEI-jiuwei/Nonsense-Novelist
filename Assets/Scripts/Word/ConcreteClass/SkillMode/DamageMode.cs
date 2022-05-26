using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 伤害技能
/// </summary>
class DamageMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 1;
        skillModeName = "伤害";
    }

    /// <summary>
    /// 对目标实际影响
    /// </summary>
    /// <param name="value">实际伤害</param>
    /// <param name="character">目标（来自目标数组）</param>
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
        if (useCharacter != null)//角色使用
        {
            float a = Random.Range(0, 100);//暴击抽奖
            if (a <= useCharacter.criticalChance * 100)//暴击
            {
                value *= useCharacter.multipleCriticalStrike;
            }

            float b=Random.Range(0, 100);//闪避抽奖
            if(b<=aimCharacter.dodgeChance*100)//闪避
            {
                return; 
            }

            if (useCharacter.role.restrainRole.ContainsKey(aimCharacter.role.roleID))//攻击者克被攻击者
            {
                aimCharacter.hp -= (int)(value * (1 + useCharacter.role.restrainRole[aimCharacter.role.roleID]));
            }
            else if (aimCharacter.role.restrainRole.ContainsKey(useCharacter.role.roleID))//被攻击者克制攻击者
            {
                aimCharacter.hp -= (int)(value * (1 - aimCharacter.role.restrainRole[useCharacter.role.roleID]));
            }
        }
        else//玩家使用（形容词）
            aimCharacter.hp -= (int)value;
    }
    /// <summary>
    /// 再次计算锁定的目标
    /// </summary>
    /// <param name="character">施法者</param>
    /// <returns></returns>
    override public GameObject[] CalculateAgain(float attackDistance, GameObject character)
    {
        CampEnum camp = character.GetComponent<AbstractCharacter>().camp;
        GameObject[] a = base.CalculateAgain(attackDistance, character);
        if (a != null)
        {
            if (camp == CampEnum.enemy)
            {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == CampEnum.friend);
            }
            else if (camp == CampEnum.friend)
            {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == CampEnum.enemy);
            }
        }
        return a;
    }
}
