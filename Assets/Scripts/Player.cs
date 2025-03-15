using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int coins;
    private int Health = 3;
    [SerializeField] TextMeshProUGUI textHeath;
    public Sprite heartSprite;
    public Transform heartsContainer;
    public Vector2 initialPosition = new Vector2(0, 0);  // ��������� �������

    private void Start()
    {
        UpdateUI();
    }
    
    public void TakeDamage()
    {
        Health--;
        if (Health <= 0)
        {
            SceneManager.LoadScene(2);
            Time.timeScale = 0;
        }
        UpdateUI();
    }

    private void UpdateUI()
    {

        foreach (Transform child in heartsContainer)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < Health; i++)
        {
            GameObject newHeart = new GameObject("Heart", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
            newHeart.transform.SetParent(heartsContainer);

            RectTransform rectTransform = newHeart.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = initialPosition + new Vector2(-i * 50, 0);  // ������ ������� ������� �� ��������� �������
            rectTransform.sizeDelta = new Vector2(40, 40);  // ����� �������

            Image heartImage = newHeart.GetComponent<Image>();
            heartImage.sprite = heartSprite;
        }
    }
}
