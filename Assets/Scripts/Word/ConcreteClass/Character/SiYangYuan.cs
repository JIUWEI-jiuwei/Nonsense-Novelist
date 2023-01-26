using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class SiYangYuan : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 11;
        wordName = "贝洛姬·姬妮";
        bookName = BookNameEnum.ZooManual;
        gender = GenderEnum.noGender;
        hp =maxHP  = 100;
        atk = 0;
        def = 5;
        psy = 3;
        san = 5;
        mainProperty.Add("意志","奶");
        trait=gameObject.AddComponent<Mercy>();
        attackInterval = 2.2f;
        attackDistance = 5;
        brief = "《红楼梦》中一位性格敏感脆弱，却又极有灵性的少女。";
        description = "林黛玉，中国古典名著《红楼梦》的女主角，金陵十二钗正册双首之一，西方灵河岸绛珠仙草转世，最后于贾宝玉、薛宝钗大婚之夜泪尽而逝。她生得容貌清丽，兼有诗才，是古代文学作品中极富灵气的经典女性形象。" +
            "\n道是：" +
            "\n可叹停机德，堪怜咏絮才。" +
            "\n玉带林中挂，金簪雪里埋。";
    }
    private void Start()
    {
        attackState = GetComponent<AttackState>();
        Destroy(attackState.attackA);
        attackState.attackA = gameObject.AddComponent<CureMode>();
    }

    AttackState attackState;
    AbstractCharacter[] aims;
    public override void AttackA()
    {
        base.AttackA();
        myState.aim = null;
        if (myState.character.aAttackAudio != null)
        {
            myState.character.source.clip = myState.character.aAttackAudio;
            myState.character.source.Play();
        }
        myState.character.charaAnim.Play(AnimEnum.attack);
        aims=attackState.attackA.CalculateAgain(100, this);
        CollectionHelper.OrderBy(aims, p=>p.hp);
        //普通攻击目标为血量百分比最低的队友，恢复120%意志的血量，以及“亢奋”状态
        attackState.attackA.UseMode(myState.character, san * 1.2f, aims[0]);
        
    }

    public override void CreateBullet(GameObject aimChara)
    {
        base.CreateBullet(aimChara);
        DanDao danDao = bullet.GetComponent<DanDao>();
        danDao.aim = aimChara;
        danDao.bulletSpeed = 0.5f;
        danDao.birthTransform = this.transform;
        ARPGDemo.Common.GameObjectPool.instance.CreateObject(bullet.gameObject.name, bullet.gameObject, this.transform.position, aimChara.transform.rotation);

    }
    public override string ShowText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return otherChara.wordName + "早已看见多了一个妹妹，细看形容，只见泪光点点，娇喘微微，闲静时如姣花照水，行动处似弱柳扶风，" + otherChara.wordName + "笑道：“这个妹妹，我曾见过的”";
        else
            return null;
    }
    public override string CriticalText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "“我就知道，别人不挑剩下的也不给我。”林黛玉轻捻一朵花瓣，向" + otherChara.wordName + "飞去";
        else
            return null;
    }

    public override string LowHPText()
    {
        return "黛玉对侍女喘息道：“笼上火盆罢。”便将一对帕子，一叠诗稿焚尽于火盆中。";
    }
    public override string DieText()
    {
        return "“宝玉…宝玉…你好……”黛玉没说完便合上了双眼。";
    }

}
