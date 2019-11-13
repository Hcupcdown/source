using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SqlServer;


namespace Hospital.Hospital.bl
{
    class BackDB
    {
        public static void BackupDB(string hostName, string userID, string pw, string DBName, string pathAndFile, string BackupSetName)
        {
            SQLDMO.Backup bk = new SQLDMO.BackupClass();
            SQLDMO.SQLServer sqlserver = new SQLDMO.SQLServerClass();

            try
            {
                sqlserver.LoginSecure = true;
                sqlserver.Connect(hostName, userID, pw);

                bk.Action = SQLDMO.SQLDMO_BACKUP_TYPE.SQLDMOBackup_Database;
                bk.Database = DBName;
                bk.Files = pathAndFile;
                bk.BackupSetName = BackupSetName;
                bk.BackupSetDescription = "数据库备份";
                bk.Initialize = true;
                bk.SQLBackup(sqlserver);
            }
            catch
            {
                throw;
            }
            finally
            {
                sqlserver.DisConnect();
            }
        }
        /// <summary>
        /// 数据库恢复
        /// </summary>
        /// <param name="hostName"></param>
        /// <param name="userID"></param>
        /// <param name="pw"></param>
        /// <param name="DBName"></param>
        /// <param name="pathAndFile"></param>

        public static void RestoreDB(string hostName, string userID, string pw, string DBName, string pathAndFile)
        {
            SQLDMO.Restore restore = new SQLDMO.RestoreClass();
            SQLDMO.SQLServer sqlserver = new SQLDMO.SQLServerClass();
            try
            {
                
                sqlserver.LoginSecure = true;
                sqlserver.Connect(hostName, userID, pw);

                restore.Action = SQLDMO.SQLDMO_RESTORE_TYPE.SQLDMORestore_Database;
                restore.Database = DBName;
                restore.Files = pathAndFile;
                restore.FileNumber = 1;
                restore.ReplaceDatabase = true;
                restore.SQLRestore(sqlserver);
            }
            catch
            {
                throw;
            }
            finally
            {
                sqlserver.DisConnect();
            }


        }
    }
}
