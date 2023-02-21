using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// combat after start
/// </summary>
public class AfterStart : MonoBehaviour
{
    /// <summary>角色简要预制体（手动挂）</summary>
    private Transform charaShortInstance;
    /// <summary>角色简要预制体克隆</summary>
    private Transform charaShort;
    /// <summary></summary>
    private bool one;

    private void Start()
    {
        charaShortInstance = Resources.Load<Transform>("SecondStageLoad/CharacterShort");
    }
    private void OnMouseOver()
    {

        //颜色变黄
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)225 / 255, (float)189 / 255, (float)255 / 255);

        if (!one)
        {
            one = true;
            //显示角色简要信息(待测试)
            charaShort = Instantiate(charaShortInstance);
            charaShort.SetParent(transform.GetChild(4));
            charaShort.localScale = Vector3.one;

            //给角色简要赋值
            AbstractCharacter abschara = GetComponent<AbstractCharacter>();
            //name
            charaShort.GetChild(0).GetComponent<Text>().text = abschara.wordName;
            //HP
            charaShort.GetChild(1).GetComponentInChildren<Text>().text = abschara.hp.ToString() + "/" + abschara.maxHP.ToString();
            //ATK
            charaShort.GetChild(2).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.atk);
            //def
            charaShort.GetChild(3).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.def);
            //san
            charaShort.GetChild(4).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.san);
            //psy
            charaShort.GetChild(5).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.psy);
        }
    }
    private void OnMouseExit()
    {
        //颜色恢复
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)255 / 255, (float)255 / 255, (float)255 / 255);

        //角色简要不显示
        Destroy(charaShort.gameObject);
    }
}
