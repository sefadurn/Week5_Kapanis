# 🚗 Araba Üretim ve Listeleme Uygulaması

Bu C# konsol uygulaması, kullanıcıdan veri alarak `Araba` nesneleri üretir ve üretilen arabaları bir listeye kaydeder. Kullanıcı, her bir araba için seri no, marka, model, renk ve kapı sayısı gibi bilgileri girerek dilediği kadar araba ekleyebilir. Program sonunda tüm eklenen arabalar listelenir.

---

## 📦 Sınıf: `Araba`

| Özellik (Property) | Açıklama |
|---------------------|----------|
| `DateTime UretimTarihi` | Arabanın üretim zamanı (varsayılan olarak `DateTime.Now`) |
| `string SeriNo`         | Arabanın seri numarası |
| `string Marka`          | Marka bilgisi |
| `string Model`          | Model bilgisi |
| `string Renk`           | Renk bilgisi |
| `int KapiSayisi`        | Kapı sayısı |

> Araba sınıfı içerisinde, kurucu metot (`constructor`) ile üretim tarihi otomatik atanır.

---

## 🔁 Uygulama Akışı

1. Kullanıcıya araba üretmek isteyip istemediği sorulur.
2. Eğer isterse:
   - Araba bilgileri istenir (Seri No, Marka, Model, Renk, Kapı Sayısı)
   - Girişlerin doğruluğu kontrol edilir (örneğin kapı sayısı bir sayı mı?)
   - Oluşturulan araba, listeye eklenir.
3. Kullanıcı, yeni araba eklemek isteyip istemediğini seçer.
4. Kullanıcı eklemek istemezse:
   - Tüm arabalar listelenir (`SeriNo` ve `Marka` bilgileri)
   - Program sonlanır.

---

## 🧪 Örnek Ekran

```plaintext
Araba üretmek istiyor musunuz? (e/h): e
Seri Numarası: 123ABC
Marka: Toyota
Model: Corolla
Renk: Gri
Kapı Sayısı: 4
Başka bir araba eklemek ister misiniz? (e/h): h

Tüm Araçlar:
Seri No: 123ABC, Marka: Toyota
