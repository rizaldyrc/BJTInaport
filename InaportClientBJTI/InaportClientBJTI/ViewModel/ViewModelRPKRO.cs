using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InaportClientBJTI.ViewModel
{
    public class ViewModelRPKRO
    {
        string KODE_DERMAGA = string.Empty, PLAN_DATE = string.Empty,
               NOMOR_RPKRO = string.Empty, NOMOR_PKK = string.Empty, NOMOR_RKBM_MUAT = string.Empty,
               NOMOR_RKBM_BONGKAR= string.Empty, COMMODITY_CODE = string.Empty, COMMODITY = string.Empty, NOMOR_GUDANG = string.Empty,
               KETERANGAN = string.Empty, BERTHING_DATE = string.Empty, DEPARTURE_DATE = string.Empty, STATUS = string.Empty,
               PORTCODE = string.Empty, SENT_STATUS = string.Empty;
        int KADE_FROM = 0, KADE_TO = 0, JML_DISC = 0, JML_LOAD = 0;

        public string nomor_RPKRO
        {
            get { return NOMOR_RPKRO; }
            set { NOMOR_RPKRO = value; }
        }

        public string nomor_PKK
        {
            get { return NOMOR_PKK; }
            set { NOMOR_PKK = value; }
        }

        public string nomor_RKBM_Muat
        {
            get { return NOMOR_RKBM_MUAT; }
            set { NOMOR_RKBM_MUAT = value; }
        }

        public string nomor_RKBM_Bongkar
        {
            get { return NOMOR_RKBM_BONGKAR; }
            set { NOMOR_RKBM_BONGKAR = value; }
        }

        public int jml_Disc
        {
            get { return JML_DISC; }
            set { JML_DISC = value; }
        }

        public int jml_Load
        {
            get { return JML_LOAD; }
            set { JML_LOAD = value; }
        }

        public string commodity_Code
        {
            get { return COMMODITY_CODE; }
            set { COMMODITY_CODE = value; }
        }

        public string commodity
        {
            get { return COMMODITY; }
            set { COMMODITY = value; }
        }

        public string nomor_Gudang
        {
            get { return NOMOR_GUDANG; }
            set { NOMOR_GUDANG = value; }
        }

        public string keterangan
        {
            get { return KETERANGAN; }
            set { KETERANGAN = value; }
        }

        public string berthing_Date
        {
            get { return BERTHING_DATE; }
            set { BERTHING_DATE = value; }
        }

        public string departure_Date
        {
            get { return DEPARTURE_DATE; }
            set { DEPARTURE_DATE = value; }
        }

        public int kade_From
        {
            get { return KADE_FROM; }
            set { KADE_FROM = value; }
        }

        public int kade_To
        {
            get { return KADE_TO; }
            set { KADE_TO = value; }
        }

        public string status
        {
            get { return STATUS; }
            set { STATUS = value; }
        }

        public string portCode
        {
            get { return PORTCODE; }
            set { PORTCODE = value; }
        }

        public string sent_Status
        {
            get { return SENT_STATUS; }
            set { SENT_STATUS = value; }
        }

        public string plan_Date
        {
            get { return PLAN_DATE; }
            set { PLAN_DATE = value; }
        }

        public string kode_Dermaga
        {
            get { return KODE_DERMAGA; }
            set { KODE_DERMAGA = value; }
        }

    }
}
