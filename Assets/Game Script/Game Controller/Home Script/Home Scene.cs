using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScene : MonoBehaviour
{
    float speed = 1000;
    [SerializeField] private float loadings;
    [SerializeField] private Transform loadingLogo;
    [SerializeField] private GameObject panel, loadingt;
    private bool isPlay;
    [SerializeField] private AudioSource[] clips;

    private void Start()
    {
        clips[0].Play();
    }
    private void Update()
    {
        Loading();
    }

    public void PlayGame()
    {
        clips[1].Play();
        isPlay = true;
        panel.SetActive(true);
        loadingt.SetActive(true);
        
    }

    void Loading()
    {
        if (isPlay)
        {
            loadingLogo.Rotate(0f, 0f, speed * Time.deltaTime);
            speed = (speed - loadings);
            if (speed<=0)
            {
                isPlay = false;
                panel.SetActive(false);
                loadingt.SetActive(false);
                SceneManager.LoadScene("Player Scene");
            }
        }
    }

    public void ApplicationQuit()
    {
        clips[1].Play();
        Application.Quit();
    }
}
