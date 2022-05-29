
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
    private static CharacterTranslateAndCamera charaTransAndCamera;
    /// <summary>获取关卡结束面板</summary>
    private static GameObject endPanel;
    /// <summary>获取章节结束面板</summary>
    public static GameObject bookEndPanel;
    public static LoadingScript loadingScript;
    public static AudioSource audioSource_write;
    private  AudioSource audioSource_BGM;
    public AudioClip[] audioClips;
    private CharacterTranslateAndCamera transAndCamera;

    private void Awake()
    {
        charaTransAndCamera = GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
        transAndCamera= GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
        endPanel = GameObject.Find("endPanel");
        bookEndPanel = GameObject.Find("BookEndPanel");
        loadingScript = GameObject.Find("MainCamera").GetComponent<LoadingScript>();
        audioSource_write = GameObject.Find("AudioSource_wirte").GetComponent<AudioSource>();
        audioSource_BGM= GameObject.Find("AudioSource_BGM").GetComponent<AudioSource>();
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
        audioSource_BGM.clip = audioClips[transAndCamera.guanQiaNum+1];
        audioSource_BGM.Play();
    }
    public void InvokeNextQuanQia()
    {
        Invoke("NextQuanQia",105f);
    }
    /// <summary>
    /// 判断当前关卡是否结束
    /// </summary>
    /// <returns></returns>
    public static bool WinEnd()
    {
       

            if (GameObject.Find("EnemyCharacter").transform.childCount <= 1 && charaTransAndCamera.guanQiaNum <= 1)
            {
                //打开关卡结束面板
                endPanel.transform.GetChild(0).gameObject.SetActive(true);
                return true;
            }
            if (GameObject.Find("EnemyCharacter").transform.childCount <= 1 && charaTransAndCamera.guanQiaNum == 2)
            {
                //打开章节结束面板
                bookEndPanel.transform.GetChild(0).gameObject.SetActive(true);
                audioSource_write.Play();
                return true;
            }
        
        return false;
    }

    /// <summary>
    /// 判断当前关卡是否结束
    /// </summary>
    /// <returns></returns>
    public static bool LoseEnd()
    {
        if (GameObject.Find("SelfCharacter").transform.childCount <= 1 )
        {
            //失败先跳转到loading界面，再跳转到startgame界面
            loadingScript.enabled = true;
            return true;
        }
        return false;
    }
}
