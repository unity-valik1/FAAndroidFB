using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    public void LoadNextScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Вышли!");
    }




    //public void SceneSave1()
    //{
    //    PlayerPrefs.SetInt("Save1", SceneManager.GetActiveScene().buildIndex);
    //}
    //public void SceneSave2()
    //{
    //    PlayerPrefs.SetInt("Save2", SceneManager.GetActiveScene().buildIndex);
    //}
    //public void SceneSave3()
    //{
    //    PlayerPrefs.SetInt("Save3", SceneManager.GetActiveScene().buildIndex);
    //}
    //public void SceneSave4()
    //{
    //    PlayerPrefs.SetInt("Save4", SceneManager.GetActiveScene().buildIndex);
    //}
    //public void SceneSave5()
    //{
    //    PlayerPrefs.SetInt("Save5", SceneManager.GetActiveScene().buildIndex);
    //}


    //public void SceneLoad1()
    //{
    //    SceneManager.LoadScene(PlayerPrefs.GetInt("Save1"));
    //}
    //public void SceneLoad2()
    //{
    //    SceneManager.LoadScene(PlayerPrefs.GetInt("Save2"));
    //}
    //public void SceneLoad3()
    //{
    //    SceneManager.LoadScene(PlayerPrefs.GetInt("Save3"));
    //}
    //public void SceneLoad4()
    //{
    //    SceneManager.LoadScene(PlayerPrefs.GetInt("Save4"));
    //}
    //public void SceneLoad5()
    //{
    //    SceneManager.LoadScene(PlayerPrefs.GetInt("Save5"));
    //}
}
