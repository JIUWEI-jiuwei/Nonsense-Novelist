using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// �Ứ
/// </summary>
class BuryFlower : AbstractVerbs
{
    private GameObject buryFlower;
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 3;
        wordName = "�Ứ";
        bookName = BookNameEnum.HongLouMeng;
        description = "ѧ���Ứ���ͷ�ʱÿ�ι���������Ŀ����Χ���仨�꣬ÿ�껨������ɫ1�㾫��";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillMode.attackRange = new SingleSelector();
        attackDistance = 0;
        skillTime = 7;
        skillEffectsTime = 0;
        cd=maxCD=40;
        prepareTime = 1f;
        afterTime = 0;
        if (SceneManager.GetActiveScene().name == "Combat")
        {
            buryFlower = GameObject.Find("BuryFlowerF").transform.GetChild(0).gameObject;
        }
    }

    /// <summary>
    /// �������ܺ�ÿ�α�����ɫ�����ĵ�λ������1���仨���������޵��ӣ�ֱ������ʱ�����������ʱ���л��ɵ�����ɫ���У����������ᣬÿ���ռ��Ļ�����1�㾫����
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
       attackState= useCharacter.gameObject.GetComponent<AI.AttackState>();
       useChara = useCharacter;
        buryFlower.SetActive(true);
        buryFlower.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + useCharacter.wordName+"����");
        Invoke("DaZhaoUIFalse", 2f);
       timer = 0;
    }    
    public void DaZhaoUIFalse()
    {
        buryFlower.SetActive(false);
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

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "�ּ�ʢ�����һ������Ʈ���ڵء�\n"+character.wordName+"��Ʈ���ڵص��һ���£���ţ����������ᣬΪ�䰧��������л���ɻ����죬����������˭������";

    }
    /// <summary>
    /// ���150%���������˺�
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }
}
