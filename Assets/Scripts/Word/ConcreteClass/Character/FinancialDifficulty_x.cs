using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 经济压力
/// </summary>
class FinancialDifficulty_x : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 7;
        gender = GenderEnum.noGender;
        wordName = "经济压力";
        bookName = BookNameEnum.allBooks;
        trait=gameObject.AddComponent<NullTrait>();
        hp=maxHP = 100;
        atk = 10;
        def = 12;
        psy = 0;
        san = 2;
        multipleCriticalStrike = 2;
        attackInterval = 2.2f;
        attackDistance = 6;
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
