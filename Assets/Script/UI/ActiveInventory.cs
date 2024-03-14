using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveInventory : MonoBehaviour
{
        private int activeSlotIndexNum = 0;

    private PlayerController playerControls;
    [SerializeField] List<PlayerShoot> playerShoots;

    private void Awake() {
        playerControls = new PlayerController();
    }

    private void Start() {
        playerControls.Inventory.Keyboard.performed += ctx => ToggleActiveSlot((int)ctx.ReadValue<float>());
    }

    private void OnEnable() {
        playerControls.Enable();
    }

    private void ToggleActiveSlot(int numValue) {
        ToggleActiveHighlight(numValue - 1);
    }

    private void ToggleActiveHighlight(int indexNum) {
        activeSlotIndexNum = indexNum;

        foreach (Transform inventorySlot in this.transform)
        {
            inventorySlot.GetChild(0).gameObject.SetActive(false);
        }
        foreach(PlayerShoot playerShoot in playerShoots){
            playerShoot.enabled = false;
        }
        playerShoots[activeSlotIndexNum].enabled = true;
        this.transform.GetChild(indexNum).GetChild(0).gameObject.SetActive(true);
    }
}
