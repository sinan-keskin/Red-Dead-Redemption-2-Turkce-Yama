using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Red_Dead_Redemption_2_Türkçe_Yama
{
    public partial class Form2 : Form
    {
        private readonly string gamePath;
        private bool isInstalled;

        public Form2(string path)
        {
            InitializeComponent();
            gamePath = path;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Red Dead Redemption 2";

            if (!Directory.Exists(gamePath))
            {
                MessageBox.Show("Oyun klasörü bulunamadı.");
                Close();
                return;
            }

            UpdateButtonState();
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(gamePath))
            {
                MessageBox.Show("Oyun klasörü bulunamadı.");
                return;
            }

            if (isInstalled)
            {
                RemoveTranslation();
            }
            else
            {
                ApplyTranslation();
            }

            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            isInstalled = CheckIfInstalled();
            btnAction.Text = isInstalled ? "Orjinale Dön" : "Türkçe Yap";
        }

        private bool CheckIfInstalled()
        {
            try
            {
                byte[] zipBytes = Properties.Resources.RDR2CeviriZip;

                using (var ms = new MemoryStream(zipBytes))
                using (var archive = new ZipArchive(ms))
                {
                    foreach (var entry in archive.Entries)
                    {
                        string relPath = entry.FullName.Replace('/', Path.DirectorySeparatorChar);
                        string fullPath = Path.Combine(gamePath, relPath);

                        if (string.IsNullOrEmpty(entry.Name))
                        {
                            if (Directory.Exists(fullPath))
                                return true;
                        }
                        else
                        {
                            if (File.Exists(fullPath))
                                return true;
                        }
                    }
                }
            }
            catch
            {
            }

            return false;
        }

        private void ApplyTranslation()
        {
            try
            {
                string tempDir = ExtractZipToTemp(Properties.Resources.RDR2CeviriZip);

                CopyAll(new DirectoryInfo(tempDir), new DirectoryInfo(gamePath));

                try { Directory.Delete(tempDir, true); } catch { }

                MessageBox.Show("Oyununuz Türkçe Diline Çevirilmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Çeviri uygulanırken hata oluştu:\n" + ex.Message);
            }
        }

        private void RemoveTranslation()
        {
            try
            {
                string[] files = {
                    "dinput8.dll",
                    "fontfix.asi",
                    "rdr2-translator.asi",
                    "rdr2-translator.xml",
                    "ScriptHookRDR2.dll"
                };

                foreach (string file in files)
                {
                    string path = Path.Combine(gamePath, file);
                    if (File.Exists(path))
                        File.Delete(path);
                }

                string commonx = Path.Combine(gamePath, "commonx");
                if (Directory.Exists(commonx))
                    Directory.Delete(commonx, true);

                MessageBox.Show("Oyununuz Orjinal Diline Çevrilmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orijinale dönerken hata oluştu:\n" + ex.Message);
            }
        }

        private string ExtractZipToTemp(byte[] zipBytes)
        {
            string tempRoot = Path.Combine(Path.GetTempPath(), "RDR2Ceviri_" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(tempRoot);

            using (var ms = new MemoryStream(zipBytes))
            using (var archive = new ZipArchive(ms))
            {
                foreach (var entry in archive.Entries)
                {
                    string fullPath = Path.Combine(
                        tempRoot,
                        entry.FullName.Replace('/', Path.DirectorySeparatorChar)
                    );

                    if (string.IsNullOrEmpty(entry.Name))
                    {
                        Directory.CreateDirectory(fullPath);
                    }
                    else
                    {
                        string dir = Path.GetDirectoryName(fullPath);
                        if (!string.IsNullOrEmpty(dir))
                            Directory.CreateDirectory(dir);

                        using (var entryStream = entry.Open())
                        using (var fileStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            entryStream.CopyTo(fileStream);
                        }
                    }
                }
            }

            return tempRoot;
        }

        private void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            foreach (FileInfo fi in source.GetFiles())
            {
                string targetFilePath = Path.Combine(target.FullName, fi.Name);
                fi.CopyTo(targetFilePath, true);
            }

            foreach (DirectoryInfo di in source.GetDirectories())
            {
                string newDir = Path.Combine(target.FullName, di.Name);
                CopyAll(di, new DirectoryInfo(newDir));
            }
        }
    }
}
