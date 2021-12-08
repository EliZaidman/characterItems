using UnityEngine;

public class PlayerOutfit : MonoBehaviour
{
	public SpriteRenderer hatRenderer;
	public SpriteRenderer shirtRenderer;
	public SpriteRenderer pantRenderer;
	public SpriteRenderer shoesRenderer;
	public SpriteRenderer weaponRenderer;


	public void PutClothesOnModel(OutfitType _type, Sprite _sprite)
	{
		switch (_type)
		{
			case OutfitType.hat:
				hatRenderer.sprite = _sprite;
				break;
			case OutfitType.shirt:
				shirtRenderer.sprite = _sprite;
				break;
			case OutfitType.pants:
				pantRenderer.sprite = _sprite;
				break;
			case OutfitType.shoes:
				shoesRenderer.sprite = _sprite;
				break;
			case OutfitType.weapon:
				weaponRenderer.sprite = _sprite;
				break;
		}
	}
	public void UnClothTheModel(OutfitType _type)
	{
		switch (_type)
		{
			case OutfitType.hat:
				hatRenderer.sprite = null;
				break;
			case OutfitType.shirt:
				shirtRenderer.sprite = null;
				break;
			case OutfitType.pants:
				pantRenderer.sprite = null;
				break;
			case OutfitType.shoes:
				shoesRenderer.sprite = null;
				break;
			case OutfitType.weapon:
				weaponRenderer.sprite = null;
				break;
		}
	}

	public void MakeTheModelNude()
	{
		hatRenderer.sprite = null;
		shirtRenderer.sprite = null;
		pantRenderer.sprite = null;
		shoesRenderer.sprite = null;
		weaponRenderer.sprite = null;
	}

}


public enum OutfitType
{
	hat,
	shirt,
	pants,
	shoes,
	weapon
}