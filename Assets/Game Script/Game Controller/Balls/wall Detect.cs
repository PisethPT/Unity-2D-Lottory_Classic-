using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDetect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tball1"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball2"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball3"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball4"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball5"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");       
        else if(collision.gameObject.CompareTag("Tball6"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball7"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball8"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball9"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");       
        else if(collision.gameObject.CompareTag("Tball10"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball11"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball12"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball13"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");       
        else if(collision.gameObject.CompareTag("Tball14"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball15"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball16"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball17"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");       
        else if(collision.gameObject.CompareTag("Tball18"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball19"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball20"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball21"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");       
        else if(collision.gameObject.CompareTag("Tball22"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball23"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball24"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
        else if(collision.gameObject.CompareTag("Tball25"))
            FindAnyObjectByType<AudioManage>().sfxPlay("walls");
    }

}
