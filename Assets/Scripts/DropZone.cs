using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZone : MonoBehaviour
{
    public CookingGame cookingGame;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Pastikan hanya mendeteksi objek yang bisa di-drop (misalnya berdasarkan tag)
        if (other.CompareTag("Ingredient"))
        {
            Debug.Log("Ingredient dropped in the pan!");
            cookingGame.PlaceIngredient(other.gameObject);
            other.gameObject.SetActive(false);
        }
    }
}
