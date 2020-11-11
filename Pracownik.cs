using System;

namespace Pracownicy
{
    public class Pracownik
    {
        private string _Nazwisko
        private DateTime _DataZatrudnienia
        private decimal _Wynagrodzenie

        public string Nazwisko {
            get=>_Nazwisko;
            set=>_Nazwisko.Trim()
        }
        public DateTime DataZatrudnienia{
            get=>_DataZatrudnienia;
            set=>_DataZatrudnienia = (value>=DateTime.Now)
                ? value
                : throw new System.ArgumentException("Date invalid")
            }
        public decimal Wynagrodzenie{
            get=>_Wynagrodzenie;
            set=>_Wynagrodzenie=(value < 0)
            ? 0
            : value;
        }
        public override string ToString() => $"({Nazwisko},
            {DataZatrudnienia:d MMM yyyy}, {Wynagrodzenie} PLN)";
        
        public Pracownik(string nazwisko, DateTime dataZatrudnienia, decimal wynagrodzenie){
            Nazwisko=nazwisko
            DataZatrudnienia=dataZatrudnienia
            Wynagrodzenie=wynagrodzenie
        }
        public Pracownik(){
            Nazwisko="Anonim"
            DataZatrudnienia=DateTime.Now;
            Wynagrodzenie=0;
        }
    }
}