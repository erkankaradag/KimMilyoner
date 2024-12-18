# Kim Milyoner Olmak İster? - C# Console Application

Bu proje, ünlü "Kim Milyoner Olmak İster?" yarışmasından esinlenerek yazılmış basit bir C# konsol tabanlı uygulamadır. Uygulama, 3 sorudan oluşur ve her bir soru 2 seçenek sunar. Oyuncu doğru yanıtları vererek 1 milyon TL'lik büyük ödülü kazanır.

## Özellikler
- **3 Soru**: Oyuncuya 3 soru sunulur, her soru 2 seçenek içerir.
- **Puanlama Sistemi**: Oyuncunun 2 doğru cevap vermesi durumunda büyük ödül kazanılır.
- **Geribildirim**: Oyuncuya her soru için doğru ya da yanlış cevap verilip verilmediği bildirilir.
- **Yarışma Sonu**: Eğer oyuncu 2 doğru cevaba ulaşırsa, yarışma sonlanır ve ödül kazandığı bildirilir.

## Nasıl Oynanır?
1. Programı başlatın.
2. 3 soru ile karşılaşacaksınız.
3. Her soruya A veya B seçeneklerinden birini seçerek cevap verin.
4. 2 doğru cevabı verdikten sonra 1 milyon TL'lik ödülü kazanın.
5. Yanlış cevap verdiğinizde doğru cevap gösterilecek ve oyun devam edecektir.

## Sorular

1. **Soru 1**: 
   - **Soru**: Kızınca tüküren hayvan hangisidir?  
     **A)** Lama  
     **B)** Deve
   - **Doğru Cevap**: A) Lama

2. **Soru 2**: 
   - **Soru**: Dünyaya en yakın gezegen hangisidir?  
     **A)** Venüs  
     **B)** Mars
   - **Doğru Cevap**: B) Mars

3. **Soru 3**: 
   - **Soru**: 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?  
     **A)** 7  
     **B)** 12
   - **Doğru Cevap**: B) 12

## Uygulamanın Yapısı
- **Main Program**: Yarışma mantığı ve sorular burada bulunur.
- **Doğru Cevap Sayısı**: Doğru cevapların sayısını takip eder.
- **Kullanıcı Girdisi**: Kullanıcının yanıtları `Console.ReadLine()` ile alınır.
- **Koşul İfadeleri**: Kullanıcının doğru veya yanlış cevap verip vermediği kontrol edilir ve geri bildirim sağlanır.

## Örnek Çıktı

```text
Kim Milyoner Olmak İster? yarışmasına hoş geldiniz. 
Yarışmamız 3 sorudan ve her bir soru 2 şıktan oluşmaktadır.
2 Soruya Doğru Cevap Vermeniz Durumunda 1 Milyon TL'lik Ödülü Kazanmış Olacaksınız.
-------------------------------------------------------------------
1. Soru: Kızınca tüküren hayvan hangisidir?

A) Lama B) Deve

a

Doğru Cevap!
---------------------------------------------------------------------
2. Soru: Dünyaya en yakın gezegen hangisidir?

A) Venüs B) Mars

b

Doğru Cevap!
---------------------------------------------------------------------
Tebrikler 2 doğru cevaba ulaşarak yarışmayı tamamladınız ve 1 milyon TL değerindeki büyük ödülü kazandınız.
---------------------------------------------------------------------
