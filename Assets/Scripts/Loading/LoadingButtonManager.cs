using UnityEngine.SceneManagement;
using UnityEngine;

///<summary>
///ȫ����ת���水ťManager
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
        /* ���ʹ��ͬһ��loading����
         * if (SceneManager.GetActiveScene().buildIndex == 1)
         {
             sceneNum = 2;
         }*/
    }
    /// <summary>
    /// ��ʼ��Ϸ���濪ʼ��ť 
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
    /// ����Ϸ���濪ʼ��ť 
    /// </summary>
    public void StartCombat()
    {
        //���Ÿ��¶���
        gaiZhangAnim.gaizhang.SetBool("gaizhang", true);
        Invoke("LoadingScript", 4.6f);
    }
}