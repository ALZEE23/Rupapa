using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coet : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator bawangMerah;
    public Animator bawangPutih;
    public Animator kemiri;
    public Animator rawon;
    public GameObject hasil;
    public GameObject button;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.CompareTag("bawangMerah")) {
        //    bawangMerah.SetBool("nyala",true);
        //}

        //if (collision.CompareTag("bawangPutih"))
        //{
        //    bawangMerah.SetBool("nyala", true);
        //}

        //if (collision.CompareTag("kemiri"))
        //{
        //    bawangMerah.SetBool("nyala", true);
        //}

        //if (collision.CompareTag("rawon"))
        //{
        //    bawangMerah.SetBool("nyala", true);
        //}

        if (collision.CompareTag("ulek"))
        {
            StartCoroutine(delay());
            IEnumerator delay()
            {
                yield return new WaitForSeconds(4.5f);
                hasil.gameObject.SetActive(true);
                button.gameObject.SetActive(true);
            }
        }
    }
}
