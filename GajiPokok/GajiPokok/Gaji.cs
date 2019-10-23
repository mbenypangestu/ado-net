using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GajiPokok
{
    class Gaji
    {
        private int jam_kerja;
        private int masa_kerja;
        private double gaji;

        public Gaji(int jam, int masa)
        {
            this.jam_kerja = jam;
            this.masa_kerja = masa;
        }

        public double countGaji()
        {
            int jamLembur = this.jam_kerja - 7;
            double gaji_lembur = 0;

            double gajipokok = this.jam_kerja * 8000;
            this.gaji = gajipokok;

            if (this.jam_kerja > 7)
            {
                gaji_lembur = 1.5 * this.gaji * jamLembur;
                this.gaji += gaji_lembur;
            }

            if (this.jam_kerja > 8) this.gaji += 8500;

            if (this.jam_kerja > 9) this.gaji += 15000;

            if (this.masa_kerja > 3) this.gaji += 0.25 * gajipokok;

            return this.gaji;
        }
    }
}
