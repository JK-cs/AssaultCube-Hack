using System.Diagnostics;
using ProcessMemoryReaderLib;

namespace AssaultCubeGameHack
{
    public partial class Form1 : Form
    {
        Process[] MyProcess; 
        ProcessMemoryReader mem = new ProcessMemoryReader();
        bool attach = false;
        bool healthHack = false;
        bool ammoHack = false;

        PlayerData mainPlayer;
        PlayerData enemyPlayer;
        Process attachProc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void PlayerDataBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("종료하시겠습니까?", "종료메시지", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Abort;
                Application.Exit();
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); //기존의 프로세스 목록 초기화
            MyProcess = Process.GetProcesses();

            for(int i=0; i<MyProcess.Length;i++)
            {
                string text = MyProcess[i].ProcessName + "-" + MyProcess[i].Id;
                comboBox1.Items.Add(text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try { 
            if (comboBox1.SelectedIndex != 1)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                int pid = int.Parse(selectedItem.Split('-')[selectedItem.Split('-').Length - 1]);
                attachProc = Process.GetProcessById(pid);


                mem.ReadProcess = attachProc;
                mem.OpenProcess();


                MessageBox.Show("프로세스 열기 성공! " + attachProc.ProcessName);
                    int base_ptr = attachProc.MainModule.BaseAddress.ToInt32() + 0x0017E0A8;
                    int player_base = mem.ReadInt(base_ptr);
                    attach = true;
            }
            }
            catch(Exception ex)
            {
                attach = false;
                MessageBox.Show("프로세스 열기 실패! " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(attach)
            {
                try
                {

                    if(healthHack)
                    {
                        mainPlayer.hackHealth(mem);
                    }

                    if (ammoHack)
                    {
                        mainPlayer.hackAmmo(mem);
                    }

                    int hotkey = ProcessMemoryReaderApi.GetKeyState(0x02);
                    if ((hotkey & 0x8000) != 0) // 키가 눌려있다면...
                    {
                        GetEnemyState(mem);

                        // aim hack algorithm
                        double distance = GetDistance(mainPlayer, enemyPlayer);
                        double x_angle = Get2DDegree(mainPlayer, enemyPlayer);
                        double y_angle = GetYDegree(mainPlayer, enemyPlayer);
                        mainPlayer.hackAim(mem, x_angle, y_angle);
                    }

                    mainPlayer.SetPlayerData(mem);
                    HealthLBL.Text = "Health: " + mainPlayer.health;
                    AmmoLBL.Text = "Ammo: " + mainPlayer.ammo;
                    BulletProofLBL.Text = "BulletProof: " + mainPlayer.bulletproof;
                    AngleLBL.Text = "Angle: " + mainPlayer.x_angle.ToString("#.##") + " | " + mainPlayer.y_angle.ToString("#.##");
                    PositionLBL.Text = "Position: " + mainPlayer.x_pos.ToString("#.##") + ", " + mainPlayer.y_pos.ToString("#.##") + ", " + mainPlayer.z_pos.ToString("#.##");
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void GetEnemyState(ProcessMemoryReader mem)
        {
            int base_ptr = attachProc.MainModule.BaseAddress.ToInt32() + 0x0017E0A8;
            int[] offsetArray = { 0, 0 };
            int player_base = mem.ReadMultiLevelPointer(base_ptr, 4, offsetArray);
            enemyPlayer = new PlayerData(player_base);




        }

        private void HealthBT_Click(object sender, EventArgs e)
        {

            if(healthHack)
            {
                healthHack = false;
                HealthHLBL.Text = "동작안함";
            }
            else
            {
                healthHack = true;
                HealthHLBL.Text = "동작 중";
            }

        }

        private void AmmoBT_Click(object sender, EventArgs e)
        {
            if (ammoHack)
            {
                ammoHack = false;
                AmmoHLBL.Text = "동작안함";
            }
            else
            {
                ammoHack = true;
                AmmoHLBL.Text = "동작 중";
            }
        }
    }
}