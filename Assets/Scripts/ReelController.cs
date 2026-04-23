using UnityEngine;
using System.Collections;

public class ReelController : MonoBehaviour
{

    [Header("Setup")]
    public RectTransform[] symbols;
    public float symbolHeight = 100f;

    [Header("Spin Settings")]
    public float spinSpeed = 800f;
    public float spinDuration = 2f;
    public float stopSmoothTime = 0.25f;

    public bool isSpinning = false;
    private int targetIndex = 0;
    public int RandomNumber;


    public void StartSpin()
    {
        if (isSpinning) return;

        targetIndex = Random.Range(0, 3); // Ramdom
        RandomNumber = targetIndex;
        StartCoroutine(SpinRoutine());
    }

    IEnumerator SpinRoutine()
    {
        isSpinning = true;

        float timer = 0f;

        // 🔁 Spin phase
        while (timer < spinDuration)
        {
            MoveSymbols(spinSpeed);
            timer += Time.deltaTime;
            yield return null;
        }

        // 🛑 Smooth stop
        yield return StartCoroutine(SmoothStop());

        isSpinning = false;
    }

    void MoveSymbols(float speed)
    {
        foreach (var symbol in symbols)
        {
            symbol.anchoredPosition += Vector2.down * speed * Time.deltaTime;

            // Loop symbol to top
            if (symbol.anchoredPosition.y < -symbolHeight * (symbols.Length / 2))
            {
                float highestY = GetHighestY();
                symbol.anchoredPosition = new Vector2(
                    symbol.anchoredPosition.x,
                    highestY + symbolHeight
                );
            }
        }
    }

    float GetHighestY()
    {
        float highest = float.MinValue;

        foreach (var s in symbols)
        {
            if (s.anchoredPosition.y > highest)
                highest = s.anchoredPosition.y;
        }

        return highest;
    }

    IEnumerator SmoothStop()
    {
        RectTransform targetSymbol = symbols[targetIndex];

        float elapsed = 0f;
        float duration = stopSmoothTime;

        float startOffset = 0f;
        float endOffset = -targetSymbol.anchoredPosition.y;

        float previousOffset = 0f;

        while (elapsed < duration)
        {
            float t = elapsed / duration;
            float currentOffset = Mathf.Lerp(startOffset, endOffset, t);
            float delta = currentOffset - previousOffset;

            foreach (var symbol in symbols)
            {
                symbol.anchoredPosition += new Vector2(0, delta);
            }

            previousOffset = currentOffset;

            elapsed += Time.deltaTime;
            yield return null;
        }

        // Final correction
        float finalDelta = endOffset - previousOffset;

        foreach (var symbol in symbols)
        {
            symbol.anchoredPosition += new Vector2(0, finalDelta);
        }
    }
}