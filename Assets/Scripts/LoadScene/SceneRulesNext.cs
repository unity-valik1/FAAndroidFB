using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRulesNext : MonoBehaviour
{
    [SerializeField] private Stopwatch stopwatch;
    [SerializeField] private Animation anim;
    public GameObject animka;
    public string timer3;
    private void Start()
    {
        anim.Play("RulesAnim");
        Invoke("Invoker1", 1f);
    }
    public void Go()
    {
        stopwatch.StopTimer();
        timer3 = stopwatch.timerText;
        FireBaseAnalyticsEvents.EventsOnboarding_3Button("Onboarding_3Button", timer3);
        stopwatch.ResetTimer();
        stopwatch.StartTimer();
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
