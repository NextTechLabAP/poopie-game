using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTONS : MonoBehaviour
{

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void level01()
    {
        SceneManager.LoadScene("level01");

    }

}
