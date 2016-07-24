
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ETSEmployee
{
    public static class DatabaseScripts
    {

        public static void FireScript()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.EmployeesConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                //vQry02
                if (CheckViewExists("vQry02"))
                {
                    cmd.CommandText = DropObject("vQry02");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry02;
                cmd.ExecuteNonQuery();
                //vQry03
                if (CheckViewExists("vQry03"))
                {
                    cmd.CommandText = DropObject("vQry03");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry03;
                cmd.ExecuteNonQuery();
                //vQry04
                if (CheckViewExists("vQry04"))
                {
                    cmd.CommandText = DropObject("vQry04");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry04;
                cmd.ExecuteNonQuery();
                //vtblmortabat
                if (CheckViewExists("vtblmortabat"))
                {
                    cmd.CommandText = DropObject("vtblmortabat");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vtblmortabat;
                cmd.ExecuteNonQuery();
                //vtblbadalat
                if (CheckViewExists("vtblbadalat"))
                {
                    cmd.CommandText = DropObject("vtblbadalat");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vtblbadalat;
                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
        }

        public static bool CheckViewExists(string viewName)
        {
            bool exist = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.EmployeesConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandText = string.Format(@"IF EXISTS(select * FROM sys.views where name = '{0}')
                                            SELECT 1
                                            ELSE
                                            SELECT 0", viewName);
            try
            {
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                    exist = true;
                else
                    exist = false;
            }
            catch (SqlException ex)
            {
                Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
            return exist;
        }
        private static string DropObject(string objName)
        {
            return string.Format(@"DROP VIEW [dbo].[{0}]", objName);
        }

        public static string vQry02
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry02]
                AS
                WITH CTE1 AS
                (
                SELECT        TBLGehawork.GehaworkId, TBLGehawork.Gehawork, CDAlnoa.name_alnoa
                , CASE WHEN CDAlnoa.name_alnoa = 'ذكر' THEN COUNT(TBL_Emp.EmpID) ELSE 0 END AS MaleCount
                , CASE WHEN CDAlnoa.name_alnoa = 'انثي' THEN COUNT(TBL_Emp.EmpID) ELSE 0 END AS FemaleCount
                FROM            CDAlnoa INNER JOIN
                                         TBL_Emp ON CDAlnoa.code_alnoa = TBL_Emp.GENDER_ID RIGHT OUTER JOIN
                                         TBLGehawork ON TBL_Emp.GehaworkId = TBLGehawork.GehaworkId
                GROUP BY TBLGehawork.GehaworkId, TBLGehawork.Gehawork, CDAlnoa.name_alnoa
                )
                SELECT        GehaworkId, Gehawork, SUM(MaleCount) AS MaleCount, SUM(FemaleCount) AS FemaleCount
                FROM CTE1
                GROUP BY  GehaworkId, Gehawork";
            }
        }
        public static string vQry03
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry03]
                AS
                WITH CTE1 AS
(
SELECT        TBLGehawork.GehaworkId, TBLGehawork.Gehawork, CD_EmpJob.EmpJobId, CD_EmpJob.EmpJobName, TBL_Emp.EmpID
, YEAR(GETDATE()) - YEAR(TBL_Emp.BIRTH_DATE) AS Age
FROM            TBL_Emp INNER JOIN
                         CD_EmpJob ON TBL_Emp.EmpJobId = CD_EmpJob.EmpJobId INNER JOIN
                         TBLGehawork ON TBL_Emp.GehaworkId = TBLGehawork.GehaworkId
), CTE2 AS
(
SELECT        GehaworkId, Gehawork, EmpJobId, EmpJobName
, CASE WHEN Age BETWEEN 0 AND 20 OR Age IS NULL THEN EmpID END AS [0_20]
, CASE WHEN Age BETWEEN 20 AND 40 THEN EmpID END AS [20_40]
, CASE WHEN Age BETWEEN 40 AND 60 THEN EmpID END AS [40_60]
, CASE WHEN Age > 60 THEN EmpID END AS [>_60]
FROM            CTE1 
), CTE3 AS
(
SELECT GehaworkId, Gehawork, EmpJobId, EmpJobName, [0_20], [20_40], [40_60], [>_60]
FROM CTE2 GROUP BY GehaworkId, Gehawork, EmpJobId, EmpJobName, [0_20], [20_40], [40_60], [>_60]
)
SELECT GehaworkId, Gehawork, EmpJobId, EmpJobName, COUNT([0_20]) AS [0_20], COUNT([20_40]) AS [20_40], COUNT([40_60]) AS [40_60], COUNT([>_60]) AS [>_60]
FROM CTE3 GROUP BY GehaworkId, Gehawork, EmpJobId, EmpJobName";
            }
        }
        public static string vQry04
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry04]
                AS
                SELECT        TBLGehawork.GehaworkId, TBLGehawork.Gehawork, CD_EmpJob.EmpJobId, CD_EmpJob.EmpJobName, TBL_Emp.EmpID, TBL_Emp.EMPNAME
, TBL_Emp.BIRTH_DATE
,YEAR(GETDATE()) - YEAR(TBL_Emp.BIRTH_DATE) AS Age
, DateAdd(Year, 60, TBL_Emp.BIRTH_DATE) AS RetirementDate
FROM            TBL_Emp INNER JOIN
                         CD_EmpJob ON TBL_Emp.EmpJobId = CD_EmpJob.EmpJobId INNER JOIN
                         TBLGehawork ON TBL_Emp.GehaworkId = TBLGehawork.GehaworkId";
            }
        }
        public static string vtblmortabat
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vtblmortabat]
                AS
                SELECT        dbo.tblmortabat.mortabtid, dbo.tblmortabat.AsaseSalaryId, dbo.tblmortabat.month_code, dbo.tblmortabat.EmpID, dbo.tblmortabat.asasywithout, dbo.tblmortabat.asasy, dbo.tblmortabat.elawajan, 
                         dbo.tblmortabat.elawajulay, dbo.tblmortabat.tamin26, dbo.tblmortabat.tamin24, dbo.tblmortabat.elawa1, dbo.tblmortabat.elawa2, dbo.tblmortabat.elawa3, dbo.tblmortabat.elawa4, dbo.tblmortabat.elawa5, 
                         dbo.tblmortabat.egtmaia, dbo.tblmortabat.edafia, dbo.tblmortabat.menha, dbo.tblmortabat.hadadna, dbo.tblmortabat.hafez, dbo.tblmortabat.khpra, dbo.tblmortabat.est1, dbo.tblmortabat.est2, dbo.tblmortabat.est3, 
                         dbo.tblmortabat.est4, dbo.tblmortabat.est5, dbo.tblmortabat.sumesthkak, dbo.tblmortabat.estamin26, dbo.tblmortabat.estamin24, dbo.tblmortabat.estamin14, dbo.tblmortabat.estamin11, dbo.tblmortabat.solaf, 
                         dbo.tblmortabat.absent, dbo.tblmortabat.gaza, dbo.tblmortabat.esttkta1, dbo.tblmortabat.esttkta2, dbo.tblmortabat.esttkta3, dbo.tblmortabat.esttkta4, dbo.tblmortabat.sumesetktaa, dbo.tblmortabat.safy, 
                         dbo.CDMonth.month_name, dbo.TBL_Emp.EMPNAME, dbo.CD_AsaseSalary.AsaseSalary, dbo.tblmortabat.userin, dbo.tblmortabat.datein, dbo.Users.UserName, dbo.TBL_Emp.GehaworkId, 
                         dbo.TBLGehawork.Gehawork
FROM            dbo.tblmortabat INNER JOIN
                         dbo.TBL_Emp ON dbo.tblmortabat.EmpID = dbo.TBL_Emp.EmpID INNER JOIN
                         dbo.CD_AsaseSalary ON dbo.tblmortabat.AsaseSalaryId = dbo.CD_AsaseSalary.AsaseSalaryId INNER JOIN
                         dbo.CDMonth ON dbo.tblmortabat.month_code = dbo.CDMonth.month_code INNER JOIN
                         dbo.Users ON dbo.tblmortabat.userin = dbo.Users.UserID INNER JOIN
                         dbo.TBLGehawork ON dbo.TBL_Emp.GehaworkId = dbo.TBLGehawork.GehaworkId";
            }
        }
        public static string vtblbadalat
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vtblbadalat]
                AS
                SELECT        dbo.tblbadalat.badalid, dbo.tblbadalat.AsaseSalaryId, dbo.tblbadalat.month_code, dbo.tblbadalat.EmpID, dbo.tblbadalat.fatra1, dbo.tblbadalat.fatra2, dbo.tblbadalat.badalgohood, dbo.tblbadalat.fark, 
                         dbo.tblbadalat.years, dbo.tblbadalat.hafez, dbo.tblbadalat.sumesthkakbadal, dbo.tblbadalat.days, dbo.tblbadalat.absent, dbo.tblbadalat.gazaa, dbo.tblbadalat.soolaf, dbo.tblbadalat.sumesetktaa, 
                         dbo.tblbadalat.est1, dbo.tblbadalat.est2, dbo.tblbadalat.esttkta1, dbo.tblbadalat.esttkta2, dbo.tblbadalat.safy, dbo.tblbadalat.userin, dbo.tblbadalat.datein, dbo.CD_AsaseSalary.AsaseSalary, 
                         dbo.TBL_Emp.EMPNAME, dbo.CDMonth.month_name, dbo.Users.UserName, dbo.TBL_Emp.GehaworkId, dbo.TBLGehawork.Gehawork
FROM            dbo.tblbadalat INNER JOIN
                         dbo.CD_AsaseSalary ON dbo.tblbadalat.AsaseSalaryId = dbo.CD_AsaseSalary.AsaseSalaryId INNER JOIN
                         dbo.TBL_Emp ON dbo.tblbadalat.EmpID = dbo.TBL_Emp.EmpID INNER JOIN
                         dbo.CDMonth ON dbo.tblbadalat.month_code = dbo.CDMonth.month_code INNER JOIN
                         dbo.Users ON dbo.tblbadalat.userin = dbo.Users.UserID INNER JOIN
                         dbo.TBLGehawork ON dbo.TBL_Emp.GehaworkId = dbo.TBLGehawork.GehaworkId";
            }
        }
    }
}
