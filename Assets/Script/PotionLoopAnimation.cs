using UnityEngine;
using UnityEngine.UI;

public class PotionLoopAnimation : MonoBehaviour
{
    private Image targetPotion;
    [SerializeField] private Sprite[] potionSequence;
    [SerializeField] private float transitionTime = 0.2f;
    private int currentFrame = 0;
    private float timer = 0f; 

    private void Start()
    {
        targetPotion = GetComponent<Image>(); 
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= transitionTime)
        {
            timer -= transitionTime;

            currentFrame = (currentFrame + 1) % potionSequence.Length; 
            targetPotion.sprite = potionSequence[currentFrame];
        }
    }
}
