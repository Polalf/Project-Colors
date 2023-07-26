using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] bool isPause;
    public GameObject menuPause;
    bool inPause;
    private void Start()
    {
        inPause = false;
    }
    void Update()
    {
        if (isPause)
        {
            menuPause.SetActive(inPause);
            if (inPause) Time.timeScale = 0;
            else Time.timeScale = 1;
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                inPause = !inPause;
            }
        }
    }
    public void CargarEscena(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void Quit()
    {
        #if UNITY_STANDALONE
                Application.Quit();
        #endif
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
