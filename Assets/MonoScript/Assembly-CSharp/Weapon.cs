using UnityEngine;

public class Weapon : MonoBehaviour
{
	[Header("Weapon settings")]
	public int damage;

	public float useInterval;

	protected bool canUse = true;

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
		if (!GameManager.IsInMenu && Input.GetMouseButton(0) && canUse)
		{
			PlayerItemManager.IsBusy = true;
			PlayerAnimator.SetAnimation(PlayerAnimation.Trigger_SpearHit);
			canUse = false;
			Invoke("ResetCanUse", useInterval);
		}
	}

	protected virtual void OnWeaponUse()
	{
	}

	private void ResetCanUse()
	{
		canUse = true;
		PlayerItemManager.IsBusy = false;
	}
}
