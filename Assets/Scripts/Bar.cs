using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public GameObject perfectObject;
    public GameObject goodObject1;
    public GameObject goodObject2;
    public GameObject goodObject3;
    public GameObject komang;
    public Animator ulek;

    private bool isPerfectFrame = false;
    private bool isGoodFrame = false;
    public int point;

    void Start()
    {
        point = 0;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Deteksi klik kiri
        {
            if (isPerfectFrame)
            {
                Perfect();
            }
            else if (isGoodFrame)
            {
                Good();
            }
            else
            {
                Miss();
            }
        }

        if (point < 4)
        {
            switch (point)
            {
                case 1:
                    StartCoroutine(hit());
                    IEnumerator hit()
                    {
                        yield return new WaitForSeconds(1.4f);
                        komang.gameObject.SetActive(false);
                        goodObject1.SetActive(true);
                    }

                    break;
                case 2:
                    StartCoroutine(hit1());
                    IEnumerator hit1()
                    {
                        yield return new WaitForSeconds(1.4f);
                        komang.gameObject.SetActive(false);
                        goodObject1.SetActive(false);
                        goodObject2.SetActive(true);
                    }
                    break;
                case 3:
                    StartCoroutine(hit2());
                    IEnumerator hit2()
                    {
                        yield return new WaitForSeconds(1.4f);
                        komang.gameObject.SetActive(false);
                        goodObject1.SetActive(false);
                        goodObject2.SetActive(false);
                        goodObject3.SetActive(true);
                        this.gameObject.SetActive(false);
                    }
                    break;
            }
        }
        else
        {
            StartCoroutine(hit3());
            IEnumerator hit3()
            {
                yield return new WaitForSeconds(1.4f);
                komang.gameObject.SetActive(false);
                goodObject1.SetActive(false);
                goodObject2.SetActive(false);
                goodObject3.SetActive(true);
                perfectObject.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }


    }

    // Fungsi ini akan dipanggil di event animation untuk frame "Perfect"
    public void PerfectFrameStart()
    {
        isPerfectFrame = true;
    }

    public void PerfectFrameEnd()
    {
        isPerfectFrame = false;
    }

    // Fungsi ini akan dipanggil di event animation untuk frame "Good"
    public void GoodFrameStart()
    {
        isGoodFrame = true;
    }

    public void GoodFrameEnd()
    {
        isGoodFrame = false;
    }

    // Fungsi yang dipanggil jika timing klik pada frame "Perfect"
    public void Perfect()
    {
        Debug.Log("Perfect!");
        point += 3;
        ulek.SetTrigger("hit");
    }

    // Fungsi yang dipanggil jika timing klik pada frame "Good"
    public void Good()
    {
        Debug.Log("Good!");
        point += 1;
        ulek.SetTrigger("hit");
    }

    // Fungsi yang dipanggil jika timing klik tidak pada frame "Good" atau "Perfect"
    public void Miss()
    {
        Debug.Log("Miss!");
    }
}
