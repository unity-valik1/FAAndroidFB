using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public string timerText;
    private float elapsedTime;
    private bool isRunning;

    void Start()
    {
        // Устанавливаем начальное значение секундомера
        elapsedTime = 0f;
        // При необходимости можно также изменить формат отображения времени
        // timerText.text = elapsedTime.ToString("0.00");
        isRunning = false;
        StartTimer();
    }

    void Update()
    {
        if (isRunning)
        {
            // Увеличиваем значение секундомера на время, прошедшее с предыдущего кадра
            elapsedTime += Time.deltaTime;
            // Обновляем текстовое поле секундомера
            timerText = elapsedTime.ToString("0.00");
        }
    }

    public void StartTimer()
    {
        // Запускаем секундомер
        isRunning = true;
    }

    public void StopTimer()
    {
        // Останавливаем секундомер
        isRunning = false;
    }

    public void ResetTimer()
    {
        // Сбрасываем значение секундомера и останавливаем его
        elapsedTime = 0f;
        isRunning = false;
        timerText = "0.00";
    }
}
