using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace Red_Dead_Redemption_2_Türkçe_Yama
{
    public partial class Form1 : Form
    {
        private const string REG_PATH = @"Software\RDR2CeviriAraci";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Lütfen RDR2.exe dosyasını seçin.";
        }


        private void btnSelectExe_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "RDR2.exe dosyasını seçin";
                ofd.Filter = "RDR2 Çalıştırılabilir|RDR2.exe|Tüm Dosyalar|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!ofd.FileName.EndsWith("RDR2.exe", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Lütfen doğru dosyayı seçin (RDR2.exe)");
                        return;
                    }

                    string gamePath = Path.GetDirectoryName(ofd.FileName);

                    SaveGamePath(gamePath);

                    var f2 = new Form2(gamePath);
                    f2.StartPosition = FormStartPosition.CenterScreen;
                    f2.Show();

                    this.Close();
                }
            }
        }

        private void SaveGamePath(string path)
        {
            var key = Registry.CurrentUser.CreateSubKey(REG_PATH);
            key.SetValue("GamePath", path);
            key.Close();
        }
    }
}
