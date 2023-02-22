using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuHuo : AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "俘获";
        book = BookNameEnum.Salome;
        upup = 1;

        if (GameObject.Find("所有角色的父物体").GetComponentsInChildren<FuHuo>().Length == 1)
        AbstractVerbs.OnAwake += FuHuoSkill;

        AbstractCharacter character = GetComponent<AbstractCharacter>();
        if(character.attackA.GetType()==typeof(DamageMode))
        {
            FuHuoMode newMode= gameObject.AddComponent<FuHuoMode>();
            newMode.attackRange = character.attackA.attackRange;
            Destroy(character.attackA);
            character.attackA = newMode;
        }
        FuHuoSkill();
    }

    private void FuHuoSkill()
    {
        AbstractVerbs[] allVerb = GetComponents<AbstractVerbs>();
        foreach (AbstractVerbs verb in allVerb)
        {
            if (verb.skillMode.GetType() == typeof(DamageMode))
            {
                FuHuoMode newMode = gameObject.AddComponent<FuHuoMode>();
                newMode.attackRange = verb.skillMode.attackRange;
                Destroy(verb.skillMode);
                verb.skillMode = newMode;
            }
        }
    }

    private void OnDestroy()
    {
       if(this.GetComponents<FuHuo>().Length<=1)//只有自己
        {
            if(GameObject.Find("所有角色的父物体").GetComponentsInChildren<FuHuo>().Length<=1)
                AbstractVerbs.OnAwake -= FuHuoSkill;

            AbstractCharacter character = GetComponent<AbstractCharacter>();
            if (character.attackA.GetType() == typeof(FuHuoMode))
            {
                DamageMode newMode = gameObject.AddComponent<DamageMode>();
                newMode.attackRange = character.attackA.attackRange;
                Destroy(character.attackA);
                character.attackA = newMode;
            }
            AbstractVerbs[] allVerb = GetComponents<AbstractVerbs>();
            foreach (AbstractVerbs verb in allVerb)
            {
                if (verb.skillMode.GetType() == typeof(FuHuoMode))
                {
                    DamageMode newMode = gameObject.AddComponent<DamageMode>();
                    newMode.attackRange = verb.skillMode.attackRange;
                    Destroy(verb.skillMode);
                    verb.skillMode = newMode;
                }
            }
        }
    }

}

class FuHuoMode : AbstractSkillMode
{
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
                aimCharacter.teXiao.PlayTeXiao("BaoJi");
                AbstractBook.afterFightText += useCharacter.CriticalText(aimCharacter);
            }

            /*if(useCharacter.trait.restrainRole.Contains(aimCharacter.trait.traitEnum))//攻击者克被攻击者,提升30%伤害
            {
                aimCharacter.hp -= value * 1.3f;
            }
            else//一般*/
            {
                aimCharacter.hp -= value;
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
    override public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation, NeedCampEnum.friend);//优先攻击友方，期间伤害减半，结束后恢复
        return a;
    }
}

