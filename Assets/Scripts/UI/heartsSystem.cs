using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class heartsSystem : MonoBehaviour
{
    /*** To keep the logic and visuals separate, we're doing the scripts separate
     * We're also creating hearts dynamically
    ***/

    [SerializeField] private Sprite heart0Sprite;
    [SerializeField] private Sprite heart1Sprite;
    [SerializeField] private Sprite heart2Sprite;
    [SerializeField] private Sprite heart3Sprite;
    [SerializeField] private Sprite heart4Sprite;

    private List<HeartImage> heartImageList;
    private playerHealth playerHealth;

    private void Awake()
    {
        heartImageList = new List<HeartImage>();
    }

    public void Start()
    {
        playerHealth playerHealth = new playerHealth(4);
        setPlayerHealth(playerHealth);
    }

    public void setPlayerHealth(playerHealth playerHealth)
    {
        this.playerHealth = playerHealth;

        List<playerHealth.Heart> heartList = playerHealth.getHeartsList();
        Vector2 heartAnchor = new Vector2(0, 0);

        for (int i = 0; i < heartList.Count; i++)
        {
            playerHealth.Heart heart = heartList[i];
            createHearts(heartAnchor).setHeartFragments(heart.getFragmentAmount());
            heartAnchor += new Vector2(75, 0);
        }

        playerHealth.onDamaged += playerHealth_onDamaged;
        playerHealth.onDead += playerHealth_onDead;
    }

    private void playerHealth_onDead(object sender, System.EventArgs e)
    {
        Debug.Log("Game Over");
    }

    private void playerHealth_onDamaged(object sender, System.EventArgs e)
    {
        // player health was damaged
        List<playerHealth.Heart> heartList = playerHealth.getHeartsList();

        for (int i = 0; i < heartImageList.Count; i++)
        {
            HeartImage heartImage = heartImageList[i];
            playerHealth.Heart heart = heartList[i];

            heartImage.setHeartFragments(heart.getFragmentAmount());
        }
    }

    private HeartImage createHearts(Vector2 anchored)
    {
        // creates object
        GameObject hearts = new GameObject("Heart", typeof(Image));

        // sets as child of transform
        hearts.transform.parent = transform;
        hearts.transform.localPosition = Vector3.zero;

        // locates and sizes heart
        hearts.GetComponent<RectTransform>().anchoredPosition = anchored;
        hearts.GetComponent<RectTransform>().sizeDelta = new Vector2(75, 75);

        // sets heart sprite
        Image heartImageUI = hearts.GetComponent<Image>();

        heartImageUI.sprite = heart4Sprite;

        HeartImage heartImage = new HeartImage(this, heartImageUI);

        heartImageList.Add(heartImage);

        return heartImage;
    }

    /**** Represents a single heart ****/
    public class HeartImage
    {
        private Image heartImage;
        private heartsSystem heartsSystem;

        public HeartImage(heartsSystem heartsSystem, Image heartImage)
        {
            this.heartsSystem = heartsSystem;
            this.heartImage = heartImage;
        }

        public void setHeartFragments(int fragments)
        {
            switch (fragments)
            {
                case 0:
                    heartImage.sprite = heartsSystem.heart0Sprite;
                    break;
                case 1:
                    heartImage.sprite = heartsSystem.heart1Sprite;
                    break;
                case 2:
                    heartImage.sprite = heartsSystem.heart2Sprite;
                    break;
                case 3:
                    heartImage.sprite = heartsSystem.heart3Sprite;
                    break;
                case 4:
                    heartImage.sprite = heartsSystem.heart4Sprite;
                    break;
            }
        }
    }
}
