using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class JiaBaoYu : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 3;
        wordName = "贾宝玉";
        bookName = BookNameEnum.HongLouMeng;
        gender = GenderEnum.girl;
        hp = maxHP = 80;
        atk = 3;
        def = 3;
        psy = 5;
        san = 3;
        mainProperty.Add("精神", "远法dps");
        trait = gameObject.AddComponent<Sentimental>();
        attackInterval = 2.2f;
        attackDistance = 5;
        brief = "《红楼梦》中一位性格敏感脆弱，却又极有灵性的少女。";
        description = "林黛玉，中国古典名著《红楼梦》的女主角，金陵十二钗正册双首之一，西方灵河岸绛珠仙草转世，最后于贾宝玉、薛宝钗大婚之夜泪尽而逝。她生得容貌清丽，兼有诗才，是古代文学作品中极富灵气的经典女性形象。" +
            "\n道是：" +
            "\n可叹停机德，堪怜咏絮才。" +
            "\n玉带林中挂，金簪雪里埋。";
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
