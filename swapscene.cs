using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swapscene : MonoBehaviour
{
    public void choisescene(int numb)
    {
        SceneManager.LoadScene(numb);
    }
}
