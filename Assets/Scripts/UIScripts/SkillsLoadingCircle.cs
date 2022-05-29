using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

///<summary>
///技能词条的圆圈加载显示
///</summary>
class SkillsLoadingCircle : MonoBehaviour
{
    /// <summary>动词圆圈预制体 </summary>
    public GameObject verbLoadingPrefab;    
    /// <summary>角色头顶动词圆圈的父物体位置 </summary>
    private Transform verbLoadingPoints;
    /// <summary>剩余加载时间数值 </summary>
    private List<Image> verbCD = new List<Image>();
    /// <summary>角色位置 </summary>
    private List<GameObject> skillUIbar = new List<GameObject>();
    /// <summary>获取该角色 </summary>
    private AbstractCharacter charaComponent;
    /// <summary>条位置 </summary>
    private Transform[] barPoint;
    private int count;
    private AbstractVerbs[] absverbs;

    public void Start()
    {
        charaComponent = gameObject.GetComponent<AbstractCharacter>();
        barPoint = gameObject.GetComponentsInChildren<Transform>();
        verbLoadingPoints = barPoint[3];
        count = charaComponent.skills.Count;
    }
    public void FixedUpdate()
    {
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "UIcanvas")
            {
                if(charaComponent.skills.Count>count)
                {
                    absverbs = charaComponent.GetComponents<AbstractVerbs>();
                    count = charaComponent.skills.Count;
                    skillUIbar.Add(Instantiate(verbLoadingPrefab, canvas.transform));
                    verbCD.Add(skillUIbar[count - 1].transform.GetChild(0).GetComponent<Image>()) ;
                    skillUIbar[count - 1].transform.position = verbLoadingPoints.GetChild(count - 1).position;                    
                }
            }
        }      
        if (skillUIbar != null&&charaComponent!=null)
        {            
            for (int i = 0; i < count; i++)
            {
                //获取到该角色身上的skills库中的动词技能
                float percent = absverbs[i].cd / absverbs[i].maxCD;
                verbCD[i].fillAmount = percent;
                skillUIbar[count - 1].transform.position = verbLoadingPoints.GetChild(count - 1).position;
            }
        }
        if (charaComponent.hp <= 0)
        {
            for(int i = 0; i < skillUIbar.Count; i++)
            {
                Destroy(skillUIbar[i]);
            }
        }
    }
}
