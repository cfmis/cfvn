using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
//using System.Drawing;
//using cfvn.Interface;

namespace cfvn.Forms
{
    public partial class frmMain :Form
    {
        //string name;
        //string UserName;
        //string pwd;
        bool isexit;
        
        public static bool isRunMain ;//= false;
        public static string user_id = ""; // 此變量由Login畫面傳值，debug 時可設爲"admin"
        public static string user_name = "";
        public static string user_pwd = "";
        //private static string lang = "1"; 


        readonly frmMain_Left frmMain_Panel;
        //Form2 frm3 = new Form2();       
        

        public frmMain()
        {
            InitializeComponent();
            frmMain_Panel = new frmMain_Left(this);//實例化對象并傳給主窗體
            isexit = false;
            SetDocumentStatus(); //是否可以移動窗體
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMain_Panel.Show(dockPanel1, DockState.DockLeft);//停靠主窗體的左邊
            //禁止此窗體拖動或雙擊窗體標體,因拖動或雙擊窗體標體，此窗體再也無法顯示出來
            //frmMain_Panel.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft))));
            frmMain_Panel.DockAreas = ((DockAreas)(((DockAreas.DockLeft))));
            //this.dockPanel1.DockRightPortion = (double)frmMain_Panel.Width / (double)this.dockPanel1.Width;
            dockPanel1.DockLeftPortion = 250;//停靠窗體默認寶寬度
            frmMain_Panel.AutoHidePortion = (double)frmMain_Panel.Width / (double)dockPanel1.Width;//點擊隐藏停靠后显示的寬度，展開的
            
            //frm3.Show(dockPanel1);     
            tsDate.Text = String.Format("今天日期：{0:yyyy-MM-dd}    ", DateTime.Now);
            tsUserid.Text = "当前用户：";//+ " " + frmLogin.C_UserInfo.SysUser;


            ////test
            ////添加
            //ToolStripButton btn1 = new ToolStripButton("btnNew"); //实例化按钮对象
            //btn1.Text = "新增(&A)";
            //btn1.Image = Image.FromFile("C:\\Doct2\\Graphics\\24_Add.ico");//指定图片
            //btn1.ImageAlign = ContentAlignment.MiddleCenter;          //设置图像对齐方式
            //btn1.TextAlign = ContentAlignment.MiddleLeft;            //设置按钮上的文本对齐方式
            //btn1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            //btn1.TextImageRelation = TextImageRelation.ImageAboveText;

            //toolStrip1.Items.Add(btn1); //加入集合
            //btn1.Click += new EventHandler(btnNew_Click);
        }

        /// <summary>
        /// 自定義方法
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        //private void btnNew_Click(object Sender, EventArgs e)
        //{
        //    MessageBox.Show("成功調用自定義方法!");
        //    if (this.ActiveMdiChild == null)
        //        return;
        //    iToolBar it = (iToolBar)this.ActiveMdiChild;
        //    it.AddNew();

        //    //FormClient frm = new FormClient();
        //    //frm.Show(dockPanel1);
        //}

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isexit == false)
            {
                if (MessageBox.Show("确定退出系统?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (Form childForm in MdiChildren)
                    {
                        childForm.Close();
                    }
                    isexit = true; //設置系統退出變量
                    Dispose();
                    frmMain_Panel.Dispose();
                    Application.Exit();
                }
                else
                {
                    isexit = false; //設置系統退出變量                
                }
            }
            //frmMain_Panel.Dispose();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            int x = this.Width / 2;
            int y = this.Height / 2;
            if (x > 260 && y > 260)
            {
                pictureBox1.Location = new System.Drawing.Point(x, y);
            }
        }    


        //顯示或隱藏精豐LOGO
        private void dockPanel1_ContentRemoved(object sender, DockContentEventArgs e)
        {
            if (dockPanel1.Contents.Count == 1)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void dockPanel1_ContentAdded(object sender, DockContentEventArgs e)
        {
            if (dockPanel1.Contents.Count > 1)
            {
                pictureBox1.Visible = false;
            }            
        }

        private void SetDocumentStatus()
        {
            //禁止雙擊
            dockPanel1.AllowEndUserDocking = false;
            //禁止拖動窗體
            foreach (DockPane curPane in dockPanel1.Panes)//documents)
            {                
                if (true)
                {
                    for (int i = 0; i < curPane.Contents.Count; i++)
                    {                       
                        curPane.Contents[i].DockHandler.IsFloat = false;
                        curPane.Contents[i].DockHandler.CloseButtonVisible = false;                        
                    }
                }
            }
            return;

            //btnLock.Checked = !btnLock.Checked;
            //dockPanel1.AllowEndUserDocking = false;//!btnLock.Checked;

            //IDockContent[] documents = dockPanel1.DocumentsToArray();
            //int a = dockPanel1.DocumentsCount;
            //int b = dockPanel1.Panes.Count();


            //int index = 0;
            //foreach (IDockContent content in dockPanel.Documents)//documents)
            //{
            //    if (btnLock.Checked)
            //    {
            //        content.DockHandler.HideButtonVisible = false;
            //        content.DockHandler.CloseButtonVisible = false;
            //        //content.DockHandler.TabPageContextMenuStrip = null;
            //        content.DockHandler.ConfigButtonVisible = false;
            //    }
            //    else
            //    {
            //        content.DockHandler.HideButtonVisible = true;
            //        content.DockHandler.CloseButtonVisible = true;
            //        //content.DockHandler.TabPageContextMenuStrip = contextMenuStrip1;
            //        content.DockHandler.ConfigButtonVisible = true;
            //    }
            //    content.DockHandler.Pane.CaptionControl.ResetButtonState();
            //}

            //foreach (DockPane curPane in dockPanel1.Panes)//documents)
            //{
            //    //if (btnLock.Checked)
            //    if (true)
            //    {
            //        for (int i = 0; i < curPane.Contents.Count; i++)
            //        {
            //            //curPane.Contents[i].DockHandler.HideButtonVisible = false;
            //            curPane.Contents[i].DockHandler.IsFloat = false;
            //            curPane.Contents[i].DockHandler.CloseButtonVisible = false;
            //            //curPane.Contents[0].DockHandler.TabPageContextMenuStrip = null;
            //            //curPane.Contents[i].DockHandler.ConfigButtonVisible = false;
            //        }
            //    }
            //    //else
            //    //{
            //    //    for (int i = 0; i < curPane.Contents.Count; i++)
            //    //    {
            //    //        curPane.Contents[i].DockHandler.HideButtonVisible = true;
            //    //        curPane.Contents[i].DockHandler.CloseButtonVisible = true;
            //    //        //curPane.Contents[0].DockHandler.TabPageContextMenuStrip = contextMenuStrip1;
            //    //        curPane.Contents[i].DockHandler.ConfigButtonVisible = true;
            //    //    }
            //    //}
            //    //curPane.Contents[0].DockHandler.Pane.CaptionControl.ResetButtonState();

            //    //curPane.TabStripControl.
            //}
        }

        
    }
}
