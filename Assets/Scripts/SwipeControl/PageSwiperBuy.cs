using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PageSwiperBuy : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField] private BuyStopwatch buyStopwatch;
    public Vector3 panelLocation;
    public float percentThreshold = 0.2f;
    public float easing = 0.5f;
    public int totalPages = 1;
    public int currentPage = 1;
    public GameObject[] img;
    public GameObject notTab;

    // Start is called before the first frame update
    void Start()
    {
        panelLocation = transform.position;
    }
    public void OnDrag(PointerEventData data)
    {
        float difference = data.pressPosition.x - data.position.x;
        transform.position = panelLocation - new Vector3(difference, 0, 0);
        buyStopwatch.elapsedTime = 0f;
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
                FireBaseAnalyticsEvents.EventsOnboardingSwipeBuy("EventsOnboardingSwipeBuy");
            }
            else if (percentage < 0 && currentPage > 1)
            {
                currentPage--;
                newLocation += new Vector3(Screen.width, 0, 0);
                FireBaseAnalyticsEvents.EventsOnboardingSwipeBuy("EventsOnboardingSwipeBuy");
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

    public void Panel2()
    {
        notTab.gameObject.SetActive(true);
        Invoke("Invoker", 0.5f);
        panelLocation = transform.position;
        currentPage++;
        Vector3 newLocation = panelLocation;
        newLocation += new Vector3(-Screen.width, 0, 0);
        StartCoroutine(SmoothMove(transform.position, newLocation, easing));
        panelLocation = newLocation;
    }

    public void PanelBack()
    {
        notTab.gameObject.SetActive(true);
        Invoke("Invoker", 0.5f);
        panelLocation = transform.position;
        currentPage--;
        Vector3 newLocation = panelLocation;
        newLocation -= new Vector3(-Screen.width/**2*/, 0, 0);
        StartCoroutine(SmoothMove(transform.position, newLocation, easing));
        panelLocation = newLocation;
    }
    public void PanelBackButton()
    {
        panelLocation = transform.position;
        Vector3 newLocation = panelLocation;
        newLocation -= new Vector3(-Screen.width/**2*/, 0, 0);
        easing = 0.000001f;
        StartCoroutine(SmoothMove(transform.position, newLocation, easing));
        panelLocation = newLocation;
        easing = 0.5f;
    }
    public void PanelBackButton2()
    {
        panelLocation = transform.position;
        Vector3 newLocation = panelLocation;
        newLocation -= new Vector3(-Screen.width*2, 0, 0);
        easing = 0.000001f;
        StartCoroutine(SmoothMove(transform.position, newLocation, easing));
        panelLocation = newLocation;
        easing = 0.5f;
    }
    public void Invoker()
    {
        notTab.gameObject.SetActive(false);
    }
}
