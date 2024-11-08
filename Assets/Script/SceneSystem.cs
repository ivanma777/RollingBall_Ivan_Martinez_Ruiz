using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSystem : MonoBehaviour
{

    bool pause;

    [SerializeField] GameObject MenuPause;
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

    public void Exit()
    {
        Application.Quit();

    }

    public void Pause()
    {
        if (pause )
        {
            Time.timeScale = 0f;
            MenuPause.SetActive(true);

        }

    } 
    public void Return()
    {
        if (!pause)
        {

            Time.timeScale = 1f;
            MenuPause.SetActive(false);   
        }

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {

            Pause();
            Return();
            if (pause)
            {
                pause = false;
            }
            else
            {

                pause = true;
            }
           
        }


    }


}
