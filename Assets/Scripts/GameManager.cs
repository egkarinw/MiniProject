using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public InventoryPanel inventoryPanel;

    public void OpenInventoryPanel()
    {
        inventoryPanel.gameObject.SetActive(true);
        inventoryPanel.OnOpen();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }

    public void CloseInventoryPanel()
    {
        inventoryPanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1.0f;

    }

    public float timeConter = 30f;
    public ItemData targetItem;
    public int targetAmount = 2;

    public TMP_Text timeCounterText;
    public Image targetItemIcon;
    public TMP_Text targetCurrentAmountText;

    private void Start()
    {
        targetItemIcon.sprite = targetItem.Sprite;
    }

    void Update()
    {
        if (timeConter > 0f)
        {
            timeConter -= Time.deltaTime;
            timeCounterText.text = timeConter.ToString();
            targetCurrentAmountText.text = (targetAmount-InventoryManager.instance.GetItemAmount(targetItem)).ToString();

            if (InventoryManager.instance.GetItemAmount(targetItem) >= targetAmount)
            {
                Debug.Log("Player Win !!");
            }    
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }


}
