using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class ShuiShou : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 5;
        wordName = "˰��";
        bookName = BookNameEnum.ElectronicGoal;
        gender = GenderEnum.noGender;
        hp =maxHP  = 2200;
        atk = 5;
        def = 5;
        psy = 3;
        san = 3;
        mainProperty.Add("����","����T");
        trait=gameObject.AddComponent<ColdInexorability>();
        roleName = "¢�Ϲ�˾";
        criticalChance = 10;
        attackInterval = 2;
        attackDistance = 1;
        importantNum.AddRange(new int[] { 8 });
        brief = "�����ճ�������������ľ���ѹ��";
        description = "�����ճ�������������ľ���ѹ����";
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
            return otherChara.wordName + "���ѿ�������һ�����ã�ϸ�����ݣ�ֻ������㣬����΢΢���о�ʱ��毻���ˮ���ж������������磬" + otherChara.wordName + "Ц������������ã����������ġ�";
        else
            return null;
    }
    public override string CriticalText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "���Ҿ�֪�������˲���ʣ�µ�Ҳ�����ҡ�������������һ�仨�꣬��" + otherChara.wordName + "��ȥ";
        else
            return null;
    }

    public override string LowHPText()
    {
        return "�������Ů��Ϣ���������ϻ���ա����㽫һ�����ӣ�һ��ʫ��پ��ڻ����С�";
    }
    public override string DieText()
    {
        return "�����񡭱�����á���������û˵��������˫�ۡ�";
    }

}
