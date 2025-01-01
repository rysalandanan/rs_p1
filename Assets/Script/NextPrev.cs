using UnityEngine;

public class NextPrev : MonoBehaviour
{
    [SerializeField] private GameObject[] availablePotions;
    private int count = 0;

    public void NextPotion()
    {
        if (count < availablePotions.Length - 1) // Ensure count doesn't exceed array bounds
        {
            count++;
            EnableCurrentPotion();
        }
    }

    public void PrevPotion()
    {
        if (count > 0) // Ensure count doesn't go below 0
        {
            count--;
            EnableCurrentPotion();
        }
    }

    private void EnableCurrentPotion()
    {
        for (int i = 0; i < availablePotions.Length; i++)
        {
            availablePotions[i].SetActive(i == count); // Only enable the current potion
        }
    }
}
