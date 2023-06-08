using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PageSwiper : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField] private Stopwatch stopwatch;

    private Vector3 panelLocation;
    public float percentThreshold = 0.2f;
    public float easing = 0.5f;
    public int totalPages = 1;
    public int currentPage = 1;
    public GameObject[] img;
    public GameObject notTab;
    public string timer1;
    public string timer2;

    // Start is called before the first frame update
    void Start()
    {
        panelLocation = transform.position;
    }
    public void OnDrag(PointerEventData data)
    {
        float difference = data.pressPosition.x - data.position.x;
        transform.position = panelLocation - new Vector3(difference, 0, 0);
    }
    public void OnEndDrag(PointerEventData data)
    {
        float percentage = (data.pressPosition.x - data.position.x) / Screen.width;
        if (Mathf.Abs(percentage) >= percentThreshold)
        {
            Vector3 newLocation = panelLocation;
            if (percentage > 0 && currentPage < totalPages)
            {
                currentPage++;
                newLocation += new Vector3(-Screen.width, 0, 0);
                FireBaseAnalyticsEvents.EventsOnboarding_Swipe("Onboarding_Swipe");
            }
            else if (percentage < 0 && currentPage > 1)
            {
                currentPage--;
                newLocation += new Vector3(Screen.width, 0, 0);
                FireBaseAnalyticsEvents.EventsOnboarding_Swipe("Onboarding_Swipe");
            }
            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            panelLocation = newLocation;
        }
        else
        {
            StartCoroutine(SmoothMove(transform.position, panelLocation, easing));
        }
    }
    IEnumerator SmoothMove(Vector3 startpos, Vector3 endpos, float seconds)
    {
        float t = 0f;
        while (t <= 1.0)
        {
            t += Time.deltaTime / seconds;
            transform.position = Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0f, 1f, t));
            notTab.gameObject.SetActive(true);
            yield return null;
        }
        notTab.gameObject.SetActive(false);
    }

    void Update()
    {
        if (currentPage == 1)
        {
            for (int i = 0; i < img.Length; ++i)
            {
                img[i].gameObject.SetActive(false);
                img[0].gameObject.SetActive(true);
            }
        }
        else if (currentPage == 2)
        {
            for (int i = 0; i < img.Length; ++i)
            {
                img[i].gameObject.SetActive(false);
                img[1].gameObject.SetActive(true);
            }
        }
        else if (currentPage == 3)
        {
            for (int i = 0; i < img.Length; ++i)
            {
                img[i].gameObject.SetActive(false);
                img[2].gameObject.SetActive(true);
            }
        }
    }

    public void Panel1()
    {
        stopwatch.StopTimer();
        timer1 = stopwatch.timerText;
        FireBaseAnalyticsEvents.EventsOnboarding_1Button("Onboarding_1Button", timer1);
        stopwatch.ResetTimer();
        stopwatch.StartTimer();
        notTab.gameObject.SetActive(true);
        Invoke("Invoker", 0.5f);
        panelLocation = transform.position;
        currentPage++;
        Vector3 newLocation = panelLocation;
        newLocation += new Vector3(-Screen.width, 0, 0);
        StartCoroutine(SmoothMove(transform.position, newLocation, easing));
        panelLocation = newLocation;
    }
    public void Panel2()
    {
        timer2 = stopwatch.timerText;
        FireBaseAnalyticsEvents.EventsOnboarding_2Button("Onboarding_2Button", timer2);
        stopwatch.ResetTimer();
        stopwatch.StartTimer();
        notTab.gameObject.SetActive(true);
        Invoke("Invoker", 0.5f);
        panelLocation = transform.position;
        currentPage++;
        Vector3 newLocation = panelLocation;
        newLocation += new Vector3(-Screen.width, 0, 0);
        StartCoroutine(SmoothMove(transform.position, newLocation, easing));
        panelLocation = newLocation;
    }
    public void Invoker()
    {
        notTab.gameObject.SetActive(false);
    }
}
