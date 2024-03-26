using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public void nickNameSceneChage()
    {
        SceneManager.LoadScene("nickNameScene");
    }

    public void SampleSceneChage()
    {
        SceneManager.LoadScene("SampleScene");
    }
}