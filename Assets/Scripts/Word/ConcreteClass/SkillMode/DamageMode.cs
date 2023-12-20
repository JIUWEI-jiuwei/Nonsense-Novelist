using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 伤害技能
/// </summary>
class DamageMode : AbstractSkillMode
{
    /// <summary>是否为物理伤害（仅用于展示） </summary>
    public bool isPhysics=true;
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
    public override float UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
        if (useCharacter != null)//角色使用
        {
            float a = Random.Range(0, 100);//暴击抽奖
            if (a <= useCharacter.criticalChance * 100)//暴击
            {
                value *= useCharacter.multipleCriticalStrike;
                aimCharacter.teXiao.PlayTeXiao("BaoJi");
                AbstractBook.afterFightText += useCharacter.CriticalText(aimCharacter);
            }
          
            //aimCharacter.hp -= value;
        }
        else//玩家使用（形容词）
        {
            aimCharacter.hp -= (int)value;
        }
        return value;
    }
    /// <summary>
    /// 再次计算锁定的目标
    /// </summary>
    /// <param name="character">施法者</param>
    /// <returns></returns>
    override public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        
        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation, NeedCampEnum.enemy);
        return a;
    }
    override public AbstractCharacter[] CalculateRandom(int attackDistance, AbstractCharacter character, bool _ignoreBoss)
    {

        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation, _ignoreBoss);
        return a;
    }
}
