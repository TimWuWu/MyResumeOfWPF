using MyResumeOfWPF.PDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
using System.Xml.Linq;

namespace MyResumeOfWPF
{
    /// <summary>
    /// InputEducationControl.xaml 的交互逻辑
    /// </summary>
    public partial class InputEducationControl : UserControl
    {
        private EducationRow _educationRow;
        public InputEducationControl()
        {
            //通过（数据源）绑定educationRow（ViewModel）到View
            _educationRow = new EducationRow();
            DataContext = _educationRow;
            InitializeComponent();
        }

        //保存按钮的逻辑
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //打开数据库
            using var db = new PersonalDbContext();
            if (_educationRow.StartColumn!= null&&_educationRow.StageColumn!=null
                &&_educationRow.PeriodColumn!=null&&_educationRow.MajoyColumn!=null)
            {
                //先保存记录
                db.Add(_educationRow);
                db.SaveChanges();

                //展示更新记录后的记录条数
                int count = db.Educations.Count();
                MessageBox.Show($"Now had {count} record of Education!");

                //重置绑定的数据源
                _educationRow = new EducationRow();
                DataContext = _educationRow;
            }
            else
            {
                MessageBox.Show("Please input useful data!");
            }         
                       
        }
        //删除按钮的逻辑
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //打开数据库
            using var dbfordelete = new PersonalDbContext();
            if (dbfordelete.Educations.Count()>0)
            {
                //删除最后一项
                var fordelete = dbfordelete.Educations.OrderBy(b => b.EducationRowId).Last();
                dbfordelete.Remove(fordelete);
                dbfordelete.SaveChanges();

                //展示更新记录后的记录条数
                int count = dbfordelete.Educations.Count();
                MessageBox.Show($"Now had {count} record of Education!");
            }
            else
            {
                MessageBox.Show("No record in database");
            }                      
        }
    }
}
