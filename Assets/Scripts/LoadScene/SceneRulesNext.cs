using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRulesNext : MonoBehaviour
{
    [SerializeField] private Animation anim;
    public GameObject animka;
    private void Start()
    {
        anim.Play("RulesAnim");
        Invoke("Invoker1", 1f);
    }
    public void Go()
    {
        anim.Play("RulesAnim2");
        animka.gameObject.SetActive(true);

        Invoke("Invoker", 1f);
    }
    public void Invoker()
    {
        SceneManager.LoadScene(2);
    }
    public void Invoker1()
    {
        animka.gameObject.SetActive(false);
    }
}
