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
    /// InputJobUIControl.xaml 的交互逻辑
    /// </summary>
    public partial class InputJobUIControl : UserControl
    {
        private JobRow _jobrow;
        public InputJobUIControl()
        {
            //通过（数据源）绑定_jobrow（ViewModel）到View
            _jobrow = new JobRow();
            DataContext= _jobrow;
            InitializeComponent();
        }
        //删除按钮的逻辑
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //打开数据库
            using var dbfordelete = new PersonalDbContext();
            if (dbfordelete.Jobs.Count() > 0)
            {
                //删除最后一项
                var fordelete = dbfordelete.Jobs.OrderBy(j => j.JobRowId).Last();
                dbfordelete.Remove(fordelete);
                dbfordelete.SaveChanges();

                //展示更新记录后的记录条数
                int count = dbfordelete.Jobs.Count();
                MessageBox.Show($"现在数据库里有 {count} 条工作的记录");
            }
            else
            {
                MessageBox.Show("数据库里没有关于工作的记录！");
            }
        }

        //保存按钮的逻辑
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //打开数据库
            using var db = new PersonalDbContext();
            if (_jobrow.InputColumn!=null&&_jobrow.TitleColumn!=null
                &&_jobrow.DutyColumn!= null&&_jobrow.OutputColumn!=null
                && _jobrow.CompanyNameColumn!= null)
            {
                //先保存记录
                db.Add(_jobrow);
                db.SaveChanges();

                //展示更新记录后的记录条数
                int count = db.Jobs.Count();
                MessageBox.Show($"现在数据库里有 {count} 条工作的记录");

                //重置绑定的数据源
                _jobrow = new JobRow();
                DataContext = _jobrow;
            }
            else
            {
                MessageBox.Show("请输入正确的数据");
            }
        }
    }
}
