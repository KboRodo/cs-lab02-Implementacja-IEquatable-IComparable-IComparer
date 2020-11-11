using System;

namespace cs_lab02
{
    public class Pracownik : IEquatable<Pracownik>
    {
        #region implementacja IComparable<Pracownik>

        #endregion implementacja IComparable<Pracownik>
        
        #region implementacja IEquatable<Pracownik>

            public bool Equals(Pracownik other)
            {
                if (other is null) return false;
                if (Object.ReferenceEquals(this, other)) //other i this są referencjami do tego samego obiektu
                    return true;

                return (Nazwisko == other.Nazwisko &&
                    DataZatrudnienia == other.DataZatrudnienia &&
                    Wynagrodzenie == other.Wynagrodzenie);
            }
            
            // override object.Equals
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            public override bool Equals(object obj)
            {
                if(obj is Pracownik){
                    return Equals((Pracownik)obj);
                }
                else{
                    return false;
                }
            }          
            // override object.GetHashCode
            public override int GetHashCode()=>(Nazwisko, DataZatrudnienia, Wynagrodzenie).GetHashCode();

            public static bool Equals(Pracownik p1, Pracownik p2)
            {
                if ((p1 is null) && (p2 is null)) return true; // w C#: null == null
                if ((p1 is null)) return false;

                //p1 nie jest `null`, nie będzie NullReferenceException
                return p1.Equals(p2);
            }

            // przeciążenie operatora `==` i `!=`
            public static bool operator ==(Pracownik p1, Pracownik p2) => Equals(p1, p2);
            public static bool operator !=(Pracownik p1, Pracownik p2) => !(p1 == p2);


        #endregion implementacja IEquatable<Pracownik>
        
        private string _Nazwisko;
        private DateTime _DataZatrudnienia;
        private decimal _Wynagrodzenie;

        public string Nazwisko {
            get=>_Nazwisko;
            set=>_Nazwisko=value.Trim();
        }
        public DateTime DataZatrudnienia{
            get=>_DataZatrudnienia;
            set=>_DataZatrudnienia = (value<=DateTime.Now)
                ? value
                : throw new System.ArgumentException($"Date invalid {value}");
            }
        public decimal Wynagrodzenie{
            get=>_Wynagrodzenie;
            set=>_Wynagrodzenie=(value < 0)
            ? 0
            : value;
        }
        public override string ToString() => $"({Nazwisko}, {DataZatrudnienia:d MMM yyyy}, {CzasZatrudnienia()}, {Wynagrodzenie} PLN)";
        
        public Pracownik(string nazwisko, DateTime dataZatrudnienia, decimal wynagrodzenie){
            Nazwisko=nazwisko;
            DataZatrudnienia=dataZatrudnienia;
            Wynagrodzenie=wynagrodzenie;
        }
        public Pracownik(){
            Nazwisko="Anonim";
            DataZatrudnienia=DateTime.Now;
            Wynagrodzenie=0;
        }
        public int CzasZatrudnienia(){
            return(DateTime.Now-DataZatrudnienia).Days/30;
        }
    }
}