using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallsDetect : MonoBehaviour
{

    public int[] BallValues;
    public int state = 0;
    [SerializeField] public Text[] resultText;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("is Trigger collision");
        if (FindAnyObjectByType<GameManager>().state < FindAnyObjectByType<GameManager>().valueOfBallOpt && BallValues.Length <= FindAnyObjectByType<GameManager>().valueOfBallOpt)
        {
            if (collision.gameObject.CompareTag("Tball1"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[0].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;
                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[0].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());

                // Destroy(FindAnyObjectByType<GameManager>().BallsGroups[0].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball2"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[1].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;
                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[1].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[1].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball3"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                print("Balls Value: " + BallValues[state]);
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[2].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[2].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());

                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[2].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball4"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[3].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[3].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());

                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[3].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball5"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[4].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[4].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[4].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball6"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[5].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[5].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[5].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball7"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[6].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[6].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                // Destroy(FindAnyObjectByType<GameManager>().BallsGroups[6].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball8"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[7].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[7].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                // Destroy(FindAnyObjectByType<GameManager>().BallsGroups[7].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball9"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[8].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[8].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[8].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball10"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[9].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[9].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                // Destroy(FindAnyObjectByType<GameManager>().BallsGroups[9].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball11"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[10].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[10].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[10].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball12"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[11].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[11].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[11].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball13"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[12].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[12].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[12].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball14"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[13].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[13].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[13].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball15"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[14].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[14].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //   Destroy(FindAnyObjectByType<GameManager>().BallsGroups[14].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball16"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[15].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[15].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[16].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball17"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[16].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[16].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[16].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball18"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[17].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[17].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //   Destroy(FindAnyObjectByType<GameManager>().BallsGroups[17].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball19"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[18].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[18].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                //   Destroy(FindAnyObjectByType<GameManager>().BallsGroups[18].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball20"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[19].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[19].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[19].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball21"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[20].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[20].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                //  Destroy(FindAnyObjectByType<GameManager>().BallsGroups[20].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball22"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[21].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[21].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                //   Destroy(FindAnyObjectByType<GameManager>().BallsGroups[21].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball23"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[22].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[22].sprite.SetActive(false);
                }
                StartCoroutine(waitShow()); 
                //   Destroy(FindAnyObjectByType<GameManager>().BallsGroups[22].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball24"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[23].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[23].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                //    Destroy(FindAnyObjectByType<GameManager>().BallsGroups[23].sprite);
            }
            else
            if (collision.gameObject.CompareTag("Tball25"))
            {
                FindFirstObjectByType<AudioManage>().sfxPlay("detect");
                BallValues[state] = FindAnyObjectByType<GameManager>().BallsGroups[24].value;
                print("Balls Value: " + BallValues[state]);
                FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;

                IEnumerator waitShow()
                {
                    yield return new WaitForSecondsRealtime(1.5f);
                    FindAnyObjectByType<GameManager>().BallsGroups[24].sprite.SetActive(false);
                }
                StartCoroutine(waitShow());
                //    Destroy(FindAnyObjectByType<GameManager>().BallsGroups[24].sprite);
            }

            resultText[state].text = BallValues[state].ToString();
            state++;
            
        }
        else
            FindAnyObjectByType<GameManager>().Roud.GetComponent<BoxCollider2D>().isTrigger = false;
        print("State: " + state);
    }
    

}

