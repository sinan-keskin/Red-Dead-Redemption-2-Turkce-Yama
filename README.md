<p align="center">
  <img src="https://raw.githubusercontent.com/sinan-keskin/REPO/main/icon.png" width="120">
</p>

<h1 align="center">🎮 Red Dead Redemption 2 Türkçe Yama Aracı</h1>
<p align="center">Red Dead Redemption 2 için otomatik Türkçe yama kurup kaldırma uygulaması</p>

---

<p align="center">
  <img src="https://img.shields.io/badge/C%23-WinForms-239120?style=for-the-badge&logo=csharp&logoColor=white">&nbsp;
  <img src="https://img.shields.io/badge/RDR2-Turkish%20Patch-red?style=for-the-badge">&nbsp;
  <img src="https://img.shields.io/github/license/sinan-keskin/REPO?style=for-the-badge">&nbsp;
  <img src="https://img.shields.io/github/stars/sinan-keskin/REPO?style=for-the-badge">
</p>

---

## 📌 Özellikler

- ✔ **Gömülü ZIP** içindeki çeviriyi otomatik kurar  
- ✔ Kurulu dosyaları algılar → buton **Türkçe Yap / Orjinale Dön** olarak değişir  
- ✔ Oyun klasörünü **RDR2.exe seçimiyle** otomatik belirler  
- ✔ Kurulum ve kaldırma tamamen otomatik  
- ✔ Yama dosyalarını oyun klasörüne güvenli şekilde kopyalar  
- ✔ Yedek gerektirmez, orijinal dosyaları doğru şekilde temizler  
- ✔ Windows Registry’ye kayıt ederek oyun yolunu hatırlar
  
---

---

## 🚀 Kurulum ve Kullanım

1. Programı çalıştırın  
2. İlk açılışta **RDR2.exe** dosyasını seçin  
3. Uygulama çevirinin yüklü olup olmadığını algılar  
4. Duruma göre:
   - **Türkçe Yap**
   - **Orjinale Dön**
5. Hepsi tek butonla yapılır 🎉  

---

## 📂 Proje Yapısı (Şema)

```yaml
📁 RedDeadR2-TurkceYamaAraci
├── 📄 Program.cs
├── 📄 Form1.cs → Exe seçim ekranı
├── 📄 Form2.cs → Tek butonlu yama paneli
├── 📁 Properties
│ └── RDR2CeviriZip.zip (Gömülü kaynak)
└── 📄 README.md
```


---

## 🛠 Teknik

- **Dil:** C#  
- **Arayüz:** WinForms  
- **ZIP İşleme:** ZipArchive (internal)  
- **Config:** Windows Registry  
- **Hedef:** .NET Framework / .NET 6 uyumlu  

---

## 📜 Lisans

Bu proje **MIT lisansı** ile lisanslanmıştır.  
İsteyen herkes geliştirebilir, dağıtabilir ve değiştirebilir.

---

<p align="center">⭐ Beğendiyseniz projeyi yıldızlamayı unutmayın!</p>
