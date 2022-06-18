using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��Ĭ��
/// </summary>
class SilenceOne : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 6;
        gender = GenderEnum.noGender;
        wordName = "��Ĭ��";
        bookName = BookNameEnum.allBooks;
        brief = "һ��ǿ��ģ��޷��ƿ��ĵ���";
        description = "һ��ǿ��ģ��޷��ƿ��ĵ���";
        criticalSpeak = "�š���";
        deadSpeak = "�š�������";
        camp = CampEnum.enemy;
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
        bg_text = "һ��ǿ��ģ��޷��ƿ��ĵ���";
        mainSort = MainSortEnum.atk;
    }

    public override void CreateBullet(GameObject aimChara)
    {
        base.CreateBullet(aimChara);
        ARPGDemo.Common.GameObjectPool.instance.CreateObject(bullet.gameObject.name, bullet.gameObject,this.transform.position,aimChara.transform.rotation );
        DanDao danDao = bullet.GetComponent<DanDao>();
        danDao.aim = aimChara;
        danDao.birthTransform = this.transform;
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
