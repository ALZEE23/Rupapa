using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sliceable : MonoBehaviour
{
    public GameObject potongan;
    public GameObject lanjut;
    public GameObject pisau;
    public bool isSirip = false;
    public GameObject sirip;
    public GameObject kosong;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("blade"))
        {
            Debug.Log("acumala");
            pisau.transform.rotation = this.transform.rotation;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("blade"))
        {
            lanjut.gameObject.SetActive(true);
            potongan.gameObject.SetActive(true);
            if (isSirip == true)
            {
                sirip.gameObject.SetActive(false);
            }
            if (kosong == true){
                kosong.gameObject.SetActive(false);
            }
            this.gameObject.SetActive(false);
        }

    }

}
