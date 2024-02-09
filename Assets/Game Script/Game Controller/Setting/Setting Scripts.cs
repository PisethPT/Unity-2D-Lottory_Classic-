using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScripts : MonoBehaviour
{
    public Animator settingAnimator;

    bool isOnClickSetting;
    public void Setting()
    {
        isOnClickSetting = !isOnClickSetting;
        if (isOnClickSetting)
        {
            FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
            settingAnimator.Play("settingOn");

        }

        else if (!isOnClickSetting)
        {
            FindFirstObjectByType<AudioManage>().sfxPlay("onClick");
            settingAnimator.Play("settingOff");
        }
    }
}
