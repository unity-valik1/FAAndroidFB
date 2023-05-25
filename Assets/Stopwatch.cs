using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public string timerText;
    private float elapsedTime;
    private bool isRunning;

    void Start()
    {
        // ������������� ��������� �������� �����������
        elapsedTime = 0f;
        // ��� ������������� ����� ����� �������� ������ ����������� �������
        // timerText.text = elapsedTime.ToString("0.00");
        isRunning = false;
        StartTimer();
    }

    void Update()
    {
        if (isRunning)
        {
            // ����������� �������� ����������� �� �����, ��������� � ����������� �����
            elapsedTime += Time.deltaTime;
            // ��������� ��������� ���� �����������
            timerText = elapsedTime.ToString("0.00");
        }
    }

    public void StartTimer()
    {
        // ��������� ����������
        isRunning = true;
    }

    public void StopTimer()
    {
        // ������������� ����������
        isRunning = false;
    }

    public void ResetTimer()
    {
        // ���������� �������� ����������� � ������������� ���
        elapsedTime = 0f;
        isRunning = false;
        timerText = "0.00";
    }
}
