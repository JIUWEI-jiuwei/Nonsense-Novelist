using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 经济压力
/// </summary>
class FinancialDifficulty : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 7;
        gender = GenderEnum.noGender;
        wordName = "经济压力";
        bookName = BookNameEnum.allBooks;
        role = gameObject.AddComponent<Bank>();
        trait=gameObject.AddComponent<NullTrait>();
        hp=maxHP = 100;
        sp=maxSP = 10;
        atk = 10;
        def = 12;
        psy = 0;
        san = 2;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 2f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        enemyLevel = 2;
        mainSort = MainSortEnum.def;
    }

    public override void CreateBullet(GameObject aimChara)
    {
        base.CreateBullet(aimChara);
        DanDao danDao = bullet.GetComponent<DanDao>();
        danDao.aim = this.gameObject;
        danDao.bulletSpeed = 0.5f;
        danDao.birthTransform = aimChara.transform;
        ARPGDemo.Common.GameObjectPool.instance.CreateObject(bullet.gameObject.name, bullet.gameObject, aimChara.transform.position, aimChara.transform.rotation);
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
