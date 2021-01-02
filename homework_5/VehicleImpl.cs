namespace homework_5
{
    class VehicleImpl : ITank, IShip
    {
        string ITank.Move()
        {
           return "Tank goes";
        }

        string IShip.Move()
        {
            return "Ship sails";
        }
    }
}
