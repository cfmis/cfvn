using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cfvn.CLS
{
    public class clsPublic
    {
        public static string GeoEncrypt(string strEncrypt)
        {
            //函數說明：傳入用戶密碼(原碼),返回加密之後的字串
            //參數：as_code(輸入的密碼原碼).
            //返回值：ls_EncryptPass 加密之後的字串
            //ChingFung可以寫一個類似的函數，將加密之後的字串與目前資料庫中保存的密碼去比較,如果相等就表示輸入的密碼正確。
            //定義函數使用到的變數
            string ls_TempString, ls_Work, ls_EncryptPass, ls_DecryptString, ls_EncryptString, as_code;
            int li_Length, li_Position, li_Multiplier, li_Offset, li_Count;
            as_code = strEncrypt;// 輸入的密碼
            //--將輸入的密碼轉化為小寫字元
            ls_TempString = as_code.ToLower();
            //定義加密解密的字串,這一些字元是固定的.不允許修改.
            //以雙引號開始,同樣以雙引號結束，比如："123456",表示123456這幾個字元.

            ls_DecryptString = " !" + "\"" + "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[" + "\\" + "]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            ls_EncryptString = "~{[}u;Ce83KX%:VIm!|gs]_aL-QEOpx<UlzZjBq6#1($" + "\\" + "\"" + "FS5H0'cM&>Po.NGA*Jr)Y" + " " + "Dv/t9kd?^fni,hR2Wy=`+4T@7wb";


            //取得輸入的密碼長度
            li_Length = as_code.Trim().Length;
            //--根據不同的密碼長度得到不同的加密方法的字元長度倍數
            if (1 <= li_Length && li_Length <= 3)
                li_Multiplier = 1;
            else
                if (4 <= li_Length && li_Length <= 6)
                    li_Multiplier = 2;
                else
                    if (7 <= li_Length && li_Length <= 9)
                        li_Multiplier = 3;
                    else
                        li_Multiplier = 4;
            ls_EncryptPass = "";//先將保存加密之後字串清空。

            //以下為迴圈密碼每一位元字元,對每一位元字元進行加密
            for (li_Count = 1; li_Count <= li_Length; li_Count++)
            {
                li_Offset = li_Count * li_Multiplier;
                //取密碼中的第li_count位元的字元，長度為1
                //使用方法：Mid(需要取值的字串,開始位置，長度)
                ls_Work = as_code.Substring(li_Count - 1, 1);//SUBSTR(as_code, li_Count, 1);
                //取到ls_work字元在ls_decryptstring中的第一個位置
                //使用方法：Pos(用來查找的字串，需要查找的字串)
                li_Position = ls_DecryptString.IndexOf(ls_Work) + 1;//substring(ls_Work,ls_DecryptString);
                li_Position = li_Position + li_Offset;
                //Mod是取模函數，即取到Li_positon除以95之後的餘數
                li_Position = li_Position % 95;//Mod(li_Position, 95);
                //將li_position值加1 ，相當於li_postion = li_postion + 1
                li_Position = li_Position + 1;
                //取到ls_EncryptString中第li_Position開始的1位元字元
                ls_Work = ls_EncryptString.Substring(li_Position - 1, 1);//SUBSTR(ls_EncryptString, li_Position, 1);
                //將加密之後的字元相加,得到加密結果字串.
                ls_EncryptPass = ls_EncryptPass + ls_Work;
                //重新設置加密方法的字元長度倍數
                if (1 <= li_Multiplier && li_Multiplier <= 3)
                    li_Multiplier = li_Multiplier + 1;
                else
                    li_Multiplier = 1;
            }
            //--將加密之後的字元返回
            return ls_EncryptPass;
        }

    }
}
