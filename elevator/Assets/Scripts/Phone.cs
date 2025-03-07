using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Phone : MonoBehaviour
{

    bool phoneEquipped = false;
    PlayerMovement movementScript;

    private void Awake()
    {
        movementScript = FindFirstObjectByType<PlayerMovement>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnPhone()
    {
        GetComponentInChildren<MeshRenderer>(true).gameObject.SetActive(!phoneEquipped);
        phoneEquipped = !phoneEquipped;

        if (phoneEquipped)
        {
            EventSystem.current.SetSelectedGameObject(GetComponentInChildren<Scrollbar>(true).gameObject);
            movementScript.enabled = false;
        }
        else
        {
            EventSystem.current.SetSelectedGameObject(null);
            movementScript.enabled=true;
        }


    }

}
