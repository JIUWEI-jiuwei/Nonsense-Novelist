using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 版本二：拖拽角色站位
/// </summary>
public class CharacterMouseDrag : MonoBehaviour
{
    /// <summary>OnMouseDown相关参数</summary>
    private Vector3 targetScreenpos;//拖拽物体的屏幕坐标
    private Vector3 targetWorldpos;//拖拽物体的世界坐标
    private Transform target;//拖拽物体
    private Vector3 mouseScreenpos;//鼠标的屏幕坐标
    private Vector3 offset;//偏移量

    /// <summary>记录目前所在的站位</summary>
    private Transform nowParentTF;
    /// <summary>记录上一个所在的站位</summary>
    private Transform lastParentTF;
    /// <summary>角色和站位position的Y偏移量</summary>
    public static float offsetY = 0.5f;
    /// <summary>角色简要预制体（手动挂）</summary>
    public Transform charaShortInstance;
    /// <summary>角色简要预制体克隆</summary>
    private Transform charaShort;

    private void Start()
    {
        nowParentTF = transform.parent;
        target = transform;
    }

    private void OnMouseEnter()
    {
        
    }
    #region OnMouseDrag()随鼠标移动(废弃)

    /* private void OnMouseDrag()
     {
         //随鼠标移动
         var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         transform.position = new Vector3(pos.x, pos.y, transform.position.z);
         
     }*/
    #endregion

    /// <summary>
    /// 鼠标悬停
    /// </summary>
    private void OnMouseOver()
    {
        //颜色变黄
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)225 / 255, (float)189 / 255, (float)255 / 255);

        //显示角色简要信息(待测试)
        /*charaShort = Instantiate(charaShortInstance);
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
        charaShort.GetChild(5).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.psy);*/
    }
    private void OnMouseExit()
    {
        //颜色恢复
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)255 / 255, (float)255 / 255, (float)255 / 255);

        //角色简要不显示
        Destroy(charaShort);
    }
    //被移动物体需要添加collider组件，以响应OnMouseDown()函数
    //基本思路。当鼠标点击物体时（OnMouseDown（），函数体里面代码只执行一次），
    //记录此时鼠标坐标和物体坐标，并求得差值。如果此后用户仍然按着鼠标左键，那么保持之前的差值不变即可。
    //由于物体坐标是世界坐标，鼠标坐标是屏幕坐标，需要进行转换。具体过程如下所示。
    IEnumerator OnMouseDown()
    {
        targetScreenpos = Camera.main.WorldToScreenPoint(target.position);
        mouseScreenpos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetScreenpos.z);
        offset = target.position - Camera.main.ScreenToWorldPoint(mouseScreenpos);

        while (Input.GetMouseButton(0))//鼠标左键被持续按下。
        {
            mouseScreenpos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetScreenpos.z);
            targetWorldpos = Camera.main.ScreenToWorldPoint(mouseScreenpos) + offset;
            target.position = targetWorldpos;
            yield return new WaitForFixedUpdate();
        }
    }
    private void OnMouseUp()
    {
        //加上了检测层级（忽略角色本身）
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero,100,LayerMask.GetMask("Situation"));
        if (hit.collider != null)
        {
            Debug.Log(hit.transform.name);

            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Situation"))
            {
                //角色拖拽到站位上且位置校准
                lastParentTF = nowParentTF;
                nowParentTF = hit.transform;
                this.transform.SetParent(nowParentTF);
                transform.position = new Vector3(nowParentTF.position.x, nowParentTF.position.y + offsetY, nowParentTF.position.z);

                //隐藏/恢复站位颜色（透明度为0
                nowParentTF.gameObject.GetComponent<SpriteRenderer>().material.color = Color.clear;
                if(lastParentTF.gameObject.GetComponent<SpriteRenderer>())
                    lastParentTF.gameObject.GetComponent<SpriteRenderer>().material.color = new Color((float)180/255, (float)180 /255, (float)180 /255, 1);

                AbstractCharacter c = this.GetComponent<AbstractCharacter>();
                //根据站位给角色阵营赋值
                if (hit.collider.gameObject.GetComponent<Situation>().number < 6)
                {
                    c.camp = CampEnum.left;
                    if (CharacterManager.charas_right.Contains(c))
                    {
                        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
                        CharacterManager.charas_right.Remove(c);
                    }
                    CharacterManager.charas_left.Add(c);
                }
                else
                {
                    c.camp = CampEnum.right;
                    if (CharacterManager.charas_left.Contains(c)) CharacterManager.charas_left.Remove(c);
                    CharacterManager.charas_right.Add(c);
                    transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
                }
            }

        }
        else//没有检测到站位
        {
            transform.position = new Vector3(nowParentTF.position.x, nowParentTF.position.y + offsetY, nowParentTF.position.z);

        }
    }
} 

