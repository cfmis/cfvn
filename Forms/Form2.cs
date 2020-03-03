using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cfvn.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MyDataSource mydatasource = new MyDataSource(); //應用於第二種方式
        public int Num { get; set; } //應用於第三種方式
        public List<BlogNew> blogNews { get; set; } //應用於第四種方式
        public BindingList<BlogNew> blogNewsRegardUI { get; set; } //應用於DataGridView介面UI更新

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dgcf_vnDataSet.bs_group' table. You can move, or remove it, as needed.
            
            #region 測試一
            /************************************************
           * 第一個值：要繫結到TextBox的什麼地方
           * 第二個值：資料來源是什麼
           * 第三個值：應該取資料來源的什麼屬性
           * 第四個值：是否開啟資料格式化
           * 第五個值：在什麼時候啟用資料來源繫結
           * *********************************************/
            textBox1.DataBindings.Add("Text", trackBar1, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
            #region 測試二
            /*********************************************
       * 這個主要就是通過一個外部的類，當做資料來源
       * *********************************************/
            mydatasource.Myvalue = "這是個測試";
            textBox2.DataBindings.Add("Text", mydatasource, "Myvalue", false, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
            #region 測試三
            /*****************************************
       *這個主要就是通過本身擁有的屬性，當做資料來源
       ****************************************/
            Num = 5;
            textBox3.DataBindings.Add("Text", this, "Num", false, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
            /*
       * 注意：上面的3個測試，改變文字框中的值，資料來源中對應的屬性值會改變 
       *    但是，資料來源的屬性值改變了，文字框中的值不會改變
       */
            #region 測試四 ： List<T>
            blogNews = new List<BlogNew>();
            blogNews.Add(new BlogNew { BlogID = 1, BlogTitle = "人生若只如初見" });
            blogNews.Add(new BlogNew { BlogID = 2, BlogTitle = "何事秋風悲畫扇" });
            blogNews.Add(new BlogNew { BlogID = 3, BlogTitle = "最喜歡納蘭性德" });
            dataGridView1.DataBindings.Add("DataSource", this, "blogNews", false, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
            #region 測試五 ： BindingList<T>
            blogNewsRegardUI = new BindingList<BlogNew>();
            blogNewsRegardUI.Add(new BlogNew { BlogID = 11, BlogTitle = "僵臥孤村不自哀" });
            blogNewsRegardUI.Add(new BlogNew { BlogID = 12, BlogTitle = "尚思為國戍輪臺" });
            blogNewsRegardUI.Add(new BlogNew { BlogID = 13, BlogTitle = "夜闌臥聽風吹雨" });
            dataGridView2.DataBindings.Add("DataSource", this, "blogNewsRegardUI", false, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //從這裡可以看出，改變了TextBox2中的值，這裡的值也改變了，原因是因為類屬於引用型別
            MessageBox.Show(mydatasource.Myvalue);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //從這裡可以看出，改變了TextBox3中的值，這裡的值也改變了，
            //原因是Num被當做了當前窗體的一個屬性(窗體本身就是一個類)，也屬於引用型別
            MessageBox.Show(Num.ToString());
            //this.Num = 10;
            //MessageBox.Show(Num.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //在這裡向DataGridView中插入一行
            var data = dataGridView1.DataSource as List<BlogNew>;
            data.Add(new BlogNew { BlogID = 4, BlogTitle = "取次花叢懶回顧，半緣修道半緣君" });
            foreach (BlogNew blogNew in dataGridView1.DataSource as List<BlogNew>)
            {
                /***********
                 * 當我們心插入一條BlogID記錄為4的資料的時候，在介面上可以看出dataGridView1的dataSource已經被更新，
                 * 但是介面上依舊顯示為BlogID為1,2,3三條資料，很奇怪
                 * *********************/
                MessageBox.Show(blogNew.BlogID + "--" + blogNew.BlogTitle);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            /*這裡主要用來解決DataGridView1介面不更新的問題，其實原因在於使用了List<BlogNew>,這裡我們採用BindList<BlogNew>
             *通過測試，我們發現，只要資料來源改變，介面就可以自動的進行更新了，很是方便，不需要重新繫結
             */
            var dataRegardUI = dataGridView2.DataSource as BindingList<BlogNew>;
            dataRegardUI.Add(new BlogNew { BlogID = 20, BlogTitle = "竹外桃花三兩枝，春江水暖鴨先知" });
        }

        public class MyDataSource
        {
            public string Myvalue { get; set; }
        }
        public class BlogNew
        {
            public int BlogID { get; set; }
            public string BlogTitle { get; set; }
        }
    }
}
