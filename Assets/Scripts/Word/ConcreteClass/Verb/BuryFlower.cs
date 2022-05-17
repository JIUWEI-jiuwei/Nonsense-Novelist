using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �Ứ
/// </summary>
class BuryFlower : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 3;
        wordName = "�Ứ";
        bookName = BookNameEnum.HongLouMeng;
        description = "ƽ���Ứɱ�ˣ������仨�����㣬����������֮��";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        attackDistance = 0;
        skillTime = 7;
        skillEffectsTime = 0;
        cd=maxCD=40;
        comsumeSP = 15;
        prepareTime = 1f;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;

    }

    /// <summary>
    /// �������ܺ�ÿ�α�����ɫ�����ĵ�λ������1���仨���������޵��ӣ�ֱ������ʱ�����������ʱ���л��ɵ�����ɫ���У����������ᣬÿ���ռ��Ļ�����1�㾫����
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
       attackState= useCharacter.gameObject.GetComponent<AI.AttackState>();
        useChara = useCharacter;
       timer = 0;
    }

    private AI.AttackState attackState;//
    private int flowerNum;//������
    private float timer;//��ʱ��
    private AbstractCharacter useChara;

    /// <summary>
    /// ���������仨
    /// </summary>
    public void Update()
    {
        //û��ͣ��Ϸ&&�����ͷ��ڼ�&&ƽA��,�����仨
        if (Time.deltaTime!=0 && attackState!=null && attackState.attackAtime == 0)
            flowerNum++;
    }

    
    /// <summary>
    /// ��ʱ
    /// </summary>
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        if (timer < skillTime)
        {
            timer += Time.deltaTime;
        }
        else if (timer >= skillTime)//�൱���仨�����ľ��������
        {
            attackState = null;
            if (useChara != null)
            {
                useChara.psy += flowerNum;
            }
            flowerNum = 0;
        }
    }

    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "�ּ�ʢ�����һ������Ʈ���ڵء�\n" + character.wordName + "��Ʈ���ڵص��һ���£���ţ����������ᣬΪ�䰧����";

    }

}
