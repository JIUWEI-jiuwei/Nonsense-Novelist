using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 蚁酸喷射
/// </summary>
class CHOOHShoot : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 7;
        wordName = "蚁酸喷射";
        bookName = BookNameEnum.PHXTwist;
        description = "学会蚁酸喷射，造成150%攻击力的伤害，减少2点防御力。";
        attackDistance = 5;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new SingleSelector();
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 7;
        cd=maxCD=3;
        prepareTime = 0.3f;
        afterTime = 0;
        description = "以全力将毒腺挤压，喷射出的毒液可以腐蚀护甲。";
    }


    private float now = 0;//计时
    /// <summary>
    /// 腐蚀，可叠加9次，每次-2防御
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        
        for (int i = 0; i < aims.Length; i++)
        {
            if (!aims[i].buffs.ContainsKey(9) || aims[i].buffs[10] < 9)
            {
                aims[i].def -= 2;
                aims[i].AddBuff(10);
                now = 0;
            }
        }
    }
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now >= skillEffectsTime && aims!=null)
        {
            for (int i = 0; i < aims.Length; i++)
            {
                aims[i].def += 2;
                aims[i].RemoveBuff(10);
            }
        }
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "鼓动着自己腹部的腺体，突然收缩腹部，喷射出了一道酸性的液体，正好命中了名字2的脸部。";

    }
}
