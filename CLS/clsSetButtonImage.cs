using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cfvn.CLS
{    
    public class clsSetButtonImage
    {
        public clsSetButtonImage()
        {
        }

        /// <summary>
        /// set button image
        /// </summary>
        /// <param name="tlstp"></param>
        public void Set_Button_Image(ToolStrip tlstp)
        {
            string ls_button_name = "", ls_file_image = "";            
            foreach (ToolStripItem tsp in tlstp.Items)
            {
                ls_button_name = tsp.Name.ToUpper();
                switch (ls_button_name)
                {
                    case "BTNEXIT":
                        ls_file_image = "Image\\exit.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNNEW":
                        ls_file_image = "Image\\24_Add.ico";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNEDIT":
                        ls_file_image = "Image\\edit.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNDELETE":
                        ls_file_image = "Image\\delete.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNITEMADD":
                        ls_file_image = "Image\\p_add_Item.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNITEMDEL":
                        ls_file_image = "Image\\DeleteMR.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNSAVE":
                        ls_file_image = "Image\\SAVE.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNCANCEL":
                        ls_file_image = "Image\\cancel.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNAPPROVE":
                        ls_file_image = "Image\\p_ok.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNPRINT":
                        ls_file_image = "Image\\print.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNFIND":
                        ls_file_image = "Image\\find.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNUNDO":
                        ls_file_image = "Image\\cancel.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNCOPY":
                        ls_file_image = "Image\\copy.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNEXCEL":
                        ls_file_image = "Image\\Excel.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNREFRESH":
                        ls_file_image = "Image\\refresh.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNIMPORT":
                        ls_file_image = "Image\\p_input.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNNEWVER":
                        ls_file_image = "Image\\p_batch_additem.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNOK":
                        ls_file_image = "Image\\p_ok.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNSAVESET":
                        ls_file_image = "Image\\w_set.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Load_Image_File(ToolStripItem tsp, string ls_file_image)
        {
            string ls_image_path = AppDomain.CurrentDomain.BaseDirectory;
            ls_file_image = ls_image_path + ls_file_image;//絕對路徑
            if (System.IO.File.Exists(ls_file_image))
            {
                tsp.Image = System.Drawing.Image.FromFile(ls_file_image);
            }
        }

    }
}
