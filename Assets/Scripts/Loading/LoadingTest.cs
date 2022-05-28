using UnityEngine;
using UnityEngine.SceneManagement;
///<summary>
///加载场景测试（仅供开发测试使用）
///</summary>
class LoadingTest : MonoBehaviour
{
    public string sceneName;
    public GaiZhangAnim gaiZhangAnim;

    public void NextLayer()
    {        
        SceneManager.LoadSceneAsync(sceneName);
    }
    public void StartCombat()
    {
        //gaiZhangAnim.gaizhang.Play("GaiZhang");
        gaiZhangAnim.gaizhang.SetBool("gaizhang",true);
        Invoke("NextLayer", 2.8f);
    }
}
