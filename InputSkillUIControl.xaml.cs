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
    /// InputSkillUIControl.xaml 的交互逻辑
    /// </summary>
    public partial class InputSkillUIControl : UserControl
    {
        private SkillRow _skillRow;
        public InputSkillUIControl()
        {
            //通过（数据源）绑定_skillRow（ViewModel）到View
            _skillRow = new SkillRow();
            DataContext = _skillRow;
            InitializeComponent();
        }

        //删除按钮的逻辑
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //打开数据库
            using var dbfordelete = new PersonalDbContext();
            if (dbfordelete.Skills.Count() > 0)
            {
                //删除最后一项
                var fordelete = dbfordelete.Skills.OrderBy(sk =>sk.SkillRowId ).Last();
                dbfordelete.Remove(fordelete);
                dbfordelete.SaveChanges();

                //展示更新记录后的记录条数
                int count = dbfordelete.Skills.Count();
                MessageBox.Show($"现在数据库里有 {count} 条技能的记录");
            }
            else
            {
                MessageBox.Show("数据库里没有关于技能的记录！");
            }
        }

        //将数据保存到数据库的逻辑
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //打开数据库
            using var db = new PersonalDbContext();
            if (_skillRow.TopicColumn!= null && _skillRow.ComponentOneColumn!= null
                && _skillRow.ComponentTwoColumn!= null && _skillRow.ComponentThreeColumn!= null
                && _skillRow.ComponentFourColumn != null)
            {
                //先保存记录
                db.Add(_skillRow);
                db.SaveChanges();

                //展示更新记录后的记录条数
                int count = db.Skills.Count();
                MessageBox.Show($"现在数据库里有 {count} 条技能的记录");

                //重置绑定的数据源
                _skillRow = new SkillRow();
                DataContext = _skillRow;
            }
            else
            {
                MessageBox.Show("请输入正确的数据");
            }
        }
    }
}
