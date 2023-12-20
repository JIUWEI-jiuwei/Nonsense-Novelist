using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera camera;

    private float count;
    private float nowSize;
    private void Awake()
    {
        camera = GetComponent<Camera>();
        
    }
    bool pausing = false;
    public void SetCameraSizeTo(float _size)
    {

        print("SetCameraSizeTo");
        camera = GetComponent<Camera>();
        nowSize = _size;

        if (Time.timeScale == 0)
        {
            pausing = true;
        }


        if (Mathf.Abs(_size- camera.orthographicSize ) > 0.001f)
        {
            StopAllCoroutines();
            count =_size -camera.orthographicSize  ;
            StartCoroutine(ChangeCameraSize());
        }
    }
    IEnumerator ChangeCameraSize()
    {
      if(pausing)Time.timeScale = 1f;
        print("ChangeCameraSize");
        while (Mathf.Abs(camera.orthographicSize - nowSize) > 0.001f)
        { 
            yield return new WaitForFixedUpdate();
    
            camera.orthographicSize += (count) * 0.02f; 
            //count = camera.orthographicSize - nowSize;
        }
        if (pausing)
        {
            Time.timeScale = 0f;
            pausing = false;
        }
      
    }
}
