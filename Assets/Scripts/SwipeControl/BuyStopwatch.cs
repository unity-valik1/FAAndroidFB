using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class BuyStopwatch : MonoBehaviour
{
    [SerializeField] private PageSwiperBuy pageSwiperBuy;
    public float elapsedTime;
    private bool isRunning;
    public int back = 0;
    public GameObject tPBuy;
    public GameObject close;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Палец только что коснулся экрана
                Debug.Log("Палец коснулся экрана.");
                isRunning = false;
                elapsedTime = 0f;
            }

            if (touch.phase == TouchPhase.Moved)
            {
                // Палец перемещается по экрану
                Debug.Log("Палец перемещается по экрану.");
                isRunning = false;
                elapsedTime = 0f;
            }

            if (touch.phase == TouchPhase.Ended)
            {
                // Палец перестал касаться экрана
                Debug.Log("Палец перестал касаться экрана.");
                isRunning = true;
            }
        }
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
        }
        if (elapsedTime > 6 && pageSwiperBuy.currentPage == 1)
        {
            print("Panel2");
            pageSwiperBuy.Panel2();
            elapsedTime = 0f;
        }
        if (elapsedTime > 6 && pageSwiperBuy.currentPage == 2 && back == 0)
        {
            print("Panel3");
            pageSwiperBuy.Panel2();
            elapsedTime = 0f;
            back = 1;
        }
        if (elapsedTime > 6 && pageSwiperBuy.currentPage == 3)
        {
            print("Panel3");
            pageSwiperBuy.PanelBack();
            elapsedTime = 0f;
        }
        if (elapsedTime > 6 && pageSwiperBuy.currentPage == 2 && back == 1)
        {
            print("Panel3");
            pageSwiperBuy.PanelBack();
            elapsedTime = 0f;
            back = 0;
        }
        if (pageSwiperBuy.currentPage == 3)
        {
            back = 1;
        }
        if (pageSwiperBuy.currentPage == 1)
        {
            back = 0;
        }
    }

    public void StartTimer()
    {
        //isRunning = true;
        Invoke("Invoker", 1f);
    }

    public void Invoker()
    {
        isRunning = true;
    }

    public void ResetTimer()
    {
        if (pageSwiperBuy.currentPage == 2)
        {
            pageSwiperBuy.PanelBackButton();
        }
        if (pageSwiperBuy.currentPage == 3)
        {
            pageSwiperBuy.PanelBackButton2();
        }
        // Сбрасываем значение секундомера и останавливаем его       
        isRunning = false;
        elapsedTime = 0f;
        pageSwiperBuy.currentPage = 1;
        back = 0;
        //tPBuy.transform.position = new Vector3(0, 0, 0);
        pageSwiperBuy.Invoker();
        close.gameObject.SetActive(false);
    }
}
