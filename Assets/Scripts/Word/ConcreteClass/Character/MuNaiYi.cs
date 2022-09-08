using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class MuNaiYi : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 4;
        wordName = "ľ����";
        bookName = BookNameEnum.EgyptMyth;
        gender = GenderEnum.noGender;
        hp =maxHP  = 220;
        atk = 3;
        def = 4;
        psy = 4;
        san = 4;
        mainProperty.Add("��־","�з�T");
        trait=gameObject.AddComponent<Vicious>();
        roleName = "����";
        criticalChance = 15;
        attackInterval = 2;
        attackDistance = 3;
        reLifes = true;//�����
        importantNum.AddRange(new int[] { 8 });
        brief = "";
        description = "��Ĭ��������ĳ�������Ĺ��壬��С�㾫ͨħ����ʹ�á���˵��������Ȩ���߸�֮�����������߹��ڵ�������ĥ��ʹ���˻������ʱ���������ţ�ֱ�����������Զ���ĥ�𡣶������ϵ�ħ������Ҳ��Ť������ö񶾲������������������������ĵؽ����ϰ�ű���ʦ��������ħ����";
    }
    /// <summary>
    /// ���
    /// </summary>
    public override float psy { get { return PSY +5; } set { PSY = value; } }
    public override float san { get { return SAN +5; } set { SAN = value; } }

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
