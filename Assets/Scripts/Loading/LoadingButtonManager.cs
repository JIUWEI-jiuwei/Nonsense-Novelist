using UnityEngine.SceneManagement;
using UnityEngine;

///<summary>
///全局跳转界面按钮Manager
///</summary>
class LoadingButtonManager : MonoBehaviour
{
    public GaiZhangAnim gaiZhangAnim;

    public LoadingScript loadingScript;
    public string startGame = "Login";
    public string bookDesk = "BookDesk";
    public string newGame = "NewGame";
    public string combat = "Combat";

    private void Start()
    {
        /* 如果使用同一个loading场景
         * if (SceneManager.GetActiveScene().buildIndex == 1)
         {
             sceneNum = 2;
         }*/
    }
    /// <summary>
    /// 开始游戏界面开始按钮 
    /// </summary>
    public void StartGame()
    {
        loadingScript.enabled = true;
    }
    public void BackToStartGame()
    {
        SceneManager.LoadSceneAsync(startGame);
    }
    public void NextToNewGame()
    {
        SceneManager.LoadSceneAsync(newGame);
    }
    public void BackToBookDesk()
    {
        SceneManager.LoadSceneAsync(bookDesk);
    }
    public void LoadingScript()
    {
        loadingScript.enabled = true;
    }
    /// <summary>
    /// 新游戏界面开始按钮 
    /// </summary>
    public void StartCombat()
    {
        //播放盖章动画
        gaiZhangAnim.gaizhang.SetBool("gaizhang", true);
        Invoke("LoadingScript", 4.6f);
    }
}
