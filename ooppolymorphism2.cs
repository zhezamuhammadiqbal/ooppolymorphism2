using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace wwww
{

    using System;

    public class simpledataklg
    {
        static public void Main()
        {
            datakeluarga ok = new datakeluarga();
            datakeluarga ayahku = new Ayah();
            ayahku.Nama = "johan";
            ayahku.Umur = 44;
            ayahku.Nohp = +6282765435768;
            Console.WriteLine("Data Ayah:");
            Console.WriteLine(ayahku.Nama);
            Console.WriteLine(ayahku.Umur);
            Console.WriteLine(ayahku.Nohp);
            ayahku.Hobi();
            datakeluarga ibuku = new Ibu();
            ibuku.Nama = "erika";
            ibuku.Umur = 46;
            ibuku.Nohp = +6283465635768;
            Console.WriteLine("Data Ibu:");
            Console.WriteLine(ibuku.Nama);
            Console.WriteLine(ibuku.Umur);
            Console.WriteLine(ibuku.Nohp);
            ibuku.Hobi();
            Console.WriteLine("Data Diriku:");
            datakeluarga aku = new Anak();
            aku.Nama = "Zheza M Iqbal";
            aku.Umur = 17;
            aku.Nohp = +6281965439668;
            Console.WriteLine(aku.Nama);
            Console.WriteLine(aku.Umur);
            Console.WriteLine(aku.Nohp);
            aku.Hobi();
        }
        class datakeluarga
        {
            private string nama;
            public string Nama
            {
                get { return nama; }
                set { nama = value; }
            }
            private int umur;
            public int Umur
            {
                get { return umur; }
                set { umur = value; }
            }
            private long nohp;
            public long Nohp
            {
                get { return nohp; }
                set { nohp = value; }
            }
            public virtual void Hobi()
            {
                Console.WriteLine("Hobi");
            }
        }
        class Ayah : datakeluarga
        {
            public override void Hobi()
            {
                Console.WriteLine("Basket");
            }
        }
        class Ibu : datakeluarga
        {
            public override void Hobi()
            {
                Console.WriteLine("Memasak");
            }
        }
        class Anak : datakeluarga
        {
            public override void Hobi()
            {
                Console.WriteLine("Sepak Bola");
            }
        }

    }
}
