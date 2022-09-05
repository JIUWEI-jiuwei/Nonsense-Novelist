using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 沉默者
/// </summary>
class SilenceOne : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 6;
        gender = GenderEnum.noGender;
        wordName = "沉默者";
        bookName = BookNameEnum.allBooks;
        brief = "一个强大的，无法绕开的敌人";
        criticalSpeak = "嗯……";
        deadSpeak = "嗯……？！";
        role = gameObject.AddComponent<OldEnemy>();
        trait=gameObject.AddComponent<Pride>();
        hp=maxHP = 300;
        sp=maxSP = 20;
        atk = 13;
        def = 5;
        psy = 10;
        san = 30;
        mainSort = MainSortEnum.atk;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.5f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        enemyLevel = 3;
        description = "一个强大的，无法绕开的敌人";
        mainSort = MainSortEnum.atk;
    }

    public override void CreateBullet(GameObject aimChara)
    {
        base.CreateBullet(aimChara);
        DanDao danDao = bullet.GetComponent<DanDao>();
        danDao.aim = aimChara;
        danDao.birthTransform = this.transform;
        ARPGDemo.Common.GameObjectPool.instance.CreateObject(bullet.gameObject.name, bullet.gameObject,this.transform.position,aimChara.transform.rotation );
        
    }

    public override string ShowText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string CriticalText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string LowHPText()
    {
        return "";
    }
    public override string DieText()
    {
        return "";
    }


}
