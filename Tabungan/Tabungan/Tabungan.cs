using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabungan
{
    public class Tabungan
    {
        public int saldo;

        public Tabungan(int initial_saldo)
        {
            this.saldo = initial_saldo;
        }
        public int cekSaldo()
        {
            return this.saldo;
        }
        public void simpanUang(int jumlah)
        {
            int nilaiTabungan = (this.saldo + jumlah);
            biayaAdministrasi(nilaiTabungan);
        }
        public void biayaAdministrasi(int jumlah)
        {
            this.saldo = jumlah - 5000;
        }
        public bool ambilRupiah(int jumlah)
        {
            if (this.saldo - jumlah > 0)
            {
                this.saldo -= jumlah;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ambilDollar(int jumlah)
        {
            int usd = 15000;
            int potongan = 50;
            int rupiah = (jumlah * usd);
            int biayaAdministrasi = jumlah * potongan;
            if (rupiah + biayaAdministrasi <= this.saldo)
            {
                this.saldo -= (rupiah + biayaAdministrasi);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
