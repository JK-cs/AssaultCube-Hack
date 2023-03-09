using ProcessMemoryReaderLib;
using System.Diagnostics;

namespace AssaultCubeGameHack
{
    internal class PlayerData
    {
        int base_addr; //"ac_client.exe"+0017E0A8
        int health_offset = 0xEC;
        int bulletproof_offset = 0xF0;
        int ammo_offset = 0x140;
        int x_pos_offset = 0x28;
        int z_pos_offset = 0x2C;
        int y_pos_offset = 0x30;
        int x_angle_offset = 0x34;
        int y_angle_offset = 0x38;



        public int health;
        public int bulletproof;
        public int ammo;
        public float x_pos;
        public float z_pos;
        public float y_pos;
        public float x_angle;
        public float y_angle;

        public PlayerData(int player_base)
        {
            //mainPlayer 또는 적 플레이어 구조체의 위치
            base_addr = player_base;

            health = 0;
            bulletproof = 0;
            ammo = 0;
            x_pos = 0;
            z_pos = 0;
            y_pos = 0;
            x_angle = 0;
            y_angle = 0;
    }

        internal void SetPlayerData(ProcessMemoryReader mem)
        {
            health = mem.ReadInt(base_addr + health_offset);
            bulletproof = mem.ReadInt(base_addr + bulletproof_offset);
            ammo = mem.ReadInt(base_addr + ammo_offset);
            x_pos = mem.ReadFloat(base_addr + x_pos_offset);
            z_pos = mem.ReadFloat(base_addr + z_pos_offset);
            y_pos = mem.ReadFloat(base_addr + y_pos_offset);
            x_angle = mem.ReadFloat(base_addr + x_angle_offset);
            y_angle = mem.ReadFloat(base_addr + y_angle_offset);
        }

        internal void hackHealth(ProcessMemoryReader mem)
        {
            mem.WriteInt(base_addr + health_offset, 1000);
        }

        internal void hackAmmo(ProcessMemoryReader mem)
        {
            mem.WriteInt(base_addr + ammo_offset, 1000);
        }

        internal void hackAim(ProcessMemoryReader mem, double x_angle, double y_angle)
        {
            mem.WriteFloat(base_addr + ammo_offset, 1000);
            mem.WriteFloat(base_addr + ammo_offset, 1000);
        }
    }
}