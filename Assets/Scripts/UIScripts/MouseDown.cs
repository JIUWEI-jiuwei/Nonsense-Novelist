using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
///鼠标点击物体 显示信息
///</summary>
class MouseDown : MonoBehaviour
{
    /// <summary>属性面板预制体</summary>
    public GameObject propertyPanelPrefab;
    /// <summary>UIcanvas</summary>
    public Canvas UIcanvas;
    /// <summary>预制体的克隆体</summary>
    private static GameObject a;
    /// <summary>预制体中的文字</summary>
    private Text[] texts=new Text[2];
    /// <summary>抽象角色</summary>
    private AbstractCharacter abschara;
    /// <summary>抽象角色</summary>
    private AbstractRole absRole;

 
    private void Update()
    {
        MouseDownView();
    }  
    /// <summary>
    /// 全局鼠标射线
    /// </summary>
    private void MouseDownView()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if(hit.collider!=null)
            {
                Debug.Log(hit.collider.name);
                a = Instantiate(propertyPanelPrefab, UIcanvas.transform);
                abschara = hit.collider.GetComponent<AbstractCharacter>();
                absRole = hit.collider.GetComponent<AbstractRole>();
                //将texts数组获取子物体Text组件
                for (int i = 0; i < texts.Length ; i++)
                {
                   texts[i] = a.transform.GetChild(i + 2).GetComponent<Text>();
                }
                texts[0].text = "人物身份   " + absRole.roleName;
                texts[1].text = "血量       " + abschara.maxHP.ToString();
                //texts[2].text = "蓝量       " + abschara.maxSP.ToString();
                //texts[3].text = "攻击力     " + abschara.atk.ToString();
                //texts[4].text = "防御力     " + abschara.def.ToString();
                //texts[5].text = "精神力     " + abschara.san.ToString();
                //texts[6].text = "意志力     " + abschara.psy.ToString();
                //texts[7].text = "人物性格   " + abschara.trait.ToString();
                //texts[8].text = "暴击几率   " + abschara.criticalChance.ToString();
                //texts[9].text = "暴击倍数   " + abschara.multipleCriticalStrike.ToString();
                //texts[10].text = "攻击速度  " + abschara.attackInterval.ToString();
                //texts[11].text = "技能速度  " + abschara.skillSpeed.ToString();
                //texts[12].text = "闪避几率  " + abschara.dodgeChance.ToString();
                //texts[13].text = "幸运值  " + abschara.luckyValue.ToString();
            }

        }
    }
    /// <summary>
    /// 属性面板的关闭按钮（用预制体挂脚本来赋值）
    /// </summary>
    public void propertyButtonDown()
    {
        Destroy(a);
        Debug.Log("button"+a.name);
    }
}
