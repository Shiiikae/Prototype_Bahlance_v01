using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        Debug.Log("La scene suivante se lance");
        SceneManager.LoadScene("Game_v01");
    }

    public void QuitGame()
    {
        Debug.Log("Le jeu est quitter");
        Application.Quit();
    }
}
