using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortaMenu : MonoBehaviour
{
    // Nome da cena do menu principal
    public string nomeMenu = "SampleScene";

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            SceneManager.LoadScene(nomeMenu);
        }
    }
}
