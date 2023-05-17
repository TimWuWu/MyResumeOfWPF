using MyResumeOfWPF.PDO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonalDbContext dbContext;
        
        public MainWindow()
        {           
            InitializeComponent();
            
            
            //数据源
            dbContext = new PersonalDbContext();
        }
    

        //经过测试，在UI界面添加任何元素，都会触发该事件，
        //看起来就像是加载TabControl的时候就直接运行一样。
        //所以，控件加载就在这里进行。逻辑就是从数据库取得数据后在这里生成界面。
        private void TTTT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //获取选中的TabItem
            TabControl mytabcontrol= (TabControl)sender;
            TabItem selectedItem = (TabItem)mytabcontrol.SelectedItem;

            //从数据库直接获取数据
            dbContext = new PersonalDbContext();

            IOrderedQueryable<SkillRow> skillRows = 
                dbContext.Skills.OrderBy(s => s.SkillRowId);
            IOrderedQueryable<EducationRow> educationRows =
                dbContext.Educations.OrderBy(b=>b.EducationRowId);
            IOrderedQueryable<JobRow> jobRows =
                dbContext.Jobs.OrderBy(j =>j.JobRowId);
            IOrderedQueryable<BasicinfoRow> basicinfoRows =
                dbContext.BasicInfos.OrderBy(ba => ba.BasicinfoRowId);

            //按照展示页面的逻辑对控件进行绘画
            if (selectedItem.Name== "Show")
            {
                //绘画前先清理该页的界面
                ShowPage.Children.Clear();

                ////绘画BasicUI
                if (basicinfoRows.Count() == 0)
                {
                    int basicheight = 135;
                    BasicControl basicControl = new BasicControl();
                    basicControl.Margin = new Thickness(0, 3, 0, 3);
                    basicControl.Height = basicheight;
                    basicControl.VerticalAlignment = VerticalAlignment.Top;
                    basicControl.HorizontalAlignment = HorizontalAlignment.Stretch;

                    ShowPage.Children.Add(basicControl);
                    Grid.SetColumn(basicControl, 1);
                }
                else
                {
                    int basicheight = 135;
                    BasicControl basicControl = new BasicControl(basicinfoRows.First());
                    basicControl.Margin = new Thickness(0, 3, 0, 3);
                    basicControl.Height = basicheight;
                    basicControl.VerticalAlignment = VerticalAlignment.Top;
                    basicControl.HorizontalAlignment = HorizontalAlignment.Stretch;

                    ShowPage.Children.Add(basicControl);
                    Grid.SetColumn(basicControl, 1);
                }



                //绘画EducationUI
                int educationamount = 0;
                foreach (EducationRow education in educationRows)
                {
                    int educationheight = 135;
                    var ED = new EducationUIControl(education);
                    ED.Margin = new Thickness(0, 3 + (educationheight+3) * educationamount, 0, 3);
                    ED.Height = educationheight;
                    ED.VerticalAlignment = VerticalAlignment.Top;
                    ED.HorizontalAlignment = HorizontalAlignment.Stretch;

                    ShowPage.Children.Add(ED);
                    Grid.SetColumn(ED, 3);

                    educationamount++;
                }

                //绘画SkillUI
                int skillamount = 0;
                foreach (SkillRow skill in skillRows)
                {
                    int skilluiheight = 100;
                    var sk = new SkillUIControl(skill);
                    sk.Margin = new Thickness(0, 140 + (skilluiheight+3) * skillamount, 0, 3);
                    sk.Height = skilluiheight;
                    sk.VerticalAlignment = VerticalAlignment.Top;
                    sk.HorizontalAlignment = HorizontalAlignment.Stretch;

                    ShowPage.Children.Add(sk);
                    Grid.SetColumn(sk, 1);

                    skillamount++;
                }

                //绘画JobUI
                int Jobamount = 0;
                foreach (JobRow job in jobRows)
                {
                    int jobuiheight = 135;
                    var jo = new JobUIControl(job);
                    jo.Margin = new Thickness(0, 3+ (jobuiheight + 3) * Jobamount, 0, 3);
                    jo.Height = jobuiheight;
                    jo.VerticalAlignment = VerticalAlignment.Top;
                    jo.HorizontalAlignment = HorizontalAlignment.Stretch;

                    ShowPage.Children.Add(jo);
                    Grid.SetColumn(jo, 2);

                    Jobamount++;
                }
            }

            if (selectedItem.Name == "Getinfo")
            {
                InputPage.Background = new SolidColorBrush(Colors.Yellow);
            }
        }
    }
}
