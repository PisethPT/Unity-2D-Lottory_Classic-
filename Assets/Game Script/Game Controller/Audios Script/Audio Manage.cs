using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AudioManage : MonoBehaviour
{
    private bool musicIsTrue, sfxIsTrue;
    [SerializeField] public AudioSources[] music, sfxsound;
    [SerializeField] public Button musicBtn, sfxBtn;
    [SerializeField] public AudioSource audioSources, sfxSources;
    [SerializeField] public Sprite[] btnSprites;
    private AudioManage instran;
    [SerializeField] private Animator a;

    private void Awake()
    {
        if (instran == null)
        {
            instran = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void musicPlay(string SourceName)
    {
        AudioSources SD = Array.Find(music, m => m.AudioNames == SourceName);
        if (SD​.Equals(null)) print("not found");
        else
        {

            audioSources.clip = SD.AudioClips;
            audioSources.Play();
        }
    }
   
    public void TGGBackgroundMusic()
    {
        musicIsTrue = !musicIsTrue;
        if (musicIsTrue)
        {
            FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
            musicBtn.image.sprite = btnSprites[0];
            audioSources.mute = true;
            a.Play("settingOff");
        }
        else if(!musicIsTrue)
        {
            FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
            musicBtn.image.sprite = btnSprites[1];
            audioSources.mute = false;
            a.Play("settingOff");
        }
    }

    public void sfxPlay(string SourceName)
    {
        AudioSources SD = Array.Find(sfxsound, s => s.AudioNames == SourceName);
        if (SD.Equals(null)) print("sfx not found sound");
        else sfxSources.PlayOneShot(SD.AudioClips);
    }

    public void TGGSfxSound()
    {
        sfxIsTrue = !sfxIsTrue;
        if (sfxIsTrue)
        {
            FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
            sfxBtn.image.sprite = btnSprites[2];
            sfxSources.mute = true;
            a.Play("settingOff");
        }
        else if(!sfxIsTrue)
        {
            FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
            sfxBtn.image.sprite = btnSprites[3];
            sfxSources.mute = false;
            a.Play("settingOff");
        }
    }

}
