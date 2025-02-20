using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance = null;

    [SerializeField] private Text muskratText;

    public int muskRatCount = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(instance != null)
        {
            Debug.LogError("Another instance of ui controller detected");

            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void IterateMuskratCount(int change)
    {
        muskRatCount += change;

        muskratText.text = "Muskrats alive: " + muskRatCount.ToString();
    }
}
