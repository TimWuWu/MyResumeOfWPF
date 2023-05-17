using Microsoft.EntityFrameworkCore;
using MyResumeOfWPF.PDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyResumeOfWPF
{
    /// <summary>
    /// UpdateBasicUIControl.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateBasicUIControl : UserControl
    {
        //View model
        private BasicinfoRow _row;
        public UpdateBasicUIControl()
        {
            //打开数据库
            using var db = new PersonalDbContext();
            if (db.BasicInfos.Count() == 0)
            {
                _row =new BasicinfoRow();
                DataContext = _row;
            }
            else
            {
                _row = db.BasicInfos.First();
                DataContext = _row;
            }
                       
            InitializeComponent();
        }

        //更新和上传数据的逻辑
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //打开数据库
            using var db = new PersonalDbContext();
            
            //如果数据库里没有个人记录，那么就是上传（添加）数据
            if (db.BasicInfos.Count()==0)
            {
                //先保存记录
                db.Add(_row);
                db.SaveChanges();

                MessageBox.Show("个人信息添加成功！");

                //重置绑定的数据源
                _row = new BasicinfoRow();
                DataContext = _row;
            }
            else
            {
                try
                {
                    //如果以及有个人信息，那么只能进行更新
                    //先删除掉旧项
                    db.BasicInfos.Remove(db.BasicInfos.First());
                    //然后保存新记录
                    db.Add(_row);
                    db.SaveChanges();

                    MessageBox.Show("个人信息更新成功！");

                    //重置绑定的数据源
                    _row = new BasicinfoRow();
                    DataContext = _row;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("请准确的填写每一项！");
                }
                
            }
        }
    }
}
