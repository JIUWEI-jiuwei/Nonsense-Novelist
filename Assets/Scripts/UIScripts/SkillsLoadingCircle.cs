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
    private GameObject UIbar;
    /// <summary>获取该角色 </summary>
    private AbstractCharacter charaComponent;
    /// <summary>条位置 </summary>
    private Transform[] barPoint;


    public void Start()
    {
        charaComponent = gameObject.GetComponent<AbstractCharacter>();
        barPoint = gameObject.GetComponentsInChildren<Transform>();
        verbLoadingPoints = barPoint[3];
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "UIcanvas")
            {
                for (int i = 0; i < charaComponent.skills.Count; i++)
                {
                    UIbar = Instantiate(verbLoadingPrefab, canvas.transform);
                    verbCD[i] = UIbar.transform.GetChild(i).GetComponent<Image>();
                    UIbar.transform.position = verbLoadingPoints.GetChild(i).position;
                }                   
            }
        }
    }
    public void FixedUpdate()
    {
        UpdateHealthBar();
        if (UIbar != null)
        {
            for (int i = 0; i < charaComponent.skills.Count; i++)
            {                
                UIbar.transform.position = verbLoadingPoints.GetChild(i).position;
            }
        }
    }
    /// <summary>
    /// 技能CD进度
    /// </summary>
    public void UpdateHealthBar()
    {
        for (int i = 0; i < charaComponent.skills.Count; i++)
        {//获取到该角色身上的skills库中的动词技能
            verbCD[i].fillAmount = charaComponent.skills[i].cd / charaComponent.skills[i].maxCD;
        }
    }
}
