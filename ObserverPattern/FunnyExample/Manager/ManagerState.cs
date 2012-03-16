namespace FunnyExample.Manager
{
    using System;

    public class ManagerState
    {
        public ManagerState()
        {
            this.IsInRoom = false;
        }

        public ManagerState(bool isInRoom)
        {
            this.IsInRoom = isInRoom;
        }

        public bool IsInRoom { get; set; }
    }
}
