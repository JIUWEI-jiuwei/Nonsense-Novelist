using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 狄卡德
/// </summary>
class DiKaDe : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 9;
        wordName = "狄卡德";
        bookName = BookNameEnum.ElectronicGoal;
        gender = GenderEnum.boy;
        hp =MaxHP  = 120;
        atk = 5;
        def = 4;
        psy = 3;
        san = 3;
        mainProperty.Add("攻击","远物dps");
        trait=gameObject.AddComponent<Persistent>();
        roleName = "银翼杀手";
        attackInterval = 2.2f;
        attackDistance = 500;
    }

    public override float atk 
    {
        get => base.atk + MaxHP * 0.05f; 
        set => base.atk = value; 
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
