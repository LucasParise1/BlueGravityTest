using UnityEngine;

[CreateAssetMenu(fileName = "BodyPart", menuName = "PlayerBodyPart")]
public class BodyPartScriptableObject : ScriptableObject
{
    public bool isPurchased;
    public Color cardBackgroundColor;
    public Color cardColor;
    public int price;
    public Sprite[] partsSprites;
}
