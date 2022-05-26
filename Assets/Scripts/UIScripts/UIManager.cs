
using UnityEngine;
using UnityEngine.UI;

///<summary>
///UI管理器(建立一个UIManager空物体，挂在上面)
///</summary>
class UIManager  : MonoBehaviour
{
    /// <summary>战斗场景是否进入下一关</summary>
    public static bool nextQuanQia;
    /// <summary>脚本</summary>
    private CharacterTranslateAndCamera charaTransAndCamera;
    /// <summary>获取关卡结束面板</summary>
    private static GameObject endPanel;    

    private void Awake()
    {
        charaTransAndCamera = GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
        endPanel = GameObject.Find("endPanel");
        
    }
    /// <summary>
    /// 每一章的下一关按钮
    /// </summary>
    public void NextQuanQia()
    {
        //打开关卡结束面板
        endPanel.transform.GetChild(0).gameObject.SetActive(false);
        charaTransAndCamera.BeginMove();
        nextQuanQia = true;
    }
    /// <summary>
    /// 判断当前关卡是否结束
    /// </summary>
    /// <returns></returns>
    public static bool isEnd()
    {
        if (GameObject.Find("EnemyCharacter").transform.childCount <= 1)
        {
            //打开关卡结束面板
            endPanel.transform.GetChild(0).gameObject.SetActive(true);
            return true;
        }
        return false;
    }
}
