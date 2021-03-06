using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 杂耍火球
/// </summary>
class FireBall : AbstractVerbs
{
    private GameObject bullet;

    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 10;
        wordName = "杂耍火球";
        bookName = BookNameEnum.StudentOfWitch;
        description = "学会杂耍火球，造成150%精神力的伤害，晕眩0.3秒。";
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        percentage = 1.5f;
        attackDistance = 999;
        skillTime = 0;
        skillEffectsTime = 0.3f;
        cd = 0;
        maxCD = 5;
        comsumeSP = 5;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
        description = "花哨且伤害不俗的杂技把戏。";

        bullet = Resources.Load<GameObject>("bullet/Fireball_bullet");
    }

    private AbstractCharacter aimState;//目标的抽象角色类
    /// <summary>
    /// 造成150%攻击力的伤害
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        if (aims != null)
        {
            aimState = aims[0].GetComponent<AbstractCharacter>();
            skillMode.UseMode(useCharacter, useCharacter.atk * percentage * (1 - aimState.def / (aimState.def + 20)), aimState);
            SpecialAbility(useCharacter);
        }
    }
    /// <summary>
    /// 晕眩0.3秒
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        DanDao danDao = bullet.GetComponent<DanDao>();
            danDao.aim = aims[0];
            danDao.bulletSpeed = 0.5f;
            danDao.birthTransform = this.transform;
            ARPGDemo.Common.GameObjectPool.instance.CreateObject(bullet.gameObject.name, bullet.gameObject, this.transform.position, aims[0].transform.rotation);

            AbstractCharacter a = aims[0].GetComponent<AbstractCharacter>();
            a.dizzyTime = skillEffectsTime;
            a.AddBuff(5);
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null || aimState == null)
            return null;

        return character.wordName + "动了动手指，几个火球伴随着低声吟唱的咒语从之间跃出，以花哨的动作旋转着并朝" + aimState.wordName + "冲了过去。";

    }
}
