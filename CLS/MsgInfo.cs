using System;
using System.Collections.Generic;
using System.Linq;

namespace cfvn
{
    public class MsgInfo
    {
        public string msgTitle, msgSave_ok, msgSave_error, msgIsDelete, msgIsExists, msgApprove, msgSetup, msgResult_Find;
        public MsgInfo()
        {
            if (DBUtility._language == "2")
            {
                msgTitle = "System Information.";
                msgSave_ok = "Data saved successfully.";
                msgSave_error = "Failed to save the data";
                msgIsDelete = "Are you sure you want to delete this record ?";
                msgIsExists = "Data already exists.";
                msgApprove = "Successful approval.";
                msgSetup = "Successful setup.";
                msgResult_Find = "The data found does not exist.";               
               
            }
            else
            {
                msgTitle = "提示信息.";
                msgSave_ok = "資料保存成功!";
                msgSave_error = "資料保存失敗!";
                msgIsDelete = "確定要刪除此記錄?";
                msgIsExists = "資料已存在!";
                msgApprove = "批準成功.";
                msgSetup = "設置成功.";
                msgResult_Find = "查找的數據不存在!";
            }    
        }
    }
}
