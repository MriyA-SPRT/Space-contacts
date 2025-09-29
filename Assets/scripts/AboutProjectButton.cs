using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutProjectButton : MonoBehaviour
{
    public void onClickStart()
    {
        SceneManager.LoadScene("AboutGame", LoadSceneMode.Additive);
    }
}
