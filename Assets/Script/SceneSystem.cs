using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSystem : MonoBehaviour
{

    


    bool pause;

    [SerializeField] GameObject MenuPause;

    [SerializeField] Animator transitionAnim;

    

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

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

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

    public void Final()
    {
        StartCoroutine(ChangeFinal());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //RegalosRecogidos.SetText("Regalos totales recogidos: " + Regalos);


    }
    IEnumerator ChangeFinal()
    {
        transitionAnim.SetTrigger("exit");
        yield return new WaitForSeconds(10f);

    }

}
