using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CookingGame : MonoBehaviour
{
    public GameObject final;
    public GameObject button;
    public List<GameObject> requiredIngredients; // Urutan bahan yang harus disusun
    public List<GameObject> feedbackObjects; // List objek untuk memberikan feedback visual
    private List<GameObject> placedIngredients = new List<GameObject>(); // Bahan yang ditempatkan oleh pemain

    void Start()
    {
        // Pastikan semua objek feedback tidak aktif di awal
        foreach (GameObject feedback in feedbackObjects)
        {
            feedback.SetActive(false);
        }
    }

    public void PlaceIngredient(GameObject ingredient)
    {
        if (placedIngredients.Count < requiredIngredients.Count)
        {
            // Cek apakah bahan yang ditempatkan sesuai urutan yang benar
            if (ingredient == requiredIngredients[placedIngredients.Count])
            {
                placedIngredients.Add(ingredient);
                Debug.Log("Bahan ditempatkan dengan benar!");

                // Aktifkan objek feedback yang sesuai dengan indeks saat ini
                if (placedIngredients.Count - 1 < feedbackObjects.Count)
                {
                    feedbackObjects[placedIngredients.Count - 1].SetActive(true);
                }

                // Cek jika semua bahan sudah ditempatkan dengan benar
                if (placedIngredients.Count == requiredIngredients.Count)
                {
                    Debug.Log("Semua bahan ditempatkan dengan benar! Masakan selesai!");
                    final.SetActive(true);
                    button.SetActive(true);
                    // Bisa menambahkan aksi lain di sini jika semua bahan benar
                }
            }
            else
            {
                Debug.Log("Urutan salah! Coba lagi.");
                ResetCooking();
            }
        }
    }

    public void ResetCooking()
    {
        // Nonaktifkan semua objek feedback dan ulang urutan
        foreach (GameObject feedback in feedbackObjects)
        {
            feedback.SetActive(false);
        }
        placedIngredients.Clear();
        Debug.Log("Resep diulang dari awal.");
        SceneManager.LoadScene("");
    }
}
