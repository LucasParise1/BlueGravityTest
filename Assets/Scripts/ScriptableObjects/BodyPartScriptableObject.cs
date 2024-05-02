using UnityEngine;

[CreateAssetMenu(fileName = "BodyPart", menuName = "PlayerBodyPart")]
public class BodyPartScriptableObject : ScriptableObject
{
    public bool isPurchased;
    public int price;
    public Sprite buttonIcon;
    public Sprite[] partsSprites;
}
