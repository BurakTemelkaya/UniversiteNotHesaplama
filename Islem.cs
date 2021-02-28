using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UniversiteNotHesaplama
{
    class Islem
    {
        ArrayList krediArray = new ArrayList();
        ArrayList notlar = new ArrayList();
        public void NotAl(int vize, int final, int krediDeger, out double not, out double katSayi, out string katSayiHarf)
        {
            not = vize * 0.4 + final * 0.6;
            katSayiHesap(not, out katSayi, out katSayiHarf);
            notlar.Add(katSayi);
            krediArray.Add(krediDeger);
        }
        public double Hesapla()
        {
            double top=0,ort=0,kredi=0;
            for (int i = 0; i < notlar.Count; i++)
            {
                top += Convert.ToDouble(notlar[i])*Convert.ToDouble(krediArray[i]);//notla krediyi çarpma 
                kredi += Convert.ToInt32(krediArray[i]);//kredileri toplama
            }
            ort = top / kredi;//toplamla krediyi bölme
            return ort;//ortalamayı döndürme
        }
         void katSayiHesap(double katSayi, out double katsayi , out string katHarf)
        {
            
            if (katSayi>=88 && katSayi<=100)
            {
                katsayi = 4;
                katHarf = "AA";
            }
            else if (katSayi >= 80 && katSayi <= 87)
            {
                katsayi = 3.5;
                katHarf = "BA";
            }
            else if (katSayi >= 73 && katSayi <= 79)
            {
                katsayi = 3;
                katHarf = "BB";
            }
            else if (katSayi >= 66 && katSayi <= 72)
            {
                katsayi = 2.5;
                katHarf = "CB";
            }
            else if (katSayi >= 60 && katSayi <= 65)
            {
                katsayi = 2;
                katHarf = "CC";
            }
            else if (katSayi >= 55 && katSayi <= 59)
            {
                katsayi = 1.5;
                katHarf = "DC";
            }
            else if (katSayi >= 50 && katSayi <= 54)
            {
                katsayi = 1;
                katHarf = "DD";
            }
            else
            {
                katsayi = 0;
                katHarf = "FF";
            }
        }
        public void sil(int index)
        {
            notlar.RemoveAt(index);
            krediArray.RemoveAt(index);
        }
        public void HepsiniSil()
        {
            notlar.Clear();
            krediArray.Clear();
        }
    }
}
