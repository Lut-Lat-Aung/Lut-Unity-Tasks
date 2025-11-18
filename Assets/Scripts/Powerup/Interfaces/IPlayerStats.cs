public interface IPlayerStats
{
    float MoveSpeed { get; set; }
    float Damage { get; set; }
    float Shield { get; set; }

    void EquipTemporaryWeapon(Weapon newWeapon);
    void UnequipTemporaryWeapon();
}
