using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// combat after start
/// </summary>
public class AfterStart : MonoBehaviour
{
    /// <summary>角色简要预制体（手动挂）</summary>
    private GameObject charaShortInstance;
    /// <summary>角色简要预制体克隆</summary>
    private GameObject charaShort;



    /// <summary></summary>
    private bool one;
    private SpriteRenderer sr;

    private Color colorIn = new Color((float)255 / 255, (float)225 / 255, (float)189 / 255, (float)255 / 255);
    private Color colorOut = new Color((float)255 / 255, (float)255 / 255, (float)255 / 255, (float)255 / 255);
    private Color colorNoEnergy=Color.white;
    private Color colorHasEnergy =Color.blue;
    private void Start()
    {
        charaShortInstance = Resources.Load<GameObject>("UI/CharacterShort");

        sr = GetComponentInChildren<AI.MyState0>().GetComponent<SpriteRenderer>();
    }


    private void OnMouseOver()
    {
        //颜色变黄
        sr.color = colorIn;

        if (!one)
        {
            one = true;
            //显示角色简要信息(注意第二个参数对于UI)
            charaShort = Instantiate(charaShortInstance,this.transform.GetComponentInChildren<Canvas>().gameObject.transform);

            Function();


        }
    }


    private Transform skillList;
    private Transform buffList;
    string energyAdr = "UI/energySingle";
    private float energyOffset = 60;//一行之间的每两个能量值中间的间隔大小
    private float energyOffsetWith = 150;//第一个能量值在x轴上向右的位移

    void Function()
    {
        //给角色简要赋值
        AbstractCharacter abschara = GetComponent<AbstractCharacter>();

        //ATK1
        charaShort.transform.GetChild(0).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.atk);
        //def4
        charaShort.transform.GetChild(3).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.def);
        //san3
        charaShort.transform.GetChild(2).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.san);
        //psy2
        charaShort.transform.GetChild(1).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.psy);


        //获取角色的技能列表
        skillList = charaShort.transform.GetChild(4);
        if (abschara.skills.Count > 3) print(abschara.name + "技能数超过3个");

        skillList.GetChild(0).GetComponent<Text>().text = "";
        skillList.GetChild(1).GetComponent<Text>().text = "";
        skillList.GetChild(2).GetComponent<Text>().text = "";

        for (int x = 0; x < abschara.skills.Count; x++)
        {

            skillList.GetChild(x).GetComponent<Text>().text = abschara.skills[x].wordName;

            print(abschara.skills[x].wordName + abschara.skills[x].CD);
            for (int i = 0; i < abschara.skills[x].needCD; i++)
            {
                PoolMgr.GetInstance().GetObj(energyAdr, (o) =>
                {
                    o.transform.parent = skillList.GetChild(x);
                    o.transform.localScale = Vector3.one;
                    o.transform.localPosition = new Vector3(i * energyOffset + energyOffsetWith, 0, 0);
                    o.GetComponent<Image>().color = (i < abschara.skills[x].CD) ? colorHasEnergy : colorNoEnergy;


                });

            }
        }


        //获取角色的状态列表（最多10个）
        buffList = charaShort.transform.GetChild(5);

    }


    private void Update()
    {
        if (!one)
            return;


        Function();
    }


    private void OnMouseExit()
    {
        //颜色恢复

        sr.color = colorOut;

    

        if (one)
        {
            //角色简要不显示
            Destroy(charaShort.gameObject);
            one = false;
        }
    }
}
