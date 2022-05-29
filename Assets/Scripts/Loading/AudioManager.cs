using UnityEngine;
using UnityEngine.SceneManagement;

///<summary>
///“Ù–ßπ‹¿Ì∆˜
///</summary>
class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public string currentScene;

    private void Start()
    {
        DontDestroyOnLoad(audioSource);
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == currentScene)
        {
            Destroy(audioSource);
        }
    }
}
