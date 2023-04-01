using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectReset : MonoBehaviour
{
    private ScrollRect scrollRect;

    private void Awake()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    private void OnLevelWasLoaded(int level)
    {
        // Reset the scroll rect properties
        scrollRect.viewport = transform.Find("Viewport").GetComponent<RectTransform>();
        scrollRect.content = transform.Find("Viewport/Content").GetComponent<RectTransform>();
    }
}

