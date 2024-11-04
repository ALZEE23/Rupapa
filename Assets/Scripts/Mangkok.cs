using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Mangkok : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator klomang;
    public Animator cangkang;

    public GameObject sebelumJatoh;
    public GameObject cangkangKlomang;
    public GameObject kluwek;
    public GameObject kluwek1;
    public GameObject kluwek2;
    public GameObject kluwek3;

    public int button;
    public GameObject buttonUi;

    private void Update()
    {
        if(button == 4)
        {
            buttonUi.gameObject.SetActive(true);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("klomang"))
        {
            button += 1;
            sebelumJatoh.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
            kluwek.gameObject.SetActive(true);
            cangkangKlomang.SetActive(false);
            StartCoroutine(delay());
            IEnumerator delay()
            {
                yield return new WaitForSeconds(1.3f);
                sebelumJatoh.gameObject.SetActive(false);
            }
        }

        if (other.CompareTag("klomang2"))
        {
            button += 1;
            sebelumJatoh.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
            kluwek1.gameObject.SetActive(true);
            cangkangKlomang.SetActive(false);
            StartCoroutine(delay());
            IEnumerator delay()
            {
                yield return new WaitForSeconds(1.3f);
                sebelumJatoh.gameObject.SetActive(false);
            }
        }

        if (other.CompareTag("klomang3"))
        {
            button += 1;
            sebelumJatoh.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
            kluwek2.gameObject.SetActive(true);
            cangkangKlomang.SetActive(false);
            StartCoroutine(delay());
            IEnumerator delay()
            {
                yield return new WaitForSeconds(1.3f);
                sebelumJatoh.gameObject.SetActive(false);
            }
        }

        if (other.CompareTag("klomang4"))
        {
            button += 1;
            sebelumJatoh.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
            kluwek3.gameObject.SetActive(true);
            cangkangKlomang.SetActive(false);
            StartCoroutine(delay());
            IEnumerator delay()
            {
                yield return new WaitForSeconds(1.3f);
                sebelumJatoh.gameObject.SetActive(false);
            }
        }
    }
}
