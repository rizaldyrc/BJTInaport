using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using InaportClientBJTI.Helper;

namespace InaportClientBJTI.Model
{
    class ModelRPKRO
    {
        DBTPKDHelper tpkd;
        DbCommand insert, update, delete, get;
        public ModelRPKRO()
        {
            tpkd = new DBTPKDHelper();
        }

        public void addRPK(String kode_dermaga, String plan_date, String nomor_rpkro,
                String nomor_pkk, String nomor_rkbm_muat, String nomor_rkbm_bongkar, int jml_disc,
                int jml_load, String commodity_code, String commodity, String nomor_gudang, 
                String keterangan, String berthing_date, String departure_date, int kade_from,
                int kade_to, String status, String portcode)
        {
            tpkd.establishConnection();
            insert = tpkd.Factory.CreateCommand();
            insert.Connection = tpkd.Connection;
            insert.CommandText = String.Format("Insert into TPKD_RPKRO (KODE_DERMAGA, PLAN_DATE, "+
                "NOMOR_RPKRO, NOMOR_PKK, NOMOR_RKBM_MUAT, NOMOR_RKBM_BONGKAR, JML_DISC, JML_LOAD, "+
                "COMMODITY_CODE, COMMODITY, NOMOR_GUDANG, KETERANGAN, BERTHING_DATE, DEPARTURE_DATE, "+
                "KADE_FROM, KADE_TO, STATUS, PORTCODE) values (rtrim('{0}'),to_date('{1}','DD/MM/RRRR HH24:MI'),"+
                "rtrim('{2}'),rtrim('{3}'),rtrim('{4}'),rtrim('{5}'),{6},{7}," +
                "rtrim('{8}'),rtrim('{9}'),rtrim('{10}'),rtrim('{11}'),to_date('{12}','DD/MM/RRRR HH24:MI'),to_date('{13}','DD/MM/RRRR HH24:MI')," +
                "{14},{15},rtrim('{16}'),rtrim('{17}'))",
                kode_dermaga, plan_date, nomor_rpkro, nomor_pkk, nomor_rkbm_muat, nomor_rkbm_bongkar, jml_disc,
                jml_load, commodity_code, commodity, nomor_gudang, keterangan, berthing_date, departure_date,
                kade_from, kade_to, status, portcode);

            DbTransaction trx = tpkd.Connection.BeginTransaction();
            insert.Transaction = trx;
            insert.ExecuteNonQuery();
            trx.Commit();
            tpkd.releaseConnection();
        }

        public void deleteRPKRO(int id_rpkro)
        {
            tpkd.establishConnection();
            delete = tpkd.Factory.CreateCommand();
            delete.Connection = tpkd.Connection;
            delete.CommandText = String.Format("Delete from TPKD_RPKRO where id_rpkro = {0}",
                id_rpkro);

            DbTransaction trx = tpkd.Connection.BeginTransaction();
            delete.Transaction = trx;
            delete.ExecuteNonQuery();
            trx.Commit();
            tpkd.releaseConnection();
        }

        public void updateRPK(int id_rpkro, String kode_dermaga, String plan_date, String nomor_rpkro,
                String nomor_pkk, String nomor_rkbm_muat, String nomor_rkbm_bongkar, int jml_disc,
                int jml_load, String commodity_code, String commodity, String nomor_gudang,
                String keterangan, String berthing_date, String departure_date, int kade_from,
                int kade_to, String status, String portcode)
        {
            tpkd.establishConnection();
            update = tpkd.Factory.CreateCommand();
            update.Connection = tpkd.Connection;
            update.CommandText = String.Format("update TPKD_RPKRO set KODE_DERMAGA = rtrim('{0}'), PLAN_DATE = to_date('{1}','DD/MM/RRRR HH24:MI'), " +
                "NOMOR_RPKRO = rtrim('{2}'), NOMOR_PKK = rtrim('{3}'), NOMOR_RKBM_MUAT = rtrim('{4}'), NOMOR_RKBM_BONGKAR = rtrim('{5}'), JML_DISC = {6}, JML_LOAD = {7}, " +
                "COMMODITY_CODE = rtrim('{8}'), COMMODITY = rtrim('{9}'), NOMOR_GUDANG = rtrim('{10}'), KETERANGAN = rtrim('{11}'), BERTHING_DATE = to_date('{12}','DD/MM/RRRR HH24:MI'), "+
                "DEPARTURE_DATE = to_date('{13}','DD/MM/RRRR HH24:MI'), KADE_FROM = {14}, KADE_TO = {15}, STATUS = rtrim('{16}'), PORTCODE = rtrim('{17}') "+
                "where id_rpkro = {18}",
                kode_dermaga, plan_date, nomor_rpkro, nomor_pkk, nomor_rkbm_muat, nomor_rkbm_bongkar, jml_disc,
                jml_load, commodity_code, commodity, nomor_gudang, keterangan, berthing_date, departure_date,
                kade_from, kade_to, status, portcode, id_rpkro);

            DbTransaction trx = tpkd.Connection.BeginTransaction();
            update.Transaction = trx;
            update.ExecuteNonQuery();
            trx.Commit();
            tpkd.releaseConnection();
        }

        public bool getRPKROByNomorRPKRO(String nomor_rpkro)
        {
            tpkd.establishConnection();
            get = tpkd.Factory.CreateCommand();
            get.Connection = tpkd.Connection;
            get.CommandText =
                string.Format("select * from TPKD_RPKRO where nomor_rpkro = rtrim('{0}')",
                nomor_rpkro);
            DbDataReader reader = get.ExecuteReader();
            reader.Read();
            String result = (String)reader[0];
            reader.Close();
            tpkd.releaseConnection();

            if (result.Equals(""))
                return false;
            else
                return true;

        }

        public bool getRPKROAll()
        {
            tpkd.establishConnection();
            get = tpkd.Factory.CreateCommand();
            get.Connection = tpkd.Connection;
            get.CommandText =
                string.Format("select * from TPKD_RPKRO");
            DbDataReader reader = get.ExecuteReader();
            reader.Read();
            String result = (String)reader[0];
            reader.Close();
            tpkd.releaseConnection();

            if (result.Equals(""))
                return false;
            else
                return true;

        }
    }
}
