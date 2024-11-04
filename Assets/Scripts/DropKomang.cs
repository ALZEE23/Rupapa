using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class DropKomang : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator klomang;
    public GameObject klomangObject;
    public Bar bar;

    public GameObject cangkangKlomang;
    public GameObject cangkangKlomang2;
    public GameObject cangkangKlomang3;
    public GameObject cangkangKlomang4;
    public GameObject cangkangKlomang5;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("klomangMentah"))
        {
            bar.point = 0;
            bar.gameObject.SetActive(true);


            klomangObject.SetActive(true);
            cangkangKlomang.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("klomangMentah1"))
        {
            bar.point = 0;
            bar.gameObject.SetActive(true);


            klomangObject.SetActive(true);
            cangkangKlomang2.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("klomangMentah2"))
        {
            bar.point = 0;
            bar.gameObject.SetActive(true);

            klomangObject.SetActive(true);
            cangkangKlomang3.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
        }

        if (other.CompareTag("klomangMentah3"))
        {
            bar.point = 0;
            bar.gameObject.SetActive(true);

            klomangObject.SetActive(true);
            cangkangKlomang4.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
